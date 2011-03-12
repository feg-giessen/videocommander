using System.Windows.Forms;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace D16.VideoCommander
{
    class Program
    {
        [STAThread]
        public static void Main(params string[] arguments)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);

            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += WorkerThreadHandler;

            using (Main app = new Main())
            {
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

                if (FileExtensionRegistry.IsAdministrator())
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();

                    FileExtensionRegistry.CreateFileAssociation(
                        "vplx", "D16VideoPlaylist", "Playlist for D16 VideoCommander.",
                        assembly.Location);
                }

                app.ShowDialog();
            }
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            Trace.TraceError(e.Exception.ToString());
        }

        static void WorkerThreadHandler(object sender, UnhandledExceptionEventArgs args)
        {
            if (!(args.ExceptionObject is System.Threading.ThreadAbortException))
                Trace.TraceError(args.ExceptionObject.ToString());
        }
    }
}
