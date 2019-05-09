namespace WindowsFormsApp1
{
    partial class TournamentViewerForm
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
            this.Tournamentlabel = new System.Windows.Forms.Label();
            this.nonelabel = new System.Windows.Forms.Label();
            this.roundlabel = new System.Windows.Forms.Label();
            this.roundDropBox = new System.Windows.Forms.ComboBox();
            this.unPlayedcheckBox = new System.Windows.Forms.CheckBox();
            this.firstTeamScoretextBox = new System.Windows.Forms.TextBox();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.firstTeamlabel = new System.Windows.Forms.Label();
            this.firstTeamScorelabel = new System.Windows.Forms.Label();
            this.vslabel = new System.Windows.Forms.Label();
            this.secondTeamlabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.secondTeamScorelabel = new System.Windows.Forms.Label();
            this.scorebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tournamentlabel
            // 
            this.Tournamentlabel.AutoSize = true;
            this.Tournamentlabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tournamentlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Tournamentlabel.Location = new System.Drawing.Point(12, 9);
            this.Tournamentlabel.Name = "Tournamentlabel";
            this.Tournamentlabel.Size = new System.Drawing.Size(164, 37);
            this.Tournamentlabel.TabIndex = 0;
            this.Tournamentlabel.Text = "Tournament:";
            // 
            // nonelabel
            // 
            this.nonelabel.AutoSize = true;
            this.nonelabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nonelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.nonelabel.Location = new System.Drawing.Point(182, 9);
            this.nonelabel.Name = "nonelabel";
            this.nonelabel.Size = new System.Drawing.Size(113, 37);
            this.nonelabel.TabIndex = 1;
            this.nonelabel.Text = "<none>";
            // 
            // roundlabel
            // 
            this.roundlabel.AutoSize = true;
            this.roundlabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.roundlabel.Location = new System.Drawing.Point(12, 58);
            this.roundlabel.Name = "roundlabel";
            this.roundlabel.Size = new System.Drawing.Size(100, 37);
            this.roundlabel.TabIndex = 2;
            this.roundlabel.Text = "Round:";
            // 
            // roundDropBox
            // 
            this.roundDropBox.BackColor = System.Drawing.Color.White;
            this.roundDropBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundDropBox.ForeColor = System.Drawing.Color.Black;
            this.roundDropBox.FormattingEnabled = true;
            this.roundDropBox.Location = new System.Drawing.Point(118, 55);
            this.roundDropBox.Name = "roundDropBox";
            this.roundDropBox.Size = new System.Drawing.Size(212, 38);
            this.roundDropBox.TabIndex = 3;
            this.roundDropBox.SelectedIndexChanged += new System.EventHandler(this.roundDropBox_SelectedIndexChanged);
            // 
            // unPlayedcheckBox
            // 
            this.unPlayedcheckBox.AutoSize = true;
            this.unPlayedcheckBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unPlayedcheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.unPlayedcheckBox.Location = new System.Drawing.Point(118, 99);
            this.unPlayedcheckBox.Name = "unPlayedcheckBox";
            this.unPlayedcheckBox.Size = new System.Drawing.Size(212, 41);
            this.unPlayedcheckBox.TabIndex = 4;
            this.unPlayedcheckBox.Text = "Unplayed Only";
            this.unPlayedcheckBox.UseVisualStyleBackColor = true;
            this.unPlayedcheckBox.CheckedChanged += new System.EventHandler(this.unPlayedcheckBox_CheckedChanged);
            // 
            // firstTeamScoretextBox
            // 
            this.firstTeamScoretextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstTeamScoretextBox.Location = new System.Drawing.Point(467, 158);
            this.firstTeamScoretextBox.Name = "firstTeamScoretextBox";
            this.firstTeamScoretextBox.Size = new System.Drawing.Size(134, 31);
            this.firstTeamScoretextBox.TabIndex = 5;
            // 
            // matchupListBox
            // 
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.Location = new System.Drawing.Point(19, 152);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(311, 290);
            this.matchupListBox.TabIndex = 6;
            this.matchupListBox.SelectedIndexChanged += new System.EventHandler(this.matchupListBox_SelectedIndexChanged);
            // 
            // firstTeamlabel
            // 
            this.firstTeamlabel.AutoSize = true;
            this.firstTeamlabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstTeamlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.firstTeamlabel.Location = new System.Drawing.Point(360, 103);
            this.firstTeamlabel.Name = "firstTeamlabel";
            this.firstTeamlabel.Size = new System.Drawing.Size(165, 37);
            this.firstTeamlabel.TabIndex = 7;
            this.firstTeamlabel.Text = "<team one>";
            // 
            // firstTeamScorelabel
            // 
            this.firstTeamScorelabel.AutoSize = true;
            this.firstTeamScorelabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstTeamScorelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.firstTeamScorelabel.Location = new System.Drawing.Point(369, 152);
            this.firstTeamScorelabel.Name = "firstTeamScorelabel";
            this.firstTeamScorelabel.Size = new System.Drawing.Size(82, 37);
            this.firstTeamScorelabel.TabIndex = 8;
            this.firstTeamScorelabel.Text = "Score";
            // 
            // vslabel
            // 
            this.vslabel.AutoSize = true;
            this.vslabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vslabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.vslabel.Location = new System.Drawing.Point(415, 232);
            this.vslabel.Name = "vslabel";
            this.vslabel.Size = new System.Drawing.Size(63, 37);
            this.vslabel.TabIndex = 9;
            this.vslabel.Text = "-vs-";
            // 
            // secondTeamlabel
            // 
            this.secondTeamlabel.AutoSize = true;
            this.secondTeamlabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondTeamlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.secondTeamlabel.Location = new System.Drawing.Point(360, 307);
            this.secondTeamlabel.Name = "secondTeamlabel";
            this.secondTeamlabel.Size = new System.Drawing.Size(165, 37);
            this.secondTeamlabel.TabIndex = 10;
            this.secondTeamlabel.Text = "<team two>";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(467, 361);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 35);
            this.textBox2.TabIndex = 11;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // secondTeamScorelabel
            // 
            this.secondTeamScorelabel.AutoSize = true;
            this.secondTeamScorelabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondTeamScorelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.secondTeamScorelabel.Location = new System.Drawing.Point(379, 361);
            this.secondTeamScorelabel.Name = "secondTeamScorelabel";
            this.secondTeamScorelabel.Size = new System.Drawing.Size(82, 37);
            this.secondTeamScorelabel.TabIndex = 12;
            this.secondTeamScorelabel.Text = "Score";
            this.secondTeamScorelabel.Click += new System.EventHandler(this.secondTeamScorelabel_Click);
            // 
            // scorebutton
            // 
            this.scorebutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.scorebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.scorebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.scorebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scorebutton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.scorebutton.Location = new System.Drawing.Point(579, 225);
            this.scorebutton.Name = "scorebutton";
            this.scorebutton.Size = new System.Drawing.Size(103, 57);
            this.scorebutton.TabIndex = 13;
            this.scorebutton.Text = "Score";
            this.scorebutton.UseVisualStyleBackColor = true;
            this.scorebutton.Click += new System.EventHandler(this.scorebutton_Click);
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(694, 455);
            this.Controls.Add(this.scorebutton);
            this.Controls.Add(this.secondTeamScorelabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.secondTeamlabel);
            this.Controls.Add(this.vslabel);
            this.Controls.Add(this.firstTeamScorelabel);
            this.Controls.Add(this.firstTeamlabel);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.firstTeamScoretextBox);
            this.Controls.Add(this.unPlayedcheckBox);
            this.Controls.Add(this.roundDropBox);
            this.Controls.Add(this.roundlabel);
            this.Controls.Add(this.nonelabel);
            this.Controls.Add(this.Tournamentlabel);
            this.Name = "TournamentViewerForm";
            this.Text = "TournamentViewer";
            this.Load += new System.EventHandler(this.TournamentViewerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Tournamentlabel;
        private System.Windows.Forms.Label nonelabel;
        private System.Windows.Forms.Label roundlabel;
        private System.Windows.Forms.ComboBox roundDropBox;
        private System.Windows.Forms.CheckBox unPlayedcheckBox;
        private System.Windows.Forms.TextBox firstTeamScoretextBox;
        private System.Windows.Forms.ListBox matchupListBox;
        private System.Windows.Forms.Label firstTeamlabel;
        private System.Windows.Forms.Label firstTeamScorelabel;
        private System.Windows.Forms.Label vslabel;
        private System.Windows.Forms.Label secondTeamlabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label secondTeamScorelabel;
        private System.Windows.Forms.Button scorebutton;
    }
}

