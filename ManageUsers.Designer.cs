namespace InventoryManagement
{
    partial class ManageUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.uNameTb = new System.Windows.Forms.TextBox();
            this.fNameTb = new System.Windows.Forms.TextBox();
            this.pNumberTb = new System.Windows.Forms.TextBox();
            this.PasswordTb = new System.Windows.Forms.TextBox();
            this.inventorydbDataSet = new InventoryManagement.InventorydbDataSet();
            this.inventorydbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usertb1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventorydbDataSet1 = new InventoryManagement.InventorydbDataSet1();
            this.usertb1TableAdapter = new InventoryManagement.InventorydbDataSet1TableAdapters.Usertb1TableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.UsersGv = new System.Windows.Forms.DataGridView();
            this.inventorydbDataSet2 = new InventoryManagement.InventorydbDataSet2();
            this.usertb1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usertb1TableAdapter1 = new InventoryManagement.InventorydbDataSet2TableAdapters.Usertb1TableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventorydbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorydbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usertb1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorydbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorydbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usertb1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-9, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 130);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(885, -4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(356, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Manage Users";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(535, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(336, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "SHOPRITE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(38, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "User Name ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(38, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Full Name ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(38, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(38, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "Phone Number";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(7, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(123, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 36);
            this.button2.TabIndex = 11;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(234, 441);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 36);
            this.button3.TabIndex = 12;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkRed;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(123, 496);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 35);
            this.button4.TabIndex = 13;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // uNameTb
            // 
            this.uNameTb.Location = new System.Drawing.Point(7, 192);
            this.uNameTb.Name = "uNameTb";
            this.uNameTb.Size = new System.Drawing.Size(307, 22);
            this.uNameTb.TabIndex = 24;
            this.uNameTb.TextChanged += new System.EventHandler(this.uNameTb_TextChanged);
            // 
            // fNameTb
            // 
            this.fNameTb.Location = new System.Drawing.Point(7, 262);
            this.fNameTb.Name = "fNameTb";
            this.fNameTb.Size = new System.Drawing.Size(307, 22);
            this.fNameTb.TabIndex = 26;
            // 
            // pNumberTb
            // 
            this.pNumberTb.Location = new System.Drawing.Point(7, 328);
            this.pNumberTb.Name = "pNumberTb";
            this.pNumberTb.Size = new System.Drawing.Size(307, 22);
            this.pNumberTb.TabIndex = 27;
            // 
            // PasswordTb
            // 
            this.PasswordTb.Location = new System.Drawing.Point(7, 393);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.Size = new System.Drawing.Size(307, 22);
            this.PasswordTb.TabIndex = 28;
            // 
            // inventorydbDataSet
            // 
            this.inventorydbDataSet.DataSetName = "InventorydbDataSet";
            this.inventorydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventorydbDataSetBindingSource
            // 
            this.inventorydbDataSetBindingSource.DataSource = this.inventorydbDataSet;
            this.inventorydbDataSetBindingSource.Position = 0;
            // 
            // usertb1BindingSource
            // 
            this.usertb1BindingSource.DataMember = "Usertb1";
            this.usertb1BindingSource.DataSource = this.inventorydbDataSet1;
            // 
            // inventorydbDataSet1
            // 
            this.inventorydbDataSet1.DataSetName = "InventorydbDataSet1";
            this.inventorydbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usertb1TableAdapter
            // 
            this.usertb1TableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(539, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 38);
            this.label9.TabIndex = 30;
            this.label9.Text = "USERS LIST ";
            // 
            // UsersGv
            // 
            this.UsersGv.BackgroundColor = System.Drawing.Color.White;
            this.UsersGv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsersGv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UsersGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UsersGv.DefaultCellStyle = dataGridViewCellStyle1;
            this.UsersGv.GridColor = System.Drawing.SystemColors.Control;
            this.UsersGv.Location = new System.Drawing.Point(334, 192);
            this.UsersGv.Name = "UsersGv";
            this.UsersGv.RowHeadersWidth = 51;
            this.UsersGv.RowTemplate.Height = 24;
            this.UsersGv.Size = new System.Drawing.Size(556, 339);
            this.UsersGv.TabIndex = 52;
            this.UsersGv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersGv_CellContentClick_1);
            // 
            // inventorydbDataSet2
            // 
            this.inventorydbDataSet2.DataSetName = "InventorydbDataSet2";
            this.inventorydbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usertb1BindingSource1
            // 
            this.usertb1BindingSource1.DataMember = "Usertb1";
            this.usertb1BindingSource1.DataSource = this.inventorydbDataSet2;
            // 
            // usertb1TableAdapter1
            // 
            this.usertb1TableAdapter1.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Location = new System.Drawing.Point(-110, 666);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1122, 11);
            this.panel2.TabIndex = 61;
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 672);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.UsersGv);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PasswordTb);
            this.Controls.Add(this.pNumberTb);
            this.Controls.Add(this.fNameTb);
            this.Controls.Add(this.uNameTb);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageUsers";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventorydbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorydbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usertb1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorydbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorydbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usertb1BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox uNameTb;
        private System.Windows.Forms.TextBox fNameTb;
        private System.Windows.Forms.TextBox pNumberTb;
        private System.Windows.Forms.TextBox PasswordTb;
        private InventorydbDataSet inventorydbDataSet;
        private System.Windows.Forms.BindingSource inventorydbDataSetBindingSource;
        private InventorydbDataSet1 inventorydbDataSet1;
        private System.Windows.Forms.BindingSource usertb1BindingSource;
        private InventorydbDataSet1TableAdapters.Usertb1TableAdapter usertb1TableAdapter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView UsersGv;
        private InventorydbDataSet2 inventorydbDataSet2;
        private System.Windows.Forms.BindingSource usertb1BindingSource1;
        private InventorydbDataSet2TableAdapters.Usertb1TableAdapter usertb1TableAdapter1;
        private System.Windows.Forms.Panel panel2;
    }
}