namespace BookStore.Client
{
    using System;
    using BookStore.Data;
    using XMLImporter;
    using BookStore.ExportContoller;
    class EntryPoint
    {
        static void Main()
        {
            var db = new BookStoreContext();

            var xmlImporter = new XMLImporter(db);
            //uncomment below to import data
            //xmlImporter.ImporXML("../../complex-books.xml");

            var xmlExporter = new XMLExporter(db);
            xmlExporter.Generate("../../reviews-search-results.xml");

            Console.WriteLine("Success!");
        }
    }
}
