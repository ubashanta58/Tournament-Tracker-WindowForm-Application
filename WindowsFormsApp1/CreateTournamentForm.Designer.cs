namespace WindowsFormsApp1
{
    partial class CreateTournamentForm
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
            this.createTournamentlabel = new System.Windows.Forms.Label();
            this.tournamentNamelabel = new System.Windows.Forms.Label();
            this.tournamentNametextBox = new System.Windows.Forms.TextBox();
            this.entryFeelabel = new System.Windows.Forms.Label();
            this.entryFeetextBox = new System.Windows.Forms.TextBox();
            this.selectTeamlabel = new System.Windows.Forms.Label();
            this.selectTeamDropBox = new System.Windows.Forms.ComboBox();
            this.addTeambutton = new System.Windows.Forms.Button();
            this.createPrizebutton = new System.Windows.Forms.Button();
            this.createNewTeamlinkLabel = new System.Windows.Forms.LinkLabel();
            this.teamorPlayerslabel = new System.Windows.Forms.Label();
            this.tournamentTeamsListBox = new System.Windows.Forms.ListBox();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.prizeslabel = new System.Windows.Forms.Label();
            this.createTournamentbutton = new System.Windows.Forms.Button();
            this.removeSelectedTeambutton = new System.Windows.Forms.Button();
            this.removeSelectedPrizebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createTournamentlabel
            // 
            this.createTournamentlabel.AutoSize = true;
            this.createTournamentlabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createTournamentlabel.Location = new System.Drawing.Point(240, 9);
            this.createTournamentlabel.Name = "createTournamentlabel";
            this.createTournamentlabel.Size = new System.Drawing.Size(291, 45);
            this.createTournamentlabel.TabIndex = 1;
            this.createTournamentlabel.Text = "Create Tournament";
            // 
            // tournamentNamelabel
            // 
            this.tournamentNamelabel.AutoSize = true;
            this.tournamentNamelabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentNamelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.tournamentNamelabel.Location = new System.Drawing.Point(12, 54);
            this.tournamentNamelabel.Name = "tournamentNamelabel";
            this.tournamentNamelabel.Size = new System.Drawing.Size(242, 37);
            this.tournamentNamelabel.TabIndex = 2;
            this.tournamentNamelabel.Text = "Tournament Name:";
            this.tournamentNamelabel.Click += new System.EventHandler(this.tournamentNamelabel_Click);
            // 
            // tournamentNametextBox
            // 
            this.tournamentNametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentNametextBox.Location = new System.Drawing.Point(19, 94);
            this.tournamentNametextBox.Name = "tournamentNametextBox";
            this.tournamentNametextBox.Size = new System.Drawing.Size(308, 31);
            this.tournamentNametextBox.TabIndex = 6;
            this.tournamentNametextBox.TextChanged += new System.EventHandler(this.firstTeamScoretextBox_TextChanged);
            // 
            // entryFeelabel
            // 
            this.entryFeelabel.AutoSize = true;
            this.entryFeelabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryFeelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.entryFeelabel.Location = new System.Drawing.Point(12, 128);
            this.entryFeelabel.Name = "entryFeelabel";
            this.entryFeelabel.Size = new System.Drawing.Size(131, 37);
            this.entryFeelabel.TabIndex = 7;
            this.entryFeelabel.Text = "Entry Fee:";
            this.entryFeelabel.Click += new System.EventHandler(this.entryFeelabel_Click);
            // 
            // entryFeetextBox
            // 
            this.entryFeetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryFeetextBox.Location = new System.Drawing.Point(160, 131);
            this.entryFeetextBox.Name = "entryFeetextBox";
            this.entryFeetextBox.Size = new System.Drawing.Size(167, 31);
            this.entryFeetextBox.TabIndex = 8;
            this.entryFeetextBox.Text = "0";
            this.entryFeetextBox.TextChanged += new System.EventHandler(this.entryFeetextBox_TextChanged);
            // 
            // selectTeamlabel
            // 
            this.selectTeamlabel.AutoSize = true;
            this.selectTeamlabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.selectTeamlabel.Location = new System.Drawing.Point(12, 175);
            this.selectTeamlabel.Name = "selectTeamlabel";
            this.selectTeamlabel.Size = new System.Drawing.Size(156, 37);
            this.selectTeamlabel.TabIndex = 9;
            this.selectTeamlabel.Text = "Select Team";
            this.selectTeamlabel.Click += new System.EventHandler(this.selectTeamlabel_Click);
            // 
            // selectTeamDropBox
            // 
            this.selectTeamDropBox.BackColor = System.Drawing.Color.White;
            this.selectTeamDropBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamDropBox.ForeColor = System.Drawing.Color.Black;
            this.selectTeamDropBox.FormattingEnabled = true;
            this.selectTeamDropBox.Location = new System.Drawing.Point(19, 224);
            this.selectTeamDropBox.Name = "selectTeamDropBox";
            this.selectTeamDropBox.Size = new System.Drawing.Size(308, 38);
            this.selectTeamDropBox.TabIndex = 10;
            this.selectTeamDropBox.SelectedIndexChanged += new System.EventHandler(this.selectTeamDropBox_SelectedIndexChanged);
            // 
            // addTeambutton
            // 
            this.addTeambutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeambutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addTeambutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addTeambutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeambutton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeambutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addTeambutton.Location = new System.Drawing.Point(111, 284);
            this.addTeambutton.Name = "addTeambutton";
            this.addTeambutton.Size = new System.Drawing.Size(134, 57);
            this.addTeambutton.TabIndex = 14;
            this.addTeambutton.Text = "Add Team";
            this.addTeambutton.UseVisualStyleBackColor = true;
            this.addTeambutton.Click += new System.EventHandler(this.addTeambutton_Click);
            // 
            // createPrizebutton
            // 
            this.createPrizebutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createPrizebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createPrizebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizebutton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createPrizebutton.Location = new System.Drawing.Point(101, 360);
            this.createPrizebutton.Name = "createPrizebutton";
            this.createPrizebutton.Size = new System.Drawing.Size(153, 57);
            this.createPrizebutton.TabIndex = 15;
            this.createPrizebutton.Text = "Create Prize";
            this.createPrizebutton.UseVisualStyleBackColor = true;
            this.createPrizebutton.Click += new System.EventHandler(this.createPrizebutton_Click);
            // 
            // createNewTeamlinkLabel
            // 
            this.createNewTeamlinkLabel.AutoSize = true;
            this.createNewTeamlinkLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewTeamlinkLabel.Location = new System.Drawing.Point(213, 182);
            this.createNewTeamlinkLabel.Name = "createNewTeamlinkLabel";
            this.createNewTeamlinkLabel.Size = new System.Drawing.Size(114, 30);
            this.createNewTeamlinkLabel.TabIndex = 16;
            this.createNewTeamlinkLabel.TabStop = true;
            this.createNewTeamlinkLabel.Text = "create new";
            this.createNewTeamlinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createNewTeamlinkLabel_LinkClicked);
            // 
            // teamorPlayerslabel
            // 
            this.teamorPlayerslabel.AutoSize = true;
            this.teamorPlayerslabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamorPlayerslabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.teamorPlayerslabel.Location = new System.Drawing.Point(379, 54);
            this.teamorPlayerslabel.Name = "teamorPlayerslabel";
            this.teamorPlayerslabel.Size = new System.Drawing.Size(198, 37);
            this.teamorPlayerslabel.TabIndex = 17;
            this.teamorPlayerslabel.Text = "Teams / Players";
            // 
            // tournamentTeamsListBox
            // 
            this.tournamentTeamsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentTeamsListBox.FormattingEnabled = true;
            this.tournamentTeamsListBox.ItemHeight = 16;
            this.tournamentTeamsListBox.Location = new System.Drawing.Point(386, 94);
            this.tournamentTeamsListBox.Name = "tournamentTeamsListBox";
            this.tournamentTeamsListBox.Size = new System.Drawing.Size(311, 148);
            this.tournamentTeamsListBox.TabIndex = 18;
            this.tournamentTeamsListBox.SelectedIndexChanged += new System.EventHandler(this.tournamentTeamsListBox_SelectedIndexChanged);
            // 
            // prizesListBox
            // 
            this.prizesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 16;
            this.prizesListBox.Location = new System.Drawing.Point(386, 284);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(311, 148);
            this.prizesListBox.TabIndex = 19;
            this.prizesListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // prizeslabel
            // 
            this.prizeslabel.AutoSize = true;
            this.prizeslabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeslabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.prizeslabel.Location = new System.Drawing.Point(379, 244);
            this.prizeslabel.Name = "prizeslabel";
            this.prizeslabel.Size = new System.Drawing.Size(85, 37);
            this.prizeslabel.TabIndex = 20;
            this.prizeslabel.Text = "Prizes";
            this.prizeslabel.Click += new System.EventHandler(this.playersorTeamlabel_Click);
            // 
            // createTournamentbutton
            // 
            this.createTournamentbutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createTournamentbutton.Location = new System.Drawing.Point(248, 440);
            this.createTournamentbutton.Name = "createTournamentbutton";
            this.createTournamentbutton.Size = new System.Drawing.Size(290, 57);
            this.createTournamentbutton.TabIndex = 21;
            this.createTournamentbutton.Text = "Create Tournament";
            this.createTournamentbutton.UseVisualStyleBackColor = true;
            this.createTournamentbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // removeSelectedTeambutton
            // 
            this.removeSelectedTeambutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.removeSelectedTeambutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.removeSelectedTeambutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.removeSelectedTeambutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedTeambutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSelectedTeambutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.removeSelectedTeambutton.Location = new System.Drawing.Point(703, 126);
            this.removeSelectedTeambutton.Name = "removeSelectedTeambutton";
            this.removeSelectedTeambutton.Size = new System.Drawing.Size(153, 51);
            this.removeSelectedTeambutton.TabIndex = 22;
            this.removeSelectedTeambutton.Text = "Remove Selected";
            this.removeSelectedTeambutton.UseVisualStyleBackColor = true;
            this.removeSelectedTeambutton.Click += new System.EventHandler(this.removeSelectedTeambutton_Click);
            // 
            // removeSelectedPrizebutton
            // 
            this.removeSelectedPrizebutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.removeSelectedPrizebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.removeSelectedPrizebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.removeSelectedPrizebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedPrizebutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSelectedPrizebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.removeSelectedPrizebutton.Location = new System.Drawing.Point(703, 307);
            this.removeSelectedPrizebutton.Name = "removeSelectedPrizebutton";
            this.removeSelectedPrizebutton.Size = new System.Drawing.Size(153, 48);
            this.removeSelectedPrizebutton.TabIndex = 23;
            this.removeSelectedPrizebutton.Text = "Remove Selected";
            this.removeSelectedPrizebutton.UseVisualStyleBackColor = true;
            this.removeSelectedPrizebutton.Click += new System.EventHandler(this.removeSelectedPrizebutton_Click);
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(859, 498);
            this.Controls.Add(this.removeSelectedPrizebutton);
            this.Controls.Add(this.removeSelectedTeambutton);
            this.Controls.Add(this.createTournamentbutton);
            this.Controls.Add(this.prizeslabel);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.tournamentTeamsListBox);
            this.Controls.Add(this.teamorPlayerslabel);
            this.Controls.Add(this.createNewTeamlinkLabel);
            this.Controls.Add(this.createPrizebutton);
            this.Controls.Add(this.addTeambutton);
            this.Controls.Add(this.selectTeamDropBox);
            this.Controls.Add(this.selectTeamlabel);
            this.Controls.Add(this.entryFeetextBox);
            this.Controls.Add(this.entryFeelabel);
            this.Controls.Add(this.tournamentNametextBox);
            this.Controls.Add(this.tournamentNamelabel);
            this.Controls.Add(this.createTournamentlabel);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.Load += new System.EventHandler(this.CreateTournamentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createTournamentlabel;
        private System.Windows.Forms.Label tournamentNamelabel;
        private System.Windows.Forms.TextBox tournamentNametextBox;
        private System.Windows.Forms.Label entryFeelabel;
        private System.Windows.Forms.TextBox entryFeetextBox;
        private System.Windows.Forms.Label selectTeamlabel;
        private System.Windows.Forms.ComboBox selectTeamDropBox;
        private System.Windows.Forms.Button addTeambutton;
        private System.Windows.Forms.Button createPrizebutton;
        private System.Windows.Forms.LinkLabel createNewTeamlinkLabel;
        private System.Windows.Forms.Label teamorPlayerslabel;
        private System.Windows.Forms.ListBox tournamentTeamsListBox;
        private System.Windows.Forms.ListBox prizesListBox;
        private System.Windows.Forms.Label prizeslabel;
        private System.Windows.Forms.Button createTournamentbutton;
        private System.Windows.Forms.Button removeSelectedTeambutton;
        private System.Windows.Forms.Button removeSelectedPrizebutton;
    }
}