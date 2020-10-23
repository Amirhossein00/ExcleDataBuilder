using System;
using System.Windows.Forms;
using Excel_Data_Mkaer.Factory;
using SimpleInjector;

namespace Excel_Data_Mkaer
{
    static class Program
    {
        private static Container container;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Bootstrap();
            Application.Run(container.GetInstance<Form1>());
        }
        private static void Bootstrap()
        {
            var container = new Container();

            container.Register<IExcelFactory,ExcelFactory>(Lifestyle.Singleton);
            container.Register<Form1>();
            container.Verify();
        }
    }
}
