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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCanteen.views.details
{
    public partial class InvoiceDetails : Form
    {
        private InvoiceDetailsController controller;
        public InvoiceDetails()
        {
            InitializeComponent();
            controller = new InvoiceDetailsController();

        }

    }
}
