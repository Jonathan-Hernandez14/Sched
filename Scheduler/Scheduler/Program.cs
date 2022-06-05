using Scheduler.Forms;

namespace Scheduler
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        static Mutex mutex = new Mutex(true, "MUTEX_SINGLEINSTANCE");

        [STAThread]
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            else
            {
                MessageBox.Show("Only one instance of the program is allowed");
            }
        }
    }
}