using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace HW_CS_11_Serialization {
	public struct GoodItem : IComparable<GoodItem> {
		public string name { get; set; }
		public int count { get; set; }
		public double pay { get; set; }
		public double sum { get=>count*pay; }
		public GoodItem(string name, int cnt, double pay) {
			this.name = name;
			this.count = cnt;
			this.pay = pay;
		}

		public int CompareTo(GoodItem item) {
			return item.name.CompareTo(name);
		}

		public override string ToString() {
			return $"Name : {name}  | Counts : {count}  | Price : {pay:F2}  | Summary : {sum:F2}  |\n";
		}
	}
	[Serializable]
	public class Order : IEnumerable<GoodItem> {
		public string ordNumber { get; set; }
		private List<GoodItem> goods;
		public double sumPrice { get; set; }
		[NonSerialized]
		public readonly string currency = "UAH";
		public Order() {
			ordNumber = null;
			goods = new List<GoodItem>();
			sumPrice = 0.0;
		}
		public Order(string ordNum) {
			ordNumber = ordNum;
			goods = new List<GoodItem>();
			sumPrice = 0.0;
		}
		public void AddItem(GoodItem good) {
			goods.Add(good);
			sumPrice += good.sum;
		}

		public void AddItem(string name, int cnt, double pay) {
			GoodItem good = new GoodItem(name, cnt, pay);
			AddItem(good);
		}
		public override string ToString() {
			StringBuilder str = new StringBuilder($"Order N: {ordNumber};\n");
			foreach(var s in goods) {
				str.Insert(str.Length, s.ToString());
			}
			str.Insert(str.Length, $"\nSum : {sumPrice:F2} {currency}");
			return str.ToString();
		}

		IEnumerator IEnumerable.GetEnumerator() {
			return goods.GetEnumerator();
		}

		public IEnumerator<GoodItem> GetEnumerator() {
			return ((IEnumerable<GoodItem>)goods).GetEnumerator();
		}
	}
	class Program {
		static void Main(string[] args) {
			Order ord = new Order("ORD-0001");
			ord.AddItem("Notebook", 1, 10500.80);
			ord.AddItem("Web-Camera", 2, 900);
			ord.AddItem("KeyBoard", 3, 241.05);

			#region XmlTextWriter
			try {
				using (XmlTextWriter xmlDoc = new XmlTextWriter("order.xml", System.Text.Encoding.Unicode)) {
					xmlDoc.Formatting = Formatting.Indented;
					xmlDoc.WriteStartDocument();
					xmlDoc.WriteStartElement("Order");
					xmlDoc.WriteAttributeString("Number", ord.ordNumber);
					xmlDoc.WriteAttributeString("SumOrder", $"{ord.sumPrice.ToString():F2}");
					foreach (var item in ord) {
						xmlDoc.WriteStartElement("GoodsItem");
						xmlDoc.WriteAttributeString("Name", item.name);
						xmlDoc.WriteAttributeString("Count", item.count.ToString());
						xmlDoc.WriteAttributeString("Price", item.pay.ToString());
						xmlDoc.WriteAttributeString("Summ", item.sum.ToString());
						xmlDoc.WriteEndElement();
					}
					xmlDoc.WriteEndElement();
					xmlDoc.WriteEndDocument();
					Console.WriteLine("XML Create done");
				}
			} catch(Exception e) {
				Console.WriteLine(e);
			}
			#endregion

			#region XmlTextReader
			Order ordReader = new Order();
			try {
				using (XmlTextReader xmlDoc = new XmlTextReader("order.xml")) {
					xmlDoc.WhitespaceHandling = WhitespaceHandling.None;
					while (xmlDoc.Read()) {
						if(xmlDoc.NodeType == XmlNodeType.Element && xmlDoc.Name == "Order" && xmlDoc.AttributeCount > 0) {
							ordReader.ordNumber = xmlDoc.GetAttribute("Number");
						}
						if(xmlDoc.NodeType == XmlNodeType.Element && xmlDoc.Name == "GoodsItem" && xmlDoc.AttributeCount > 0) {
							ordReader.AddItem(xmlDoc.GetAttribute("Name"), Int32.Parse(xmlDoc.GetAttribute("Count")), Double.Parse(xmlDoc.GetAttribute("Price")));
						}
					}
				}
			} catch ( Exception e) {
				Console.WriteLine(e);
			}
			#endregion

			#region XmlDocument
			Order ordDoc = new Order();
			try {
				XmlDocument xmlDoc = new XmlDocument();
				xmlDoc.Load("order.xml");
				if (xmlDoc.DocumentElement.NodeType == XmlNodeType.Element && xmlDoc.DocumentElement.Name == "Order") ordDoc.ordNumber = xmlDoc.DocumentElement.GetAttribute("Number");
				if (xmlDoc.DocumentElement.HasChildNodes) {
					foreach(XmlNode item in xmlDoc.DocumentElement.ChildNodes) {
						ordDoc.AddItem(item.Attributes.GetNamedItem("Name").Value, Int32.Parse(item.Attributes.GetNamedItem("Count").Value), Double.Parse(item.Attributes.GetNamedItem("Price").Value));
					}
				}
			} catch (Exception e) {
				Console.WriteLine(e);
			}

			#endregion

			Console.WriteLine("\nMain Order object to write");
			Console.WriteLine(ord.ToString());
			Console.WriteLine("\nXmlTextReader Order object from read");
			Console.WriteLine(ordReader.ToString());
			Console.WriteLine("\nXmlDocument Order object from read");
			Console.WriteLine(ordDoc.ToString());
			Console.ReadKey();
		}
	}
}
