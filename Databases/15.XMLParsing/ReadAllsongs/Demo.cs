namespace ReadAllsongs
{
    using System;
    using System.Xml;
    using System.Xml.Linq;

    class Demo
    {
        static void Main()
        {
            ReadAllSongs();

            ExtractSongsWithXElement();
        }

        private static void ExtractSongsWithXElement()
        {
            var catalog = XDocument.Load("../../catalog.xml");
            var songs = catalog.Descendants("song");

            foreach (var song in songs)
            {
                Console.WriteLine(song.Value);
            }
        }

        private static void ReadAllSongs()
        {
            using (XmlReader reader = XmlReader.Create("../../catalog.xml"))
            {
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) &&
                        (reader.Name == "song"))
                    {
                        Console.WriteLine(reader.ReadElementString());
                    }
                }
            }
        }
    }
}
