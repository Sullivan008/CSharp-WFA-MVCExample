using MVCWithWinForm.Controller;
using MVCWithWinForm.Model;
using System;
using System.Windows.Forms;

namespace MVCWithWinForm
{
    public partial class UserView : Form, IUserView
    {
        private UserController controller;

        public UserView()
        {
            InitializeComponent();
        }

#region Eseménykezelések implementálása

        /// <summary>
        ///     Esemény -> Új felhasználó hozzáadása
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            controller.AddNewUser();
        }
        
        /// <summary>
        ///     Esemény -> Felhasználó törlése
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            /// Csak akkor futtatjuk az eseményt ha a Grid-ben ki van választva legalább egy sor
            if (usersGrid.SelectedItems.Count > 0)
            {
                /// Lekérdezzük a 0. indexű oszlop értékét, azaz az ID-t, majd azt adjuk át paraméterként
                controller.RemoveUser(int.Parse(usersGrid.SelectedItems[0].Text));
            }
        }

        /// <summary>
        ///     Esemény -> Új felhasználó regisztrálása
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            controller.SaveUser();
        }

        /// <summary>
        ///     Esemény -> A Grid-ben a legutóbbi sor adatai kerüljenek bele az Input mezőkbe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void usersGrid_SelectedIndexChanged(object sender, EventArgs e)
        {
            /// Csak akkor futtatjuk az eseményt ha a Grid-ben ki van választva legalább egy sor
            if(usersGrid.SelectedItems.Count > 0)
            {
                /// Lekérdezzük a 0. indexű oszlop értékét, azaz az ID-t, majd azt adjuk át paraméterként
                controller.GetSelectedUser(int.Parse(usersGrid.SelectedItems[0].Text));
            }
        }

#endregion

#region Grid-hez tartozó műveletek implementálása

        /// <summary>
        ///     A paraméterben kapott kontrollert beállítja az épp, aktuális Controller-nek
        /// </summary>
        /// <param name="controller">   A beállítandó kontroller</param>
        public void SetController(UserController controller)
        {
            this.controller = controller;
        }

        /// <summary>
        ///     Inicializálja a View-on megjelenő Grid-et.
        /// </summary>
        public void GridInitialization()
        {
            ClearColumnAndRowDataInGrid();

            ColumnInitialization();
        }

        /// <summary>
        ///     Kitörli az Olszop majd pedig a Sor adatokat a Grid-ből
        /// </summary>
        private void ClearColumnAndRowDataInGrid()
        {
            /// Grid Oszlopadatok törlése
            usersGrid.Columns.Clear();

            /// Grid sor adatok törlése
            usersGrid.Items.Clear();
        }

        /// <summary>
        ///     Definiálja a Grid-ben megjelenő oszlop adatokat
        /// </summary>
        private void ColumnInitialization()
        {
            usersGrid.Columns.Add("Id",         150, HorizontalAlignment.Left);
            usersGrid.Columns.Add("Vezetéknév", 150, HorizontalAlignment.Left);
            usersGrid.Columns.Add("Keresztnév", 150, HorizontalAlignment.Left);
            usersGrid.Columns.Add("Osztály",    150, HorizontalAlignment.Left);
            usersGrid.Columns.Add("Nem",        150, HorizontalAlignment.Left);

        }

        /// <summary>
        ///     A paraméterben megkapott User objektumot hozzáadja a Grid-hez.
        /// </summary>
        /// <param name="user"> A beszúrandó objektum</param>
        public void AddUserToGrid(User user)
        {
            ListViewItem parentID;

            /// ID beszúrása a Grid-be
            parentID = usersGrid.Items.Add(user.ID.ToString());

            /// Az ID-hez tartozó adatok beszúrása (Név, osztály, nem)
            parentID.SubItems.Add(user.FirstName);
            parentID.SubItems.Add(user.LastName);
            parentID.SubItems.Add(user.Department);
            parentID.SubItems.Add(Enum.GetName(typeof(SexOfPerson), user.Sex));
        }

#endregion

#region View - Controller közötti adatkapcsolat implementálása

        /// <summary>
        ///     Getter/Setter metódus az idTextBox mezőhöz
        /// </summary>
        public int ID
        {
            get
            {
                /// Vizsgálat, hogy nem üres-e az IDTextBox mező. Ha igen -1-et térítünk vissza
                try
                {
                    return int.Parse(idTextBox.Text);
                }
                catch (FormatException e)
                {
                    return -1;
                }
            }

            set
            {
                /// Vizsgálat, hogy a beállítandó érték -1-e. Ha -1, akkor egy üres
                /// karakterláncot szúrunk be az idTextBox mezőbe, különben pedig
                /// a kapott ID értéket
                if (value == -1)
                {
                    idTextBox.Text = "";
                }
                else
                {
                    idTextBox.Text = value.ToString();
                }
            }
        }

        /// <summary>
        ///     Getter/Setter metódus a firstNameTextBox mezőhöz
        /// </summary>
        public string FirstName
        {
            get { return firstNameTextBox.Text; }
            set { firstNameTextBox.Text = value; }
        }

        /// <summary>
        ///      Getter/Setter metódus a lastNameTextBox mezőhöz
        /// </summary>
        public string LastName
        {
            get { return lastNameTextBox.Text; }
            set { lastNameTextBox.Text = value; }
        }

        /// <summary>
        ///      Getter/Setter metódus a departmentTextBox mezőhöz
        /// </summary>
        public string Department
        {
            get { return departmentTextBox.Text; }
            set { departmentTextBox.Text = value; }
        }

        /// <summary>
        ///      Getter/Setter metódus a Male/Female radioButton objektumokhoz
        /// </summary>
        public SexOfPerson Sex
        {
            get
            {
                /// Vizsgálat, hogy a maleRadioButton be van-e pipálva.
                /// Ha nincs akkor a femaleRadioButton értéket térítjük vissza, 
                /// különben a maleRadioButton értéket.
                if (maleRadioButton.Checked)
                {
                    return SexOfPerson.Male;
                }
                else
                {
                    return SexOfPerson.Female;
                }
            }

            set
            {
                /// Vizsgálat, hogy a kapott érték Male-e. Ha igen akkor a 
                /// maleRadioButton-t pipáljuk be, ellenkező esetben pedig a
                /// famaleRadioButton-t
                if (value == SexOfPerson.Male)
                {
                    maleRadioButton.Checked = true;
                }
                else
                {
                    femaleRadioButton.Checked = true;
                }
            }
        }

        /// <summary>
        ///     Beállítja, hogy az idTextBox input mező Enabled-e vagy sem.
        /// </summary>
        public bool CanModifyID
        {
            set { idTextBox.Enabled = value; }
        }

#endregion
    }
}
