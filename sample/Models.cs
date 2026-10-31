namespace sample
{
    public class EquipmentItem
    {
        public string PropertyNo { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string SerialNo { get; set; }
        public string DateAcquired { get; set; }   // yyyy-MM-dd, or empty
        public string Category { get; set; }
        public string Status { get; set; }
        public string Location { get; set; }
        public string Remarks { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}