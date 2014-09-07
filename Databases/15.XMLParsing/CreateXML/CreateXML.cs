namespace Demo
{
    using RandomDataGenerator;
    using System.Xml.Linq;

    class CreateXML
    {
        private static void GenerateXMLCatalog()
        {
            var generator = RandomDataGenerator.GetInstance();
            int numberOfAlbums = generator.GetInt(15, 20);
            int numberOfSongs = generator.GetInt(6, 10);

            var catalog = new XElement("catalog");
            var albums = new XElement("albums");

            for (int i = 0; i < numberOfAlbums; i++)
            {
                var album = new XElement("album");

                var name = new XElement("name");
                name.Value = "Name" + generator.GetStringExact(5);
                album.Add(name);

                var artist = new XElement("artist");
                artist.Value = "Artist" + generator.GetStringExact(3);
                album.Add(artist);

                var year = new XElement("year");
                year.Value = generator.GetRandomDate().Year.ToString();
                album.Add(year);

                var producer = new XElement("producer");
                producer.Value = "Producer" + generator.GetStringExact(4);
                album.Add(producer);

                var price = new XElement("price");
                price.Value = generator.GetDouble(100).ToString("0.00");
                album.Add(price);

                for (int j = 0; j < numberOfSongs; j++)
                {
                    var song = new XElement("song");
                    var title = new XElement("title");
                    var duration = new XElement("duraton");
                    title.Value = "Title" + generator.GetStringExact(5);
                    duration.Value = generator.GetDouble(4).ToString("0.00");
                    song.Add(title);
                    song.Add(duration);

                    album.Add(song);
                }

                albums.Add(album);
            }

            catalog.Add(albums);

            catalog.Save("../../catalog.xml");
        }

        static void Main()
        {
            GenerateXMLCatalog();
        }
    }
}
