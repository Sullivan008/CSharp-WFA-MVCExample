using MVCWithWinForm.Model.JsonParser;
using MVCWithWinForm.Model.UserView;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace MVCWithWinForm.Operations.User
{
    public class UserOperation
    {
        private readonly IList<UserViewModel> _users;

        public UserOperation()
        {
            _users = UsersInitialize();
        }

        public IList<UserViewModel> GetUsers() =>
            _users;

        #region PRIVATE Helper Methods

        private static List<UserViewModel> UsersInitialize()
        {
            using (StreamReader streamReader =
                File.OpenText($"{Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\"))}/App_Data/users.json"))
            {
                JsonSerializer serializer = new JsonSerializer();

                return ((UsersModel) serializer.Deserialize(streamReader, typeof(UsersModel))).Users;
            }
        }

        #endregion
    }
}
