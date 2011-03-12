using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace D16.VideoCommander
{
    class VlcCommander
    {
        private readonly string path;

        public VlcCommander(string path)
        {
            this.path = path;
        }

        public void Start(params VlcArgumentBuilder[] command)
        {
            List<string> commands = new List<string>();
            foreach (var item in command) 
            {
                commands.Add(item.GetArgumentString());
            }

            string argumentString = String.Join(" ", commands.ToArray());
            Trace.TraceInformation(argumentString);

            using (Process vlc = new Process()) 
            {
                vlc.StartInfo = new ProcessStartInfo(path, argumentString);
                vlc.ErrorDataReceived += vlc_ErrorDataReceived;

                vlc.Start();
            }
        }

        void vlc_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e == null)
                return;

            Trace.TraceError(e.Data);
        }
    }
}
