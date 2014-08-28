namespace Northwind.Actions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Northwind.Data;

    class Demo
    {
        static void Main()
        {
            // 2.Create a DAO class with static methods which provide functionality for inserting, modifying and deleting customers.
            // Write a testing class.
            var peshoCustomer = new Customer { CustomerID = "Pesho", CompanyName = "ICompany" };
            DataAccessObject.InsertCustomer(peshoCustomer);

            // 3.Write a method that finds all customers who have orders made in 1997 and shipped to Canada.
            DataAccessObject.CustomersWithOrdersIn1997InCanada();

            // 4.Implement previous by using native SQL query and executing it through the DbContext.
            var customers = DataAccessObject.CustomersWithOrdersIn1997InCanadaWithQuery();

            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }

            // 5.Write a method that finds all the sales by specified region and period (start / end dates).

            var region = "RJ";
            var startDate = new DateTime(1996, 1, 1);
            var endtDate = new DateTime(1997, 10, 10);
            var sales = DataAccessObject.AllSalesByPeriod(region, startDate, endtDate);

            foreach (var sale in sales)
            {
                Console.WriteLine(sale);
            }

            // 06.Create a database called NorthwindTwin with the same structure as Northwind using the features from DbContext.
            // Find for the API for schema generation in MSDN or in Google.

            // Uncoment this to create the NorthWindTwin table
            DataAccessObject.CreateTwin();

            // 07.Try to open two different data contexts and perform concurrent changes on the same records. What will happen at SaveChanges()? How to deal with it?

            DataAccessObject.ConsurentChange();

            // NOT Applicable any more in EF 6
            // 08.By inheriting the Employee entity class create a class which allows employees to access their corresponding
            // territories as property of type EntitySet<T>.


            // 09.Create a method that places a new order in the Northwind database. The order should contain several order items.
            // Use transaction to ensure the data consistency.

            var correntOrder = new Order { ShipName = "Correct" };
            var inCorrentOrder = new Order { ShipName = "InCorrect", ShipPostalCode = "12345678901" };

            DataAccessObject.InsertOrders(correntOrder, inCorrentOrder);

            //Sorry no time for 10 and 11 :(
        }
    }
}
