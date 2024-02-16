namespace IMS
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOrderClicked = new System.Windows.Forms.Button();
            this.btnProductclicked = new System.Windows.Forms.Button();
            this.btnsupplierclicked = new System.Windows.Forms.Button();
            this.btnEmployeebtnclicked = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btncustomercliked = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(31)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1944, 115);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(428, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "INVENTORY MANAGMENT DASHBOARD";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(31)))), ((int)(((byte)(88)))));
            this.panel2.Controls.Add(this.btnOrderClicked);
            this.panel2.Controls.Add(this.btnProductclicked);
            this.panel2.Controls.Add(this.btnsupplierclicked);
            this.panel2.Controls.Add(this.btnEmployeebtnclicked);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.btncustomercliked);
            this.panel2.Location = new System.Drawing.Point(0, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 601);
            this.panel2.TabIndex = 1;
            // 
            // btnOrderClicked
            // 
            this.btnOrderClicked.Location = new System.Drawing.Point(42, 417);
            this.btnOrderClicked.Name = "btnOrderClicked";
            this.btnOrderClicked.Size = new System.Drawing.Size(138, 35);
            this.btnOrderClicked.TabIndex = 0;
            this.btnOrderClicked.Text = "Order";
            this.btnOrderClicked.UseVisualStyleBackColor = true;
            this.btnOrderClicked.Click += new System.EventHandler(this.btnOrderClicked_Click);
            // 
            // btnProductclicked
            // 
            this.btnProductclicked.Location = new System.Drawing.Point(42, 356);
            this.btnProductclicked.Name = "btnProductclicked";
            this.btnProductclicked.Size = new System.Drawing.Size(138, 35);
            this.btnProductclicked.TabIndex = 0;
            this.btnProductclicked.Text = "Product";
            this.btnProductclicked.UseVisualStyleBackColor = true;
            this.btnProductclicked.Click += new System.EventHandler(this.btnProductclicked_Click);
            // 
            // btnsupplierclicked
            // 
            this.btnsupplierclicked.Location = new System.Drawing.Point(42, 288);
            this.btnsupplierclicked.Name = "btnsupplierclicked";
            this.btnsupplierclicked.Size = new System.Drawing.Size(138, 35);
            this.btnsupplierclicked.TabIndex = 0;
            this.btnsupplierclicked.Text = "Supplier";
            this.btnsupplierclicked.UseVisualStyleBackColor = true;
            this.btnsupplierclicked.Click += new System.EventHandler(this.btnsupplierclicked_Click);
            // 
            // btnEmployeebtnclicked
            // 
            this.btnEmployeebtnclicked.Location = new System.Drawing.Point(42, 219);
            this.btnEmployeebtnclicked.Name = "btnEmployeebtnclicked";
            this.btnEmployeebtnclicked.Size = new System.Drawing.Size(138, 35);
            this.btnEmployeebtnclicked.TabIndex = 0;
            this.btnEmployeebtnclicked.Text = "Employee";
            this.btnEmployeebtnclicked.UseVisualStyleBackColor = true;
            this.btnEmployeebtnclicked.Click += new System.EventHandler(this.btnEmployeebtnclicked_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(42, 99);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(138, 35);
            this.button9.TabIndex = 0;
            this.button9.Text = "Home";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // btncustomercliked
            // 
            this.btncustomercliked.Location = new System.Drawing.Point(42, 157);
            this.btncustomercliked.Name = "btncustomercliked";
            this.btncustomercliked.Size = new System.Drawing.Size(138, 35);
            this.btncustomercliked.TabIndex = 0;
            this.btncustomercliked.Text = "Customer";
            this.btncustomercliked.UseVisualStyleBackColor = true;
            this.btncustomercliked.Click += new System.EventHandler(this.btncustomercliked_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1176, 611);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncustomercliked;
        private System.Windows.Forms.Button btnOrderClicked;
        private System.Windows.Forms.Button btnProductclicked;
        private System.Windows.Forms.Button btnsupplierclicked;
        private System.Windows.Forms.Button btnEmployeebtnclicked;
        private System.Windows.Forms.Button button9;
    }
}