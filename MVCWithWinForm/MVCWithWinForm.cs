using MVCWithWinForm.Controller;
using System;
using System.Collections;
using System.Windows.Forms;

namespace MVCWithWinForm
{
    static class MVCWithWinForm
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /// Felhasználókkal feltöltjük az adathalmazunkat
            Datas.Datas.FillUsers();

            /// View implementálása
            UserView view = new UserView();

            /// Controller imploementálása
            UserController controller = new UserController(view, Datas.Datas.GetUsers());

            controller.LoadView();

            view.ShowDialog();
        }
    }
}
