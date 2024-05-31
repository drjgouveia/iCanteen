namespace iCantina.views
{
	partial class ListClients
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
			this.btnCreate = new System.Windows.Forms.Button();
			this.txtBoxSearch = new System.Windows.Forms.TextBox();
			this.lstBoxClients = new System.Windows.Forms.ListBox();
			this.lblClients = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(335, 35);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(75, 23);
			this.btnCreate.TabIndex = 27;
			this.btnCreate.Text = "Create";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// txtBoxSearch
			// 
			this.txtBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtBoxSearch.Location = new System.Drawing.Point(26, 82);
			this.txtBoxSearch.Name = "txtBoxSearch";
			this.txtBoxSearch.Size = new System.Drawing.Size(384, 20);
			this.txtBoxSearch.TabIndex = 26;
			this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
			// 
			// lstBoxClients
			// 
			this.lstBoxClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstBoxClients.FormattingEnabled = true;
			this.lstBoxClients.Location = new System.Drawing.Point(26, 108);
			this.lstBoxClients.Name = "lstBoxClients";
			this.lstBoxClients.Size = new System.Drawing.Size(384, 225);
			this.lstBoxClients.TabIndex = 25;
			// 
			// lblClients
			// 
			this.lblClients.AutoSize = true;
			this.lblClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblClients.Location = new System.Drawing.Point(21, 35);
			this.lblClients.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblClients.Name = "lblClients";
			this.lblClients.Size = new System.Drawing.Size(50, 26);
			this.lblClients.TabIndex = 24;
			this.lblClients.Text = "List";
			this.lblClients.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ListClients
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(430, 369);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.txtBoxSearch);
			this.Controls.Add(this.lstBoxClients);
			this.Controls.Add(this.lblClients);
			this.Name = "ListClients";
			this.Text = "List of Clients";
			this.Load += new System.EventHandler(this.ListClients_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.TextBox txtBoxSearch;
		private System.Windows.Forms.ListBox lstBoxClients;
		private System.Windows.Forms.Label lblClients;
	}
}