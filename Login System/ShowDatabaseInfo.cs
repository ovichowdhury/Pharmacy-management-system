using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_System
{
    public partial class ShowDatabaseInfo : Form
    {
        DatabaseIO DBIO;
        public ShowDatabaseInfo()
        {
            DBIO = new DatabaseIO();
            InitializeComponent();
            this.SetManInfo();
            this.SetDrugInfo();
            this.SetEmpInfo();
            this.SetBuyingInfo();
            this.SetSellingInfo();
            this.SetArchiveInfo();
        }

        private void SetArchiveInfo()
        {
            try
            {
                DBIO.FillArchiveBuyingInfo(dataGridViewArBuying);
                DBIO.FillArchiveSellingInfo(dataGridViewArSelling);
            }
            catch (Exception)
            {
                MessageBox.Show("Exception loading Archive information");
            }
        }

        private void SetManInfo()
        {
            try
            {
                DBIO.FillManufacturerInfo(dataGridViewManInfo);
            }
            catch (Exception)
            {
                MessageBox.Show("Exception loading Manufacturer Information");
            }
            
        }

        private void SetDrugInfo()
        {
            try
            {
                DBIO.FillDrugInfo(dataGridViewDrugInfo);
            }
            catch (Exception)
            {
                MessageBox.Show("Exception loading Drug Information");
            }

        }

        private void SetEmpInfo()
        {
            try
            {
                DBIO.FillEmpInfo(dataGridViewEmpInfo);
            }
            catch (Exception)
            {
                MessageBox.Show("Exception loading Employee Information");
            }

        }

        private void SetBuyingInfo()
        {
            try
            {
                DBIO.FillBuyingInfo(dataGridViewBuyingInfo);
            }
            catch (Exception)
            {
                MessageBox.Show("Exception loading Buying Information");
            }
        }

        private void SetSellingInfo()
        {
            try
            {
                DBIO.FillSellingInfo(dataGridViewSellingInfo);
            }
            catch (Exception)
            {
                MessageBox.Show("Exception loading Selling Information");
            }
        }


    }
}
