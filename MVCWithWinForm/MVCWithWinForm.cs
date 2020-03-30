using MVCWithWinForm.Controller.UserView;
using MVCWithWinForm.Operations.User;
using MVCWithWinForm.View.User;
using System;
using System.Windows.Forms;

namespace MVCWithWinForm
{
    static class MVCWithWinForm
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            UserView view = new UserView();
            IUserController controller = new UserController(view, new UserOperation().GetUsers());

            controller.LoadView();

            view.ShowDialog();
        }
    }
}
