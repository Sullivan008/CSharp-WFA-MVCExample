namespace MVCWithWinForm.View.User
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
            this.removeUsersBtn = new System.Windows.Forms.Button();
            this.detailsGroup = new System.Windows.Forms.GroupBox();
            this.sexGroup = new System.Windows.Forms.GroupBox();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.departmantLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.addNewUserBtn = new System.Windows.Forms.Button();
            this.createOrEditBtn = new System.Windows.Forms.Button();
            this.detailsGroup.SuspendLayout();
            this.sexGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // usersGrid
            // 
            this.usersGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.usersGrid.FullRowSelect = true;
            this.usersGrid.GridLines = true;
            this.usersGrid.HideSelection = false;
            this.usersGrid.Location = new System.Drawing.Point(0, 213);
            this.usersGrid.Margin = new System.Windows.Forms.Padding(4);
            this.usersGrid.Name = "usersGrid";
            this.usersGrid.Size = new System.Drawing.Size(1020, 365);
            this.usersGrid.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.usersGrid.TabIndex = 40;
            this.usersGrid.UseCompatibleStateImageBehavior = false;
            this.usersGrid.View = System.Windows.Forms.View.Details;
            this.usersGrid.SelectedIndexChanged += new System.EventHandler(this.UsersGrid_SelectedIndexChanged);
            // 
            // removeUsersBtn
            // 
            this.removeUsersBtn.Location = new System.Drawing.Point(855, 59);
            this.removeUsersBtn.Margin = new System.Windows.Forms.Padding(4);
            this.removeUsersBtn.Name = "removeUsersBtn";
            this.removeUsersBtn.Size = new System.Drawing.Size(149, 28);
            this.removeUsersBtn.TabIndex = 37;
            this.removeUsersBtn.Text = "- Remove user/s";
            this.removeUsersBtn.Click += new System.EventHandler(this.RemoveUsersBtn_Click);
            // 
            // detailsGroup
            // 
            this.detailsGroup.Controls.Add(this.sexGroup);
            this.detailsGroup.Controls.Add(this.departmentTextBox);
            this.detailsGroup.Controls.Add(this.departmantLabel);
            this.detailsGroup.Controls.Add(this.idTextBox);
            this.detailsGroup.Controls.Add(this.IdLabel);
            this.detailsGroup.Controls.Add(this.lastNameTextBox);
            this.detailsGroup.Controls.Add(this.lastNameLabel);
            this.detailsGroup.Controls.Add(this.firstNameTextBox);
            this.detailsGroup.Controls.Add(this.firstNameLabel);
            this.detailsGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.detailsGroup.Location = new System.Drawing.Point(16, 7);
            this.detailsGroup.Margin = new System.Windows.Forms.Padding(4);
            this.detailsGroup.Name = "detailsGroup";
            this.detailsGroup.Padding = new System.Windows.Forms.Padding(4);
            this.detailsGroup.Size = new System.Drawing.Size(819, 177);
            this.detailsGroup.TabIndex = 39;
            this.detailsGroup.TabStop = false;
            this.detailsGroup.Text = "New user registration";
            // 
            // sexGroup
            // 
            this.sexGroup.Controls.Add(this.femaleRadioButton);
            this.sexGroup.Controls.Add(this.maleRadioButton);
            this.sexGroup.Enabled = false;
            this.sexGroup.ForeColor = System.Drawing.SystemColors.MenuText;
            this.sexGroup.Location = new System.Drawing.Point(28, 97);
            this.sexGroup.Margin = new System.Windows.Forms.Padding(4);
            this.sexGroup.Name = "sexGroup";
            this.sexGroup.Padding = new System.Windows.Forms.Padding(4);
            this.sexGroup.Size = new System.Drawing.Size(368, 66);
            this.sexGroup.TabIndex = 29;
            this.sexGroup.TabStop = false;
            this.sexGroup.Text = "Sex";
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.Location = new System.Drawing.Point(184, 23);
            this.femaleRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(89, 30);
            this.femaleRadioButton.TabIndex = 5;
            this.femaleRadioButton.Text = "Female";
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.Location = new System.Drawing.Point(76, 23);
            this.maleRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(71, 30);
            this.maleRadioButton.TabIndex = 4;
            this.maleRadioButton.Text = "Male";
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.Location = new System.Drawing.Point(519, 66);
            this.departmentTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(275, 22);
            this.departmentTextBox.TabIndex = 27;
            // 
            // departmantLabel
            // 
            this.departmantLabel.Location = new System.Drawing.Point(425, 70);
            this.departmantLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.departmantLabel.Name = "departmantLabel";
            this.departmantLabel.Size = new System.Drawing.Size(85, 28);
            this.departmantLabel.TabIndex = 28;
            this.departmantLabel.Text = "Department:";
            // 
            // idTextBox
            // 
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(519, 34);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(275, 22);
            this.idTextBox.TabIndex = 5;
            // 
            // IdLabel
            // 
            this.IdLabel.Location = new System.Drawing.Point(428, 38);
            this.IdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(82, 28);
            this.IdLabel.TabIndex = 25;
            this.IdLabel.Text = "ID:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(104, 66);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(291, 22);
            this.lastNameTextBox.TabIndex = 4;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Location = new System.Drawing.Point(12, 70);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(96, 28);
            this.lastNameLabel.TabIndex = 23;
            this.lastNameLabel.Text = "Last name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(104, 34);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(291, 22);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Location = new System.Drawing.Point(8, 38);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(100, 28);
            this.firstNameLabel.TabIndex = 19;
            this.firstNameLabel.Text = "First name:";
            // 
            // addNewUserBtn
            // 
            this.addNewUserBtn.Location = new System.Drawing.Point(855, 23);
            this.addNewUserBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addNewUserBtn.Name = "addNewUserBtn";
            this.addNewUserBtn.Size = new System.Drawing.Size(149, 28);
            this.addNewUserBtn.TabIndex = 36;
            this.addNewUserBtn.Text = "+ New user";
            this.addNewUserBtn.Click += new System.EventHandler(this.AddNewUserBtn_Click);
            // 
            // createOrEditBtn
            // 
            this.createOrEditBtn.Location = new System.Drawing.Point(855, 143);
            this.createOrEditBtn.Margin = new System.Windows.Forms.Padding(4);
            this.createOrEditBtn.Name = "createOrEditBtn";
            this.createOrEditBtn.Size = new System.Drawing.Size(149, 28);
            this.createOrEditBtn.TabIndex = 38;
            this.createOrEditBtn.Click += new System.EventHandler(this.CreateOrEditUserBtn_Click);
            // 
            // UserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 578);
            this.Controls.Add(this.usersGrid);
            this.Controls.Add(this.removeUsersBtn);
            this.Controls.Add(this.detailsGroup);
            this.Controls.Add(this.addNewUserBtn);
            this.Controls.Add(this.createOrEditBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        internal System.Windows.Forms.Button removeUsersBtn;
        internal System.Windows.Forms.GroupBox detailsGroup;
        private System.Windows.Forms.GroupBox sexGroup;
        internal System.Windows.Forms.RadioButton femaleRadioButton;
        internal System.Windows.Forms.RadioButton maleRadioButton;
        internal System.Windows.Forms.TextBox departmentTextBox;
        internal System.Windows.Forms.Label departmantLabel;
        internal System.Windows.Forms.TextBox idTextBox;
        internal System.Windows.Forms.Label IdLabel;
        internal System.Windows.Forms.TextBox lastNameTextBox;
        internal System.Windows.Forms.Label lastNameLabel;
        internal System.Windows.Forms.TextBox firstNameTextBox;
        internal System.Windows.Forms.Label firstNameLabel;
        internal System.Windows.Forms.Button addNewUserBtn;
        internal System.Windows.Forms.Button createOrEditBtn;
    }
}

