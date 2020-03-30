using MVCWithWinForm.Enum.UserView;

namespace MVCWithWinForm.Model.UserView
{
    public class UserBaseViewModel
    {
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Department { get; set; }

        public SexOfUser Sex { get; set; }
    }
}
