namespace Northwind.Actions
{
    using System;
    using Northwind.Data;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

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

        public static void UpdateCustomers(Customer customer, string id)
        {
            using (var northwindDb = new NorthwindEntities())
            {
                var toUpdate = northwindDb.Customers.First(c => c.CustomerID == id);
                toUpdate = customer;
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
                                        .Select(o => new { o.ShipName, o.ShippedDate}).ToList();

                return sales;
            }
        }


        public static void CreateTwin()
        {
            
        }
    }
}
