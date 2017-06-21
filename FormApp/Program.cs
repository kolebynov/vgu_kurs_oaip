using Domain.Concrete;
using System;
using System.Windows.Forms;
using FormApp.Forms;
using FormApp.Infrastructure;
using Domain.Model;

namespace FormApp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Init();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(Factory.GetInstance<IDataHelper<BookedTour>>()));
        }

        static void Init()
        {
            DomainSchemas.GenerateAllSchemas();
        }
    }
}
