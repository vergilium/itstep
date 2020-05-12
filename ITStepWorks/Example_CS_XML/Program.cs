using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Example_CS_XML {
	class Program {
		static void Main(string[] args) {
			XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("./../../academy.xml");

			foreach(XmlNode node in xmlDoc.DocumentElement.ChildNodes[0].ChildNodes) {
                Console.WriteLine($"{node.Attributes["firstName"].Value} {node.Attributes["lastName"].Value}");

                XmlNode newmark = xmlDoc.CreateElement("mark", "");
                newmark.Attributes.Append(xmlDoc.CreateAttribute("subject"));
                newmark.Attributes.Append(xmlDoc.CreateAttribute("value"));
                newmark.Attributes["subject"].Value = "SQL";
                newmark.Attributes["value"].Value = "10";
                node.FirstChild.AppendChild(newmark);

                foreach (XmlNode mark in node.FirstChild.ChildNodes) {
                    Console.WriteLine($"{mark.Attributes["subject"].Value} {mark.Attributes["value"].Value}");
                }
            }
            xmlDoc.Save("academy.xml");
		}
	}
}
