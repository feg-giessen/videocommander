using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace D16.VideoCommander
{
    class PlaylistSerializer
    {
        public XmlDocument Serialize(IEnumerable<ListViewItem> items)
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration declaration = doc.CreateXmlDeclaration("1.0", "utf-8", "yes");
            doc.AppendChild(declaration);

            XmlElement root = doc.CreateElement("items");
            doc.AppendChild(root);

            foreach (ListViewItem item in items)
            {
                XmlElement element = doc.CreateElement("item");
                element.InnerText = item.Text;

                XmlAttribute startTime = doc.CreateAttribute("start");
                startTime.InnerText = item.SubItems[1].Text;
                element.Attributes.Append(startTime);

                XmlAttribute endTime = doc.CreateAttribute("end");
                endTime.InnerText = item.SubItems[2].Text;
                element.Attributes.Append(endTime);

                XmlAttribute duration = doc.CreateAttribute("duration");
                duration.InnerText = item.SubItems[3].Text;
                element.Attributes.Append(duration);

                root.AppendChild(element);
            }
            
            return doc;
        }

        public IEnumerable<ListViewItem> Deserialize(XmlDocument document)
        {
            List<ListViewItem> items = new List<ListViewItem>();

            if (document == null || document.DocumentElement == null)
                return items;

            foreach (XmlNode element in document.DocumentElement.ChildNodes)
            {
                ListViewItem item = new ListViewItem(element.InnerText);

                item.SubItems.AddRange(new string[] {
                    GetAttributeValue(element, "start"),
                    GetAttributeValue(element, "end"),
                    GetAttributeValue(element, "duration")
                });

                items.Add(item);
            }

            return items;
        }

        public string GetAttributeValue(XmlNode node, string name)
        {
            if (node == null || String.IsNullOrEmpty(name))
                return String.Empty;

            XmlAttribute attribute = node.Attributes[name];

            if (attribute == null)
                return String.Empty;

            return attribute.InnerText;
        }
    }
}
