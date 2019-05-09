namespace WindowsFormsApp1
{
    partial class CreatePrizeForm
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
            this.createPrizelabel = new System.Windows.Forms.Label();
            this.placeNumberlabel = new System.Windows.Forms.Label();
            this.placeNamelabel = new System.Windows.Forms.Label();
            this.prizeAmountlabel = new System.Windows.Forms.Label();
            this.orlabel = new System.Windows.Forms.Label();
            this.prizePercentagelabel = new System.Windows.Forms.Label();
            this.createPrizebutton = new System.Windows.Forms.Button();
            this.placeNumbertextBox = new System.Windows.Forms.TextBox();
            this.placeNametextBox = new System.Windows.Forms.TextBox();
            this.prizeAmounttextBox = new System.Windows.Forms.TextBox();
            this.prizePercentagetextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // createPrizelabel
            // 
            this.createPrizelabel.AutoSize = true;
            this.createPrizelabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createPrizelabel.Location = new System.Drawing.Point(148, 9);
            this.createPrizelabel.Name = "createPrizelabel";
            this.createPrizelabel.Size = new System.Drawing.Size(158, 37);
            this.createPrizelabel.TabIndex = 4;
            this.createPrizelabel.Text = "Create Prize";
            // 
            // placeNumberlabel
            // 
            this.placeNumberlabel.AutoSize = true;
            this.placeNumberlabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeNumberlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.placeNumberlabel.Location = new System.Drawing.Point(12, 83);
            this.placeNumberlabel.Name = "placeNumberlabel";
            this.placeNumberlabel.Size = new System.Drawing.Size(183, 37);
            this.placeNumberlabel.TabIndex = 5;
            this.placeNumberlabel.Text = "Place Number";
            this.placeNumberlabel.Click += new System.EventHandler(this.placeNumberlabel_Click);
            // 
            // placeNamelabel
            // 
            this.placeNamelabel.AutoSize = true;
            this.placeNamelabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeNamelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.placeNamelabel.Location = new System.Drawing.Point(10, 138);
            this.placeNamelabel.Name = "placeNamelabel";
            this.placeNamelabel.Size = new System.Drawing.Size(157, 37);
            this.placeNamelabel.TabIndex = 6;
            this.placeNamelabel.Text = "Place Name";
            this.placeNamelabel.Click += new System.EventHandler(this.placeNamelabel_Click);
            // 
            // prizeAmountlabel
            // 
            this.prizeAmountlabel.AutoSize = true;
            this.prizeAmountlabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeAmountlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.prizeAmountlabel.Location = new System.Drawing.Point(10, 196);
            this.prizeAmountlabel.Name = "prizeAmountlabel";
            this.prizeAmountlabel.Size = new System.Drawing.Size(176, 37);
            this.prizeAmountlabel.TabIndex = 7;
            this.prizeAmountlabel.Text = "Prize Amount";
            this.prizeAmountlabel.Click += new System.EventHandler(this.prizeAmountlabel_Click);
            // 
            // orlabel
            // 
            this.orlabel.AutoSize = true;
            this.orlabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.orlabel.Location = new System.Drawing.Point(176, 248);
            this.orlabel.Name = "orlabel";
            this.orlabel.Size = new System.Drawing.Size(64, 37);
            this.orlabel.TabIndex = 8;
            this.orlabel.Text = "-or-";
            // 
            // prizePercentagelabel
            // 
            this.prizePercentagelabel.AutoSize = true;
            this.prizePercentagelabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizePercentagelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.prizePercentagelabel.Location = new System.Drawing.Point(3, 304);
            this.prizePercentagelabel.Name = "prizePercentagelabel";
            this.prizePercentagelabel.Size = new System.Drawing.Size(212, 37);
            this.prizePercentagelabel.TabIndex = 9;
            this.prizePercentagelabel.Text = "Prize Percentage";
            this.prizePercentagelabel.Click += new System.EventHandler(this.prizePercentagelabel_Click);
            // 
            // createPrizebutton
            // 
            this.createPrizebutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createPrizebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createPrizebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizebutton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createPrizebutton.Location = new System.Drawing.Point(93, 381);
            this.createPrizebutton.Name = "createPrizebutton";
            this.createPrizebutton.Size = new System.Drawing.Size(290, 57);
            this.createPrizebutton.TabIndex = 22;
            this.createPrizebutton.Text = "Create Prize";
            this.createPrizebutton.UseVisualStyleBackColor = true;
            this.createPrizebutton.Click += new System.EventHandler(this.createPrizebutton_Click);
            // 
            // placeNumbertextBox
            // 
            this.placeNumbertextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeNumbertextBox.Location = new System.Drawing.Point(221, 83);
            this.placeNumbertextBox.Name = "placeNumbertextBox";
            this.placeNumbertextBox.Size = new System.Drawing.Size(249, 31);
            this.placeNumbertextBox.TabIndex = 23;
            this.placeNumbertextBox.TextChanged += new System.EventHandler(this.placeNumbertextBox_TextChanged);
            // 
            // placeNametextBox
            // 
            this.placeNametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeNametextBox.Location = new System.Drawing.Point(221, 138);
            this.placeNametextBox.Name = "placeNametextBox";
            this.placeNametextBox.Size = new System.Drawing.Size(249, 31);
            this.placeNametextBox.TabIndex = 24;
            this.placeNametextBox.TextChanged += new System.EventHandler(this.placeNametextBox_TextChanged);
            // 
            // prizeAmounttextBox
            // 
            this.prizeAmounttextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeAmounttextBox.Location = new System.Drawing.Point(221, 196);
            this.prizeAmounttextBox.Name = "prizeAmounttextBox";
            this.prizeAmounttextBox.Size = new System.Drawing.Size(249, 31);
            this.prizeAmounttextBox.TabIndex = 25;
            this.prizeAmounttextBox.Text = "0";
            // 
            // prizePercentagetextBox
            // 
            this.prizePercentagetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizePercentagetextBox.Location = new System.Drawing.Point(221, 304);
            this.prizePercentagetextBox.Name = "prizePercentagetextBox";
            this.prizePercentagetextBox.Size = new System.Drawing.Size(249, 31);
            this.prizePercentagetextBox.TabIndex = 26;
            this.prizePercentagetextBox.Text = "0";
            this.prizePercentagetextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(475, 450);
            this.Controls.Add(this.prizePercentagetextBox);
            this.Controls.Add(this.prizeAmounttextBox);
            this.Controls.Add(this.placeNametextBox);
            this.Controls.Add(this.placeNumbertextBox);
            this.Controls.Add(this.createPrizebutton);
            this.Controls.Add(this.prizePercentagelabel);
            this.Controls.Add(this.orlabel);
            this.Controls.Add(this.prizeAmountlabel);
            this.Controls.Add(this.placeNamelabel);
            this.Controls.Add(this.placeNumberlabel);
            this.Controls.Add(this.createPrizelabel);
            this.Name = "CreatePrizeForm";
            this.Text = "Create Prize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createPrizelabel;
        private System.Windows.Forms.Label placeNumberlabel;
        private System.Windows.Forms.Label placeNamelabel;
        private System.Windows.Forms.Label prizeAmountlabel;
        private System.Windows.Forms.Label orlabel;
        private System.Windows.Forms.Label prizePercentagelabel;
        private System.Windows.Forms.Button createPrizebutton;
        private System.Windows.Forms.TextBox placeNumbertextBox;
        private System.Windows.Forms.TextBox placeNametextBox;
        private System.Windows.Forms.TextBox prizeAmounttextBox;
        private System.Windows.Forms.TextBox prizePercentagetextBox;
    }
}