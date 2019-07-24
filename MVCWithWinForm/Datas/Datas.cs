using MVCWithWinForm.Model;
using System.Collections;

namespace MVCWithWinForm.Datas
{
    class Datas
    {
        private static IList users = new ArrayList();

        /// <summary>
        ///     Feltölt egy Felhasználókat tartalmazó listát
        /// </summary>
        public static void FillUsers()
        {
            users.Add(new User(1, "Kozák", "Péter", "Első osztály", SexOfPerson.Male));
            users.Add(new User(2, "Siteri", "Emese Csilla", "Első osztály", SexOfPerson.Female));
        }

        /// <summary>
        ///     Visszatérít egy Felhasználókat taratalmazó listát
        /// </summary>
        /// <returns>   Felhasználók (User objektumok)</returns>
        public static IList GetUsers()
        {
            return users;
        }
    }
}
