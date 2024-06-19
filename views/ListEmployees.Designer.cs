namespace iCanteen.views
{
    partial class ListEmployees
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
            this.btnCreateEmployee = new System.Windows.Forms.Button();
            this.txtBoxSearchEmployees = new System.Windows.Forms.TextBox();
            this.lstBoxEmployees = new System.Windows.Forms.ListBox();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateEmployee
            // 
            this.btnCreateEmployee.Location = new System.Drawing.Point(281, 54);
            this.btnCreateEmployee.Name = "btnCreateEmployee";
            this.btnCreateEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnCreateEmployee.TabIndex = 31;
            this.btnCreateEmployee.Text = "Create";
            this.btnCreateEmployee.UseVisualStyleBackColor = true;
            this.btnCreateEmployee.Click += new System.EventHandler(this.btnCreateEmployee_Click);
            // 
            // txtBoxSearchEmployees
            // 
            this.txtBoxSearchEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxSearchEmployees.Location = new System.Drawing.Point(44, 91);
            this.txtBoxSearchEmployees.Name = "txtBoxSearchEmployees";
            this.txtBoxSearchEmployees.Size = new System.Drawing.Size(314, 20);
            this.txtBoxSearchEmployees.TabIndex = 30;
            this.txtBoxSearchEmployees.TextChanged += new System.EventHandler(this.txtBoxSearchEmployees_TextChanged);
            // 
            // lstBoxEmployees
            // 
            this.lstBoxEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstBoxEmployees.FormattingEnabled = true;
            this.lstBoxEmployees.Location = new System.Drawing.Point(44, 124);
            this.lstBoxEmployees.Name = "lstBoxEmployees";
            this.lstBoxEmployees.Size = new System.Drawing.Size(314, 199);
            this.lstBoxEmployees.TabIndex = 29;
            this.lstBoxEmployees.DoubleClick += new System.EventHandler(this.lstBoxEmployees_DoubleClick);
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployees.Location = new System.Drawing.Point(39, 21);
            this.lblEmployees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(202, 26);
            this.lblEmployees.TabIndex = 28;
            this.lblEmployees.Text = "List of Employees";
            this.lblEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 344);
            this.Controls.Add(this.btnCreateEmployee);
            this.Controls.Add(this.txtBoxSearchEmployees);
            this.Controls.Add(this.lstBoxEmployees);
            this.Controls.Add(this.lblEmployees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ListEmployees";
            this.Text = "ListEmployees";
            this.Load += new System.EventHandler(this.ListEmployees_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateEmployee;
        private System.Windows.Forms.TextBox txtBoxSearchEmployees;
        private System.Windows.Forms.ListBox lstBoxEmployees;
        private System.Windows.Forms.Label lblEmployees;
    }
}