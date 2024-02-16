namespace IMS
{
    partial class SupplierForm
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
            this.txtSuppEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteSupp = new System.Windows.Forms.Button();
            this.btnUpdateSupp = new System.Windows.Forms.Button();
            this.btnAddSupp = new System.Windows.Forms.Button();
            this.dataGridViewSupplier = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSuppPhoneNo = new System.Windows.Forms.TextBox();
            this.txtSuppAddress = new System.Windows.Forms.TextBox();
            this.txtSupFullName = new System.Windows.Forms.TextBox();
            this.txtSuppID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSuppProduct = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSuppEmail
            // 
            this.txtSuppEmail.Location = new System.Drawing.Point(244, 205);
            this.txtSuppEmail.Multiline = true;
            this.txtSuppEmail.Name = "txtSuppEmail";
            this.txtSuppEmail.Size = new System.Drawing.Size(219, 38);
            this.txtSuppEmail.TabIndex = 36;
            this.txtSuppEmail.TextChanged += new System.EventHandler(this.txtSuppEmail_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(32, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 38);
            this.label7.TabIndex = 35;
            this.label7.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 38);
            this.label2.TabIndex = 34;
            this.label2.Text = "ID";
            // 
            // btnDeleteSupp
            // 
            this.btnDeleteSupp.BackColor = System.Drawing.Color.Red;
            this.btnDeleteSupp.Location = new System.Drawing.Point(312, 550);
            this.btnDeleteSupp.Name = "btnDeleteSupp";
            this.btnDeleteSupp.Size = new System.Drawing.Size(114, 47);
            this.btnDeleteSupp.TabIndex = 30;
            this.btnDeleteSupp.Text = "Delete";
            this.btnDeleteSupp.UseVisualStyleBackColor = false;
            this.btnDeleteSupp.Click += new System.EventHandler(this.btnDeleteSupp_Click);
            // 
            // btnUpdateSupp
            // 
            this.btnUpdateSupp.BackColor = System.Drawing.Color.Blue;
            this.btnUpdateSupp.Location = new System.Drawing.Point(160, 550);
            this.btnUpdateSupp.Name = "btnUpdateSupp";
            this.btnUpdateSupp.Size = new System.Drawing.Size(114, 47);
            this.btnUpdateSupp.TabIndex = 32;
            this.btnUpdateSupp.Text = "Edit";
            this.btnUpdateSupp.UseVisualStyleBackColor = false;
            this.btnUpdateSupp.Click += new System.EventHandler(this.btnUpdateSupp_Click);
            // 
            // btnAddSupp
            // 
            this.btnAddSupp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddSupp.Location = new System.Drawing.Point(13, 550);
            this.btnAddSupp.Name = "btnAddSupp";
            this.btnAddSupp.Size = new System.Drawing.Size(114, 47);
            this.btnAddSupp.TabIndex = 33;
            this.btnAddSupp.Text = "Add";
            this.btnAddSupp.UseVisualStyleBackColor = false;
            this.btnAddSupp.Click += new System.EventHandler(this.btnAddSupp_Click);
            // 
            // dataGridViewSupplier
            // 
            this.dataGridViewSupplier.AllowUserToOrderColumns = true;
            this.dataGridViewSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Email,
            this.Name,
            this.Product,
            this.Address,
            this.Number});
            this.dataGridViewSupplier.Location = new System.Drawing.Point(562, 143);
            this.dataGridViewSupplier.Name = "dataGridViewSupplier";
            this.dataGridViewSupplier.RowHeadersWidth = 51;
            this.dataGridViewSupplier.RowTemplate.Height = 24;
            this.dataGridViewSupplier.Size = new System.Drawing.Size(808, 473);
            this.dataGridViewSupplier.TabIndex = 29;
            this.dataGridViewSupplier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSupplier_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // Name
            // 
            this.Name.HeaderText = "Full Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 125;
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.MinimumWidth = 6;
            this.Product.Name = "Product";
            this.Product.Width = 125;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.Width = 125;
            // 
            // Number
            // 
            this.Number.HeaderText = "Phone No";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.Width = 125;
            // 
            // txtSuppPhoneNo
            // 
            this.txtSuppPhoneNo.Location = new System.Drawing.Point(244, 477);
            this.txtSuppPhoneNo.Multiline = true;
            this.txtSuppPhoneNo.Name = "txtSuppPhoneNo";
            this.txtSuppPhoneNo.Size = new System.Drawing.Size(219, 38);
            this.txtSuppPhoneNo.TabIndex = 25;
            this.txtSuppPhoneNo.TextChanged += new System.EventHandler(this.txtSuppPhoneNo_TextChanged);
            // 
            // txtSuppAddress
            // 
            this.txtSuppAddress.Location = new System.Drawing.Point(244, 410);
            this.txtSuppAddress.Multiline = true;
            this.txtSuppAddress.Name = "txtSuppAddress";
            this.txtSuppAddress.Size = new System.Drawing.Size(219, 38);
            this.txtSuppAddress.TabIndex = 26;
            // 
            // txtSupFullName
            // 
            this.txtSupFullName.Location = new System.Drawing.Point(244, 281);
            this.txtSupFullName.Multiline = true;
            this.txtSupFullName.Name = "txtSupFullName";
            this.txtSupFullName.Size = new System.Drawing.Size(219, 38);
            this.txtSupFullName.TabIndex = 27;
            this.txtSupFullName.TextChanged += new System.EventHandler(this.txtSupFullName_TextChanged);
            // 
            // txtSuppID
            // 
            this.txtSuppID.Location = new System.Drawing.Point(244, 130);
            this.txtSuppID.Multiline = true;
            this.txtSuppID.Name = "txtSuppID";
            this.txtSuppID.Size = new System.Drawing.Size(219, 38);
            this.txtSuppID.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(32, 477);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 38);
            this.label6.TabIndex = 21;
            this.label6.Text = "Phone No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(32, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 38);
            this.label5.TabIndex = 22;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(32, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 38);
            this.label4.TabIndex = 23;
            this.label4.Text = "Full Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(132, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 38);
            this.label1.TabIndex = 24;
            this.label1.Text = "Supplier Managment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 38);
            this.label3.TabIndex = 22;
            this.label3.Text = "Product";
            // 
            // txtSuppProduct
            // 
            this.txtSuppProduct.Location = new System.Drawing.Point(244, 346);
            this.txtSuppProduct.Multiline = true;
            this.txtSuppProduct.Name = "txtSuppProduct";
            this.txtSuppProduct.Size = new System.Drawing.Size(219, 38);
            this.txtSuppProduct.TabIndex = 26;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(562, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(461, 39);
            this.comboBox1.TabIndex = 103;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Fuchsia;
            this.button3.Location = new System.Drawing.Point(1044, 59);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 46);
            this.button3.TabIndex = 102;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(31)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(1533, 640);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtSuppEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeleteSupp);
            this.Controls.Add(this.btnUpdateSupp);
            this.Controls.Add(this.btnAddSupp);
            this.Controls.Add(this.dataGridViewSupplier);
            this.Controls.Add(this.txtSuppPhoneNo);
            this.Controls.Add(this.txtSuppProduct);
            this.Controls.Add(this.txtSuppAddress);
            this.Controls.Add(this.txtSupFullName);
            this.Controls.Add(this.txtSuppID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.Name = "SupplierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.Supplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSuppEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteSupp;
        private System.Windows.Forms.Button btnUpdateSupp;
        private System.Windows.Forms.Button btnAddSupp;
        private System.Windows.Forms.DataGridView dataGridViewSupplier;
        private System.Windows.Forms.TextBox txtSuppPhoneNo;
        private System.Windows.Forms.TextBox txtSuppAddress;
        private System.Windows.Forms.TextBox txtSupFullName;
        private System.Windows.Forms.TextBox txtSuppID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSuppProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
    }
}