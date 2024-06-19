namespace iCanteen.views.lists
{
	partial class ListExtras
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
            this.listBoxExtras = new System.Windows.Forms.ListBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxExtras
            // 
            this.listBoxExtras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxExtras.DisplayMember = "w";
            this.listBoxExtras.FormattingEnabled = true;
            this.listBoxExtras.ItemHeight = 16;
            this.listBoxExtras.Location = new System.Drawing.Point(44, 128);
            this.listBoxExtras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxExtras.Name = "listBoxExtras";
            this.listBoxExtras.Size = new System.Drawing.Size(511, 292);
            this.listBoxExtras.TabIndex = 36;
            this.listBoxExtras.ValueMember = "w";
            this.listBoxExtras.DoubleClick += new System.EventHandler(this.listBoxExtras_DoubleClick);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(456, 38);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 28);
            this.btnCreate.TabIndex = 35;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxSearch.Location = new System.Drawing.Point(44, 96);
            this.txtBoxSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(511, 22);
            this.txtBoxSearch.TabIndex = 34;
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(37, 38);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(191, 32);
            this.title.TabIndex = 33;
            this.title.Text = "List of Extras";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListExtras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 459);
            this.Controls.Add(this.listBoxExtras);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.title);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ListExtras";
            this.Text = "ListExtras";
            this.Load += new System.EventHandler(this.ListExtras_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBoxExtras;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.TextBox txtBoxSearch;
		private System.Windows.Forms.Label title;
	}
}