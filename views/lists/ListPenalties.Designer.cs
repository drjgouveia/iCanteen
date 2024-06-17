namespace iCanteen.views.lists
{
    partial class ListPenalties
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
            this.listBoxFines = new System.Windows.Forms.ListBox();
            this.btnCreateFines = new System.Windows.Forms.Button();
            this.txtBoxSearchFines = new System.Windows.Forms.TextBox();
            this.lblFines = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxFines
            // 
            this.listBoxFines.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxFines.DisplayMember = "w";
            this.listBoxFines.FormattingEnabled = true;
            this.listBoxFines.ItemHeight = 16;
            this.listBoxFines.Location = new System.Drawing.Point(33, 145);
            this.listBoxFines.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxFines.Name = "listBoxFines";
            this.listBoxFines.Size = new System.Drawing.Size(498, 276);
            this.listBoxFines.TabIndex = 36;
            this.listBoxFines.ValueMember = "w";
            // 
            // btnCreateFines
            // 
            this.btnCreateFines.Location = new System.Drawing.Point(431, 30);
            this.btnCreateFines.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateFines.Name = "btnCreateFines";
            this.btnCreateFines.Size = new System.Drawing.Size(100, 28);
            this.btnCreateFines.TabIndex = 35;
            this.btnCreateFines.Text = "Create";
            this.btnCreateFines.UseVisualStyleBackColor = true;
            this.btnCreateFines.Click += new System.EventHandler(this.btnCreateFines_Click);
            // 
            // txtBoxSearchFines
            // 
            this.txtBoxSearchFines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxSearchFines.Location = new System.Drawing.Point(33, 106);
            this.txtBoxSearchFines.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxSearchFines.Name = "txtBoxSearchFines";
            this.txtBoxSearchFines.Size = new System.Drawing.Size(498, 22);
            this.txtBoxSearchFines.TabIndex = 34;
            this.txtBoxSearchFines.TextChanged += new System.EventHandler(this.txtBoxSearchFines_TextChanged);
            // 
            // lblFines
            // 
            this.lblFines.AutoSize = true;
            this.lblFines.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFines.Location = new System.Drawing.Point(27, 30);
            this.lblFines.Name = "lblFines";
            this.lblFines.Size = new System.Drawing.Size(233, 32);
            this.lblFines.TabIndex = 33;
            this.lblFines.Text = "List of Penalties";
            this.lblFines.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListPenalties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 451);
            this.Controls.Add(this.listBoxFines);
            this.Controls.Add(this.btnCreateFines);
            this.Controls.Add(this.txtBoxSearchFines);
            this.Controls.Add(this.lblFines);
            this.Name = "ListPenalties";
            this.Text = "ListFines";
            this.Load += new System.EventHandler(this.ListFines_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFines;
        private System.Windows.Forms.Button btnCreateFines;
        private System.Windows.Forms.TextBox txtBoxSearchFines;
        private System.Windows.Forms.Label lblFines;
    }
}