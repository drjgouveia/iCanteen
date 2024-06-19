namespace iCantina.views
{
    partial class MainPage
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnStudents = new System.Windows.Forms.Button();
			this.btnProfessors = new System.Windows.Forms.Button();
			this.btnDishes = new System.Windows.Forms.Button();
			this.btnReservations = new System.Windows.Forms.Button();
			this.btnExtras = new System.Windows.Forms.Button();
			this.btnFines = new System.Windows.Forms.Button();
			this.lblUser = new System.Windows.Forms.Label();
			this.btnLogout = new System.Windows.Forms.Button();
			this.btnMenu = new System.Windows.Forms.Button();
			this.btnEmployees = new System.Windows.Forms.Button();
			this.btnInvoices = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel1.Controls.Add(this.btnStudents, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.btnProfessors, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.btnEmployees, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.btnInvoices, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.btnDishes, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnReservations, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnExtras, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnMenu, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.btnFines, 2, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 417);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// btnStudents
			// 
			this.btnStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
			this.btnStudents.Location = new System.Drawing.Point(3, 281);
			this.btnStudents.Name = "btnStudents";
			this.btnStudents.Size = new System.Drawing.Size(252, 133);
			this.btnStudents.TabIndex = 6;
			this.btnStudents.Text = "Students";
			this.btnStudents.UseVisualStyleBackColor = true;
			this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
			// 
			// btnProfessors
			// 
			this.btnProfessors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnProfessors.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
			this.btnProfessors.Location = new System.Drawing.Point(261, 281);
			this.btnProfessors.Name = "btnProfessors";
			this.btnProfessors.Size = new System.Drawing.Size(252, 133);
			this.btnProfessors.TabIndex = 7;
			this.btnProfessors.Text = "Professors";
			this.btnProfessors.UseVisualStyleBackColor = true;
			this.btnProfessors.Click += new System.EventHandler(this.btnProfessors_Click);
			// 
			// btnDishes
			// 
			this.btnDishes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDishes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
			this.btnDishes.Location = new System.Drawing.Point(519, 3);
			this.btnDishes.Name = "btnDishes";
			this.btnDishes.Size = new System.Drawing.Size(254, 133);
			this.btnDishes.TabIndex = 2;
			this.btnDishes.Text = "Dishes";
			this.btnDishes.UseVisualStyleBackColor = true;
			this.btnDishes.Click += new System.EventHandler(this.btnDishes_Click);
			// 
			// btnReservations
			// 
			this.btnReservations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnReservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
			this.btnReservations.Location = new System.Drawing.Point(3, 3);
			this.btnReservations.Name = "btnReservations";
			this.btnReservations.Size = new System.Drawing.Size(252, 133);
			this.btnReservations.TabIndex = 0;
			this.btnReservations.Text = "Reservations";
			this.btnReservations.UseVisualStyleBackColor = true;
			this.btnReservations.Click += new System.EventHandler(this.btnReservations_Click);
			// 
			// btnExtras
			// 
			this.btnExtras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
			this.btnExtras.Location = new System.Drawing.Point(261, 3);
			this.btnExtras.Name = "btnExtras";
			this.btnExtras.Size = new System.Drawing.Size(252, 133);
			this.btnExtras.TabIndex = 1;
			this.btnExtras.Text = "Extras";
			this.btnExtras.UseVisualStyleBackColor = true;
			this.btnExtras.Click += new System.EventHandler(this.btnExtras_Click);
			// 
			// btnFines
			// 
			this.btnFines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFines.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
			this.btnFines.Location = new System.Drawing.Point(519, 142);
			this.btnFines.Name = "btnFines";
			this.btnFines.Size = new System.Drawing.Size(254, 133);
			this.btnFines.TabIndex = 5;
			this.btnFines.Text = "Penalties";
			this.btnFines.UseVisualStyleBackColor = true;
			this.btnFines.Click += new System.EventHandler(this.btnFines_Click);
			// 
			// lblUser
			// 
			this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblUser.AutoSize = true;
			this.lblUser.Location = new System.Drawing.Point(14, 442);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(61, 13);
			this.lblUser.TabIndex = 1;
			this.lblUser.Text = "Welcome...";
			// 
			// btnLogout
			// 
			this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLogout.Location = new System.Drawing.Point(710, 437);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(75, 23);
			this.btnLogout.TabIndex = 3;
			this.btnLogout.Text = "Logout";
			this.btnLogout.UseVisualStyleBackColor = true;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// btnMenu
			// 
			this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
			this.btnMenu.Location = new System.Drawing.Point(261, 142);
			this.btnMenu.Name = "btnMenu";
			this.btnMenu.Size = new System.Drawing.Size(252, 133);
			this.btnMenu.TabIndex = 4;
			this.btnMenu.Text = "Menus";
			this.btnMenu.UseVisualStyleBackColor = true;
			this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
			// 
			// btnEmployees
			// 
			this.btnEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
			this.btnEmployees.Location = new System.Drawing.Point(519, 281);
			this.btnEmployees.Name = "btnEmployees";
			this.btnEmployees.Size = new System.Drawing.Size(254, 133);
			this.btnEmployees.TabIndex = 8;
			this.btnEmployees.Text = "Employees";
			this.btnEmployees.UseVisualStyleBackColor = true;
			this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
			// 
			// btnInvoices
			// 
			this.btnInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnInvoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
			this.btnInvoices.Location = new System.Drawing.Point(3, 142);
			this.btnInvoices.Name = "btnInvoices";
			this.btnInvoices.Size = new System.Drawing.Size(252, 133);
			this.btnInvoices.TabIndex = 3;
			this.btnInvoices.UseVisualStyleBackColor = true;
			// 
			// MainPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 469);
			this.Controls.Add(this.btnLogout);
			this.Controls.Add(this.lblUser);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "MainPage";
			this.Text = "Main page";
			this.Load += new System.EventHandler(this.MainPage_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnReservations;
        private System.Windows.Forms.Button btnFines;
        private System.Windows.Forms.Button btnExtras;
        private System.Windows.Forms.Button btnDishes;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnProfessors;
    private System.Windows.Forms.Label lblUser;
    private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.Button btnEmployees;
		private System.Windows.Forms.Button btnInvoices;
		private System.Windows.Forms.Button btnMenu;
	}
}