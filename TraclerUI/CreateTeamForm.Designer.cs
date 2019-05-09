namespace TraclerUI
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
            this.teamNameText = new System.Windows.Forms.TextBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.creteTeamLabel = new System.Windows.Forms.Label();
            this.addTeamMemberbutton = new System.Windows.Forms.Button();
            this.selectTeamMembersDroupDown = new System.Windows.Forms.ComboBox();
            this.selectTeamMemberLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNametextBox = new System.Windows.Forms.TextBox();
            this.lastNamelabel = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cellPhonelabel = new System.Windows.Forms.Label();
            this.createMemberbutton = new System.Windows.Forms.Button();
            this.teamMembersListBox = new System.Windows.Forms.ListBox();
            this.deleteSelectedMemberbutton = new System.Windows.Forms.Button();
            this.createTeambutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamNameText
            // 
            this.teamNameText.Location = new System.Drawing.Point(11, 99);
            this.teamNameText.Name = "teamNameText";
            this.teamNameText.Size = new System.Drawing.Size(359, 35);
            this.teamNameText.TabIndex = 13;
            this.teamNameText.TextChanged += new System.EventHandler(this.teamNameText_TextChanged);
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.teamNameLabel.Location = new System.Drawing.Point(4, 59);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(163, 37);
            this.teamNameLabel.TabIndex = 12;
            this.teamNameLabel.Text = "Team Name:";
            // 
            // creteTeamLabel
            // 
            this.creteTeamLabel.AutoSize = true;
            this.creteTeamLabel.BackColor = System.Drawing.Color.White;
            this.creteTeamLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creteTeamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.creteTeamLabel.Location = new System.Drawing.Point(2, 9);
            this.creteTeamLabel.Name = "creteTeamLabel";
            this.creteTeamLabel.Size = new System.Drawing.Size(213, 50);
            this.creteTeamLabel.TabIndex = 11;
            this.creteTeamLabel.Text = "Create Team";
            // 
            // addTeamMemberbutton
            // 
            this.addTeamMemberbutton.BackColor = System.Drawing.Color.White;
            this.addTeamMemberbutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeamMemberbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addTeamMemberbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addTeamMemberbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamMemberbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeamMemberbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addTeamMemberbutton.Location = new System.Drawing.Point(113, 221);
            this.addTeamMemberbutton.Name = "addTeamMemberbutton";
            this.addTeamMemberbutton.Size = new System.Drawing.Size(154, 37);
            this.addTeamMemberbutton.TabIndex = 19;
            this.addTeamMemberbutton.Text = "Add Member";
            this.addTeamMemberbutton.UseVisualStyleBackColor = false;
            this.addTeamMemberbutton.Click += new System.EventHandler(this.addTeamMemberbutton_Click);
            // 
            // selectTeamMembersDroupDown
            // 
            this.selectTeamMembersDroupDown.FormattingEnabled = true;
            this.selectTeamMembersDroupDown.Location = new System.Drawing.Point(11, 177);
            this.selectTeamMembersDroupDown.Name = "selectTeamMembersDroupDown";
            this.selectTeamMembersDroupDown.Size = new System.Drawing.Size(359, 38);
            this.selectTeamMembersDroupDown.TabIndex = 18;
            // 
            // selectTeamMemberLabel
            // 
            this.selectTeamMemberLabel.AutoSize = true;
            this.selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamMemberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.selectTeamMemberLabel.Location = new System.Drawing.Point(4, 137);
            this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            this.selectTeamMemberLabel.Size = new System.Drawing.Size(263, 37);
            this.selectTeamMemberLabel.TabIndex = 17;
            this.selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.createMemberbutton);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.cellPhonelabel);
            this.groupBox1.Controls.Add(this.emailText);
            this.groupBox1.Controls.Add(this.emailLabel);
            this.groupBox1.Controls.Add(this.lastNametextBox);
            this.groupBox1.Controls.Add(this.lastNamelabel);
            this.groupBox1.Controls.Add(this.firstNameText);
            this.groupBox1.Controls.Add(this.firstNameLabel);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 269);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Member";
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(176, 50);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(190, 35);
            this.firstNameText.TabIndex = 13;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.firstNameLabel.Location = new System.Drawing.Point(6, 50);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(151, 37);
            this.firstNameLabel.TabIndex = 12;
            this.firstNameLabel.Text = "First Name ";
            this.firstNameLabel.Click += new System.EventHandler(this.teamTwoScoreLabel_Click);
            // 
            // lastNametextBox
            // 
            this.lastNametextBox.Location = new System.Drawing.Point(176, 91);
            this.lastNametextBox.Name = "lastNametextBox";
            this.lastNametextBox.Size = new System.Drawing.Size(190, 35);
            this.lastNametextBox.TabIndex = 15;
            this.lastNametextBox.TextChanged += new System.EventHandler(this.lastNametextBox_TextChanged);
            // 
            // lastNamelabel
            // 
            this.lastNamelabel.AutoSize = true;
            this.lastNamelabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNamelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lastNamelabel.Location = new System.Drawing.Point(9, 92);
            this.lastNamelabel.Name = "lastNamelabel";
            this.lastNamelabel.Size = new System.Drawing.Size(149, 37);
            this.lastNamelabel.TabIndex = 14;
            this.lastNamelabel.Text = "Last Name ";
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(176, 134);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(190, 35);
            this.emailText.TabIndex = 17;
            this.emailText.TextChanged += new System.EventHandler(this.emailText_TextChanged);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.emailLabel.Location = new System.Drawing.Point(6, 134);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(89, 37);
            this.emailLabel.TabIndex = 16;
            this.emailLabel.Text = "Email ";
            this.emailLabel.Click += new System.EventHandler(this.teamTwoScoreLabel_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(176, 176);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 35);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cellPhonelabel
            // 
            this.cellPhonelabel.AutoSize = true;
            this.cellPhonelabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellPhonelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.cellPhonelabel.Location = new System.Drawing.Point(7, 176);
            this.cellPhonelabel.Name = "cellPhonelabel";
            this.cellPhonelabel.Size = new System.Drawing.Size(145, 37);
            this.cellPhonelabel.TabIndex = 18;
            this.cellPhonelabel.Text = "Cellphone ";
            this.cellPhonelabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // createMemberbutton
            // 
            this.createMemberbutton.BackColor = System.Drawing.Color.White;
            this.createMemberbutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createMemberbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createMemberbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createMemberbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemberbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createMemberbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createMemberbutton.Location = new System.Drawing.Point(101, 226);
            this.createMemberbutton.Name = "createMemberbutton";
            this.createMemberbutton.Size = new System.Drawing.Size(173, 37);
            this.createMemberbutton.TabIndex = 20;
            this.createMemberbutton.Text = "Create Member";
            this.createMemberbutton.UseVisualStyleBackColor = false;
            // 
            // teamMembersListBox
            // 
            this.teamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamMembersListBox.FormattingEnabled = true;
            this.teamMembersListBox.ItemHeight = 30;
            this.teamMembersListBox.Location = new System.Drawing.Point(399, 81);
            this.teamMembersListBox.Name = "teamMembersListBox";
            this.teamMembersListBox.Size = new System.Drawing.Size(310, 452);
            this.teamMembersListBox.TabIndex = 21;
            this.teamMembersListBox.SelectedIndexChanged += new System.EventHandler(this.tournamentPlayersListBox_SelectedIndexChanged);
            // 
            // deleteSelectedMemberbutton
            // 
            this.deleteSelectedMemberbutton.BackColor = System.Drawing.Color.White;
            this.deleteSelectedMemberbutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedMemberbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedMemberbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedMemberbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedMemberbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedMemberbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.deleteSelectedMemberbutton.Location = new System.Drawing.Point(715, 264);
            this.deleteSelectedMemberbutton.Name = "deleteSelectedMemberbutton";
            this.deleteSelectedMemberbutton.Size = new System.Drawing.Size(124, 71);
            this.deleteSelectedMemberbutton.TabIndex = 22;
            this.deleteSelectedMemberbutton.Text = "Delete Selected";
            this.deleteSelectedMemberbutton.UseVisualStyleBackColor = false;
            // 
            // createTeambutton
            // 
            this.createTeambutton.BackColor = System.Drawing.Color.White;
            this.createTeambutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTeambutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTeambutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTeambutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeambutton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTeambutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createTeambutton.Location = new System.Drawing.Point(261, 539);
            this.createTeambutton.Name = "createTeambutton";
            this.createTeambutton.Size = new System.Drawing.Size(264, 55);
            this.createTeambutton.TabIndex = 23;
            this.createTeambutton.Text = "Create Team";
            this.createTeambutton.UseVisualStyleBackColor = false;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(844, 606);
            this.Controls.Add(this.createTeambutton);
            this.Controls.Add(this.deleteSelectedMemberbutton);
            this.Controls.Add(this.teamMembersListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addTeamMemberbutton);
            this.Controls.Add(this.selectTeamMembersDroupDown);
            this.Controls.Add(this.selectTeamMemberLabel);
            this.Controls.Add(this.teamNameText);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.creteTeamLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox teamNameText;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Label creteTeamLabel;
        private System.Windows.Forms.Button addTeamMemberbutton;
        private System.Windows.Forms.ComboBox selectTeamMembersDroupDown;
        private System.Windows.Forms.Label selectTeamMemberLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox lastNametextBox;
        private System.Windows.Forms.Label lastNamelabel;
        private System.Windows.Forms.Button createMemberbutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label cellPhonelabel;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.ListBox teamMembersListBox;
        private System.Windows.Forms.Button deleteSelectedMemberbutton;
        private System.Windows.Forms.Button createTeambutton;
    }
}