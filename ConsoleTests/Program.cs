using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

using libeveapi;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc = Network.GetXml("http://localhost/eveapi/corp/AssetList.xml");
            foreach (XmlNode node in xmlDoc.SelectNodes("//rowset[@name='assets']/row"))
            {
                PrintItem(node, "");
            }
        }

        static void PrintItem(XmlNode item, string indent)
        {
            Console.WriteLine("{0}{1}", indent, item.Attributes["itemID"].InnerText);
            foreach (XmlNode containedItem in item.SelectNodes("./rowset[@name='contents']/row"))
            {
                PrintItem(containedItem, indent + "  ");
            }
        }
    }
}
