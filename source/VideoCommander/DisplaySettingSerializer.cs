using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace D16.VideoCommander
{
    /// <summary>
    /// Serializer for display settings.
    /// </summary>
    internal class DisplaySettingSerializer
    {
        /// <summary>
        /// The xml serializer.
        /// </summary>
        private readonly XmlSerializer serializer;

        /// <summary>
        /// Initializes a new instance of the <see cref="DisplaySettingSerializer" /> class.
        /// </summary>
        public DisplaySettingSerializer()
        {
            this.serializer = new XmlSerializer(typeof(DisplaySetting));
        }

        /// <summary>
        /// Serializes the specified display setting.
        /// </summary>
        /// <param name="data">The display setting.</param>
        /// <returns>The serialized display setting as xml string</returns>
        public string Serialize(DisplaySetting data)
        {
            if (data == null)
                return string.Empty;

            var result = new StringBuilder();

            using (TextWriter writer = new StringWriter(result)) 
            {
                serializer.Serialize(writer, data);
            }

            return result.ToString();
        }

        /// <summary>
        /// Deserializes a display setting from specified xml string.
        /// </summary>
        /// <param name="data">The display setting as xml string.</param>
        /// <returns>The deserialized display setting.</returns>
        public DisplaySetting Deserialize(string data)
        {
            if (string.IsNullOrEmpty(data))
                return null;

            using (TextReader reader = new StringReader(data))
            {
                return serializer.Deserialize(reader) as DisplaySetting;
            }
        }
    }
}
