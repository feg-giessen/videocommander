using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace D16.VideoCommander
{
    /// <summary>
    /// Serielizer for play lists.
    /// </summary>
    internal class PlaylistSerializer
    {
        /// <summary>
        /// Serializes the specified play list items.
        /// </summary>
        /// <param name="items">The play list.</param>
        /// <returns>The serielized play list as xml document.</returns>
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

        /// <summary>
        /// Deserializes a play list from specified xml document.
        /// </summary>
        /// <param name="document">The serialized play list as xml document.</param>
        /// <returns>The play list as list of items.</returns>
        public IEnumerable<ListViewItem> Deserialize(XmlDocument document)
        {
            List<ListViewItem> items = new List<ListViewItem>();

            if (document == null || document.DocumentElement == null)
                return items;

            foreach (XmlNode element in document.DocumentElement.ChildNodes)
            {
                ListViewItem item = new ListViewItem(element.InnerText);

                item.SubItems.AddRange(new []
                {
                    this.GetAttributeValue(element, "start"),
                    this.GetAttributeValue(element, "end"),
                    this.GetAttributeValue(element, "duration")
                });

                items.Add(item);
            }

            return items;
        }

        /// <summary>
        /// Returns the value of the specified attribute.
        /// If the attribute is not present for the specified node, an empty string is returned.
        /// </summary>
        /// <param name="node">The xml node.</param>
        /// <param name="name">The attribute name.</param>
        /// <returns>Value of the attribute or an empty string as fallback.</returns>
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