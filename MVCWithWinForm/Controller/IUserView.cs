using MVCWithWinForm.Model;

namespace MVCWithWinForm.Controller
{
    public interface IUserView
    {
        void SetController(UserController controller);
        void GridInitialization();
        void AddUserToGrid(User user);

        int ID              { get; set; }
        string FirstName    { get; set; }
        string LastName     { get; set; }
        string Department   { get; set; }
        SexOfPerson Sex     { get; set; }
        bool CanModifyID    {      set; }
    }
}
