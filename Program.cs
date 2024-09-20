using System;
using System.Windows.Forms;

namespace InPay
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
            Application.Exit();
        } //END: MAIN
    }
}
