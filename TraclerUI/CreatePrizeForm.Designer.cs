namespace TraclerUI
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
            this.cretePrizeLabel = new System.Windows.Forms.Label();
            this.placeNameText = new System.Windows.Forms.TextBox();
            this.placeNameLabel = new System.Windows.Forms.Label();
            this.placeNumbertextBox = new System.Windows.Forms.TextBox();
            this.placeNumberlabel = new System.Windows.Forms.Label();
            this.prizeAmounttextBox = new System.Windows.Forms.TextBox();
            this.prizeAmountlabel = new System.Windows.Forms.Label();
            this.prizePercentagetextBox = new System.Windows.Forms.TextBox();
            this.prizePercentagelabel = new System.Windows.Forms.Label();
            this.orLabel = new System.Windows.Forms.Label();
            this.createPrizebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cretePrizeLabel
            // 
            this.cretePrizeLabel.AutoSize = true;
            this.cretePrizeLabel.BackColor = System.Drawing.Color.White;
            this.cretePrizeLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cretePrizeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.cretePrizeLabel.Location = new System.Drawing.Point(12, 9);
            this.cretePrizeLabel.Name = "cretePrizeLabel";
            this.cretePrizeLabel.Size = new System.Drawing.Size(209, 50);
            this.cretePrizeLabel.TabIndex = 12;
            this.cretePrizeLabel.Text = "Create Prize";
            // 
            // placeNameText
            // 
            this.placeNameText.Location = new System.Drawing.Point(255, 160);
            this.placeNameText.Name = "placeNameText";
            this.placeNameText.Size = new System.Drawing.Size(190, 35);
            this.placeNameText.TabIndex = 15;
            this.placeNameText.TextChanged += new System.EventHandler(this.firstNameText_TextChanged);
            // 
            // placeNameLabel
            // 
            this.placeNameLabel.AutoSize = true;
            this.placeNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.placeNameLabel.Location = new System.Drawing.Point(23, 160);
            this.placeNameLabel.Name = "placeNameLabel";
            this.placeNameLabel.Size = new System.Drawing.Size(157, 37);
            this.placeNameLabel.TabIndex = 14;
            this.placeNameLabel.Text = "Place Name";
            // 
            // placeNumbertextBox
            // 
            this.placeNumbertextBox.Location = new System.Drawing.Point(255, 88);
            this.placeNumbertextBox.Name = "placeNumbertextBox";
            this.placeNumbertextBox.Size = new System.Drawing.Size(190, 35);
            this.placeNumbertextBox.TabIndex = 17;
            this.placeNumbertextBox.TextChanged += new System.EventHandler(this.placeNumbertextBox_TextChanged);
            // 
            // placeNumberlabel
            // 
            this.placeNumberlabel.AutoSize = true;
            this.placeNumberlabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeNumberlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.placeNumberlabel.Location = new System.Drawing.Point(23, 86);
            this.placeNumberlabel.Name = "placeNumberlabel";
            this.placeNumberlabel.Size = new System.Drawing.Size(183, 37);
            this.placeNumberlabel.TabIndex = 16;
            this.placeNumberlabel.Text = "Place Number";
            // 
            // prizeAmounttextBox
            // 
            this.prizeAmounttextBox.Location = new System.Drawing.Point(255, 234);
            this.prizeAmounttextBox.Name = "prizeAmounttextBox";
            this.prizeAmounttextBox.Size = new System.Drawing.Size(190, 35);
            this.prizeAmounttextBox.TabIndex = 19;
            this.prizeAmounttextBox.Text = "0";
            this.prizeAmounttextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // prizeAmountlabel
            // 
            this.prizeAmountlabel.AutoSize = true;
            this.prizeAmountlabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeAmountlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.prizeAmountlabel.Location = new System.Drawing.Point(23, 234);
            this.prizeAmountlabel.Name = "prizeAmountlabel";
            this.prizeAmountlabel.Size = new System.Drawing.Size(183, 37);
            this.prizeAmountlabel.TabIndex = 18;
            this.prizeAmountlabel.Text = "Prize Amount ";
            // 
            // prizePercentagetextBox
            // 
            this.prizePercentagetextBox.Location = new System.Drawing.Point(255, 360);
            this.prizePercentagetextBox.Name = "prizePercentagetextBox";
            this.prizePercentagetextBox.Size = new System.Drawing.Size(190, 35);
            this.prizePercentagetextBox.TabIndex = 21;
            this.prizePercentagetextBox.Text = "0";
            this.prizePercentagetextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // prizePercentagelabel
            // 
            this.prizePercentagelabel.AutoSize = true;
            this.prizePercentagelabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizePercentagelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.prizePercentagelabel.Location = new System.Drawing.Point(23, 360);
            this.prizePercentagelabel.Name = "prizePercentagelabel";
            this.prizePercentagelabel.Size = new System.Drawing.Size(212, 37);
            this.prizePercentagelabel.TabIndex = 20;
            this.prizePercentagelabel.Text = "Prize Percentage";
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.orLabel.Location = new System.Drawing.Point(200, 295);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(64, 37);
            this.orLabel.TabIndex = 22;
            this.orLabel.Text = "-or-";
            // 
            // createPrizebutton
            // 
            this.createPrizebutton.BackColor = System.Drawing.Color.White;
            this.createPrizebutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createPrizebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createPrizebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizebutton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createPrizebutton.Location = new System.Drawing.Point(128, 420);
            this.createPrizebutton.Name = "createPrizebutton";
            this.createPrizebutton.Size = new System.Drawing.Size(202, 61);
            this.createPrizebutton.TabIndex = 23;
            this.createPrizebutton.Text = "Create Prize";
            this.createPrizebutton.UseVisualStyleBackColor = false;
            this.createPrizebutton.Click += new System.EventHandler(this.createPrizebutton_Click);
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(466, 493);
            this.Controls.Add(this.createPrizebutton);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.prizePercentagetextBox);
            this.Controls.Add(this.prizePercentagelabel);
            this.Controls.Add(this.prizeAmounttextBox);
            this.Controls.Add(this.prizeAmountlabel);
            this.Controls.Add(this.placeNumbertextBox);
            this.Controls.Add(this.placeNumberlabel);
            this.Controls.Add(this.placeNameText);
            this.Controls.Add(this.placeNameLabel);
            this.Controls.Add(this.cretePrizeLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreatePrizeForm";
            this.Text = "Create Prize";
            this.Load += new System.EventHandler(this.CreatePrizeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cretePrizeLabel;
        private System.Windows.Forms.TextBox placeNameText;
        private System.Windows.Forms.Label placeNameLabel;
        private System.Windows.Forms.TextBox placeNumbertextBox;
        private System.Windows.Forms.Label placeNumberlabel;
        private System.Windows.Forms.TextBox prizeAmounttextBox;
        private System.Windows.Forms.Label prizeAmountlabel;
        private System.Windows.Forms.TextBox prizePercentagetextBox;
        private System.Windows.Forms.Label prizePercentagelabel;
        private System.Windows.Forms.Label orLabel;
        private System.Windows.Forms.Button createPrizebutton;
    }
}