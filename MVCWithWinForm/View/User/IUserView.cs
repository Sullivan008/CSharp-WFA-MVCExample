using MVCWithWinForm.Controller.UserView;
using MVCWithWinForm.Enum.UserView;
using MVCWithWinForm.Model.UserView;

namespace MVCWithWinForm.View.User
{
    public interface IUserView
    {
        void SetController(UserController userController);

        #region PROPERTIES Getters/ Setters

        string Id { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        string Department { get; set; }

        SexOfUser Sex { get; set; }

        #endregion

        #region VALIDATION

        bool ModelIsValid { get; }

        #endregion

        #region INPUT Fields Modifiers Methods

        void SetInputFieldsToDefault();

        void SetInputFieldsForUpdating();

        #endregion

        #region PUBLIC GRID OPERATIONS

        void GridInitialization();

        void AddUserToGrid(UserViewModel user);

        #endregion
    }
}
