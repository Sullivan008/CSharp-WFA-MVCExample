namespace MVCWithWinForm
{
    partial class UserView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usersGrid = new System.Windows.Forms.ListView();
            this.removeButton = new System.Windows.Forms.Button();
            this.detailsGroup = new System.Windows.Forms.GroupBox();
            this.sexGroup = new System.Windows.Forms.GroupBox();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.departmantLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.detailsGroup.SuspendLayout();
            this.sexGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // usersGrid
            // 
            this.usersGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.usersGrid.FullRowSelect = true;
            this.usersGrid.GridLines = true;
            this.usersGrid.Location = new System.Drawing.Point(0, 173);
            this.usersGrid.Name = "usersGrid";
            this.usersGrid.Size = new System.Drawing.Size(765, 297);
            this.usersGrid.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.usersGrid.TabIndex = 40;
            this.usersGrid.UseCompatibleStateImageBehavior = false;
            this.usersGrid.View = System.Windows.Forms.View.Details;
            this.usersGrid.SelectedIndexChanged += new System.EventHandler(this.usersGrid_SelectedIndexChanged);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(641, 48);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(112, 23);
            this.removeButton.TabIndex = 37;
            this.removeButton.Text = "- Felhasználó törlése";
            this.removeButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // detailsGroup
            // 
            this.detailsGroup.Controls.Add(this.sexGroup);
            this.detailsGroup.Controls.Add(this.departmentTextBox);
            this.detailsGroup.Controls.Add(this.departmantLabel);
            this.detailsGroup.Controls.Add(this.idTextBox);
            this.detailsGroup.Controls.Add(this.IDLabel);
            this.detailsGroup.Controls.Add(this.lastNameTextBox);
            this.detailsGroup.Controls.Add(this.lastNameLabel);
            this.detailsGroup.Controls.Add(this.firstNameTextBox);
            this.detailsGroup.Controls.Add(this.firstNameLabel);
            this.detailsGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.detailsGroup.Location = new System.Drawing.Point(12, 6);
            this.detailsGroup.Name = "detailsGroup";
            this.detailsGroup.Size = new System.Drawing.Size(614, 144);
            this.detailsGroup.TabIndex = 39;
            this.detailsGroup.TabStop = false;
            this.detailsGroup.Text = "Új felhasználó regisztrálása: ";
            // 
            // sexGroup
            // 
            this.sexGroup.Controls.Add(this.femaleRadioButton);
            this.sexGroup.Controls.Add(this.maleRadioButton);
            this.sexGroup.ForeColor = System.Drawing.SystemColors.MenuText;
            this.sexGroup.Location = new System.Drawing.Point(21, 79);
            this.sexGroup.Name = "sexGroup";
            this.sexGroup.Size = new System.Drawing.Size(276, 54);
            this.sexGroup.TabIndex = 29;
            this.sexGroup.TabStop = false;
            this.sexGroup.Text = "Nem:";
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.Location = new System.Drawing.Point(138, 19);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(67, 24);
            this.femaleRadioButton.TabIndex = 5;
            this.femaleRadioButton.Text = "Nő";
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.Location = new System.Drawing.Point(57, 19);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(53, 24);
            this.maleRadioButton.TabIndex = 4;
            this.maleRadioButton.Text = "Férfi";
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.Location = new System.Drawing.Point(389, 54);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(207, 20);
            this.departmentTextBox.TabIndex = 27;
            // 
            // departmantLabel
            // 
            this.departmantLabel.Location = new System.Drawing.Point(331, 57);
            this.departmantLabel.Name = "departmantLabel";
            this.departmantLabel.Size = new System.Drawing.Size(52, 23);
            this.departmantLabel.TabIndex = 28;
            this.departmantLabel.Text = "Osztály:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(389, 28);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(207, 20);
            this.idTextBox.TabIndex = 5;
            // 
            // IDLabel
            // 
            this.IDLabel.Location = new System.Drawing.Point(331, 31);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(52, 23);
            this.IDLabel.TabIndex = 25;
            this.IDLabel.Text = "ID:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(78, 54);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(219, 20);
            this.lastNameTextBox.TabIndex = 4;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Location = new System.Drawing.Point(9, 57);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(72, 23);
            this.lastNameLabel.TabIndex = 23;
            this.lastNameLabel.Text = "Kereszt név:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(78, 28);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(219, 20);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Location = new System.Drawing.Point(6, 31);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(75, 23);
            this.firstNameLabel.TabIndex = 19;
            this.firstNameLabel.Text = "Vezetéknév:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(641, 19);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(112, 23);
            this.addButton.TabIndex = 36;
            this.addButton.Text = "+ Új felhasználó";
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(641, 116);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(112, 23);
            this.registerButton.TabIndex = 38;
            this.registerButton.Text = "Regisztrálás";
            this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // UserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 470);
            this.Controls.Add(this.usersGrid);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.detailsGroup);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.registerButton);
            this.MaximizeBox = false;
            this.Name = "UserView";
            this.Text = "MVC With WinForm";
            this.detailsGroup.ResumeLayout(false);
            this.detailsGroup.PerformLayout();
            this.sexGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ListView usersGrid;
        internal System.Windows.Forms.Button removeButton;
        internal System.Windows.Forms.GroupBox detailsGroup;
        private System.Windows.Forms.GroupBox sexGroup;
        internal System.Windows.Forms.RadioButton femaleRadioButton;
        internal System.Windows.Forms.RadioButton maleRadioButton;
        internal System.Windows.Forms.TextBox departmentTextBox;
        internal System.Windows.Forms.Label departmantLabel;
        internal System.Windows.Forms.TextBox idTextBox;
        internal System.Windows.Forms.Label IDLabel;
        internal System.Windows.Forms.TextBox lastNameTextBox;
        internal System.Windows.Forms.Label lastNameLabel;
        internal System.Windows.Forms.TextBox firstNameTextBox;
        internal System.Windows.Forms.Label firstNameLabel;
        internal System.Windows.Forms.Button addButton;
        internal System.Windows.Forms.Button registerButton;
    }
}

