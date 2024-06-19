﻿namespace iCanteen.views.details
{
    partial class InvoiceDetails
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
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.Invoices = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.labelValue = new System.Windows.Forms.Label();
            this.btnGenerateInvoice = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(148, 95);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(384, 22);
            this.txtDescription.TabIndex = 36;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(34, 95);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(106, 20);
            this.lblDescription.TabIndex = 35;
            this.lblDescription.Text = "Description";
            // 
            // Invoices
            // 
            this.Invoices.AutoSize = true;
            this.Invoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Invoices.Location = new System.Drawing.Point(12, 9);
            this.Invoices.Name = "Invoices";
            this.Invoices.Size = new System.Drawing.Size(126, 32);
            this.Invoices.TabIndex = 34;
            this.Invoices.Text = "Invoices";
            this.Invoices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.Location = new System.Drawing.Point(33, 59);
            this.labelCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(68, 20);
            this.labelCliente.TabIndex = 37;
            this.labelCliente.Text = "Cliente";
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCliente.Location = new System.Drawing.Point(120, 59);
            this.textBoxCliente.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.Size = new System.Drawing.Size(411, 22);
            this.textBoxCliente.TabIndex = 38;
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPreco.Location = new System.Drawing.Point(107, 128);
            this.textBoxPreco.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(424, 22);
            this.textBoxPreco.TabIndex = 39;
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValue.Location = new System.Drawing.Point(33, 128);
            this.labelValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(56, 20);
            this.labelValue.TabIndex = 40;
            this.labelValue.Text = "Value";
            // 
            // btnGenerateInvoice
            // 
            this.btnGenerateInvoice.Location = new System.Drawing.Point(385, 20);
            this.btnGenerateInvoice.Name = "btnGenerateInvoice";
            this.btnGenerateInvoice.Size = new System.Drawing.Size(146, 23);
            this.btnGenerateInvoice.TabIndex = 41;
            this.btnGenerateInvoice.Text = "Generate Invoice";
            this.btnGenerateInvoice.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(36, 179);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(495, 202);
            this.listView1.TabIndex = 42;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // InvoiceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 409);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnGenerateInvoice);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.textBoxPreco);
            this.Controls.Add(this.textBoxCliente);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.Invoices);
            this.Name = "InvoiceDetails";
            this.Text = "InvoiceDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label Invoices;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.TextBox textBoxPreco;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Button btnGenerateInvoice;
        private System.Windows.Forms.ListView listView1;
    }
}