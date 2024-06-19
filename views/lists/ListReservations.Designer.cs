namespace iCanteen.views
{
	partial class ListReservations
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
            this.listBoxReservations = new System.Windows.Forms.ListBox();
            this.comboBoxClients = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblReservations = new System.Windows.Forms.Label();
            this.btnMark = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.listBoxPastReservations = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxReservations
            // 
            this.listBoxReservations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxReservations.FormattingEnabled = true;
            this.listBoxReservations.Location = new System.Drawing.Point(11, 87);
            this.listBoxReservations.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxReservations.Name = "listBoxReservations";
            this.listBoxReservations.Size = new System.Drawing.Size(358, 147);
            this.listBoxReservations.TabIndex = 8;
            this.listBoxReservations.SelectedIndexChanged += new System.EventHandler(this.listBoxReservations_SelectedIndexChanged);
            // 
            // comboBoxClients
            // 
            this.comboBoxClients.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxClients.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxClients.FormattingEnabled = true;
            this.comboBoxClients.Location = new System.Drawing.Point(92, 50);
            this.comboBoxClients.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxClients.Name = "comboBoxClients";
            this.comboBoxClients.Size = new System.Drawing.Size(237, 21);
            this.comboBoxClients.TabIndex = 7;
            this.comboBoxClients.SelectedIndexChanged += new System.EventHandler(this.comboBoxClients_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 54);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Client:";
            // 
            // lblReservations
            // 
            this.lblReservations.AutoSize = true;
            this.lblReservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservations.Location = new System.Drawing.Point(144, 19);
            this.lblReservations.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReservations.Name = "lblReservations";
            this.lblReservations.Size = new System.Drawing.Size(114, 20);
            this.lblReservations.TabIndex = 5;
            this.lblReservations.Text = "Reservations";
            // 
            // btnMark
            // 
            this.btnMark.Location = new System.Drawing.Point(193, 238);
            this.btnMark.Margin = new System.Windows.Forms.Padding(2);
            this.btnMark.Name = "btnMark";
            this.btnMark.Size = new System.Drawing.Size(136, 25);
            this.btnMark.TabIndex = 11;
            this.btnMark.Text = "Mark as served";
            this.btnMark.UseVisualStyleBackColor = true;
            this.btnMark.Click += new System.EventHandler(this.btnMark_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(55, 238);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(136, 25);
            this.btnCreate.TabIndex = 12;
            this.btnCreate.Text = "Create reservation";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // listBoxPastReservations
            // 
            this.listBoxPastReservations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPastReservations.FormattingEnabled = true;
            this.listBoxPastReservations.Location = new System.Drawing.Point(11, 267);
            this.listBoxPastReservations.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxPastReservations.Name = "listBoxPastReservations";
            this.listBoxPastReservations.Size = new System.Drawing.Size(358, 121);
            this.listBoxPastReservations.TabIndex = 13;
            // 
            // ListReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 399);
            this.Controls.Add(this.listBoxPastReservations);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnMark);
            this.Controls.Add(this.listBoxReservations);
            this.Controls.Add(this.comboBoxClients);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblReservations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ListReservations";
            this.Text = "ListReservations";
            this.Load += new System.EventHandler(this.ListReservations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBoxReservations;
		private System.Windows.Forms.ComboBox comboBoxClients;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lblReservations;
		private System.Windows.Forms.Button btnMark;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.ListBox listBoxPastReservations;
	}
}