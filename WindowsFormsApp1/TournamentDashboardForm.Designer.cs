namespace WindowsFormsApp1
{
    partial class TournamentDashboardForm
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
            this.tournamentDashBoardlabel = new System.Windows.Forms.Label();
            this.loadExistingDashBoardlabel = new System.Windows.Forms.Label();
            this.loadExistingDashBoardDropBox = new System.Windows.Forms.ComboBox();
            this.loadTournamentbutton = new System.Windows.Forms.Button();
            this.createTournamentbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tournamentDashBoardlabel
            // 
            this.tournamentDashBoardlabel.AutoSize = true;
            this.tournamentDashBoardlabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentDashBoardlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.tournamentDashBoardlabel.Location = new System.Drawing.Point(117, 9);
            this.tournamentDashBoardlabel.Name = "tournamentDashBoardlabel";
            this.tournamentDashBoardlabel.Size = new System.Drawing.Size(295, 37);
            this.tournamentDashBoardlabel.TabIndex = 5;
            this.tournamentDashBoardlabel.Text = "Tournament Dashboard";
            // 
            // loadExistingDashBoardlabel
            // 
            this.loadExistingDashBoardlabel.AutoSize = true;
            this.loadExistingDashBoardlabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadExistingDashBoardlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.loadExistingDashBoardlabel.Location = new System.Drawing.Point(109, 62);
            this.loadExistingDashBoardlabel.Name = "loadExistingDashBoardlabel";
            this.loadExistingDashBoardlabel.Size = new System.Drawing.Size(311, 37);
            this.loadExistingDashBoardlabel.TabIndex = 6;
            this.loadExistingDashBoardlabel.Text = "Load Existing Dashboard";
            // 
            // loadExistingDashBoardDropBox
            // 
            this.loadExistingDashBoardDropBox.BackColor = System.Drawing.Color.White;
            this.loadExistingDashBoardDropBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadExistingDashBoardDropBox.ForeColor = System.Drawing.Color.Black;
            this.loadExistingDashBoardDropBox.FormattingEnabled = true;
            this.loadExistingDashBoardDropBox.Location = new System.Drawing.Point(118, 115);
            this.loadExistingDashBoardDropBox.Name = "loadExistingDashBoardDropBox";
            this.loadExistingDashBoardDropBox.Size = new System.Drawing.Size(292, 38);
            this.loadExistingDashBoardDropBox.TabIndex = 12;
            this.loadExistingDashBoardDropBox.SelectedIndexChanged += new System.EventHandler(this.loadExistingDashBoardDropBox_SelectedIndexChanged);
            // 
            // loadTournamentbutton
            // 
            this.loadTournamentbutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.loadTournamentbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.loadTournamentbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.loadTournamentbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTournamentbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadTournamentbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.loadTournamentbutton.Location = new System.Drawing.Point(174, 169);
            this.loadTournamentbutton.Name = "loadTournamentbutton";
            this.loadTournamentbutton.Size = new System.Drawing.Size(195, 57);
            this.loadTournamentbutton.TabIndex = 23;
            this.loadTournamentbutton.Text = "Load Tournament";
            this.loadTournamentbutton.UseVisualStyleBackColor = true;
            this.loadTournamentbutton.Click += new System.EventHandler(this.loadTournamentbutton_Click);
            // 
            // createTournamentbutton
            // 
            this.createTournamentbutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createTournamentbutton.Location = new System.Drawing.Point(56, 242);
            this.createTournamentbutton.Name = "createTournamentbutton";
            this.createTournamentbutton.Size = new System.Drawing.Size(414, 57);
            this.createTournamentbutton.TabIndex = 24;
            this.createTournamentbutton.Text = "Create Tournament";
            this.createTournamentbutton.UseVisualStyleBackColor = true;
            this.createTournamentbutton.Click += new System.EventHandler(this.createTournamentbutton_Click);
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(551, 340);
            this.Controls.Add(this.createTournamentbutton);
            this.Controls.Add(this.loadTournamentbutton);
            this.Controls.Add(this.loadExistingDashBoardDropBox);
            this.Controls.Add(this.loadExistingDashBoardlabel);
            this.Controls.Add(this.tournamentDashBoardlabel);
            this.Name = "TournamentDashboardForm";
            this.Text = "Tournament Dashboard";
            this.Load += new System.EventHandler(this.TournamentDashboardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tournamentDashBoardlabel;
        private System.Windows.Forms.Label loadExistingDashBoardlabel;
        private System.Windows.Forms.ComboBox loadExistingDashBoardDropBox;
        private System.Windows.Forms.Button loadTournamentbutton;
        private System.Windows.Forms.Button createTournamentbutton;
    }
}