namespace iCantina.views
{
  partial class ListCanteenMenus
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
			this.lstBoxMenus = new System.Windows.Forms.ListBox();
			this.lblCanteen = new System.Windows.Forms.Label();
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
			this.lstBoxMenus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstBoxMenus.FormattingEnabled = true;
			this.lstBoxMenus.Location = new System.Drawing.Point(26, 108);
			this.lstBoxMenus.Name = "lstBoxClients";
			this.lstBoxMenus.Size = new System.Drawing.Size(384, 225);
			this.lstBoxMenus.TabIndex = 25;
			// 
			// lblClients
			// 
			this.lblCanteen.AutoSize = true;
			this.lblCanteen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCanteen.Location = new System.Drawing.Point(21, 35);
			this.lblCanteen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblCanteen.Name = "lblClients";
			this.lblCanteen.Size = new System.Drawing.Size(251, 26);
			this.lblCanteen.TabIndex = 24;
			this.lblCanteen.Text = "List of Canteen menus";
			this.lblCanteen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ListCanteenMenus
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(430, 369);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.txtBoxSearch);
			this.Controls.Add(this.lstBoxMenus);
			this.Controls.Add(this.lblCanteen);
			this.Name = "ListCanteenMenus";
			this.Text = "List of Canteen Menus";
			this.Load += new System.EventHandler(this.ListCanteenMenus_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnCreate;
    private System.Windows.Forms.TextBox txtBoxSearch;
    private System.Windows.Forms.ListBox lstBoxMenus;
    private System.Windows.Forms.Label lblCanteen;
  }
}