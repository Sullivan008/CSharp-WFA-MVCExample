using MVCWithWinForm.Model.UserView;
using MVCWithWinForm.View.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MVCWithWinForm.Controller.UserView
{
    public class UserController : IUserController
    {
        private readonly IUserView _userView;
        private readonly IList<UserViewModel> _users;

        public UserController(IUserView userView, IList<UserViewModel> users)
        {
            _userView = userView ?? throw new ArgumentNullException(nameof(userView));
            _users = users ?? throw new ArgumentNullException(nameof(users));

            _userView.SetController(this);
        }

        public void LoadView()
        {
            _userView.GridInitialization();

            FillGridWithUsers();

            _userView.SetInputFieldsToDefault();
        }

        public void RemoveSelectedUsers(ListView.SelectedListViewItemCollection selectedUsers)
        {
            for (int i = 0; i < selectedUsers.Count; i++)
            {
                _users.Remove(_users.SingleOrDefault(x => x.Id == selectedUsers[i].SubItems[0].Text));
            }

            _userView.GridInitialization();

            FillGridWithUsers();
        }

        public void CreateOrUpdateUser(CreateOrEditUserViewModel model)
        {
            if (_userView.ModelIsValid)
            {
                UserViewModel user = _users.SingleOrDefault(x => x.Id == model.Id);

                if (user == null)
                {
                    _users.Add(new UserViewModel
                    {
                        Id = Guid.NewGuid().ToString(),
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        Department = model.Department,
                        Sex = model.Sex
                    });
                }
                else
                {
                    user.FirstName = model.FirstName;
                    user.LastName = model.LastName;
                    user.Department = model.Department;
                    user.Sex = model.Sex;
                }

                _userView.GridInitialization();

                FillGridWithUsers();

                _userView.SetInputFieldsToDefault();
            }
            else
            {
                MessageBox.Show("asd", "Információ!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void GetUserById(string userId)
        {
            UserViewModel user = _users.SingleOrDefault(x => x.Id == userId);

            if (user != null)
            {
                _userView.Id = user.Id;
                _userView.FirstName = user.FirstName;
                _userView.LastName = user.LastName;
                _userView.Department = user.Department;
                _userView.Sex = user.Sex;

                _userView.SetInputFieldsForUpdating();
            }
            else
            {
                MessageBox.Show("asd", "Információ!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #region PRIVATE Helper Methods

        private void FillGridWithUsers()
        {
            foreach (UserViewModel currentUser in _users)
            {
                _userView.AddUserToGrid(currentUser);
            }
        }

        #endregion
    }
}
