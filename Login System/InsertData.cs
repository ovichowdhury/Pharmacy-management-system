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
    public partial class InsertData : Form
    {
        DatabaseInsert DBIO;
        public InsertData()
        {
            DBIO = new DatabaseInsert();
            InitializeComponent();
            this.SetAutoCompleteGenericName();
            this.SetAutoCompleteLocationId();
        }

        private void SetAutoCompleteLocationId()
        {
            AutoCompleteStringCollection locationId = new AutoCompleteStringCollection();
            locationId = DBIO.GetAutoCompleteDrugLocationIds();
            textBoxLocId.AutoCompleteCustomSource = locationId;
        }

        private void SetAutoCompleteGenericName()
        {
            AutoCompleteStringCollection genericNames = new AutoCompleteStringCollection();
            genericNames = DBIO.GetAutoCompleteDrugGenericNames();
            textBoxGenericName.AutoCompleteCustomSource = genericNames;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                DBIO.InsertDrugInformation(textBoxName.Text,textBoxGenericName.Text,textBoxPower.Text,textBoxPrice.Text,textBoxQuantity.Text,textBoxLocId.Text,textBoxLocDet.Text,textBoxManId.Text,textBoxDrugDet.Text);
                
            }
            catch (Exception)
            {
                MessageBox.Show("Insertion failed");
            }
            
        }

        private void buttonManuInsert_Click(object sender, EventArgs e)
        {
            DBIO.InsertManufacturerInformation(textBoxManuName.Text, textBoxManuCon.Text, textBoxManuRep.Text);
        }

        private void buttonEmpInsert_Click(object sender, EventArgs e)
        {
            DBIO.InsertEmpInformation(textBoxEmpName.Text, textBoxEmpType.Text, textBoxEmpSal.Text, textBoxEmpCon.Text);
        }


    }
}
