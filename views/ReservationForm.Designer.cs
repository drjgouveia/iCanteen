namespace iCantina.views
{
    partial class ReservationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonReservation = new System.Windows.Forms.Button();
            this.checkedListBoxExtrasReservation = new System.Windows.Forms.CheckedListBox();
            this.comboBoxClientCreate = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonVegetarianReservation = new System.Windows.Forms.RadioButton();
            this.radioButtonFishReservation = new System.Windows.Forms.RadioButton();
            this.radioButtonMeatReservation = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonDinner = new System.Windows.Forms.RadioButton();
            this.radioButtonLunch = new System.Windows.Forms.RadioButton();
            this.dateTimePickerDayReservation = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCheckReservation = new System.Windows.Forms.Button();
            this.listBoxReservations = new System.Windows.Forms.ListBox();
            this.comboBoxClientCheck = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(494, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 73);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.buttonReservation);
            this.splitContainer1.Panel1.Controls.Add(this.checkedListBoxExtrasReservation);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxClientCreate);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.radioButtonVegetarianReservation);
            this.splitContainer1.Panel1.Controls.Add(this.radioButtonFishReservation);
            this.splitContainer1.Panel1.Controls.Add(this.radioButtonMeatReservation);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.radioButtonDinner);
            this.splitContainer1.Panel1.Controls.Add(this.radioButtonLunch);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePickerDayReservation);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonCheckReservation);
            this.splitContainer1.Panel2.Controls.Add(this.listBoxReservations);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxClientCheck);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Size = new System.Drawing.Size(1288, 731);
            this.splitContainer1.SplitterDistance = 623;
            this.splitContainer1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(370, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Extras:";
            // 
            // buttonReservation
            // 
            this.buttonReservation.Location = new System.Drawing.Point(216, 632);
            this.buttonReservation.Name = "buttonReservation";
            this.buttonReservation.Size = new System.Drawing.Size(159, 50);
            this.buttonReservation.TabIndex = 12;
            this.buttonReservation.Text = "Reservation";
            this.buttonReservation.UseVisualStyleBackColor = true;
            this.buttonReservation.Click += new System.EventHandler(this.buttonReservation_Click);
            // 
            // checkedListBoxExtrasReservation
            // 
            this.checkedListBoxExtrasReservation.FormattingEnabled = true;
            this.checkedListBoxExtrasReservation.Location = new System.Drawing.Point(352, 367);
            this.checkedListBoxExtrasReservation.Name = "checkedListBoxExtrasReservation";
            this.checkedListBoxExtrasReservation.Size = new System.Drawing.Size(214, 200);
            this.checkedListBoxExtrasReservation.TabIndex = 11;
            this.checkedListBoxExtrasReservation.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxExtrasReservation_SelectedIndexChanged);
            // 
            // comboBoxClientCreate
            // 
            this.comboBoxClientCreate.FormattingEnabled = true;
            this.comboBoxClientCreate.Location = new System.Drawing.Point(140, 57);
            this.comboBoxClientCreate.Name = "comboBoxClientCreate";
            this.comboBoxClientCreate.Size = new System.Drawing.Size(390, 33);
            this.comboBoxClientCreate.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Client:";
            // 
            // radioButtonVegetarianReservation
            // 
            this.radioButtonVegetarianReservation.AutoSize = true;
            this.radioButtonVegetarianReservation.Location = new System.Drawing.Point(72, 511);
            this.radioButtonVegetarianReservation.Name = "radioButtonVegetarianReservation";
            this.radioButtonVegetarianReservation.Size = new System.Drawing.Size(147, 29);
            this.radioButtonVegetarianReservation.TabIndex = 8;
            this.radioButtonVegetarianReservation.TabStop = true;
            this.radioButtonVegetarianReservation.Text = "Vegetarian";
            this.radioButtonVegetarianReservation.UseVisualStyleBackColor = true;
            // 
            // radioButtonFishReservation
            // 
            this.radioButtonFishReservation.AutoSize = true;
            this.radioButtonFishReservation.Location = new System.Drawing.Point(72, 452);
            this.radioButtonFishReservation.Name = "radioButtonFishReservation";
            this.radioButtonFishReservation.Size = new System.Drawing.Size(84, 29);
            this.radioButtonFishReservation.TabIndex = 7;
            this.radioButtonFishReservation.TabStop = true;
            this.radioButtonFishReservation.Text = "Fish";
            this.radioButtonFishReservation.UseVisualStyleBackColor = true;
            // 
            // radioButtonMeatReservation
            // 
            this.radioButtonMeatReservation.AutoSize = true;
            this.radioButtonMeatReservation.Location = new System.Drawing.Point(68, 389);
            this.radioButtonMeatReservation.Name = "radioButtonMeatReservation";
            this.radioButtonMeatReservation.Size = new System.Drawing.Size(91, 29);
            this.radioButtonMeatReservation.TabIndex = 6;
            this.radioButtonMeatReservation.TabStop = true;
            this.radioButtonMeatReservation.Text = "Meat";
            this.radioButtonMeatReservation.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Type:";
            // 
            // radioButtonDinner
            // 
            this.radioButtonDinner.AutoSize = true;
            this.radioButtonDinner.Location = new System.Drawing.Point(352, 216);
            this.radioButtonDinner.Name = "radioButtonDinner";
            this.radioButtonDinner.Size = new System.Drawing.Size(106, 29);
            this.radioButtonDinner.TabIndex = 4;
            this.radioButtonDinner.TabStop = true;
            this.radioButtonDinner.Text = "Dinner";
            this.radioButtonDinner.UseVisualStyleBackColor = true;
            // 
            // radioButtonLunch
            // 
            this.radioButtonLunch.AutoSize = true;
            this.radioButtonLunch.Location = new System.Drawing.Point(117, 216);
            this.radioButtonLunch.Name = "radioButtonLunch";
            this.radioButtonLunch.Size = new System.Drawing.Size(102, 29);
            this.radioButtonLunch.TabIndex = 3;
            this.radioButtonLunch.TabStop = true;
            this.radioButtonLunch.Text = "Lunch";
            this.radioButtonLunch.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDayReservation
            // 
            this.dateTimePickerDayReservation.Location = new System.Drawing.Point(166, 150);
            this.dateTimePickerDayReservation.Name = "dateTimePickerDayReservation";
            this.dateTimePickerDayReservation.Size = new System.Drawing.Size(327, 31);
            this.dateTimePickerDayReservation.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Day:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Create";
            // 
            // buttonCheckReservation
            // 
            this.buttonCheckReservation.Location = new System.Drawing.Point(238, 633);
            this.buttonCheckReservation.Name = "buttonCheckReservation";
            this.buttonCheckReservation.Size = new System.Drawing.Size(170, 49);
            this.buttonCheckReservation.TabIndex = 4;
            this.buttonCheckReservation.Text = "Check";
            this.buttonCheckReservation.UseVisualStyleBackColor = true;
            // 
            // listBoxReservations
            // 
            this.listBoxReservations.FormattingEnabled = true;
            this.listBoxReservations.ItemHeight = 25;
            this.listBoxReservations.Location = new System.Drawing.Point(58, 167);
            this.listBoxReservations.Name = "listBoxReservations";
            this.listBoxReservations.Size = new System.Drawing.Size(545, 429);
            this.listBoxReservations.TabIndex = 3;
            // 
            // comboBoxClientCheck
            // 
            this.comboBoxClientCheck.FormattingEnabled = true;
            this.comboBoxClientCheck.Location = new System.Drawing.Point(131, 57);
            this.comboBoxClientCheck.Name = "comboBoxClientCheck";
            this.comboBoxClientCheck.Size = new System.Drawing.Size(440, 33);
            this.comboBoxClientCheck.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Client:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(287, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 37);
            this.label6.TabIndex = 0;
            this.label6.Text = "Check";
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 816);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Name = "ReservationForm";
            this.Text = "Reservation";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDayReservation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonVegetarianReservation;
        private System.Windows.Forms.RadioButton radioButtonFishReservation;
        private System.Windows.Forms.RadioButton radioButtonMeatReservation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonDinner;
        private System.Windows.Forms.RadioButton radioButtonLunch;
        private System.Windows.Forms.Button buttonReservation;
        private System.Windows.Forms.CheckedListBox checkedListBoxExtrasReservation;
        private System.Windows.Forms.ComboBox comboBoxClientCreate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxClientCheck;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonCheckReservation;
        private System.Windows.Forms.ListBox listBoxReservations;
    }
}