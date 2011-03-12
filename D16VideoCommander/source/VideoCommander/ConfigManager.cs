using System;
using System.Configuration;
using System.Linq;

namespace D16.VideoCommander
{
    /// <summary>
    /// Manager for access to app.config settings.
    /// </summary>
    static class ConfigManager
    {
        static private Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        static private KeyValueConfigurationCollection Settings
        {
            get { return configuration.AppSettings.Settings; }
        }

        /// <summary>
        /// Returns a value from app.config or an empty string, if value is not present.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        static public string GetValue(string key)
        {
            if (Settings.AllKeys.Contains(key))
                return Settings[key].Value;

            return String.Empty;
        }

        /// <summary>
        /// Sets a value to the app.config file.
        /// If specified value is <code>null</code>, the entry is removed from app.config.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
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
