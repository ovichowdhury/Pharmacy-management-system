using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Login_System
{
    public partial class DailyReport : Form
    {
        DatabaseIO DBIO;
        public DailyReport()
        {
            DBIO = new DatabaseIO();
            InitializeComponent();
            this.PrepareReport();
        }

        private void PrepareReport()
        {
            try
            {
                string totalBuy, totalSell, numBought, numSold, bestEmp;
                DBIO.GetReportData(out totalBuy, out totalSell, out numBought, out numSold, out bestEmp);
                labelTotalBuyingMoney.Text = totalBuy +" Tk";
                labelTotalSellingMoney.Text = totalSell +" Tk";
                labelNumberOfDrugsBought.Text = numBought +" Item";
                labelNumberOfDrugsSold.Text = numSold +" Item";
                labelBestEmployee.Text = bestEmp;
            }
            catch (Exception)
            {

            }
        }

        private void buttonPdf_Click(object sender, EventArgs e)
        {
            try
            {
                Document doc = new Document(iTextSharp.text.PageSize.A4, 10, 10, 20, 30);
                string name = DateTime.Now.ToString("dd-MM-yyyy") + ".pdf";
                PdfWriter pdfWriter = PdfWriter.GetInstance(doc, new FileStream(name, FileMode.Create));
                doc.Open();

                Paragraph prg = new Paragraph();

                prg.Add("Total buying amount :        " + labelTotalBuyingMoney.Text +" \n");
                prg.Add("Total selling amount :       " + labelTotalSellingMoney.Text + " \n");
                prg.Add("Number of drug bought :      " + labelNumberOfDrugsBought.Text + "\n");
                prg.Add("Number of drug sold:         " + labelNumberOfDrugsSold.Text + "\n");
                prg.Add("Today's best employee :      " + labelBestEmployee.Text);

                doc.Add(prg);
                doc.Close();
                pdfWriter.Close();
                MessageBox.Show("PDF export successful");
            }
            catch (Exception)
            {
                MessageBox.Show("Pdf export failed");
            }
        }
    }
}
