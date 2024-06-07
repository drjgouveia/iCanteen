namespace iCanteen.views
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
			this.listBoxClients.Location = new System.Drawing.Point(25, 99);
			this.listBoxClients.Name = "listBoxClients";
			this.listBoxClients.Size = new System.Drawing.Size(384, 238);
			this.listBoxClients.TabIndex = 32;
			this.listBoxClients.ValueMember = "w";
			this.listBoxClients.DoubleClick += new System.EventHandler(this.listBoxClients_DoubleClick);
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(334, 26);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(75, 23);
			this.btnCreate.TabIndex = 31;
			this.btnCreate.Text = "Create";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// txtBoxSearch
			// 
			this.txtBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtBoxSearch.Location = new System.Drawing.Point(25, 73);
			this.txtBoxSearch.Name = "txtBoxSearch";
			this.txtBoxSearch.Size = new System.Drawing.Size(384, 20);
			this.txtBoxSearch.TabIndex = 30;
			this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
			// 
			// lblClients
			// 
			this.lblClients.AutoSize = true;
			this.lblClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblClients.Location = new System.Drawing.Point(20, 26);
			this.lblClients.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblClients.Name = "lblClients";
			this.lblClients.Size = new System.Drawing.Size(50, 26);
			this.lblClients.TabIndex = 29;
			this.lblClients.Text = "List";
			this.lblClients.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ListClients
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(428, 362);
			this.Controls.Add(this.listBoxClients);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.txtBoxSearch);
			this.Controls.Add(this.lblClients);
			this.Name = "ListClients";
			this.Text = "ListClients";
			this.Load += new System.EventHandler(this.ListClients_Load);
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