using System;
using System.Configuration;
using System.Linq;

namespace D16.VideoCommander
{
    static class ConfigManager
    {
        static private Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        static private KeyValueConfigurationCollection Settings
        {
            get { return configuration.AppSettings.Settings; }
        }

        static public string GetValue(string key)
        {
            if (Settings.AllKeys.Contains(key))
                return Settings[key].Value;

            return String.Empty;
        }

        static public void SetValue(string key, object value)
        {
            if (Settings.AllKeys.Contains(key))
            {
                if (value == null)
                {
                    Settings.Remove(key);
                }
                else
                {
                    Settings[key].Value = value.ToString();
                }

            }
            else if (value != null)
            {
                Settings.Add(key, value.ToString());
            }

            configuration.Save();
        }
    }
}
