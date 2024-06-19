namespace iCantina.views
{
	partial class CanteenMenuDetails
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
            this.lblExtras = new System.Windows.Forms.Label();
            this.chListBoxExtras = new System.Windows.Forms.CheckedListBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.cmbBoxDish = new System.Windows.Forms.ComboBox();
            this.lblDish = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.rdoBtnLunch = new System.Windows.Forms.RadioButton();
            this.rdoBtnDinner = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblPriceStudent = new System.Windows.Forms.Label();
            this.lblPriceProfessor = new System.Windows.Forms.Label();
            this.txtBoxPriceStudent = new System.Windows.Forms.TextBox();
            this.txtBoxPriceProfessor = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExtras
            // 
            this.lblExtras.AutoSize = true;
            this.lblExtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtras.Location = new System.Drawing.Point(17, 260);
            this.lblExtras.Name = "lblExtras";
            this.lblExtras.Size = new System.Drawing.Size(63, 20);
            this.lblExtras.TabIndex = 25;
            this.lblExtras.Text = "Extras";
            // 
            // chListBoxExtras
            // 
            this.chListBoxExtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chListBoxExtras.FormattingEnabled = true;
            this.chListBoxExtras.Items.AddRange(new object[] {
            "Extra 1",
            "Extra 2",
            "Extra 3"});
            this.chListBoxExtras.Location = new System.Drawing.Point(21, 283);
            this.chListBoxExtras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chListBoxExtras.Name = "chListBoxExtras";
            this.chListBoxExtras.Size = new System.Drawing.Size(719, 174);
            this.chListBoxExtras.TabIndex = 19;
            this.chListBoxExtras.SelectedIndexChanged += new System.EventHandler(this.chListBoxExtras_SelectedIndexChanged);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar.Location = new System.Drawing.Point(439, 44);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 18;
            // 
            // cmbBoxDish
            // 
            this.cmbBoxDish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxDish.FormattingEnabled = true;
            this.cmbBoxDish.Location = new System.Drawing.Point(23, 155);
            this.cmbBoxDish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBoxDish.Name = "cmbBoxDish";
            this.cmbBoxDish.Size = new System.Drawing.Size(371, 24);
            this.cmbBoxDish.TabIndex = 17;
            this.cmbBoxDish.SelectedIndexChanged += new System.EventHandler(this.cmbBoxDish_SelectedIndexChanged);
            // 
            // lblDish
            // 
            this.lblDish.AutoSize = true;
            this.lblDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDish.Location = new System.Drawing.Point(19, 132);
            this.lblDish.Name = "lblDish";
            this.lblDish.Size = new System.Drawing.Size(48, 20);
            this.lblDish.TabIndex = 14;
            this.lblDish.Text = "Dish";
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(13, 27);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(89, 32);
            this.lblMenu.TabIndex = 13;
            this.lblMenu.Text = "Menu";
            // 
            // rdoBtnLunch
            // 
            this.rdoBtnLunch.AutoSize = true;
            this.rdoBtnLunch.Checked = true;
            this.rdoBtnLunch.Location = new System.Drawing.Point(239, 80);
            this.rdoBtnLunch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoBtnLunch.Name = "rdoBtnLunch";
            this.rdoBtnLunch.Size = new System.Drawing.Size(63, 20);
            this.rdoBtnLunch.TabIndex = 26;
            this.rdoBtnLunch.TabStop = true;
            this.rdoBtnLunch.Text = "Lunch";
            this.rdoBtnLunch.UseVisualStyleBackColor = true;
            // 
            // rdoBtnDinner
            // 
            this.rdoBtnDinner.AutoSize = true;
            this.rdoBtnDinner.Location = new System.Drawing.Point(320, 80);
            this.rdoBtnDinner.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoBtnDinner.Name = "rdoBtnDinner";
            this.rdoBtnDinner.Size = new System.Drawing.Size(67, 20);
            this.rdoBtnDinner.TabIndex = 27;
            this.rdoBtnDinner.Text = "Dinner";
            this.rdoBtnDinner.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEdit, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCreate, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 484);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(763, 37);
            this.tableLayoutPanel1.TabIndex = 41;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(512, 4);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(247, 29);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(258, 4);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(246, 29);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Location = new System.Drawing.Point(4, 4);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(246, 29);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Quantity";
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(117, 81);
            this.numQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(65, 22);
            this.numQuantity.TabIndex = 43;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPriceStudent
            // 
            this.lblPriceStudent.AutoSize = true;
            this.lblPriceStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceStudent.Location = new System.Drawing.Point(17, 187);
            this.lblPriceStudent.Name = "lblPriceStudent";
            this.lblPriceStudent.Size = new System.Drawing.Size(123, 20);
            this.lblPriceStudent.TabIndex = 44;
            this.lblPriceStudent.Text = "Price Student";
            // 
            // lblPriceProfessor
            // 
            this.lblPriceProfessor.AutoSize = true;
            this.lblPriceProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceProfessor.Location = new System.Drawing.Point(16, 219);
            this.lblPriceProfessor.Name = "lblPriceProfessor";
            this.lblPriceProfessor.Size = new System.Drawing.Size(141, 20);
            this.lblPriceProfessor.TabIndex = 45;
            this.lblPriceProfessor.Text = "Price Professor";
            // 
            // txtBoxPriceStudent
            // 
            this.txtBoxPriceStudent.Location = new System.Drawing.Point(180, 187);
            this.txtBoxPriceStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxPriceStudent.Name = "txtBoxPriceStudent";
            this.txtBoxPriceStudent.Size = new System.Drawing.Size(213, 22);
            this.txtBoxPriceStudent.TabIndex = 46;
            this.txtBoxPriceStudent.TextChanged += new System.EventHandler(this.txtBoxPriceStudent_TextChanged);
            // 
            // txtBoxPriceProfessor
            // 
            this.txtBoxPriceProfessor.Location = new System.Drawing.Point(179, 219);
            this.txtBoxPriceProfessor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxPriceProfessor.Name = "txtBoxPriceProfessor";
            this.txtBoxPriceProfessor.Size = new System.Drawing.Size(215, 22);
            this.txtBoxPriceProfessor.TabIndex = 47;
            this.txtBoxPriceProfessor.TextChanged += new System.EventHandler(this.txtBoxProfessor_TextChanged);
            // 
            // CanteenMenuDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 521);
            this.Controls.Add(this.txtBoxPriceProfessor);
            this.Controls.Add(this.txtBoxPriceStudent);
            this.Controls.Add(this.lblPriceProfessor);
            this.Controls.Add(this.lblPriceStudent);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.rdoBtnDinner);
            this.Controls.Add(this.rdoBtnLunch);
            this.Controls.Add(this.lblExtras);
            this.Controls.Add(this.chListBoxExtras);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.cmbBoxDish);
            this.Controls.Add(this.lblDish);
            this.Controls.Add(this.lblMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CanteenMenuDetails";
            this.Text = "Canteen Menu";
            this.Load += new System.EventHandler(this.CanteenMenu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblExtras;
		private System.Windows.Forms.CheckedListBox chListBoxExtras;
		private System.Windows.Forms.MonthCalendar monthCalendar;
		private System.Windows.Forms.ComboBox cmbBoxDish;
		private System.Windows.Forms.Label lblDish;
		private System.Windows.Forms.Label lblMenu;
		private System.Windows.Forms.RadioButton rdoBtnLunch;
		private System.Windows.Forms.RadioButton rdoBtnDinner;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numQuantity;
		private System.Windows.Forms.Label lblPriceStudent;
		private System.Windows.Forms.Label lblPriceProfessor;
		private System.Windows.Forms.TextBox txtBoxPriceStudent;
		private System.Windows.Forms.TextBox txtBoxPriceProfessor;
	}
}
