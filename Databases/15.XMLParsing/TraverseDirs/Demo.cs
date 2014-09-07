namespace TraverseDirs
{
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml;
    using System.Xml.Linq;


    class Demo
    {
        public static void Main()
        {
            string folderToScan = "../../";
            string outputXmlFile = "../../directory.xml";
            DirectoryInfo directoryInfo = new DirectoryInfo(folderToScan);
            Encoding encoding = Encoding.GetEncoding("windows-1251");

            using (XmlTextWriter writer = new XmlTextWriter(outputXmlFile, encoding))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;

                writer.WriteStartDocument();
                writer.WriteStartElement("directories");
                CreateXML(writer, directoryInfo);
                writer.WriteEndDocument();
            }
        }

        private static void CreateXML(XmlTextWriter writer, DirectoryInfo dir)
        {
            foreach (var file in dir.GetFiles())
            {
                string xml = new XElement("file", new XAttribute("name", file.Name)).ToString();
                XmlReader reader = XmlReader.Create(new StringReader(xml));
                writer.WriteNode(reader, true);
            }

            var subdirectories = dir.GetDirectories().ToList().OrderBy(d => d.Name);
            foreach (var subDir in subdirectories)
            {
                CreateSubdirectoryXML(writer, subDir);
            }
        }

        private static void CreateSubdirectoryXML(XmlTextWriter writer, DirectoryInfo dir)
        {
            string xml = new XElement("dir", new XAttribute("name", dir.Name)).ToString();
            XmlReader reader = XmlReader.Create(new StringReader(xml));
            writer.WriteNode(reader, true);

            foreach (var file in dir.GetFiles())
            {
                xml = new XElement("file", new XAttribute("name", file.Name)).ToString();
                reader = XmlReader.Create(new StringReader(xml));
                writer.WriteNode(reader, true);
            }

            var subdirectories = dir.GetDirectories().ToList().OrderBy(d => d.Name);
            foreach (var subDir in subdirectories)
            {
                CreateSubdirectoryXML(writer, subDir);
            }
        }
    }
}

