using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace sample
{
    public static class Database
    {
        private const string ConnStr =
            @"Server=(localdb)\MSSQLLocalDB;Database=lab_equipment_db;Trusted_Connection=True;";

        public static readonly string[] Statuses = { "Working", "Defective", "Under Repair" };

        private const string SelectEquipment = @"
            SELECT e.property_no, e.name, e.brand, e.model, e.serial_no, e.date_acquired,
                   c.name AS category, e.status, e.location, e.remarks
            FROM equipment e
            JOIN categories c ON c.id = e.category_id";

        private static SqlConnection Open()
        {
            var conn = new SqlConnection(ConnStr);
            conn.Open();
            return conn;
        }

        // Creates tables and sample data on first run. Leaves the existing users table alone.
        public static void Initialize()
        {
            const string createTables = @"
IF OBJECT_ID('categories', 'U') IS NULL
CREATE TABLE categories (
    id   INT IDENTITY(1,1) PRIMARY KEY,
    name NVARCHAR(100) NOT NULL UNIQUE
);
IF OBJECT_ID('equipment', 'U') IS NULL
CREATE TABLE equipment (
    property_no   NVARCHAR(20) PRIMARY KEY,
    name          NVARCHAR(100) NOT NULL,
    brand         NVARCHAR(100) NULL,
    model         NVARCHAR(100) NULL,
    serial_no     NVARCHAR(100) NULL,
    date_acquired DATE NULL,
    category_id   INT NOT NULL REFERENCES categories(id),
    status        NVARCHAR(20) NOT NULL,
    location      NVARCHAR(200) NULL,
    remarks       NVARCHAR(500) NULL
);";

            const string seed = @"
IF NOT EXISTS (SELECT 1 FROM categories)
INSERT INTO categories (name) VALUES ('PC Unit'), ('Monitor'), ('Keyboard'), ('Mouse');

IF NOT EXISTS (SELECT 1 FROM equipment)
INSERT INTO equipment (property_no, name, brand, model, serial_no, date_acquired, category_id, status, location, remarks)
VALUES
('PN-0001', 'Desktop PC', 'Dell', 'OptiPlex', 'SN-0001', '2024-06-10', (SELECT id FROM categories WHERE name = 'PC Unit'), 'Working', 'Computer Lab 1, Room 101', ''),
('PN-0002', 'Monitor', 'Acer', '', '', '2024-06-10', (SELECT id FROM categories WHERE name = 'Monitor'), 'Working', 'Computer Lab 1', ''),
('PN-0003', 'Keyboard', 'Logitech', '', '', '2023-08-15', (SELECT id FROM categories WHERE name = 'Keyboard'), 'Defective', 'Computer Lab 2', ''),
('PN-0004', 'Mouse', 'A4Tech', '', '', '2023-08-15', (SELECT id FROM categories WHERE name = 'Mouse'), 'Under Repair', 'Computer Lab 2', '');";

            using (var conn = Open())
            {
                new SqlCommand(createTables, conn).ExecuteNonQuery();
                new SqlCommand(seed, conn).ExecuteNonQuery();
            }
        }

        public static bool ValidateUser(string username, string password)
        {
            const string sql = @"SELECT COUNT(*) FROM users
                WHERE username = @u AND password_hash = CONVERT(NVARCHAR(255), HASHBYTES('SHA2_256', CONVERT(VARCHAR(100), @p)), 2)";

            using (var conn = Open())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);
                return (int)cmd.ExecuteScalar() == 1;
            }
        }

        // ----- Categories -----

        public static List<Category> GetCategories()
        {
            var list = new List<Category>();
            using (var conn = Open())
            using (var cmd = new SqlCommand("SELECT id, name FROM categories ORDER BY id", conn))
            using (var r = cmd.ExecuteReader())
            {
                while (r.Read())
                    list.Add(new Category { Id = r.GetInt32(0), Name = r.GetString(1) });
            }
            return list;
        }

        public static void AddCategory(string name)
        {
            using (var conn = Open())
            using (var cmd = new SqlCommand("INSERT INTO categories (name) VALUES (@n)", conn))
            {
                cmd.Parameters.AddWithValue("@n", name);
                cmd.ExecuteNonQuery();
            }
        }

        public static void RenameCategory(int id, string name)
        {
            using (var conn = Open())
            using (var cmd = new SqlCommand("UPDATE categories SET name = @n WHERE id = @id", conn))
            {
                cmd.Parameters.AddWithValue("@n", name);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public static bool CategoryInUse(int id)
        {
            using (var conn = Open())
            using (var cmd = new SqlCommand("SELECT COUNT(*) FROM equipment WHERE category_id = @id", conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        public static void DeleteCategory(int id)
        {
            using (var conn = Open())
            using (var cmd = new SqlCommand("DELETE FROM categories WHERE id = @id", conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        // ----- Equipment -----

        public static List<EquipmentItem> GetEquipment(string search)
        {
            var list = new List<EquipmentItem>();
            using (var conn = Open())
            using (var cmd = new SqlCommand(SelectEquipment +
                " WHERE @s = '' OR e.property_no LIKE @like OR e.name LIKE @like ORDER BY e.property_no", conn))
            {
                cmd.Parameters.AddWithValue("@s", search);
                cmd.Parameters.AddWithValue("@like", "%" + search + "%");
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                        list.Add(ReadItem(r));
                }
            }
            return list;
        }

        public static string NextPropertyNo()
        {
            using (var conn = Open())
            using (var cmd = new SqlCommand(
                "SELECT ISNULL(MAX(CAST(SUBSTRING(property_no, 4, 10) AS INT)), 0) FROM equipment", conn))
            {
                int max = (int)cmd.ExecuteScalar();
                return "PN-" + (max + 1).ToString("0000");
            }
        }

        public static void InsertEquipment(EquipmentItem item)
        {
            const string sql = @"
                INSERT INTO equipment (property_no, name, brand, model, serial_no, date_acquired,
                                       category_id, status, location, remarks)
                VALUES (@pn, @name, @brand, @model, @serial, @date,
                        (SELECT id FROM categories WHERE name = @cat), @status, @loc, @rem)";

            using (var conn = Open())
            using (var cmd = new SqlCommand(sql, conn))
            {
                AddEquipmentParams(cmd, item);
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateEquipment(EquipmentItem item)
        {
            const string sql = @"
                UPDATE equipment SET name = @name, brand = @brand, model = @model,
                       serial_no = @serial, date_acquired = @date,
                       category_id = (SELECT id FROM categories WHERE name = @cat),
                       status = @status, location = @loc, remarks = @rem
                WHERE property_no = @pn";

            using (var conn = Open())
            using (var cmd = new SqlCommand(sql, conn))
            {
                AddEquipmentParams(cmd, item);
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteEquipment(string propertyNo)
        {
            using (var conn = Open())
            using (var cmd = new SqlCommand("DELETE FROM equipment WHERE property_no = @pn", conn))
            {
                cmd.Parameters.AddWithValue("@pn", propertyNo);
                cmd.ExecuteNonQuery();
            }
        }

        // Count of equipment per status, such as "Working" -> 2
        public static Dictionary<string, int> GetStatusCounts()
        {
            var counts = new Dictionary<string, int>();
            using (var conn = Open())
            using (var cmd = new SqlCommand("SELECT status, COUNT(*) FROM equipment GROUP BY status", conn))
            using (var r = cmd.ExecuteReader())
            {
                while (r.Read())
                    counts[r.GetString(0)] = r.GetInt32(1);
            }
            return counts;
        }

        // ----- Helpers -----

        private static EquipmentItem ReadItem(SqlDataReader r)
        {
            return new EquipmentItem
            {
                PropertyNo = r.GetString(0),
                Name = r.GetString(1),
                Brand = Text(r, 2),
                Model = Text(r, 3),
                SerialNo = Text(r, 4),
                DateAcquired = r.IsDBNull(5) ? "" : r.GetDateTime(5).ToString("yyyy-MM-dd"),
                Category = r.GetString(6),
                Status = r.GetString(7),
                Location = Text(r, 8),
                Remarks = Text(r, 9)
            };
        }

        private static string Text(SqlDataReader r, int i)
        {
            return r.IsDBNull(i) ? "" : r.GetString(i);
        }

        private static void AddEquipmentParams(SqlCommand cmd, EquipmentItem item)
        {
            cmd.Parameters.AddWithValue("@pn", item.PropertyNo);
            cmd.Parameters.AddWithValue("@name", item.Name);
            cmd.Parameters.AddWithValue("@brand", NullIfEmpty(item.Brand));
            cmd.Parameters.AddWithValue("@model", NullIfEmpty(item.Model));
            cmd.Parameters.AddWithValue("@serial", NullIfEmpty(item.SerialNo));
            cmd.Parameters.AddWithValue("@date", NullIfEmpty(item.DateAcquired));
            cmd.Parameters.AddWithValue("@cat", item.Category);
            cmd.Parameters.AddWithValue("@status", item.Status);
            cmd.Parameters.AddWithValue("@loc", NullIfEmpty(item.Location));
            cmd.Parameters.AddWithValue("@rem", NullIfEmpty(item.Remarks));
        }

        private static object NullIfEmpty(string s)
        {
            return string.IsNullOrWhiteSpace(s) ? (object)DBNull.Value : s;
        }
    }
}