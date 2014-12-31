using System;
using System.Collections.Generic;
using System.Text;

namespace D16.VideoCommander
{
    /// <summary>
    /// Base class for command line arguments
    /// </summary>
    internal abstract class VlcArgumentBuilder
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
            if (this.commands.ContainsKey(key))
            {
                this.commands[key] = value;
            }
            else
            {
                this.commands.Add(key, value);
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
            this.commands.Remove(trueValue);
            this.commands.Remove(falseValue);

            this.commands.Add(value ? trueValue : falseValue, null);
        }

        /// <summary>
        /// Build the complete arguments string.
        /// </summary>
        /// <returns></returns>
        public virtual string GetArgumentString()
        {
            var result = new StringBuilder();

            foreach (var item in this.commands)
            {
                string value = item.Value;

                if (string.IsNullOrEmpty(value))
                {
                    result.AppendFormat(" {0}", item.Key);
                }
                else
                {
                    if (value.Contains(" "))
                    {
                        value = string.Concat("\"", value, "\"");
                    }

                    result.AppendFormat(" {0}={1}", item.Key, value);
                }
            }

            return result.ToString().Trim();
        }
    }
}