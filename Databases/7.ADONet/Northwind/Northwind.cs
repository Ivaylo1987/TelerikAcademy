namespace Northwind
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.IO;
    using System.Linq;

    class Northwind
    {
        static void Main()
        {
            SqlConnection dbConn = new SqlConnection(Settings.Default.ConnectionString);
            dbConn.Open();

            using (dbConn)
            {
                // 01. Write a program that retrieves from the Northwind sample database in 
                // MS SQL Server the number of rows in the Categories table.
                var catCountCmt = new SqlCommand("SELECT COUNT(*) FROM Categories", dbConn);
                var categoriesCount = (int)catCountCmt.ExecuteScalar();
                Console.WriteLine("Numeber of Categories {0}", categoriesCount);
                Console.WriteLine(new string('-', 10));

                // 02. Write a program that retrieves the name and description of all categories in the Northwind DB.
                var catDetailsCmt = new SqlCommand("SELECT CategoryName, Description FROM Categories", dbConn);
                var categoriesDetails = catDetailsCmt.ExecuteReader();
                using (categoriesDetails)
                {
                    while (categoriesDetails.Read())
                    {
                        var categoryName = categoriesDetails["CategoryName"];
                        var categoryDescription = categoriesDetails["Description"];

                        Console.WriteLine("Category: {0}\n\t{1}\n", categoryName, categoryDescription);
                    }
                }
                Console.WriteLine(new string('-', 10));

                // 03. Write a program that retrieves from the Northwind database all product categories and the names of the 
                // products in each category. Can you do this with a single SQL query (with table join)?
                var sqlCommand = "SELECT p.ProductName, c.CategoryName FROM Categories c INNER JOIN Products p ON c.CategoryID = p.CategoryID";

                var commandToExecute = new SqlCommand(sqlCommand, dbConn);
                var reader = commandToExecute.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        string categoryName = (string)reader["CategoryName"];
                        string products = (string)reader["ProductName"];

                        Console.WriteLine("Category: {0}\n\t{1}\n", categoryName, products);
                    }
                }
                Console.WriteLine(new string('-', 10));

                // 04. Write a method that adds a new product in the products table in the Northwind database. 
                // Use a parameterized SQL command.
                var CommandInsert = "INSERT INTO Products(ProductName, UnitPrice, SupplierID, CategoryID, Discontinued) " +
                    "VALUES (@productName, @price, @supplierID, @categoryID, @discontinued)";

                var sqlCommandInsert = new SqlCommand(CommandInsert, dbConn);

                sqlCommandInsert.Parameters.AddWithValue("@productName", "IProduct");
                sqlCommandInsert.Parameters.AddWithValue("@price", 1000.00);
                sqlCommandInsert.Parameters.AddWithValue("@supplierID", 1);
                sqlCommandInsert.Parameters.AddWithValue("@categoryID", 1);
                sqlCommandInsert.Parameters.AddWithValue("@discontinued", false);
                sqlCommandInsert.ExecuteNonQuery();
                Console.WriteLine("Inserted, check in DB for IProduct");
                Console.WriteLine(new string('-', 10));

                // 05. Write a program that retrieves the images for all categories in the Northwind database and stores 
                // them as JPG files in the file system.
                var imageCommand = new SqlCommand(
                                        "SELECT CategoryName, Picture " +
                                        "FROM Categories",
                                        dbConn);

                var imageReader = imageCommand.ExecuteReader();

                using (imageReader)
                {
                    while (imageReader.Read())
                    {
                        string categoryName = (string)imageReader["CategoryName"];

                        if (categoryName.Contains("/"))
                        {
                            categoryName = categoryName.Replace('/', ' ');
                        }

                        byte[] pictureBytes = imageReader["Picture"] as byte[];
                        var metaFilePictSize = 78;

                        MemoryStream imageStream = new MemoryStream(pictureBytes, metaFilePictSize, pictureBytes.Length - metaFilePictSize);

                        Image image = Image.FromStream(imageStream);

                        using (image)
                        {
                            image.Save(categoryName + ".jpg");
                        }
                    }

                    Console.WriteLine("You can find the pictures in the bin/debug folder.");
                }
            }
        }
    }
}
