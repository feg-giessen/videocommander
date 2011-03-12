using System;

namespace D16.VideoCommander
{
    /// <summary>
    /// Play list item
    /// </summary>
    class VlcFile : VlcArgumentBuilder
    {
        /// <summary>
        /// Path to the video file.
        /// </summary>
        private string fileName;

        /// <summary>
        /// Initializes a new instance of the <see cref="VlcFile" /> class.
        /// </summary>
        /// <param name="fileName">Name of the video file.</param>
        public VlcFile(string fileName)
        {
            this.fileName = fileName;
        }

        /// <summary>
        /// Sets the start time (in seconds).
        /// </summary>
        /// <param name="seconds">The start time in seconds.</param>
        /// <returns></returns>
        public VlcFile SetStartTime(int seconds)
        {
            SetString(":start-time", seconds.ToString());

            return this;
        }

        /// <summary>
        /// Sets the end time (in seconds).
        /// </summary>
        /// <param name="seconds">The end time in seconds.</param>
        /// <returns></returns>
        public VlcFile SetEndTime(int seconds)
        {
            SetString(":stop-time", seconds.ToString());

            return this;
        }

        /// <summary>
        /// Sets the duration (in seconds).
        /// </summary>
        /// <param name="seconds">The end time in seconds.</param>
        /// <returns></returns>
        public VlcFile SetDuration(int seconds)
        {
            SetString(":run-time", seconds.ToString());

            return this;
        }

        /// <summary>
        /// Builds the argument string for the video file.
        /// </summary>
        /// <returns></returns>
        public override string GetArgumentString()
        {
            return String.Format("\"{0}\" {1}", fileName, base.GetArgumentString());
        }
    }
}
