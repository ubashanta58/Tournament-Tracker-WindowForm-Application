namespace WindowsFormsApp1
{
    partial class CreateTeamForm
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
            this.createTeamlabel = new System.Windows.Forms.Label();
            this.teamNamelabel = new System.Windows.Forms.Label();
            this.selectTeamMemberlabel = new System.Windows.Forms.Label();
            this.selectTeamMemberDropBox = new System.Windows.Forms.ComboBox();
            this.addMemberbutton = new System.Windows.Forms.Button();
            this.addMembergroupBox = new System.Windows.Forms.GroupBox();
            this.cellPhonetextBox = new System.Windows.Forms.TextBox();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.lastNametextBox = new System.Windows.Forms.TextBox();
            this.firstNametextBox = new System.Windows.Forms.TextBox();
            this.cellPhonelabel = new System.Windows.Forms.Label();
            this.emaillabel = new System.Windows.Forms.Label();
            this.lastNamelabel = new System.Windows.Forms.Label();
            this.firstNamelabel = new System.Windows.Forms.Label();
            this.createMemberbutton = new System.Windows.Forms.Button();
            this.teamNametextBox = new System.Windows.Forms.TextBox();
            this.createTeambutton = new System.Windows.Forms.Button();
            this.tournamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.removeSelectedbutton = new System.Windows.Forms.Button();
            this.addMembergroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // createTeamlabel
            // 
            this.createTeamlabel.AutoSize = true;
            this.createTeamlabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTeamlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createTeamlabel.Location = new System.Drawing.Point(1, 9);
            this.createTeamlabel.Name = "createTeamlabel";
            this.createTeamlabel.Size = new System.Drawing.Size(163, 37);
            this.createTeamlabel.TabIndex = 3;
            this.createTeamlabel.Text = "Create Team";
            // 
            // teamNamelabel
            // 
            this.teamNamelabel.AutoSize = true;
            this.teamNamelabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNamelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.teamNamelabel.Location = new System.Drawing.Point(3, 46);
            this.teamNamelabel.Name = "teamNamelabel";
            this.teamNamelabel.Size = new System.Drawing.Size(129, 30);
            this.teamNamelabel.TabIndex = 4;
            this.teamNamelabel.Text = "Team Name:";
            this.teamNamelabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // selectTeamMemberlabel
            // 
            this.selectTeamMemberlabel.AutoSize = true;
            this.selectTeamMemberlabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamMemberlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.selectTeamMemberlabel.Location = new System.Drawing.Point(3, 113);
            this.selectTeamMemberlabel.Name = "selectTeamMemberlabel";
            this.selectTeamMemberlabel.Size = new System.Drawing.Size(207, 30);
            this.selectTeamMemberlabel.TabIndex = 5;
            this.selectTeamMemberlabel.Text = "Select Team Member";
            this.selectTeamMemberlabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // selectTeamMemberDropBox
            // 
            this.selectTeamMemberDropBox.BackColor = System.Drawing.Color.White;
            this.selectTeamMemberDropBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamMemberDropBox.ForeColor = System.Drawing.Color.Black;
            this.selectTeamMemberDropBox.FormattingEnabled = true;
            this.selectTeamMemberDropBox.Location = new System.Drawing.Point(8, 146);
            this.selectTeamMemberDropBox.Name = "selectTeamMemberDropBox";
            this.selectTeamMemberDropBox.Size = new System.Drawing.Size(292, 38);
            this.selectTeamMemberDropBox.TabIndex = 11;
            this.selectTeamMemberDropBox.SelectedIndexChanged += new System.EventHandler(this.selectTeamDropBox_SelectedIndexChanged);
            // 
            // addMemberbutton
            // 
            this.addMemberbutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addMemberbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addMemberbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addMemberbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberbutton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMemberbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addMemberbutton.Location = new System.Drawing.Point(86, 190);
            this.addMemberbutton.Name = "addMemberbutton";
            this.addMemberbutton.Size = new System.Drawing.Size(150, 46);
            this.addMemberbutton.TabIndex = 15;
            this.addMemberbutton.Text = "Add Member";
            this.addMemberbutton.UseVisualStyleBackColor = true;
            this.addMemberbutton.Click += new System.EventHandler(this.addTeambutton_Click);
            // 
            // addMembergroupBox
            // 
            this.addMembergroupBox.Controls.Add(this.cellPhonetextBox);
            this.addMembergroupBox.Controls.Add(this.emailtextBox);
            this.addMembergroupBox.Controls.Add(this.lastNametextBox);
            this.addMembergroupBox.Controls.Add(this.firstNametextBox);
            this.addMembergroupBox.Controls.Add(this.cellPhonelabel);
            this.addMembergroupBox.Controls.Add(this.emaillabel);
            this.addMembergroupBox.Controls.Add(this.lastNamelabel);
            this.addMembergroupBox.Controls.Add(this.firstNamelabel);
            this.addMembergroupBox.Controls.Add(this.createMemberbutton);
            this.addMembergroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMembergroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addMembergroupBox.Location = new System.Drawing.Point(10, 242);
            this.addMembergroupBox.Name = "addMembergroupBox";
            this.addMembergroupBox.Size = new System.Drawing.Size(290, 202);
            this.addMembergroupBox.TabIndex = 16;
            this.addMembergroupBox.TabStop = false;
            this.addMembergroupBox.Text = "Add Member";
            // 
            // cellPhonetextBox
            // 
            this.cellPhonetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellPhonetextBox.Location = new System.Drawing.Point(121, 130);
            this.cellPhonetextBox.Name = "cellPhonetextBox";
            this.cellPhonetextBox.Size = new System.Drawing.Size(163, 31);
            this.cellPhonetextBox.TabIndex = 27;
            // 
            // emailtextBox
            // 
            this.emailtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtextBox.Location = new System.Drawing.Point(121, 93);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(163, 31);
            this.emailtextBox.TabIndex = 26;
            // 
            // lastNametextBox
            // 
            this.lastNametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNametextBox.Location = new System.Drawing.Point(121, 56);
            this.lastNametextBox.Name = "lastNametextBox";
            this.lastNametextBox.Size = new System.Drawing.Size(163, 31);
            this.lastNametextBox.TabIndex = 25;
            // 
            // firstNametextBox
            // 
            this.firstNametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNametextBox.Location = new System.Drawing.Point(121, 19);
            this.firstNametextBox.Name = "firstNametextBox";
            this.firstNametextBox.Size = new System.Drawing.Size(163, 31);
            this.firstNametextBox.TabIndex = 24;
            this.firstNametextBox.TextChanged += new System.EventHandler(this.firstNametextBox_TextChanged);
            // 
            // cellPhonelabel
            // 
            this.cellPhonelabel.AutoSize = true;
            this.cellPhonelabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellPhonelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.cellPhonelabel.Location = new System.Drawing.Point(6, 130);
            this.cellPhonelabel.Name = "cellPhonelabel";
            this.cellPhonelabel.Size = new System.Drawing.Size(98, 25);
            this.cellPhonelabel.TabIndex = 23;
            this.cellPhonelabel.Text = "Cellphone";
            // 
            // emaillabel
            // 
            this.emaillabel.AutoSize = true;
            this.emaillabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.emaillabel.Location = new System.Drawing.Point(0, 96);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(58, 25);
            this.emaillabel.TabIndex = 22;
            this.emaillabel.Text = "Email";
            this.emaillabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // lastNamelabel
            // 
            this.lastNamelabel.AutoSize = true;
            this.lastNamelabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNamelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lastNamelabel.Location = new System.Drawing.Point(0, 59);
            this.lastNamelabel.Name = "lastNamelabel";
            this.lastNamelabel.Size = new System.Drawing.Size(100, 25);
            this.lastNamelabel.TabIndex = 21;
            this.lastNamelabel.Text = "Last Name";
            // 
            // firstNamelabel
            // 
            this.firstNamelabel.AutoSize = true;
            this.firstNamelabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNamelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.firstNamelabel.Location = new System.Drawing.Point(0, 22);
            this.firstNamelabel.Name = "firstNamelabel";
            this.firstNamelabel.Size = new System.Drawing.Size(102, 25);
            this.firstNamelabel.TabIndex = 20;
            this.firstNamelabel.Text = "First Name";
            // 
            // createMemberbutton
            // 
            this.createMemberbutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createMemberbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createMemberbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createMemberbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemberbutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createMemberbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createMemberbutton.Location = new System.Drawing.Point(61, 167);
            this.createMemberbutton.Name = "createMemberbutton";
            this.createMemberbutton.Size = new System.Drawing.Size(167, 30);
            this.createMemberbutton.TabIndex = 19;
            this.createMemberbutton.Text = "Create Member";
            this.createMemberbutton.UseVisualStyleBackColor = true;
            this.createMemberbutton.Click += new System.EventHandler(this.createMemberbutton_Click);
            // 
            // teamNametextBox
            // 
            this.teamNametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNametextBox.Location = new System.Drawing.Point(8, 79);
            this.teamNametextBox.Name = "teamNametextBox";
            this.teamNametextBox.Size = new System.Drawing.Size(290, 31);
            this.teamNametextBox.TabIndex = 17;
            this.teamNametextBox.TextChanged += new System.EventHandler(this.teamNametextBox_TextChanged);
            // 
            // createTeambutton
            // 
            this.createTeambutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTeambutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTeambutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTeambutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeambutton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTeambutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createTeambutton.Location = new System.Drawing.Point(261, 459);
            this.createTeambutton.Name = "createTeambutton";
            this.createTeambutton.Size = new System.Drawing.Size(167, 43);
            this.createTeambutton.TabIndex = 18;
            this.createTeambutton.Text = "Create Team";
            this.createTeambutton.UseVisualStyleBackColor = true;
            this.createTeambutton.Click += new System.EventHandler(this.createTeambutton_Click);
            // 
            // tournamentPlayersListBox
            // 
            this.tournamentPlayersListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentPlayersListBox.FormattingEnabled = true;
            this.tournamentPlayersListBox.ItemHeight = 16;
            this.tournamentPlayersListBox.Location = new System.Drawing.Point(360, 56);
            this.tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            this.tournamentPlayersListBox.Size = new System.Drawing.Size(311, 388);
            this.tournamentPlayersListBox.TabIndex = 19;
            // 
            // removeSelectedbutton
            // 
            this.removeSelectedbutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.removeSelectedbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.removeSelectedbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.removeSelectedbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedbutton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSelectedbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.removeSelectedbutton.Location = new System.Drawing.Point(677, 203);
            this.removeSelectedbutton.Name = "removeSelectedbutton";
            this.removeSelectedbutton.Size = new System.Drawing.Size(97, 70);
            this.removeSelectedbutton.TabIndex = 20;
            this.removeSelectedbutton.Text = "Remove Selected";
            this.removeSelectedbutton.UseVisualStyleBackColor = true;
            this.removeSelectedbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(786, 515);
            this.Controls.Add(this.removeSelectedbutton);
            this.Controls.Add(this.tournamentPlayersListBox);
            this.Controls.Add(this.createTeambutton);
            this.Controls.Add(this.teamNametextBox);
            this.Controls.Add(this.addMembergroupBox);
            this.Controls.Add(this.addMemberbutton);
            this.Controls.Add(this.selectTeamMemberDropBox);
            this.Controls.Add(this.selectTeamMemberlabel);
            this.Controls.Add(this.teamNamelabel);
            this.Controls.Add(this.createTeamlabel);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.addMembergroupBox.ResumeLayout(false);
            this.addMembergroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createTeamlabel;
        private System.Windows.Forms.Label teamNamelabel;
        private System.Windows.Forms.Label selectTeamMemberlabel;
        private System.Windows.Forms.ComboBox selectTeamMemberDropBox;
        private System.Windows.Forms.Button addMemberbutton;
        private System.Windows.Forms.GroupBox addMembergroupBox;
        private System.Windows.Forms.TextBox teamNametextBox;
        private System.Windows.Forms.Button createTeambutton;
        private System.Windows.Forms.TextBox cellPhonetextBox;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.TextBox lastNametextBox;
        private System.Windows.Forms.TextBox firstNametextBox;
        private System.Windows.Forms.Label cellPhonelabel;
        private System.Windows.Forms.Label emaillabel;
        private System.Windows.Forms.Label lastNamelabel;
        private System.Windows.Forms.Label firstNamelabel;
        private System.Windows.Forms.Button createMemberbutton;
        private System.Windows.Forms.ListBox tournamentPlayersListBox;
        private System.Windows.Forms.Button removeSelectedbutton;
    }
}