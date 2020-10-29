using Autofac;
using Excel_Data_Mkaer.Factory;
using System;
using System.Windows.Forms;

namespace Excel_Data_Mkaer
{
    static class Program
    {
        public static IContainer container;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ExcelFactory>().As<IExcelFactory>();
            container = builder.Build();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
