using System;

namespace D16.VideoCommander
{
    /// <summary>
    /// Helpers for time format conversations.
    /// </summary>
    internal static class TimeHelpers
    {
        /// <summary>
        /// Parses the formated string (HH:MM:SS) into a time span.
        /// </summary>
        /// <param name="formatedString">The formated time string.</param>
        /// <returns></returns>
        public static TimeSpan FromFormatedString(string formatedString)
        {
            int seconds, minutes, hours;

            string[] parts = formatedString.Split(':');

            seconds = GetInt(parts[parts.Length - 1]);
            minutes = 0;
            hours = 0;

            if (parts.Length > 1)
            {
                minutes = GetInt(parts[parts.Length - 2]);
            }
            if (parts.Length > 2)
            {
                hours = GetInt(parts[parts.Length - 3]);
            }

            return new TimeSpan(hours, minutes, seconds);
        }

        /// <summary>
        /// Converts a string into an integer value (with fallback to 0).
        /// </summary>
        /// <param name="value">The string represenation of the integer value.</param>
        /// <returns></returns>
        private static int GetInt(string value)
        {
            if (value == null)
                return 0;

            value = value.Trim();
            if (string.IsNullOrEmpty(value))
                return 0;

            try
            {
                return Convert.ToInt32(value);
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Formats a time span into a string (HH:MM:SS).
        /// </summary>
        /// <param name="time">The time span.</param>
        /// <returns></returns>
        public static string ToFormatedString(this TimeSpan time)
        {
            return string.Format("{0:00}:{1:00}:{2:00}", time.Hours, time.Minutes, time.Seconds);
        }
    }
}