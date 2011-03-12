using System;
using System.Collections.Generic;
using System.Text;

namespace D16.VideoCommander
{
    /// <summary>
    /// Base class for command line arguments
    /// </summary>
    abstract class VlcArgumentBuilder
    {
        protected VlcArgumentBuilder()
        {
        }

        /// <summary>
        /// List of commands (with values).
        /// </summary>
        protected readonly Dictionary<string, string> commands = new Dictionary<string, string>();

        /// <summary>
        /// Sets (adds or updates) a command parameter.
        /// </summary>
        /// <param name="key">The parameter name.</param>
        /// <param name="value">The parameter value.</param>
        protected void SetString(string key, string value)
        {
            if (commands.ContainsKey(key))
            {
                commands[key] = value;
            }
            else
            {
                commands.Add(key, value);
            }
        }

        /// <summary>
        /// Sets (adds or updates) a boolean command parameter.
        /// </summary>
        /// <param name="value">The value (true or false).</param>
        /// <param name="trueValue">The argument string for "true".</param>
        /// <param name="falseValue">The argument string for "false".</param>
        protected void SetBoolean(bool value, string trueValue, string falseValue)
        {
            commands.Remove(trueValue);
            commands.Remove(falseValue);

            if (value)
            {
                commands.Add(trueValue, null);
            }
            else
            {
                commands.Add(falseValue, null);
            }
        }

        /// <summary>
        /// Build the complete arguments string.
        /// </summary>
        /// <returns></returns>
        public virtual string GetArgumentString()
        {
            StringBuilder result = new StringBuilder();

            foreach (var item in commands)
            {
                string value = item.Value;

                if (String.IsNullOrEmpty(value))
                {
                    result.AppendFormat(" {0}", item.Key);
                }
                else
                {
                    if (value.Contains(" "))
                    {
                        value = String.Concat("\"", value, "\"");
                    }

                    result.AppendFormat(" {0}={1}", item.Key, value);
                }
            }

            return result.ToString().Trim();
        }
    }
}
