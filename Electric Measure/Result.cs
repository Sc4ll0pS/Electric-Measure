using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Electric_Measure
{
    public partial class Result : Form
    {
        Bitmap memoryImage;
        PrintDocument printDoc = new PrintDocument();

        public Result(double totalcost, double basecost, double ft, double vat)
        {
            InitializeComponent();

            
            lbTotal.Text = $"Total: {totalcost} Baht";
            lbBase.Text = $"Base Tariff: {basecost} Baht";
            lbFt.Text = $"Fuel Adjustment (Ft): {ft} Baht";
            lbVat.Text = $"VAT (7%): {vat} Baht";
        }
        private void CaptureForm()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void Print_btn_Click(object sender, EventArgs e)
        {
            CaptureForm();

            printDoc.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDoc;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }
    }
}
