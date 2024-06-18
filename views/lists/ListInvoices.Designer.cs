namespace iCanteen.views.lists
{
    partial class ListInvoices
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
            this.listBoxClients = new System.Windows.Forms.ListBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.lblClients = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxClients
            // 
            this.listBoxClients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxClients.DisplayMember = "w";
            this.listBoxClients.FormattingEnabled = true;
            this.listBoxClients.ItemHeight = 16;
            this.listBoxClients.Location = new System.Drawing.Point(73, 118);
            this.listBoxClients.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxClients.Name = "listBoxClients";
            this.listBoxClients.Size = new System.Drawing.Size(282, 292);
            this.listBoxClients.TabIndex = 36;
            this.listBoxClients.ValueMember = "w";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(300, 32);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 28);
            this.btnCreate.TabIndex = 35;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxSearch.Location = new System.Drawing.Point(73, 90);
            this.txtBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(282, 22);
            this.txtBoxSearch.TabIndex = 34;
            // 
            // lblClients
            // 
            this.lblClients.AutoSize = true;
            this.lblClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClients.Location = new System.Drawing.Point(67, 32);
            this.lblClients.Name = "lblClients";
            this.lblClients.Size = new System.Drawing.Size(200, 32);
            this.lblClients.TabIndex = 33;
            this.lblClients.Text = "List of Clients";
            this.lblClients.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 446);
            this.Controls.Add(this.listBoxClients);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.lblClients);
            this.Name = "ListInvoices";
            this.Text = "ListInvoices";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxClients;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Label lblClients;
    }
}