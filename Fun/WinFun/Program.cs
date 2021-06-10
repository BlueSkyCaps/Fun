using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFun
{
    class Program
    {
        public static bool terminationFlag = false;
        private static Form1 form1;
        private static ThreadStart threadStartDelegate;
        private static Action formInvokeAction;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            threadStartDelegate += AppRunThread;
            Thread thread = new Thread(threadStartDelegate);
            thread.Start();
            Thread.Sleep(1000);
            if (form1.InvokeRequired)
            {
                form1.Invoke(formInvokeAction = () => { form1.Hide(); });
            }
            while (true)
            {
                if (terminationFlag)
                {
                    System.Environment.Exit(0);
                }
                var a = System.Diagnostics.Process.GetProcesses();
                foreach (var item in a)
                {
                    if (item.ProcessName.Contains("QQBrowser") || item.ProcessName.Contains("firefox"))
                    {
                        item.Kill();
                        System.Diagnostics.Debug.WriteLine("--2");

                        if (form1.InvokeRequired)
                        {
                            System.Diagnostics.Debug.WriteLine("111");
                            form1.Invoke(formInvokeAction = () => { form1.Show(); });
                        }
                    }
                }
            }
        }

        private static void AppRunThread()
        {
            form1 = new Form1();
            Application.Run(form1);
        }
    }
}
