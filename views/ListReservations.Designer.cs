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
			this.SuspendLayout();
			// 
			// listBoxReservations
			// 
			this.listBoxReservations.FormattingEnabled = true;
			this.listBoxReservations.Location = new System.Drawing.Point(55, 81);
			this.listBoxReservations.Margin = new System.Windows.Forms.Padding(2);
			this.listBoxReservations.Name = "listBoxReservations";
			this.listBoxReservations.Size = new System.Drawing.Size(274, 251);
			this.listBoxReservations.TabIndex = 8;
			// 
			// comboBoxClients
			// 
			this.comboBoxClients.FormattingEnabled = true;
			this.comboBoxClients.Location = new System.Drawing.Point(92, 50);
			this.comboBoxClients.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxClients.Name = "comboBoxClients";
			this.comboBoxClients.Size = new System.Drawing.Size(237, 21);
			this.comboBoxClients.TabIndex = 7;
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
			this.btnMark.Location = new System.Drawing.Point(122, 347);
			this.btnMark.Margin = new System.Windows.Forms.Padding(2);
			this.btnMark.Name = "btnMark";
			this.btnMark.Size = new System.Drawing.Size(136, 25);
			this.btnMark.TabIndex = 11;
			this.btnMark.Text = "Mark as served";
			this.btnMark.UseVisualStyleBackColor = true;
			// 
			// ListReservations
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(380, 399);
			this.Controls.Add(this.btnMark);
			this.Controls.Add(this.listBoxReservations);
			this.Controls.Add(this.comboBoxClients);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.lblReservations);
			this.Name = "ListReservations";
			this.Text = "ListReservations";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBoxReservations;
		private System.Windows.Forms.ComboBox comboBoxClients;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lblReservations;
		private System.Windows.Forms.Button btnMark;
	}
}