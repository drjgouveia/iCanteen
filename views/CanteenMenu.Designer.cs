namespace iCantina.views
{
    partial class CanteenMenu
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
			this.chBoxVegetarianNotAvailable = new System.Windows.Forms.CheckBox();
			this.chBoxFishNotAvailable = new System.Windows.Forms.CheckBox();
			this.chBoxMeatNotAvailable = new System.Windows.Forms.CheckBox();
			this.cmbBoxVegetarianDish = new System.Windows.Forms.ComboBox();
			this.cmbBoxFishDish = new System.Windows.Forms.ComboBox();
			this.chListBoxExtras = new System.Windows.Forms.CheckedListBox();
			this.monthCalendar = new System.Windows.Forms.MonthCalendar();
			this.cmbBoxMeatDish = new System.Windows.Forms.ComboBox();
			this.lblVegetarianDish = new System.Windows.Forms.Label();
			this.lblFishDish = new System.Windows.Forms.Label();
			this.lblMeatDish = new System.Windows.Forms.Label();
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
			this.lblExtras.Location = new System.Drawing.Point(355, 213);
			this.lblExtras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblExtras.Name = "lblExtras";
			this.lblExtras.Size = new System.Drawing.Size(53, 17);
			this.lblExtras.TabIndex = 25;
			this.lblExtras.Text = "Extras";
			// 
			// chBoxVegetarianNotAvailable
			// 
			this.chBoxVegetarianNotAvailable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.chBoxVegetarianNotAvailable.AutoSize = true;
			this.chBoxVegetarianNotAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chBoxVegetarianNotAvailable.Location = new System.Drawing.Point(46, 289);
			this.chBoxVegetarianNotAvailable.Margin = new System.Windows.Forms.Padding(2);
			this.chBoxVegetarianNotAvailable.Name = "chBoxVegetarianNotAvailable";
			this.chBoxVegetarianNotAvailable.Size = new System.Drawing.Size(110, 21);
			this.chBoxVegetarianNotAvailable.TabIndex = 24;
			this.chBoxVegetarianNotAvailable.Text = "Not Available";
			this.chBoxVegetarianNotAvailable.UseVisualStyleBackColor = true;
			this.chBoxVegetarianNotAvailable.CheckedChanged += new System.EventHandler(this.chBoxVegetarianNotAvailable_CheckedChanged);
			// 
			// chBoxFishNotAvailable
			// 
			this.chBoxFishNotAvailable.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.chBoxFishNotAvailable.AutoSize = true;
			this.chBoxFishNotAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chBoxFishNotAvailable.Location = new System.Drawing.Point(46, 213);
			this.chBoxFishNotAvailable.Margin = new System.Windows.Forms.Padding(2);
			this.chBoxFishNotAvailable.Name = "chBoxFishNotAvailable";
			this.chBoxFishNotAvailable.Size = new System.Drawing.Size(110, 21);
			this.chBoxFishNotAvailable.TabIndex = 23;
			this.chBoxFishNotAvailable.Text = "Not Available";
			this.chBoxFishNotAvailable.UseVisualStyleBackColor = true;
			this.chBoxFishNotAvailable.CheckedChanged += new System.EventHandler(this.chBoxFishNotAvailable_CheckedChanged);
			// 
			// chBoxMeatNotAvailable
			// 
			this.chBoxMeatNotAvailable.AutoSize = true;
			this.chBoxMeatNotAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chBoxMeatNotAvailable.Location = new System.Drawing.Point(46, 143);
			this.chBoxMeatNotAvailable.Margin = new System.Windows.Forms.Padding(2);
			this.chBoxMeatNotAvailable.Name = "chBoxMeatNotAvailable";
			this.chBoxMeatNotAvailable.Size = new System.Drawing.Size(110, 21);
			this.chBoxMeatNotAvailable.TabIndex = 22;
			this.chBoxMeatNotAvailable.Text = "Not Available";
			this.chBoxMeatNotAvailable.UseVisualStyleBackColor = true;
			this.chBoxMeatNotAvailable.CheckedChanged += new System.EventHandler(this.chBoxMeatNotAvailable_CheckedChanged);
			// 
			// cmbBoxVegetarianDish
			// 
			this.cmbBoxVegetarianDish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmbBoxVegetarianDish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbBoxVegetarianDish.FormattingEnabled = true;
			this.cmbBoxVegetarianDish.Location = new System.Drawing.Point(46, 265);
			this.cmbBoxVegetarianDish.Margin = new System.Windows.Forms.Padding(2);
			this.cmbBoxVegetarianDish.Name = "cmbBoxVegetarianDish";
			this.cmbBoxVegetarianDish.Size = new System.Drawing.Size(249, 21);
			this.cmbBoxVegetarianDish.TabIndex = 21;
			this.cmbBoxVegetarianDish.SelectedIndexChanged += new System.EventHandler(this.cmbBoxVegetarianDish_SelectedIndexChanged);
			// 
			// cmbBoxFishDish
			// 
			this.cmbBoxFishDish.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cmbBoxFishDish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbBoxFishDish.FormattingEnabled = true;
			this.cmbBoxFishDish.Location = new System.Drawing.Point(46, 188);
			this.cmbBoxFishDish.Margin = new System.Windows.Forms.Padding(2);
			this.cmbBoxFishDish.Name = "cmbBoxFishDish";
			this.cmbBoxFishDish.Size = new System.Drawing.Size(249, 21);
			this.cmbBoxFishDish.TabIndex = 20;
			this.cmbBoxFishDish.SelectedIndexChanged += new System.EventHandler(this.cmbBoxFishDish_SelectedIndexChanged);
			// 
			// chListBoxExtras
			// 
			this.chListBoxExtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.chListBoxExtras.FormattingEnabled = true;
			this.chListBoxExtras.Items.AddRange(new object[] {
            "Extra 1",
            "Extra 2",
            "Extra 3"});
			this.chListBoxExtras.Location = new System.Drawing.Point(358, 230);
			this.chListBoxExtras.Margin = new System.Windows.Forms.Padding(2);
			this.chListBoxExtras.Name = "chListBoxExtras";
			this.chListBoxExtras.Size = new System.Drawing.Size(227, 154);
			this.chListBoxExtras.TabIndex = 19;
			// 
			// monthCalendar
			// 
			this.monthCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.monthCalendar.Location = new System.Drawing.Point(358, 22);
			this.monthCalendar.Margin = new System.Windows.Forms.Padding(7);
			this.monthCalendar.MaxSelectionCount = 1;
			this.monthCalendar.Name = "monthCalendar";
			this.monthCalendar.TabIndex = 18;
			// 
			// cmbBoxMeatDish
			// 
			this.cmbBoxMeatDish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbBoxMeatDish.FormattingEnabled = true;
			this.cmbBoxMeatDish.Location = new System.Drawing.Point(46, 119);
			this.cmbBoxMeatDish.Margin = new System.Windows.Forms.Padding(2);
			this.cmbBoxMeatDish.Name = "cmbBoxMeatDish";
			this.cmbBoxMeatDish.Size = new System.Drawing.Size(249, 21);
			this.cmbBoxMeatDish.TabIndex = 17;
			this.cmbBoxMeatDish.SelectedIndexChanged += new System.EventHandler(this.cmbBoxMeatDish_SelectedIndexChanged);
			// 
			// lblVegetarianDish
			// 
			this.lblVegetarianDish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblVegetarianDish.AutoSize = true;
			this.lblVegetarianDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVegetarianDish.Location = new System.Drawing.Point(43, 247);
			this.lblVegetarianDish.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblVegetarianDish.Name = "lblVegetarianDish";
			this.lblVegetarianDish.Size = new System.Drawing.Size(124, 17);
			this.lblVegetarianDish.TabIndex = 16;
			this.lblVegetarianDish.Text = "Vegetarian Dish";
			// 
			// lblFishDish
			// 
			this.lblFishDish.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblFishDish.AutoSize = true;
			this.lblFishDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFishDish.Location = new System.Drawing.Point(43, 170);
			this.lblFishDish.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblFishDish.Name = "lblFishDish";
			this.lblFishDish.Size = new System.Drawing.Size(75, 17);
			this.lblFishDish.TabIndex = 15;
			this.lblFishDish.Text = "Fish Dish";
			// 
			// lblMeatDish
			// 
			this.lblMeatDish.AutoSize = true;
			this.lblMeatDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMeatDish.Location = new System.Drawing.Point(43, 100);
			this.lblMeatDish.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblMeatDish.Name = "lblMeatDish";
			this.lblMeatDish.Size = new System.Drawing.Size(80, 17);
			this.lblMeatDish.TabIndex = 14;
			this.lblMeatDish.Text = "Meat Dish";
			// 
			// lblMenu
			// 
			this.lblMenu.AutoSize = true;
			this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMenu.Location = new System.Drawing.Point(41, 22);
			this.lblMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblMenu.Name = "lblMenu";
			this.lblMenu.Size = new System.Drawing.Size(70, 26);
			this.lblMenu.TabIndex = 13;
			this.lblMenu.Text = "Menu";
			// 
			// rdoBtnLunch
			// 
			this.rdoBtnLunch.AutoSize = true;
			this.rdoBtnLunch.Checked = true;
			this.rdoBtnLunch.Location = new System.Drawing.Point(179, 65);
			this.rdoBtnLunch.Name = "rdoBtnLunch";
			this.rdoBtnLunch.Size = new System.Drawing.Size(55, 17);
			this.rdoBtnLunch.TabIndex = 26;
			this.rdoBtnLunch.TabStop = true;
			this.rdoBtnLunch.Text = "Lunch";
			this.rdoBtnLunch.UseVisualStyleBackColor = true;
			// 
			// rdoBtnDinner
			// 
			this.rdoBtnDinner.AutoSize = true;
			this.rdoBtnDinner.Location = new System.Drawing.Point(240, 65);
			this.rdoBtnDinner.Name = "rdoBtnDinner";
			this.rdoBtnDinner.Size = new System.Drawing.Size(56, 17);
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
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 393);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 30);
			this.tableLayoutPanel1.TabIndex = 41;
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelete.Location = new System.Drawing.Point(401, 3);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(196, 24);
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
			this.btnEdit.Location = new System.Drawing.Point(202, 3);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(193, 24);
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
			this.btnCreate.Location = new System.Drawing.Point(3, 3);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(193, 24);
			this.btnCreate.TabIndex = 0;
			this.btnCreate.Text = "Create";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(43, 65);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 17);
			this.label1.TabIndex = 42;
			this.label1.Text = "Quantity";
			// 
			// numQuantity
			// 
			this.numQuantity.Location = new System.Drawing.Point(118, 65);
			this.numQuantity.Name = "numQuantity";
			this.numQuantity.Size = new System.Drawing.Size(49, 20);
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
			this.lblPriceStudent.Location = new System.Drawing.Point(43, 316);
			this.lblPriceStudent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblPriceStudent.Name = "lblPriceStudent";
			this.lblPriceStudent.Size = new System.Drawing.Size(106, 17);
			this.lblPriceStudent.TabIndex = 44;
			this.lblPriceStudent.Text = "Price Student";
			// 
			// lblPriceProfessor
			// 
			this.lblPriceProfessor.AutoSize = true;
			this.lblPriceProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPriceProfessor.Location = new System.Drawing.Point(42, 342);
			this.lblPriceProfessor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblPriceProfessor.Name = "lblPriceProfessor";
			this.lblPriceProfessor.Size = new System.Drawing.Size(120, 17);
			this.lblPriceProfessor.TabIndex = 45;
			this.lblPriceProfessor.Text = "Price Professor";
			// 
			// txtBoxPriceStudent
			// 
			this.txtBoxPriceStudent.Location = new System.Drawing.Point(165, 316);
			this.txtBoxPriceStudent.Name = "txtBoxPriceStudent";
			this.txtBoxPriceStudent.Size = new System.Drawing.Size(131, 20);
			this.txtBoxPriceStudent.TabIndex = 46;
			this.txtBoxPriceStudent.TextChanged += new System.EventHandler(this.txtBoxPriceStudent_TextChanged);
			// 
			// txtBoxPriceProfessor
			// 
			this.txtBoxPriceProfessor.Location = new System.Drawing.Point(164, 342);
			this.txtBoxPriceProfessor.Name = "txtBoxPriceProfessor";
			this.txtBoxPriceProfessor.Size = new System.Drawing.Size(131, 20);
			this.txtBoxPriceProfessor.TabIndex = 47;
			this.txtBoxPriceProfessor.TextChanged += new System.EventHandler(this.txtBoxProfessor_TextChanged);
			// 
			// CanteenMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 423);
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
			this.Controls.Add(this.chBoxVegetarianNotAvailable);
			this.Controls.Add(this.chBoxFishNotAvailable);
			this.Controls.Add(this.chBoxMeatNotAvailable);
			this.Controls.Add(this.cmbBoxVegetarianDish);
			this.Controls.Add(this.cmbBoxFishDish);
			this.Controls.Add(this.chListBoxExtras);
			this.Controls.Add(this.monthCalendar);
			this.Controls.Add(this.cmbBoxMeatDish);
			this.Controls.Add(this.lblVegetarianDish);
			this.Controls.Add(this.lblFishDish);
			this.Controls.Add(this.lblMeatDish);
			this.Controls.Add(this.lblMenu);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "CanteenMenu";
			this.Text = "Canteen Menu";
			this.Load += new System.EventHandler(this.CanteenMenu_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExtras;
        private System.Windows.Forms.CheckBox chBoxVegetarianNotAvailable;
        private System.Windows.Forms.CheckBox chBoxFishNotAvailable;
        private System.Windows.Forms.CheckBox chBoxMeatNotAvailable;
        private System.Windows.Forms.ComboBox cmbBoxVegetarianDish;
        private System.Windows.Forms.ComboBox cmbBoxFishDish;
        private System.Windows.Forms.CheckedListBox chListBoxExtras;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.ComboBox cmbBoxMeatDish;
        private System.Windows.Forms.Label lblVegetarianDish;
        private System.Windows.Forms.Label lblFishDish;
        private System.Windows.Forms.Label lblMeatDish;
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
