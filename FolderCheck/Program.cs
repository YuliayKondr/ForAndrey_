using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderCheck
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainWin());
            }catch (Exception ex)
            {
                MessageBox.Show("Программа была закрыта", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
