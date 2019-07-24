using MVCWithWinForm.Model;
using System.Collections;
using System.Windows.Forms;

namespace MVCWithWinForm.Controller
{
    public class UserController
    {
        IUserView view;
        IList users;

        /// Ebben fogjuk tárolni, hogy melyik User-t választottuk ki a Grid-ből
        User selectedUser;

        /// <summary>
        ///     Konstruktor. Hozzárendeli a paraméterben kapott View-hoz a Controller-t
        /// </summary>
        /// <param name="view">     A Controllerhez kapcsolandó View </param>
        /// <param name="users">    A felhasználókat tartalmazó lista </param>
        public UserController(IUserView view, IList users)
        {
            /// View és Modell beállítása
            this.view = view;
            this.users = users;

            /// View-hoz tartozó Vezérlő (Controller) beállítása
            view.SetController(this);
        }

        /// <summary>
        ///     Beolvassa a paraméterben kapott View-ot. 
        /// </summary>
        public void LoadView()
        {
            /// Grid inicializálása
            view.GridInitialization();

            /// Grid feltöltése adatokkal
            FillGridWithUsers();
        }

        /// <summary>
        ///     Kiüríti a View-on található összes input mező értékét és
        ///     engedélyezi az ID mező módosítását
        /// </summary>
        public void AddNewUser()
        {
            /// Input mezők inicializálása
            InitializationViewDetailValues();

            /// ID mező módosításának engedélyezése
            view.CanModifyID = true;
        }

        /// <summary>
        ///     A paraméterben kapott kiválasztott ID-jú User törlése a Grid-ből
        /// </summary>
        /// <param name="selectedUserID">   A törlendő User ID-ja </param>
        public void RemoveUser(int selectedUserID)
        {
            /// Bejárjuk az összes felhasználót
            foreach(User currentUser in users)
            {
                /// Ha az aktuális felhasználó ID-ja megegyezik a kiválaszott User ID-jával, akkor...
                if(currentUser.ID == selectedUserID)
                {
                    /// Az aktuálisan eggyező User törlése a Usereket tartalmazó listából
                    users.Remove(currentUser);

                    /// Grid újrainicializálása
                    view.GridInitialization();

                    /// Grid feltöltése adatokkal
                    FillGridWithUsers();
                    
                    /// Input mezők inicializálása
                    InitializationViewDetailValues();

                    break;
                }
            }
        }

        /// <summary>
        ///     User mentése a Grid-be
        /// </summary>
        public void SaveUser()
        {
            if (EveryDetailIsFill())
            {
                if (!IDIsExists())
                {
                    /// Ha meglévő User-t módosítunk, akkor...
                    if (selectedUser != null)
                    {
                        /// Kitöröljük a User-eket tartalmazó listából, a kiválasztott User-t
                        users.Remove(selectedUser);
                    }
                    else
                    {
                        /// Létrehozunk egy új User-t
                        selectedUser = new User();
                    }

                    /// Frissítjük a User objektumunkat, az új Input mezőben található adatokkal.
                    UpdateUserWithViewValues(selectedUser);

                    /// Hozzáadjuk az új input adatokkal elkészített User-t a Grid-hez
                    users.Add(selectedUser);

                    /// Grid újrainicializálása
                    view.GridInitialization();

                    /// Az input mezők inicializálása
                    InitializationViewDetailValues();

                    /// A Grid feltöltése adatokkal
                    FillGridWithUsers();
                }
                else
                {
                    ShowInofmrationMessage("Ilyen ID már létezik! Kérem módosítsa az ID mező értékét!");
                }
            }
            else
            {
                ShowInofmrationMessage("Kérem töltsön ki minden adatot!");
            }
        }

        /// <summary>
        ///     Feltölti az Input mezőt a Grid-ből kiválasztott sor adataival, illetve eltárolja,
        ///     hogy melyik User volt legutólájra kiválasztva
        /// </summary>
        /// <param name="selectedUserID">   A kiválasztott sor User ID-ja </param>
        public void GetSelectedUser(int selectedUserID)
        {
            /// Bejárjuk az összes User-t
            foreach(User currentUser in users)
            {
                /// Ha a jelenlegi User ID-ja megegyezik a paraméterben kapott ID-val, akkor...
                if(currentUser.ID == selectedUserID)
                {
                    /// A jelenlegi User-t beállítjuk a kiválasztott User-nek
                    selectedUser = currentUser;

                    /// Az input mezők feltöltése adatokkal.
                    UpdateViewDetailValue(selectedUser);

                    /// Az ID mező használatának letiltása
                    view.CanModifyID = false;

                    break;
                }
            }
        }

        /// <summary>
        ///     Beállítja az Input mezők tartalmát alapértelmezettre, azaz üresre
        /// </summary>
        private void InitializationViewDetailValues()
        {
            view.ID         = -1;
            view.FirstName  = "";
            view.LastName   = "";
            view.Department = "";
            view.Sex        = SexOfPerson.Male;
        }

        /// <summary>
        ///     A paraméterben kapott User objektumban található adatokkal feltölti a 
        ///     View-on található Input mezőket
        /// </summary>
        /// <param name="user">     Az objektum, amelyből kinyerjük a feltöltéshez szükséges adatokat</param>
        private void UpdateViewDetailValue(User user)
        {
            view.ID         = user.ID;
            view.FirstName  = user.FirstName;
            view.LastName   = user.LastName;
            view.Department = user.Department;
            view.Sex        = user.Sex;
        }

        /// <summary>
        ///     A paraméterben kapott User objektumnak beállítja az Input-on található
        ///     adatokat
        /// </summary>
        /// <param name="user">     Az új adatokkal feltöltendő User objektum</param>
        private void UpdateUserWithViewValues(User user)
        {
            user.ID         = view.ID;
            user.FirstName  = view.FirstName;
            user.LastName   = view.LastName;
            user.Department = view.Department;
            user.Sex        = view.Sex;
        }

        /// <summary>
        ///     Feltölti a View-ban található Grid-et User objektumokkal
        /// </summary>
        private void FillGridWithUsers()
        {
            /// Felhasználók bejárása
            foreach (User currentUser in users)
            {
                view.AddUserToGrid(currentUser);
            }
        }

        /// <summary>
        ///     Megvizsgálja, hogy a View-on minden mező kötelezően ki van e töltve
        /// </summary>
        /// <returns>   true    ->  Ha ki van töltve
        ///             false   ->  Ha nincs
        /// </returns>
        private bool EveryDetailIsFill()
        {
            if(view.ID == -1 || 
                view.FirstName.Length == 0 ||
                view.LastName.Length == 0 ||
                view.Department.Length == 0)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        ///     Megvizsgálja, hogy a View-ba beírt ID érték létezik-e már a Felhasználókat
        ///     tároló listában
        /// </summary>
        /// <returns>
        ///     true    ->  Ha létezik!
        ///     false   ->  Ha nem!
        /// </returns>
        private bool IDIsExists()
        {
            foreach(User user in users)
            {
                if(user.ID == view.ID)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        ///     Megjelenít a felhasználó számára egy Message Box-ot, a paraméterben megadott
        ///     információs üzenettel
        /// </summary>
        /// <param name="informationMessage">   Információs üzenet</param>
        private void ShowInofmrationMessage(string informationMessage)
        {
            MessageBox.Show(informationMessage, "Információ!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
