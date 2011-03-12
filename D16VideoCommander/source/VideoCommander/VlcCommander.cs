using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace D16.VideoCommander
{
    /// <summary>
    /// Passes commands to the vlc video player.
    /// </summary>
    class VlcCommander
    {
        /// <summary>
        /// Path to "vlc.exe"
        /// </summary>
        private readonly string path;

        /// <summary>
        /// Initializes a new instance of the <see cref="VlcCommander" /> class.
        /// </summary>
        /// <param name="path">The path.</param>
        public VlcCommander(string path)
        {
            this.path = path;
        }

        /// <summary>
        /// Starts the vlc player and appends commands from argument builders.
        /// </summary>
        /// <param name="command">The command.</param>
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

        /// <summary>
        /// Handles the ErrorDataReceived event of the vlc process.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Diagnostics.DataReceivedEventArgs" /> instance containing the event data.</param>
        private void vlc_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e == null)
                return;

            Trace.TraceError(e.Data);
        }
    }
}
