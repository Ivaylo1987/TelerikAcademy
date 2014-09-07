namespace ReadAndWrite
{
    using System.Text;
    using System.Xml;

    class Demo
    {
        static void Main()
        {
            using (XmlTextWriter writer = new XmlTextWriter("../../albums.xml", Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;

                writer.WriteStartDocument();
                writer.WriteStartElement("albums");

                using (XmlReader reader = XmlReader.Create("../../catalog.xml"))
                {
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "name")
                        {
                            var albumTitle = reader.ReadElementString();

                            reader.Read();

                            var artist = reader.ReadElementString();

                            writer.WriteStartElement("album");
                            writer.WriteElementString("albumTitle", albumTitle);
                            writer.WriteElementString("artist", artist);
                            writer.WriteEndElement();
                        }
                    }
                }

                writer.WriteEndElement();
            }
        }
    }
}