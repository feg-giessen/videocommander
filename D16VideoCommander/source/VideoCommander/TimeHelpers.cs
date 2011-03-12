using System;

namespace D16.VideoCommander
{
    internal static class TimeHelpers
    {
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

        private static int GetInt(string value)
        {
            if (value == null)
                return 0;

            value = value.Trim();
            if (String.IsNullOrEmpty(value))
                return 0;

            try
            {
                return Convert.ToInt32(value);
            }
            catch { }

            return 0;
        }

        public static string ToFormatedString(this TimeSpan time)
        {
            return String.Format("{0:00}:{1:00}:{2:00}", time.Hours, time.Minutes, time.Seconds);
        }
    }
}
