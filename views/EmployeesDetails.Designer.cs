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
            this.txtBoxNif = new System.Windows.Forms.TextBox();
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
            this.txtBoxUserNameEmployee.Location = new System.Drawing.Point(180, 66);
            this.txtBoxUserNameEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxUserNameEmployee.Name = "txtBoxUserNameEmployee";
            this.txtBoxUserNameEmployee.Size = new System.Drawing.Size(553, 22);
            this.txtBoxUserNameEmployee.TabIndex = 32;
            this.txtBoxUserNameEmployee.TextChanged += new System.EventHandler(this.txtBoxUserNameEmployee_TextChanged);
            // 
            // lblUsernameEmployee
            // 
            this.lblUsernameEmployee.AutoSize = true;
            this.lblUsernameEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameEmployee.Location = new System.Drawing.Point(78, 68);
            this.lblUsernameEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsernameEmployee.Name = "lblUsernameEmployee";
            this.lblUsernameEmployee.Size = new System.Drawing.Size(94, 20);
            this.lblUsernameEmployee.TabIndex = 31;
            this.lblUsernameEmployee.Text = "Username";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(76, 23);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(149, 32);
            this.lblEmployee.TabIndex = 30;
            this.lblEmployee.Text = "Employee";
            this.lblEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNIF
            // 
            this.lblNIF.AutoSize = true;
            this.lblNIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIF.Location = new System.Drawing.Point(78, 141);
            this.lblNIF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNIF.Name = "lblNIF";
            this.lblNIF.Size = new System.Drawing.Size(38, 20);
            this.lblNIF.TabIndex = 33;
            this.lblNIF.Text = "NIF";
            // 
            // txtBoxNameEmployee
            // 
            this.txtBoxNameEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxNameEmployee.Location = new System.Drawing.Point(143, 105);
            this.txtBoxNameEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxNameEmployee.Name = "txtBoxNameEmployee";
            this.txtBoxNameEmployee.Size = new System.Drawing.Size(590, 22);
            this.txtBoxNameEmployee.TabIndex = 35;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(78, 105);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 20);
            this.lblName.TabIndex = 34;
            this.lblName.Text = "Name";
            // 
            // txtBoxNif
            // 
            this.txtBoxNif.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxNif.Location = new System.Drawing.Point(119, 139);
            this.txtBoxNif.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxNif.Name = "txtBoxNif";
            this.txtBoxNif.Size = new System.Drawing.Size(614, 22);
            this.txtBoxNif.TabIndex = 36;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(82, 178);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(651, 37);
            this.tableLayoutPanel1.TabIndex = 37;
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteEmployee.Location = new System.Drawing.Point(438, 4);
            this.btnDeleteEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(209, 29);
            this.btnDeleteEmployee.TabIndex = 2;
            this.btnDeleteEmployee.Text = "Delete";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditEmployee.Location = new System.Drawing.Point(221, 4);
            this.btnEditEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(209, 29);
            this.btnEditEmployee.TabIndex = 1;
            this.btnEditEmployee.Text = "Edit";
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            // 
            // btnCreateEmployee
            // 
            this.btnCreateEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateEmployee.Location = new System.Drawing.Point(4, 4);
            this.btnCreateEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateEmployee.Name = "btnCreateEmployee";
            this.btnCreateEmployee.Size = new System.Drawing.Size(209, 29);
            this.btnCreateEmployee.TabIndex = 0;
            this.btnCreateEmployee.Text = "Create";
            this.btnCreateEmployee.UseVisualStyleBackColor = true;
            this.btnCreateEmployee.Click += new System.EventHandler(this.btnCreateEmployee_Click);
            // 
            // EmployeesDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 228);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.txtBoxNif);
            this.Controls.Add(this.txtBoxNameEmployee);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNIF);
            this.Controls.Add(this.txtBoxUserNameEmployee);
            this.Controls.Add(this.lblUsernameEmployee);
            this.Controls.Add(this.lblEmployee);
            this.Name = "EmployeesDetails";
            this.Text = "EmployeesDetails";
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
        private System.Windows.Forms.TextBox txtBoxNif;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnCreateEmployee;
    }
}