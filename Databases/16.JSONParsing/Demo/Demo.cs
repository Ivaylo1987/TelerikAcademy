namespace Demo
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using RSSParser;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;

    class Demo
    {
        static void Main()
        {
            var questionsInRss = GetAllQuestions();

            GenerateHTMLPage(questionsInRss);
        }

        private static IEnumerable<Question> GetAllQuestions()
        {
            var webClient = new WebClient();
            webClient.DownloadFile("http://forums.academy.telerik.com/feed/qa.rss", "../../forumRSS.rss");

            var parser = new XMLToJSONParser();
            var rssJSON = parser.Parse("../../forumRSS.rss");

            // for testing purposes
            File.WriteAllText("../../rssJSON.txt", rssJSON);

            var rssJObject = JObject.Parse(rssJSON);

            var forumItems = rssJObject["rss"]["channel"]["item"]
                                                     .Select(it => new
                                                     {
                                                         Title = it["title"],
                                                         Category = it["category"],
                                                         Link = it["link"]
                                                     });

            var questionsInRss = new List<Question>();

            foreach (var item in forumItems)
            {
                var itemAsJson = JsonConvert.SerializeObject(item);
                var question = JsonConvert.DeserializeObject<Question>(itemAsJson);

                questionsInRss.Add(question);
            }

            return questionsInRss;
        }

        private static void GenerateHTMLPage(IEnumerable<Question> questionsList)
        {
            using (FileStream fileStream = new FileStream("../../questions.html", FileMode.Create))
            {
                using (StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.UTF8))
                {
                    foreach (var question in questionsList)
                    {
                        streamWriter.WriteLine("<h2>Title: {0}</h2>", question.Title);
                        streamWriter.WriteLine("<category>Category: {0}</category>", question.Category);
                        streamWriter.WriteLine("<a href='{0}'>Link to question...</a>", question.Link);
                        streamWriter.WriteLine("<hr />");
                    }
                }
            }

            Process.Start(@"..\..\questions.html");
        }
    }
}
