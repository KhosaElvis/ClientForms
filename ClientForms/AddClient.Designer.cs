namespace ClientForms
{
    partial class AddClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.NametxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SurnametxtBox = new System.Windows.Forms.TextBox();
            this.GendertxtBox = new System.Windows.Forms.TextBox();
            this.LanguagetxtBox = new System.Windows.Forms.TextBox();
            this.NationalitytextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.EnthnicityTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Client Form";
            // 
            // NametxtBox
            // 
            this.NametxtBox.Location = new System.Drawing.Point(133, 47);
            this.NametxtBox.Name = "NametxtBox";
            this.NametxtBox.Size = new System.Drawing.Size(124, 20);
            this.NametxtBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "First Language";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nationality";
            // 
            // SurnametxtBox
            // 
            this.SurnametxtBox.Location = new System.Drawing.Point(133, 83);
            this.SurnametxtBox.Name = "SurnametxtBox";
            this.SurnametxtBox.Size = new System.Drawing.Size(124, 20);
            this.SurnametxtBox.TabIndex = 7;
            // 
            // GendertxtBox
            // 
            this.GendertxtBox.Location = new System.Drawing.Point(133, 111);
            this.GendertxtBox.Name = "GendertxtBox";
            this.GendertxtBox.Size = new System.Drawing.Size(124, 20);
            this.GendertxtBox.TabIndex = 8;
            // 
            // LanguagetxtBox
            // 
            this.LanguagetxtBox.Location = new System.Drawing.Point(133, 145);
            this.LanguagetxtBox.Name = "LanguagetxtBox";
            this.LanguagetxtBox.Size = new System.Drawing.Size(124, 20);
            this.LanguagetxtBox.TabIndex = 9;
            // 
            // NationalitytextBox
            // 
            this.NationalitytextBox.Location = new System.Drawing.Point(133, 180);
            this.NationalitytextBox.Name = "NationalitytextBox";
            this.NationalitytextBox.Size = new System.Drawing.Size(124, 20);
            this.NationalitytextBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ethnicty";
            // 
            // EnthnicityTextBox
            // 
            this.EnthnicityTextBox.Location = new System.Drawing.Point(133, 220);
            this.EnthnicityTextBox.Name = "EnthnicityTextBox";
            this.EnthnicityTextBox.Size = new System.Drawing.Size(124, 20);
            this.EnthnicityTextBox.TabIndex = 13;
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 277);
            this.Controls.Add(this.EnthnicityTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NationalitytextBox);
            this.Controls.Add(this.LanguagetxtBox);
            this.Controls.Add(this.GendertxtBox);
            this.Controls.Add(this.SurnametxtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NametxtBox);
            this.Controls.Add(this.label1);
            this.Name = "AddClient";
            this.Text = "AddClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NametxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SurnametxtBox;
        private System.Windows.Forms.TextBox GendertxtBox;
        private System.Windows.Forms.TextBox LanguagetxtBox;
        private System.Windows.Forms.TextBox NationalitytextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox EnthnicityTextBox;
    }
}