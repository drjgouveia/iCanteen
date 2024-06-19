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
            this.lstBoxMenus = new System.Windows.Forms.ListBox();
            this.lblCanteen = new System.Windows.Forms.Label();
            this.cmbBoxYear = new System.Windows.Forms.ComboBox();
            this.cmbBoxWeek = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(567, 35);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 27;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lstBoxMenus
            // 
            this.lstBoxMenus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstBoxMenus.FormattingEnabled = true;
            this.lstBoxMenus.Location = new System.Drawing.Point(26, 108);
            this.lstBoxMenus.Name = "lstBoxMenus";
            this.lstBoxMenus.Size = new System.Drawing.Size(616, 225);
            this.lstBoxMenus.TabIndex = 25;
            this.lstBoxMenus.DoubleClick += new System.EventHandler(this.lstBoxMenus_DoubleClick);
            // 
            // lblCanteen
            // 
            this.lblCanteen.AutoSize = true;
            this.lblCanteen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanteen.Location = new System.Drawing.Point(21, 35);
            this.lblCanteen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCanteen.Name = "lblCanteen";
            this.lblCanteen.Size = new System.Drawing.Size(250, 26);
            this.lblCanteen.TabIndex = 24;
            this.lblCanteen.Text = "List of Canteen Menus";
            this.lblCanteen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbBoxYear
            // 
            this.cmbBoxYear.FormattingEnabled = true;
            this.cmbBoxYear.Location = new System.Drawing.Point(26, 81);
            this.cmbBoxYear.Name = "cmbBoxYear";
            this.cmbBoxYear.Size = new System.Drawing.Size(300, 21);
            this.cmbBoxYear.TabIndex = 28;
            this.cmbBoxYear.SelectedIndexChanged += new System.EventHandler(this.cmbBoxYear_SelectedIndexChanged);
            // 
            // cmbBoxWeek
            // 
            this.cmbBoxWeek.FormattingEnabled = true;
            this.cmbBoxWeek.Location = new System.Drawing.Point(332, 81);
            this.cmbBoxWeek.Name = "cmbBoxWeek";
            this.cmbBoxWeek.Size = new System.Drawing.Size(310, 21);
            this.cmbBoxWeek.TabIndex = 29;
            this.cmbBoxWeek.SelectedIndexChanged += new System.EventHandler(this.cmbBoxWeek_SelectedIndexChanged);
            // 
            // ListCanteenMenus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 369);
            this.Controls.Add(this.cmbBoxWeek);
            this.Controls.Add(this.cmbBoxYear);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lstBoxMenus);
            this.Controls.Add(this.lblCanteen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ListCanteenMenus";
            this.Text = "List Canteen Menu";
            this.Load += new System.EventHandler(this.ListCanteenMenus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnCreate;
    private System.Windows.Forms.ListBox lstBoxMenus;
    private System.Windows.Forms.Label lblCanteen;
		private System.Windows.Forms.ComboBox cmbBoxYear;
		private System.Windows.Forms.ComboBox cmbBoxWeek;
	}
}