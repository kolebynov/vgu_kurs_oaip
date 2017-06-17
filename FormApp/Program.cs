using Domain.Concrete;
using System;
using System.Windows.Forms;
using FormApp.Forms;

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
            Application.Run(new MainForm());
        }

        static void Init()
        {
            DomainSchemas.GenerateAllSchemas();
        }
    }
}
