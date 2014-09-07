namespace BookStore.ExportContoller
{
    using BookStore.Data;
    using System;
    using System.Xml.Linq;
    using System.Linq;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using BookStore.Model;

    public class XMLExporter
    {
        private BookStoreContext db;

        public XMLExporter(BookStoreContext db)
        {
            this.db = db;
        }

        public void Generate(string fileName)
        {
            var queries = XDocument.Load("../../reviews-queries.xml").Descendants("query");
            var queriesWithParams = new Dictionary<string, List<string>>();
            var searchResults = new XElement("search-results");

            foreach (var query in queries)
            {
                var resultSet = new XElement("result-set");
                var queryType = query.Attribute("type").Value;

                if (queryType == "by-period")
                {
                    var byPeriodExpression = this.GeneratePeriodQuery(query);
                    GenerateReviews(resultSet, byPeriodExpression);
                }

                if (queryType == "by-author")
                {
                    var byAuthorExpression = this.GenerateByAuthorQuery(query);
                    GenerateReviews(resultSet, byAuthorExpression);
                }

                searchResults.Add(resultSet);
            }


            searchResults.Save(fileName);
        }

        private void GenerateReviews(XElement resultSet, Expression<Func<Review, bool>> expression)
        {
            var reviews = this.db.Reviews.Where(expression)
                           .OrderBy(r => r.DateOfCreatiom)
                           .ThenBy(r => r.Content);

            foreach (var review in reviews)
            {
                var xmlREview = new XElement("review");
                if (review.DateOfCreatiom != null)
                {
                    var date = new XElement("date");
                    date.Value = review.DateOfCreatiom.ToString("d-MMM-yyyy");
                    xmlREview.Add(date);
                }

                if (review.Content != null)
                {
                    var content = new XElement("content");
                    content.Value = review.Content;
                    xmlREview.Add(content);
                }

                if (review.Book != null)
                {
                    var book = new XElement("book");

                    if (review.Book.Title != null)
                    {
                        var title = new XElement("title");
                        title.Value = review.Book.Title;
                        book.Add(title);
                    }

                    if (review.Book.Authors.Count > 0)
                    {
                        var author = new XElement("author");
                        author.Value = string.Join(", ", review.Book.Authors.Select(a => a.Name));
                        book.Add(author);
                    }

                    if (review.Book.ISBN != null)
                    {
                        var ISBN = new XElement("isbn");
                        ISBN.Value = review.Book.ISBN;
                        book.Add(ISBN);
                    }

                    if (review.Book.WebSite != null)
                    {
                        var url = new XElement("url");
                        url.Value = review.Book.WebSite;
                        book.Add(url);
                    }

                    xmlREview.Add(book);
                }

                resultSet.Add(xmlREview);
            }
        }

        private Expression<Func<Review, bool>> GeneratePeriodQuery(XElement query)
        {
            var startDate = DateTime.Parse(query.Element("start-date").Value);
            var endDate = DateTime.Parse(query.Element("end-date").Value);

            Expression<Func<Review, bool>> expression = r => (startDate <= r.DateOfCreatiom && r.DateOfCreatiom <= endDate);

            return expression;
        }

        private Expression<Func<Review, bool>> GenerateByAuthorQuery(XElement query)
        {
            var authorName = query.Element("author-name").Value;
            Expression<Func<Review, bool>> expression = r => (r.Author.Name == authorName);

            return expression;
        }
    }
}