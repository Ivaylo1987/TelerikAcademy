﻿namespace RedPersonData
{
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using System.Xml;

    class Demo
    {
        public static void Main()
        {
            var personInformation = GetPersonInfoFromFile("../../PersonInformation.txt");
            CreateXMLFileWithPersonInfo(personInformation);
        }

        private static Dictionary<string, string> GetPersonInfoFromFile(string filePath)
        {
            var personInfo = new Dictionary<string, string>();
            var fileReader = new StreamReader(filePath);

            using (fileReader)
            {
                var personName = fileReader.ReadLine();
                var personAddress = fileReader.ReadLine();
                var personPhone = fileReader.ReadLine();

                personInfo.Add("name", personName);
                personInfo.Add("address", personAddress);
                personInfo.Add("phone", personPhone);
            }

            return personInfo;
        }

        private static void CreateXMLFileWithPersonInfo(Dictionary<string, string> personInfo)
        {
            string fileName = "../../PersonInfo.xml";
            Encoding encoding = Encoding.GetEncoding("windows-1251");
            XmlTextWriter writer = new XmlTextWriter(fileName, encoding);

            using (writer)
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;

                writer.WriteStartDocument();
                writer.WriteStartElement("address-book");
                writer.WriteAttributeString("name", "My Addresses Book");

                writer.WriteStartElement("addresses");

                writer.WriteStartElement("address");

                foreach (var item in personInfo)
                {
                    writer.WriteElementString(item.Key, item.Value);
                }

                writer.WriteEndElement();

                writer.WriteEndDocument();
            }
        }
    }

}
