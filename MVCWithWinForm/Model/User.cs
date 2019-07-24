using System;

namespace MVCWithWinForm.Model
{
    public class User
    {
        private int id;

        public string FirstName     { get; set; }
        public string LastName      { get; set; }
        public string Department    { get; set; }
        public SexOfPerson Sex      { get; set; }

        /// <summary>
        ///     Konstruktor
        /// </summary>
        /// <param name="ID">   ID  </param>
        /// <param name="firstName">    Vezetéknév  </param>
        /// <param name="lastName">     Keresztnév  </param>
        /// <param name="department">   Osztály     </param>
        /// <param name="sex">  Nem </param>
        public User(int id, string firstName, string lastName, string department, SexOfPerson sex)
        {
            this.id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Department = department;
            this.Sex = sex;
        }

        /// <summary>
        ///     Üres konstruktor
        /// </summary>
        public User()
        {
        }

        /// <summary>
        ///     ID Getter - Setter-s beállítása
        /// </summary>
        public int ID
        {
            get { return id; }
            set
            {
                try
                {
                    id = value;
                }
                catch(NullReferenceException e)
                {
                    System.Diagnostics.Debug.WriteLine("> ++++ ERROR - Hiba! Túl nagy számot adott meg!", e.Message);
                }
            }
        }
    }
}
