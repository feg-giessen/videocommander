using System;

namespace D16.VideoCommander
{
    class VlcFile : VlcArgumentBuilder
    {
        private string fileName;

        public VlcFile(string fileName)
        {
            this.fileName = fileName;
        }

        public VlcFile SetStartTime(int seconds)
        {
            SetString(":start-time", seconds.ToString());

            return this;
        }

        public VlcFile SetEndTime(int seconds)
        {
            SetString(":stop-time", seconds.ToString());

            return this;
        }

        public VlcFile SetDuration(int seconds)
        {
            SetString(":run-time", seconds.ToString());

            return this;
        }

        public override string GetArgumentString()
        {
            return String.Format("\"{0}\" {1}", fileName, base.GetArgumentString());
        }
    }
}
