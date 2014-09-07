namespace XMLImporter
{
    using BookStore.Data;
    using BookStore.Model;
    using System.Xml.Linq;
    using System.Linq;
    using System;

    public class XMLImporter
    {
        private BookStoreContext db;

        public XMLImporter(BookStoreContext dbConnection)
        {
            this.db = dbConnection;
        }

        public void ImporXML(string fileName)
        {
            var xmlDoc = XDocument.Load(fileName);
            var books = xmlDoc.Descendants("book");

            foreach (var book in books)
            {
                var bookDb = new Book();

                var title = book.Element("title");
                if (title != null)
                {
                    bookDb.Title = title.Value;
                }

                var authors = book.Descendants("author");
                if (authors != null && authors.Count() != 0)
                {
                    foreach (var author in authors)
                    {
                        bookDb.Authors.Add(this.ReturnAuthor(author.Value));
                    }
                }

                var website = book.Element("web-site");
                if (website != null)
                {
                    bookDb.WebSite = website.Value;
                }

                var reviews = book.Descendants("review");

                if (reviews != null && reviews.Count() != 0)
                {
                    foreach (var review in reviews)
                    {
                        var reviewDb = new Review();
                        reviewDb.Content = review.Value;

                        var creationDate = review.Attribute("date") == null ? DateTime.Now : DateTime.Parse(review.Attribute("date").Value);
                        reviewDb.DateOfCreatiom = creationDate;

                        if (review.Attribute("author")!= null)
                        {
                            var author = this.ReturnAuthor(review.Attribute("author").Value);
                            reviewDb.Author = author;
                        }

                        bookDb.Reviews.Add(reviewDb);
                    }
                }

                var ISBN = book.Element("isbn");
                if (ISBN != null)
                {
                    bookDb.ISBN = ISBN.Value;
                }

                var price = book.Element("price");
                if (price != null)
                {
                    bookDb.Price = decimal.Parse(price.Value);
                }

                this.db.Books.Add(bookDb);
                this.db.SaveChanges();
            }
        }

        private Author ReturnAuthor(string name)
        {
            var authorDB = new Author();

            if (this.db.Authors.Any(a=> a.Name == name))
            {
                authorDB = this.db.Authors.First(a => a.Name == name);
            }
            else
            {
                authorDB.Name = name;
            }

            return authorDB;
        }
    }
}
