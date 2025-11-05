using Lab4_Variant16;
using System;
using System.Windows.Forms;

namespace Lab4_Variant16
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Lab4_Variant16.FormMain());
        }
    }
}