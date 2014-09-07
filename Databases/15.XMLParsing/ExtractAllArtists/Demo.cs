namespace ExtractAllArtists
{
    using System;
    using System.Collections.Generic;
    using System.Xml;


    class Demo
    {
        static void Main()
        {
            var catalog = new XmlDocument();
            catalog.Load("../../catalog.xml");
            FindArtistsWithDOM(catalog);
            FindArtistsWithXPath(catalog);
        }

        private static void FindArtistsWithDOM(XmlDocument catalog)
        {
            var artistsAndAlbumCount = new Dictionary<string, int>();

            var root = catalog.DocumentElement;
            var albums = root.FirstChild;

            foreach (XmlNode album in albums.ChildNodes)
            {
                var artist = album["artist"].InnerText;
                if (!artistsAndAlbumCount.ContainsKey(artist))
                {
                    artistsAndAlbumCount.Add(artist, 0);
                }

                artistsAndAlbumCount[artist]++;
            }


            foreach (var item in artistsAndAlbumCount)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }

        }

        private static void FindArtistsWithXPath(XmlDocument catalog)
        {
            var artistsAndAlbumCount = new Dictionary<string, int>();

            var root = catalog.DocumentElement;
            var xpath = "//artist";

            var artists = root.SelectNodes(xpath);

            foreach (XmlNode artist in artists)
            {
                if (!artistsAndAlbumCount.ContainsKey(artist.InnerText))
                {
                    artistsAndAlbumCount.Add(artist.InnerText, 0);
                }

                artistsAndAlbumCount[artist.InnerText]++;
            }


            foreach (var item in artistsAndAlbumCount)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
