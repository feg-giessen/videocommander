using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace D16.VideoCommander
{
    public class Program
    {
        [STAThread]
        public static void Main(params string[] arguments)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);

            Application.ThreadException += OnApplicationThreadException;
            AppDomain.CurrentDomain.UnhandledException += WorkerThreadHandler;

            if (string.IsNullOrEmpty(Properties.Settings.Default.VlcPath))
                Properties.Settings.Default.Upgrade();

            using (var app = new Main())
            {
                // Open play list from arguments.
                if (arguments != null && arguments.Length > 0)
                {
                    foreach (string fileName in arguments)
                    {
                        if (File.Exists(fileName))
                        {
                            app.LoadPlaylist(fileName);
                        }
                    }
                }

                // Register file extension, if application is executed with admin rights...
                if (FileExtensionRegistry.IsAdministrator())
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();

                    FileExtensionRegistry.CreateFileAssociation(
                        "vplx", "D16VideoPlaylist", "Play list for D16 VideoCommander",
                        assembly.Location);
                }

                app.ShowDialog();
            }
        }

        private static void OnApplicationThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            Trace.TraceError(e.Exception.ToString());
        }

        private static void WorkerThreadHandler(object sender, UnhandledExceptionEventArgs args)
        {
            if (!(args.ExceptionObject is System.Threading.ThreadAbortException))
            {
                Trace.TraceError(args.ExceptionObject.ToString());
            }
        }
    }
}