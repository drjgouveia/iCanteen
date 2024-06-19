namespace iCanteen.views
{
    partial class EmployeesDetails
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
            this.txtBoxUserNameEmployee = new System.Windows.Forms.TextBox();
            this.lblUsernameEmployee = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblNIF = new System.Windows.Forms.Label();
            this.txtBoxNameEmployee = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtBoxNifEmployee = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.btnCreateEmployee = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxUserNameEmployee
            // 
            this.txtBoxUserNameEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxUserNameEmployee.Location = new System.Drawing.Point(135, 54);
            this.txtBoxUserNameEmployee.Name = "txtBoxUserNameEmployee";
            this.txtBoxUserNameEmployee.Size = new System.Drawing.Size(416, 20);
            this.txtBoxUserNameEmployee.TabIndex = 32;
            this.txtBoxUserNameEmployee.TextChanged += new System.EventHandler(this.txtBoxUserNameEmployee_TextChanged);
            // 
            // lblUsernameEmployee
            // 
            this.lblUsernameEmployee.AutoSize = true;
            this.lblUsernameEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameEmployee.Location = new System.Drawing.Point(58, 55);
            this.lblUsernameEmployee.Name = "lblUsernameEmployee";
            this.lblUsernameEmployee.Size = new System.Drawing.Size(81, 17);
            this.lblUsernameEmployee.TabIndex = 31;
            this.lblUsernameEmployee.Text = "Username";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(57, 19);
            this.lblEmployee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(118, 26);
            this.lblEmployee.TabIndex = 30;
            this.lblEmployee.Text = "Employee";
            this.lblEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNIF
            // 
            this.lblNIF.AutoSize = true;
            this.lblNIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIF.Location = new System.Drawing.Point(58, 115);
            this.lblNIF.Name = "lblNIF";
            this.lblNIF.Size = new System.Drawing.Size(32, 17);
            this.lblNIF.TabIndex = 33;
            this.lblNIF.Text = "NIF";
            // 
            // txtBoxNameEmployee
            // 
            this.txtBoxNameEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxNameEmployee.Location = new System.Drawing.Point(107, 85);
            this.txtBoxNameEmployee.Name = "txtBoxNameEmployee";
            this.txtBoxNameEmployee.Size = new System.Drawing.Size(444, 20);
            this.txtBoxNameEmployee.TabIndex = 35;
            this.txtBoxNameEmployee.TextChanged += new System.EventHandler(this.txtBoxNameEmployee_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(58, 85);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 34;
            this.lblName.Text = "Name";
            // 
            // txtBoxNifEmployee
            // 
            this.txtBoxNifEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxNifEmployee.Location = new System.Drawing.Point(89, 113);
            this.txtBoxNifEmployee.Name = "txtBoxNifEmployee";
            this.txtBoxNifEmployee.Size = new System.Drawing.Size(462, 20);
            this.txtBoxNifEmployee.TabIndex = 36;
            this.txtBoxNifEmployee.TextChanged += new System.EventHandler(this.txtBoxNifEmployee_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnDeleteEmployee, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEditEmployee, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCreateEmployee, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(62, 145);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(488, 30);
            this.tableLayoutPanel1.TabIndex = 37;
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteEmployee.Location = new System.Drawing.Point(327, 3);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(158, 24);
            this.btnDeleteEmployee.TabIndex = 2;
            this.btnDeleteEmployee.Text = "Delete";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditEmployee.Location = new System.Drawing.Point(165, 3);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(156, 24);
            this.btnEditEmployee.TabIndex = 1;
            this.btnEditEmployee.Text = "Edit";
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // btnCreateEmployee
            // 
            this.btnCreateEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateEmployee.Location = new System.Drawing.Point(3, 3);
            this.btnCreateEmployee.Name = "btnCreateEmployee";
            this.btnCreateEmployee.Size = new System.Drawing.Size(156, 24);
            this.btnCreateEmployee.TabIndex = 0;
            this.btnCreateEmployee.Text = "Create";
            this.btnCreateEmployee.UseVisualStyleBackColor = true;
            this.btnCreateEmployee.Click += new System.EventHandler(this.btnCreateEmployee_Click);
            // 
            // EmployeesDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 185);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.txtBoxNifEmployee);
            this.Controls.Add(this.txtBoxNameEmployee);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNIF);
            this.Controls.Add(this.txtBoxUserNameEmployee);
            this.Controls.Add(this.lblUsernameEmployee);
            this.Controls.Add(this.lblEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EmployeesDetails";
            this.Text = "EmployeesDetails";
            this.Load += new System.EventHandler(this.EmployeesDetails_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxUserNameEmployee;
        private System.Windows.Forms.Label lblUsernameEmployee;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblNIF;
        private System.Windows.Forms.TextBox txtBoxNameEmployee;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBoxNifEmployee;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnCreateEmployee;
    }
}