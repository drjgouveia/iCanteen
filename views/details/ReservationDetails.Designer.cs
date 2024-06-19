namespace iCantina.views
{
  partial class ReservationDetails
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.lstBoxMenus = new System.Windows.Forms.ListBox();
            this.cmbBoxYear = new System.Windows.Forms.ComboBox();
            this.cmbBoxWeek = new System.Windows.Forms.ComboBox();
            this.cmbBoxClients = new System.Windows.Forms.ComboBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblWeek = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.chckBoxExtras = new System.Windows.Forms.CheckedListBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.lblReservations = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(567, 35);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lstBoxMenus
            // 
            this.lstBoxMenus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstBoxMenus.FormattingEnabled = true;
            this.lstBoxMenus.Location = new System.Drawing.Point(26, 145);
            this.lstBoxMenus.Name = "lstBoxMenus";
            this.lstBoxMenus.Size = new System.Drawing.Size(300, 186);
            this.lstBoxMenus.TabIndex = 25;
            this.lstBoxMenus.SelectedIndexChanged += new System.EventHandler(this.lstBoxMenus_SelectedIndexChanged);
            this.lstBoxMenus.DoubleClick += new System.EventHandler(this.lstBoxMenus_DoubleClick);
            // 
            // cmbBoxYear
            // 
            this.cmbBoxYear.FormattingEnabled = true;
            this.cmbBoxYear.Location = new System.Drawing.Point(26, 118);
            this.cmbBoxYear.Name = "cmbBoxYear";
            this.cmbBoxYear.Size = new System.Drawing.Size(300, 21);
            this.cmbBoxYear.TabIndex = 28;
            this.cmbBoxYear.SelectedIndexChanged += new System.EventHandler(this.cmbBoxYear_SelectedIndexChanged);
            // 
            // cmbBoxWeek
            // 
            this.cmbBoxWeek.FormattingEnabled = true;
            this.cmbBoxWeek.Location = new System.Drawing.Point(332, 118);
            this.cmbBoxWeek.Name = "cmbBoxWeek";
            this.cmbBoxWeek.Size = new System.Drawing.Size(310, 21);
            this.cmbBoxWeek.TabIndex = 29;
            this.cmbBoxWeek.SelectedIndexChanged += new System.EventHandler(this.cmbBoxWeek_SelectedIndexChanged);
            // 
            // cmbBoxClients
            // 
            this.cmbBoxClients.FormattingEnabled = true;
            this.cmbBoxClients.Location = new System.Drawing.Point(26, 69);
            this.cmbBoxClients.Name = "cmbBoxClients";
            this.cmbBoxClients.Size = new System.Drawing.Size(584, 21);
            this.cmbBoxClients.TabIndex = 30;
            this.cmbBoxClients.SelectedIndexChanged += new System.EventHandler(this.cmbBoxClients_SelectedIndexChanged);
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(26, 54);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(33, 13);
            this.lblClient.TabIndex = 31;
            this.lblClient.Text = "Client";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(26, 102);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 32;
            this.lblYear.Text = "Year";
            // 
            // lblWeek
            // 
            this.lblWeek.AutoSize = true;
            this.lblWeek.Location = new System.Drawing.Point(329, 102);
            this.lblWeek.Name = "lblWeek";
            this.lblWeek.Size = new System.Drawing.Size(36, 13);
            this.lblWeek.TabIndex = 33;
            this.lblWeek.Text = "Week";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(486, 35);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 35;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // chckBoxExtras
            // 
            this.chckBoxExtras.FormattingEnabled = true;
            this.chckBoxExtras.Location = new System.Drawing.Point(333, 145);
            this.chckBoxExtras.Name = "chckBoxExtras";
            this.chckBoxExtras.Size = new System.Drawing.Size(309, 184);
            this.chckBoxExtras.TabIndex = 36;
            this.chckBoxExtras.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chckBoxExtras_ItemCheck);
            this.chckBoxExtras.SelectedIndexChanged += new System.EventHandler(this.chckBoxExtras_SelectedIndexChanged);
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(26, 345);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(34, 13);
            this.lblCost.TabIndex = 37;
            this.lblCost.Text = "Cost: ";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(26, 368);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(52, 13);
            this.lblBalance.TabIndex = 38;
            this.lblBalance.Text = "Balance: ";
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(617, 69);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(25, 23);
            this.btnAddClient.TabIndex = 39;
            this.btnAddClient.Text = "+";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // lblReservations
            // 
            this.lblReservations.AutoSize = true;
            this.lblReservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservations.Location = new System.Drawing.Point(22, 22);
            this.lblReservations.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReservations.Name = "lblReservations";
            this.lblReservations.Size = new System.Drawing.Size(164, 20);
            this.lblReservations.TabIndex = 40;
            this.lblReservations.Text = "Create Reservation";
            // 
            // ReservationDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 413);
            this.Controls.Add(this.lblReservations);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.chckBoxExtras);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.lblWeek);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.cmbBoxClients);
            this.Controls.Add(this.cmbBoxWeek);
            this.Controls.Add(this.cmbBoxYear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lstBoxMenus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ReservationDetails";
            this.Text = "Create Reservation";
            this.Load += new System.EventHandler(this.ListCanteenMenus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.ListBox lstBoxMenus;
		private System.Windows.Forms.ComboBox cmbBoxYear;
		private System.Windows.Forms.ComboBox cmbBoxWeek;
		private System.Windows.Forms.ComboBox cmbBoxClients;
		private System.Windows.Forms.Label lblClient;
		private System.Windows.Forms.Label lblYear;
		private System.Windows.Forms.Label lblWeek;
		private System.Windows.Forms.Button buttonCreate;
		private System.Windows.Forms.CheckedListBox chckBoxExtras;
		private System.Windows.Forms.Label lblCost;
		private System.Windows.Forms.Label lblBalance;
		private System.Windows.Forms.Button btnAddClient;
		private System.Windows.Forms.Label lblReservations;
	}
}