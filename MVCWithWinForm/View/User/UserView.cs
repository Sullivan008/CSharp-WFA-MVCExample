using MVCWithWinForm.Controller.UserView;
using MVCWithWinForm.Enum.UserView;
using MVCWithWinForm.Model.UserView;
using System;
using System.Windows.Forms;

namespace MVCWithWinForm.View.User
{
    public partial class UserView : Form, IUserView
    {
        private IUserController _userController;

        public UserView()
        {
            InitializeComponent();
        }

        public void SetController(UserController userController)
        {
            _userController = userController ?? throw new ArgumentNullException(nameof(userController));
        }

        #region PROPERTIES Getters/ Setters

        public string Id
        {
            get => idTextBox.Text;
            set => idTextBox.Text = value;
        }

        public string FirstName
        {
            get => firstNameTextBox.Text;
            set => firstNameTextBox.Text = value;
        }

        public string LastName
        {
            get => lastNameTextBox.Text;
            set => lastNameTextBox.Text = value;
        }

        public string Department
        {
            get => departmentTextBox.Text;
            set => departmentTextBox.Text = value;
        }

        public SexOfUser Sex
        {
            get => maleRadioButton.Checked ? SexOfUser.Male : SexOfUser.Female;

            set
            {
                if (value == SexOfUser.Male)
                {
                    maleRadioButton.Checked = true;
                }
                else
                {
                    femaleRadioButton.Checked = true;
                }
            }
        }

        #endregion

        #region PRIVATE View Object Modifiers Properties

        private bool CanModifyFirstName
        {
            set => firstNameTextBox.Enabled = value;
        }

        private bool CanModifyLastName
        {
            set => lastNameTextBox.Enabled = value;
        }

        private bool CanModifyDepartment
        {
            set => departmentTextBox.Enabled = value;
        }

        private bool CanModifySex
        {
            set => sexGroup.Enabled = value;
        }

        private bool CanUseSaveButton
        {
            set => createOrEditBtn.Visible = value;
        }

        private string SetSaveButtonContent
        {
            set => createOrEditBtn.Text = value;
        }

        #endregion

        #region INPUT Fields Modifiers Methods

        public void SetInputFieldsForInserting()
        {
            CanModifyFirstName = true;
            CanModifyLastName = true;
            CanModifyDepartment = true;
            CanModifySex = true;
            CanUseSaveButton = true;
            SetSaveButtonContent = "Save";

            Id = null;
            FirstName = string.Empty;
            LastName = string.Empty;
            Department = string.Empty;
        }

        public void SetInputFieldsToDefault()
        {
            CanModifyFirstName = false;
            CanModifyLastName = false;
            CanModifyDepartment = false;
            CanModifySex = false;
            CanUseSaveButton = false;

            SetSaveButtonContent = string.Empty;

            Id = null;
            FirstName = string.Empty;
            LastName = string.Empty;
            Department = string.Empty;
        }

        public void SetInputFieldsForUpdating()
        {
            CanModifyFirstName = true;
            CanModifyLastName = true;
            CanModifyDepartment = true;
            CanModifySex = true;
            CanUseSaveButton = true;

            SetSaveButtonContent = "Update";
        }

        #endregion

        #region VALIDATION

        public bool ModelIsValid =>
            Id != null && FirstName != string.Empty && LastName != string.Empty && Department != string.Empty;

        #endregion

        #region EVENT Handlers

        private void AddNewUserBtn_Click(object sender, EventArgs e)
        {
            if (usersGrid.SelectedItems.Count > 0)
            {
                usersGrid.SelectedItems.Clear();
            }

            SetInputFieldsForInserting();
        }

        private void RemoveUsersBtn_Click(object sender, EventArgs e)
        {
            if (usersGrid.SelectedItems.Count > 0)
            {
                _userController.RemoveSelectedUsers(usersGrid.SelectedItems);
            }
        }

        private void CreateOrEditUserBtn_Click(object sender, EventArgs e)
        {
            _userController.CreateOrUpdateUser(new CreateOrEditUserViewModel
            {
                Id = Id,
                FirstName = FirstName,
                LastName = LastName,
                Department = Department,
                Sex = Sex
            });
        }

        private void UsersGrid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ListView listView && listView.SelectedItems.Count == 1)
            {
                _userController.GetUserById(listView.SelectedItems[0].SubItems[0].Text);
            }
            else
            {
                SetInputFieldsToDefault();
            }
        }

        #endregion

        #region PUBLIC GRID OPERATIONS

        public void GridInitialization()
        {
            usersGrid.Clear();

            usersGrid.Columns.Add("Id", 220, HorizontalAlignment.Left);
            usersGrid.Columns.Add("First name", 150, HorizontalAlignment.Left);
            usersGrid.Columns.Add("Last name", 150, HorizontalAlignment.Left);
            usersGrid.Columns.Add("Department", 150, HorizontalAlignment.Left);
            usersGrid.Columns.Add("Sex", 91, HorizontalAlignment.Left);
        }

        public void AddUserToGrid(UserViewModel user)
        {
            string[] row =
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Department = user.Department,
                (Sex = user.Sex).ToString()
            };

            usersGrid.Items.Add(new ListViewItem(row));
        }

        #endregion
    }
}
