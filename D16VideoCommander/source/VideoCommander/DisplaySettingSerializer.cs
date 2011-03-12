using System.Text;
using System.Xml.Serialization;
using System.IO;
using System;

namespace D16.VideoCommander
{
    class DisplaySettingSerializer
    {
        private XmlSerializer serializer;

        public DisplaySettingSerializer()
        {
            serializer = new XmlSerializer(typeof(DisplaySetting));
        }

        public string Serialize(DisplaySetting data)
        {
            if (data == null)
                return String.Empty;

            StringBuilder result = new StringBuilder();

            using (TextWriter writer = new StringWriter(result)) 
            {
                serializer.Serialize(writer, data);
            }

            return result.ToString();
        }

        public DisplaySetting Deserialize(string data)
        {
            if (String.IsNullOrEmpty(data))
                return null;

            using (TextReader reader = new StringReader(data))
            {
                return serializer.Deserialize(reader) as DisplaySetting;
            }
        }
    }
}
