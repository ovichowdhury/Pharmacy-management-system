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
    public partial class UpdateDeleteData : Form
    {
        DatabaseUpdateDelete DBIO;
        public UpdateDeleteData()
        {
            DBIO = new DatabaseUpdateDelete();
            InitializeComponent();
            this.SetAutoCompleteDrugName();
        }

        private void SetAutoCompleteDrugName()
        {
            AutoCompleteStringCollection drugNames = new AutoCompleteStringCollection();
            drugNames = DBIO.GetAutoCompleteDrugNames();
            textBoxName.AutoCompleteCustomSource = drugNames;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDrug.Text.Equals("location"))
            {
                labelLocDet.Visible = true;
                textBoxLocDet.Visible = true;
            }
            else
            {
                labelLocDet.Visible = false;
                textBoxLocDet.Visible = false;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (!textBoxId.Text.Equals(""))
                {
                    string locId = null,genName = null, price = null, power = null, quantity = null, manName = null;
                    string locDir = null;
                    string details = null;
                    string name = null;
                    DBIO.GetDrugSearchResultByID(textBoxId.Text, out name,out locId,out genName, out locDir, out price, out power, out quantity, out manName, out details);

                    LocationAnsLabel.Text = locId + "  " + locDir;
                    GenericNameAnsLabel.Text = genName;
                    PriceAnsLabel.Text = price + " Tk";
                    PowerAnsLabel.Text = power;
                    QuantityAnsLabel.Text = quantity;
                    ManuAnsLabel.Text = manName;
                    DetailsTextbox.Text = details;
                    textBoxName.Text = name;
                }
                else if (!textBoxName.Text.Equals(""))
                {

                    string locId = null,genName=  null, price = null, power = null, quantity = null, manName = null;
                    string locDir = null;
                    string details = null;
                    DBIO.GetDrugSearchResult(textBoxName.Text, out locId,out genName, out locDir, out price, out power, out quantity, out manName, out details);

                    LocationAnsLabel.Text = locId + "  " + locDir;
                    GenericNameAnsLabel.Text = genName;
                    PriceAnsLabel.Text = price + " Tk";
                    PowerAnsLabel.Text = power;
                    QuantityAnsLabel.Text = quantity;
                    ManuAnsLabel.Text = manName;
                    DetailsTextbox.Text = details;
                }
            }
            catch (Exception)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete this record?","Confirmation Box", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (!textBoxName.Text.Equals(""))
                    {
                        DBIO.DeleteDrugInfoById(textBoxName.Text);
                        MessageBox.Show("Deletion Successful");
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Deletion failed");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxDrug.Text.Equals("name"))
                    this.UpdateDrugName();
                else if (comboBoxDrug.Text.Equals("generic name"))
                    this.UpdateDrugGenName();
                else if (comboBoxDrug.Text.Equals("price"))
                    this.UpdateDrugPrice();
                else if (comboBoxDrug.Text.Equals("power"))
                    this.UpdateDrugPower();
                else if (comboBoxDrug.Text.Equals("quantity"))
                    this.UpdateDrugQuantity();
                else if (comboBoxDrug.Text.Equals("details"))
                    this.UpdateDrugDetails();
                else if (comboBoxDrug.Text.Equals("manufacturer"))
                    this.UpdateDrugManufacturer();
                else if (comboBoxDrug.Text.Equals("location"))
                    this.UpdateDrugLocation();
            }
            catch (Exception)
            {
                MessageBox.Show("Update failed");
            }
        }

        private void UpdateDrugGenName()
        {
            if (!textBoxName.Text.Equals(""))
            {
                DBIO.UpdateDrugGenName(textBoxName.Text, textBoxValue.Text);
                MessageBox.Show("Updated");
            }
        }

        private void UpdateDrugLocation()
        {
            if (!textBoxName.Text.Equals(""))
            {
                DBIO.UpdateDrugLocation(textBoxName.Text, textBoxValue.Text, textBoxLocDet.Text);
                MessageBox.Show("Updated");
            }
        }

        private void UpdateDrugManufacturer()
        {
            if (!textBoxName.Text.Equals(""))
            {
                DBIO.UpdateDrugManufacturer(textBoxName.Text,textBoxValue.Text);
                MessageBox.Show("Updated");
            }
        }

        private void UpdateDrugDetails()
        {
            if (!textBoxName.Text.Equals(""))
            {
                DBIO.UpdateDrugDetails(textBoxName.Text, textBoxValue.Text);
                MessageBox.Show("Update Successful");
            }
        }

        private void UpdateDrugQuantity()
        {
            if (!textBoxName.Text.Equals("") && int.Parse(textBoxValue.Text) > -1)
            {
                DBIO.UpdateDrugQuan(textBoxName.Text,textBoxValue.Text);
                MessageBox.Show("Update Successful");
            }
        }

        private void UpdateDrugPower()
        {
            if (!textBoxName.Text.Equals(""))
            {
                DBIO.UpdateDrugPower(textBoxName.Text,textBoxValue.Text);
                MessageBox.Show("Update Successful");
            }
        }

        private void UpdateDrugPrice()
        {
            if (!textBoxName.Text.Equals(""))
            {
                DBIO.UpdateDrugPrice(textBoxName.Text, textBoxValue.Text);
                MessageBox.Show("Update Successful");
            }
        }

        private void UpdateDrugName()
        {
            if (!textBoxName.Text.Equals(""))
            {
                DBIO.UpdateDrugName(textBoxName.Text,textBoxValue.Text);
                MessageBox.Show("Update Successful");
            }
        }

        private void buttonManSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string id,contact,rep;
                DBIO.GetManSearchResult(textBoxManName.Text, out id, out contact, out rep);

                labelManId.Text = id;
                labelManContact.Text = contact;
                labelManRep.Text = rep;
            }
            catch (Exception)
            {
                MessageBox.Show("Search Failed");
            }
        }

        private void buttonManDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete all the information related to this manufacturer?", "Confirmation Box", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    DBIO.DeleteManufacturerInfo(textBoxManName.Text);
                    MessageBox.Show("Deletion successful");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Deletion failed");
            }
        }

        private void buttonManUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxManufacturer.Text)
                {
                    case "name":
                        this.UpdateManName();
                        break;
                    case "contact":
                        this.UpdateManContact();
                        break;
                    case "representative":
                        this.UpdateManRep();
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Update Failed");
            }
        }

        private void UpdateManRep()
        {
            if (!textBoxManName.Text.Equals(""))
            {
                DBIO.UpdateManRep(textBoxManName.Text, textBoxManValue.Text);
                MessageBox.Show("Update successful");
            }
        }

        private void UpdateManContact()
        {
            if (!textBoxManName.Text.Equals(""))
            {
                DBIO.UpdateManContact(textBoxManName.Text, textBoxManValue.Text);
                MessageBox.Show("Update successful");
            }
        }

        private void UpdateManName()
        {
            if (!textBoxManName.Text.Equals(""))
            {
                DBIO.UpdateManName(textBoxManName.Text,textBoxManValue.Text);
                MessageBox.Show("Update successful");
            }
        }

        private void buttonEmpDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DBIO.ArchiveEmpInfo(textBoxEmpId.Text);
                MessageBox.Show("successful");
            }
            catch (Exception)
            {
                MessageBox.Show("Archived failed");
            }
        }

        private void buttonEmpUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxEmployee.Text)
                {
                    case "name":
                        this.UpdateEmpName();
                        break;
                    case "type":
                        this.UpdateEmpType();
                        break;
                    case "salary":
                        this.UpdateEmpSalary();
                        break;
                    case "contact":
                        this.UpdateEmpContact();
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Update Failed");
            }
        }

        private void UpdateEmpContact()
        {
            if (!textBoxEmpId.Text.Equals(""))
            {
                DBIO.UpdateEmpContact(textBoxEmpId.Text, textBoxEmpValue.Text);
                MessageBox.Show("Update successful");
            }
        }

        private void UpdateEmpSalary()
        {
            if (!textBoxEmpId.Text.Equals(""))
            {
                DBIO.UpdateEmpSalary(textBoxEmpId.Text, textBoxEmpValue.Text);
                MessageBox.Show("Update successful");
            }
        }

        private void UpdateEmpType()
        {
            if (!textBoxEmpId.Text.Equals(""))
            {
                DBIO.UpdateEmpType(textBoxEmpId.Text, textBoxEmpValue.Text);
                MessageBox.Show("Update successful");
            }
        }

        private void UpdateEmpName()
        {
            if (!textBoxEmpId.Text.Equals(""))
            {
                DBIO.UpdateEmpName(textBoxEmpId.Text, textBoxEmpValue.Text);
                MessageBox.Show("Update successful");
            }
        }

        private void buttonEmpSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string name, type, salary, contact;
                DBIO.GetEmpSearchResult(textBoxEmpId.Text, out name, out type, out salary, out contact);
                labelEmpName.Text = name;
                labelEmpType.Text = type;
                labelEmpSal.Text = salary;
                labelEmpCon.Text = contact;
            }
            catch (Exception)
            {
                MessageBox.Show("Exception searching employee info");
            }
        }



    }
}
