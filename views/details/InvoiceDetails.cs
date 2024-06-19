using iCanteen.controllers.details;
using iCantina.models;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCanteen.views.details
{
    public partial class InvoiceDetails : Form
    {
        private InvoiceDetailsController controller;
        public Invoice invoice = null;

        public InvoiceDetails()
        {
            InitializeComponent();
            controller = new InvoiceDetailsController();
        }

		public InvoiceDetails(Invoice invoice) : this()
		{
			this.invoice = invoice;
		}



        private void btnGenerateInvoice_Click(object sender, EventArgs e)
        {
			using (SaveFileDialog saveFileDialog = new SaveFileDialog())
			{
				saveFileDialog.Filter = "PDF files (.pdf)|.pdf";
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					PdfDocument pdf = new PdfDocument();

					pdf.Info.Title = "Invoice of Reservation";
					PdfPage pdfPage = pdf.AddPage();
					XGraphics gfx = XGraphics.FromPdfPage(pdfPage);
					XFont font = new XFont("Verdana", 20);
					XFont titleFont = new XFont("Verdana", 20);
					XFont itemFont = new XFont("Verdana", 8);
					XFont totalFont = new XFont("Verdana", 10);
					gfx.DrawString("Invoice of Reservation", titleFont, XBrushes.Black,
					new XRect(0, 20, pdfPage.Width.Point, 40), XStringFormats.TopCenter);

					double total = 0;
					int yOffset = 60;


					foreach (var item in this.invoice.InvoiceLines)
					{
						item.Description = item.Description;
						item.Price = item.Price;


						gfx.DrawString($"Description: {item.Description}", itemFont, XBrushes.Black,
						new XRect(40, yOffset, pdfPage.Width.Point - 80, 20), XStringFormats.TopLeft);
						yOffset += 20;

						gfx.DrawString($"Price: {item.Price:C}", itemFont, XBrushes.Black,
						new XRect(60, yOffset, pdfPage.Width.Point - 120, 20), XStringFormats.TopLeft);
						yOffset += 20;

					}

					pdf.Save(saveFileDialog.FileName);
				}
			}
		}
    }
}
