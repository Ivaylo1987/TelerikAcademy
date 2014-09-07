namespace RSSParser
{
    using Newtonsoft.Json;
    using System.Xml.Linq;

    public class XMLToJSONParser
    {
        public string Parse(string xmlFile)
        {
            var rssXElement = XDocument.Load(xmlFile);
            var rssContentAsJson = JsonConvert.SerializeXNode(rssXElement);

            return rssContentAsJson;
        }
    }
}
