CREATE TABLE labs (
  id INT IDENTITY(1,1) PRIMARY KEY,
  lab_name NVARCHAR(50) NOT NULL
);
CREATE TABLE categories (
  id INT IDENTITY(1,1) PRIMARY KEY,
  category_name NVARCHAR(50) NOT NULL
);
CREATE TABLE users (
  id INT IDENTITY(1,1) PRIMARY KEY,
  full_name NVARCHAR(100),
  username NVARCHAR(50) UNIQUE NOT NULL,
  password_hash NVARCHAR(255) NOT NULL
);
CREATE TABLE equipment (
  id INT IDENTITY(1,1) PRIMARY KEY,
  asset_id NVARCHAR(50) UNIQUE NOT NULL,
  name NVARCHAR(100) NOT NULL,
  category_id INT REFERENCES categories(id),
  lab_id INT REFERENCES labs(id),
  status NVARCHAR(20),
  remarks NVARCHAR(255)
);