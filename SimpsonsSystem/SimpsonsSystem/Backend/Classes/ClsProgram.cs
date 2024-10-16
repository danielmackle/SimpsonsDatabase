using System;
using System.Windows.Forms;
namespace SimpsonsSystem.Backend.Classes
{
    static class ClsProgram
    {
        ///<summary>
        ///  The main entry point for the application.
        ///</summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frontend.Forms.FrmTitlePage());//Open starting with the title page
        }
    }
}
