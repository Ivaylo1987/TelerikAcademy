namespace Northwind.Actions
{
    using System;
    using Northwind.Data;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Data.Entity.Core.Objects;
    using System.Data.Entity.Infrastructure;
    using System.Data.SqlClient;

    public class DataAccessObject
    {
        // 2.Create a DAO class with static methods which provide functionality for inserting, modifying and deleting customers.
        public static void InsertCustomer(Customer customer)
        {
            using (var northwindDb = new NorthwindEntities())
            {
                northwindDb.Customers.Add(customer);
                northwindDb.SaveChanges();
            }
        }

        public static void UpdateCustomers(string customerName, string id)
        {
            using (var northwindDb = new NorthwindEntities())
            {
                var toUpdate = northwindDb.Customers.First(c => c.CustomerID == id);
                toUpdate.ContactName = customerName;
                northwindDb.SaveChanges();
            }
        }

        public static void DeleteCustomers(string id)
        {
            using (var northwindDb = new NorthwindEntities())
            {
                var toDelete = northwindDb.Customers.First(c => c.CustomerID == id);
                northwindDb.Customers.Remove(toDelete);
                northwindDb.SaveChanges();
            }
        }

        public static void CustomersWithOrdersIn1997InCanada()
        {
            using (var northWind = new NorthwindEntities())
            {
                var customers = northWind.Orders
                    .Where(o => o.OrderDate.Value.Year == 1997 && o.ShipCountry == "Canada")
                    .Select(o => new { o.Customer.CustomerID, o.Customer.ContactName });
                //Console.WriteLine(customers);
                foreach (var customer in customers)
                {
                    Console.WriteLine("Id: {0} Name: {1}", customer.CustomerID, customer.ContactName);
                }
            }
        }

        public static IEnumerable<object> CustomersWithOrdersIn1997InCanadaWithQuery()
        {
            using (var northWind = new NorthwindEntities())
            {
                var query = "SELECT c.[ContactName] FROM  Orders AS o LEFT JOIN [dbo].[Customers] AS c ON o.[CustomerID] = c.[CustomerID] WHERE (1997 = (DATEPART (year, o.[OrderDate]))) AND (N'Canada' = o.[ShipCountry])";

                return northWind.Database.SqlQuery<string>(query).ToList();
            }
        }

        public static IEnumerable<object> AllSalesByPeriod(string region, DateTime start, DateTime end)
        {
            using (var northWindDb = new NorthwindEntities())
            {
                var sales = northWindDb.Orders
                                        .Where(o => o.ShipRegion == region && start < o.OrderDate && o.OrderDate < end)
                                        .Select(o => new { o.ShipName, o.ShippedDate }).ToList();

                return sales;
            }
        }

        public static void CreateTwin()
        {
            IObjectContextAdapter northWindDb = new NorthwindEntities();
            string northwindScript = northWindDb.ObjectContext.CreateDatabaseScript();
            string createNorthwindCloneDB = "USE master; " +
                                            "CREATE DATABASE NorthwindTwin; ";

            SqlConnection dbCon = new SqlConnection("Server=.\\SQLEXPRESS; " +
                                                    "Database=master; Integrated Security=true");
            dbCon.Open();
            using (dbCon)
            {
                SqlCommand createCloneDB = new SqlCommand(createNorthwindCloneDB, dbCon);
                createCloneDB.ExecuteNonQuery();

                string changeDB = "USE  NorthwindTwin; ";
                SqlCommand changeDataB = new SqlCommand(changeDB, dbCon);
                changeDataB.ExecuteNonQuery();

                SqlCommand cloneDB = new SqlCommand(northwindScript, dbCon);
                cloneDB.ExecuteNonQuery();
            }
        }

        public static void ConsurentChange()
        {
            using (var northWindDbOther = new NorthwindEntities())
            {
                var customerOne = northWindDbOther.Customers.First(c => c.CustomerID == "Pesho");

                northWindDbOther.Customers.Remove(customerOne);

                UpdateCustomers("Gosho", "Pesho");

                northWindDbOther.SaveChanges();

            }
        }

        public static void InsertOrders(params Order[] orders)
        {
            using (var northWindDb = new NorthwindEntities())
            {
                using (var dbTransaction = northWindDb.Database.BeginTransaction())
                {
                    try
                    {
                        foreach (var item in orders)
                        {
                            northWindDb.Orders.Add(item);
                        }

                        northWindDb.SaveChanges();
                        dbTransaction.Commit();
                        Console.WriteLine("Successfully Inserted");
                    }
                    catch (Exception ex)
                    {
                        dbTransaction.Rollback();
                        Console.WriteLine(ex.Message);
                    }

                }
            }
        }
    }
}
