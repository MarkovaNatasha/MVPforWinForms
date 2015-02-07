using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Task14.View;

namespace Task14
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var f1 = new Form1();
            var pr = new Presenter.Presenter(f1);
            Application.Run(f1);

        }
    }
}
