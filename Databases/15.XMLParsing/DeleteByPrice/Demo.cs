namespace DeleteByPrice
{
    using System.Xml;

    class Demo
    {
        static void Main()
        {
            DeleteAlbumsByCost(20.00M);
        }

        private static void DeleteAlbumsByCost(decimal limitPrice)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../catalog.xml");

            foreach (XmlNode node in doc.SelectNodes("//album"))
            {
                if (decimal.Parse(node["price"].InnerText) > 20)
                {
                    XmlNode parent = node.ParentNode;
                    parent.RemoveChild(node);
                }
            }

            doc.Save("../../modified.xml");
        }
    }
}
