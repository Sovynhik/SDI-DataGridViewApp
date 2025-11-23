using System;
using System.Windows.Forms;

namespace PhoneBook_V16
{
    // Класс, содержащий точку входа в приложение (Main)
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}