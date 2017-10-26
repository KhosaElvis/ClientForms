namespace ClientForms
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.clientDBRTTDataSet = new ClientForms.ClientDBRTTDataSet();
            this.tblAddressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblAddressTableAdapter = new ClientForms.ClientDBRTTDataSetTableAdapters.tblAddressTableAdapter();
            this.tblPersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPersonTableAdapter = new ClientForms.ClientDBRTTDataSetTableAdapters.tblPersonTableAdapter();
            this.fKPersonAddressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKPersonContactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblContactTableAdapter = new ClientForms.ClientDBRTTDataSetTableAdapters.tblContactTableAdapter();
            this.tblContactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientDBRTTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAddressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPersonAddressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPersonContactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblContactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // clientDBRTTDataSet
            // 
            this.clientDBRTTDataSet.DataSetName = "ClientDBRTTDataSet";
            this.clientDBRTTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblAddressBindingSource
            // 
            this.tblAddressBindingSource.DataMember = "tblAddress";
            this.tblAddressBindingSource.DataSource = this.clientDBRTTDataSet;
            // 
            // tblAddressTableAdapter
            // 
            this.tblAddressTableAdapter.ClearBeforeFill = true;
            // 
            // tblPersonBindingSource
            // 
            this.tblPersonBindingSource.DataMember = "tblPerson";
            this.tblPersonBindingSource.DataSource = this.clientDBRTTDataSet;
            // 
            // tblPersonTableAdapter
            // 
            this.tblPersonTableAdapter.ClearBeforeFill = true;
            // 
            // fKPersonAddressBindingSource
            // 
            this.fKPersonAddressBindingSource.DataMember = "FKPersonAddress";
            this.fKPersonAddressBindingSource.DataSource = this.tblPersonBindingSource;
            // 
            // fKPersonContactBindingSource
            // 
            this.fKPersonContactBindingSource.DataMember = "FKPersonContact";
            this.fKPersonContactBindingSource.DataSource = this.tblPersonBindingSource;
            // 
            // tblContactTableAdapter
            // 
            this.tblContactTableAdapter.ClearBeforeFill = true;
            // 
            // tblContactBindingSource
            // 
            this.tblContactBindingSource.DataMember = "tblContact";
            this.tblContactBindingSource.DataSource = this.clientDBRTTDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(754, 201);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 267);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(260, 122);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(423, 267);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(227, 122);
            this.dataGridView3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Address";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(278, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Edit Address";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(278, 337);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Delete Address";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(278, 366);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Show Address";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(668, 267);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Add Contact";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(668, 296);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "Add Contac";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(668, 337);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(89, 23);
            this.button7.TabIndex = 9;
            this.button7.Text = "Add Contact";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(668, 366);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(89, 23);
            this.button8.TabIndex = 10;
            this.button8.Text = "Add Contact";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(13, 220);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 11;
            this.button9.Text = "Add Client";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(108, 220);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 12;
            this.button10.Text = "Delete Client";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(197, 220);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 13;
            this.button11.Text = "Update Client";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(302, 220);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(91, 23);
            this.button12.TabIndex = 14;
            this.button12.Text = "Export To CSV";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 401);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientDBRTTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAddressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPersonAddressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPersonContactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblContactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ClientDBRTTDataSet clientDBRTTDataSet;
        private System.Windows.Forms.BindingSource tblAddressBindingSource;
        private ClientDBRTTDataSetTableAdapters.tblAddressTableAdapter tblAddressTableAdapter;
        private System.Windows.Forms.BindingSource tblPersonBindingSource;
        private ClientDBRTTDataSetTableAdapters.tblPersonTableAdapter tblPersonTableAdapter;
        private System.Windows.Forms.BindingSource fKPersonAddressBindingSource;
        private System.Windows.Forms.BindingSource fKPersonContactBindingSource;
        private ClientDBRTTDataSetTableAdapters.tblContactTableAdapter tblContactTableAdapter;
        private System.Windows.Forms.BindingSource tblContactBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
    }
}

