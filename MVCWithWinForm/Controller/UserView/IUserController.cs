using MVCWithWinForm.Model.UserView;
using System.Windows.Forms;

namespace MVCWithWinForm.Controller.UserView
{
    public interface IUserController
    {
        void LoadView();

        void RemoveSelectedUsers(ListView.SelectedListViewItemCollection selectedUsers);

        void CreateOrUpdateUser(CreateOrEditUserViewModel model);

        void GetUserById(string userId);
    }
}
