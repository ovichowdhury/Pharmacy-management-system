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
    public partial class PrepareBillForm : Form
    {
        TextBox[] nameTextBoxList;
        TextBox[] quanTextBoxList;

        DatabaseInsert DBIO;
       // DatabaseIO DBIOParent;
        public PrepareBillForm()
        {
            DBIO = new DatabaseInsert();
            //DBIOParent = new DatabaseIO();
            InitializeComponent();
            this.SetAutoCompleteDrugNames();
        }

        private void SetAutoCompleteDrugNames()
        {
            AutoCompleteStringCollection drugNames = new AutoCompleteStringCollection();
            drugNames = DBIO.GetAutoCompleteDrugNames();
            textBoxDrugName.AutoCompleteCustomSource = drugNames;
            textBoxDN1.AutoCompleteCustomSource = drugNames;
            textBoxDN2.AutoCompleteCustomSource = drugNames;
            textBoxDN3.AutoCompleteCustomSource = drugNames;
            textBoxDN4.AutoCompleteCustomSource = drugNames;
            textBoxDN5.AutoCompleteCustomSource = drugNames;
            textBoxDN6.AutoCompleteCustomSource = drugNames;
            textBoxDN7.AutoCompleteCustomSource = drugNames;
            textBoxDN8.AutoCompleteCustomSource = drugNames;
            textBoxDN9.AutoCompleteCustomSource = drugNames;
            textBoxDN10.AutoCompleteCustomSource = drugNames;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.HideAllTextBox();
            this.ShowGivenNumberOfTextBox();
            this.listView1.Items.Clear();
            this.labelTotalPrice.Text = "-";
        }

        private void HideAllTextBox()
        {
            textBoxDN1.Visible = false;
            textBoxQ1.Visible = false;
            textBoxDN2.Visible = false;
            textBoxQ2.Visible = false;
            textBoxDN3.Visible = false;
            textBoxQ3.Visible = false;
            textBoxDN4.Visible = false;
            textBoxQ4.Visible = false;
            textBoxDN5.Visible = false;
            textBoxQ5.Visible = false;
            textBoxDN6.Visible = false;
            textBoxQ6.Visible = false;
            textBoxDN7.Visible = false;
            textBoxQ7.Visible = false;
            textBoxDN8.Visible = false;
            textBoxQ8.Visible = false;
            textBoxDN9.Visible = false;
            textBoxQ9.Visible = false;
            textBoxDN10.Visible = false;
            textBoxQ10.Visible = false;
        }

        private void ShowGivenNumberOfTextBox()
        {
            int item = int.Parse(comboBox1.Text);

            switch (item)
            {
                case 1:
                    textBoxDN1.Visible = true;
                    textBoxQ1.Visible = true;
                    break;
                case 2:
                    textBoxDN1.Visible = true;
                    textBoxQ1.Visible = true;
                    textBoxDN2.Visible = true;
                    textBoxQ2.Visible = true;
                    break;
                case 3:
                    textBoxDN1.Visible = true;
                    textBoxQ1.Visible = true;
                    textBoxDN2.Visible = true;
                    textBoxQ2.Visible = true;
                    textBoxDN3.Visible = true;
                    textBoxQ3.Visible = true;
                    break;
                case 4:
                    textBoxDN1.Visible = true;
                    textBoxQ1.Visible = true;
                    textBoxDN2.Visible = true;
                    textBoxQ2.Visible = true;
                    textBoxDN3.Visible = true;
                    textBoxQ3.Visible = true;
                    textBoxDN4.Visible = true;
                    textBoxQ4.Visible = true;
                    break;
                case 5:
                    textBoxDN1.Visible = true;
                    textBoxQ1.Visible = true;
                    textBoxDN2.Visible = true;
                    textBoxQ2.Visible = true;
                    textBoxDN3.Visible = true;
                    textBoxQ3.Visible = true;
                    textBoxDN4.Visible = true;
                    textBoxQ4.Visible = true;
                    textBoxDN5.Visible = true;
                    textBoxQ5.Visible = true;
                    break;
                case 6:
                    textBoxDN1.Visible = true;
                    textBoxQ1.Visible = true;
                    textBoxDN2.Visible = true;
                    textBoxQ2.Visible = true;
                    textBoxDN3.Visible = true;
                    textBoxQ3.Visible = true;
                    textBoxDN4.Visible = true;
                    textBoxQ4.Visible = true;
                    textBoxDN5.Visible = true;
                    textBoxQ5.Visible = true;
                    textBoxDN6.Visible = true;
                    textBoxQ6.Visible = true;
                    break;
                case 7:
                    textBoxDN1.Visible = true;
                    textBoxQ1.Visible = true;
                    textBoxDN2.Visible = true;
                    textBoxQ2.Visible = true;
                    textBoxDN3.Visible = true;
                    textBoxQ3.Visible = true;
                    textBoxDN4.Visible = true;
                    textBoxQ4.Visible = true;
                    textBoxDN5.Visible = true;
                    textBoxQ5.Visible = true;
                    textBoxDN6.Visible = true;
                    textBoxQ6.Visible = true;
                    textBoxDN7.Visible = true;
                    textBoxQ7.Visible = true;
                    break;
                case 8:
                    textBoxDN1.Visible = true;
                    textBoxQ1.Visible = true;
                    textBoxDN2.Visible = true;
                    textBoxQ2.Visible = true;
                    textBoxDN3.Visible = true;
                    textBoxQ3.Visible = true;
                    textBoxDN4.Visible = true;
                    textBoxQ4.Visible = true;
                    textBoxDN5.Visible = true;
                    textBoxQ5.Visible = true;
                    textBoxDN6.Visible = true;
                    textBoxQ6.Visible = true;
                    textBoxDN7.Visible = true;
                    textBoxQ7.Visible = true;
                    textBoxDN8.Visible = true;
                    textBoxQ8.Visible = true;
                    break;
                case 9:
                    textBoxDN1.Visible = true;
                    textBoxQ1.Visible = true;
                    textBoxDN2.Visible = true;
                    textBoxQ2.Visible = true;
                    textBoxDN3.Visible = true;
                    textBoxQ3.Visible = true;
                    textBoxDN4.Visible = true;
                    textBoxQ4.Visible = true;
                    textBoxDN5.Visible = true;
                    textBoxQ5.Visible = true;
                    textBoxDN6.Visible = true;
                    textBoxQ6.Visible = true;
                    textBoxDN7.Visible = true;
                    textBoxQ7.Visible = true;
                    textBoxDN8.Visible = true;
                    textBoxQ8.Visible = true;
                    textBoxDN9.Visible = true;
                    textBoxQ9.Visible = true;
                    break;
                case 10:
                    textBoxDN1.Visible = true;
                    textBoxQ1.Visible = true;
                    textBoxDN2.Visible = true;
                    textBoxQ2.Visible = true;
                    textBoxDN3.Visible = true;
                    textBoxQ3.Visible = true;
                    textBoxDN4.Visible = true;
                    textBoxQ4.Visible = true;
                    textBoxDN5.Visible = true;
                    textBoxQ5.Visible = true;
                    textBoxDN6.Visible = true;
                    textBoxQ6.Visible = true;
                    textBoxDN7.Visible = true;
                    textBoxQ7.Visible = true;
                    textBoxDN8.Visible = true;
                    textBoxQ8.Visible = true;
                    textBoxDN9.Visible = true;
                    textBoxQ9.Visible = true;
                    textBoxDN10.Visible = true;
                    textBoxQ10.Visible = true;
                    break;

            }
        }


        private void initializeTextBoxList()
        {
            nameTextBoxList = new TextBox[10];
            quanTextBoxList = new TextBox[10];

            nameTextBoxList[0] = textBoxDN1; nameTextBoxList[1] = textBoxDN2; nameTextBoxList[2] = textBoxDN3;
            nameTextBoxList[3] = textBoxDN4; nameTextBoxList[4] = textBoxDN5; nameTextBoxList[5] = textBoxDN6;
            nameTextBoxList[6] = textBoxDN7; nameTextBoxList[7] = textBoxDN8; nameTextBoxList[8] = textBoxDN9;
            nameTextBoxList[9] = textBoxDN10;

            quanTextBoxList[0] = textBoxQ1; quanTextBoxList[1] = textBoxQ2; quanTextBoxList[2] = textBoxQ3;
            quanTextBoxList[3] = textBoxQ4; quanTextBoxList[4] = textBoxQ5; quanTextBoxList[5] = textBoxQ6;
            quanTextBoxList[6] = textBoxQ7; quanTextBoxList[7] = textBoxQ8; quanTextBoxList[8] = textBoxQ9;
            quanTextBoxList[9] = textBoxQ10;
        }

        private void PrepareBill_Click(object sender, EventArgs e)
        {
            try
            {
                this.initializeTextBoxList();
                for (int i = 0; i < int.Parse(comboBox1.Text); i++)
                {
                    string[] details = DBIO.InsertBuyingInfo(nameTextBoxList[i].Text, quanTextBoxList[i].Text);
                    ListViewItem item = new ListViewItem(details);
                    listView1.Items.Add(item);
                }
                double sum=0;
                foreach (ListViewItem item in listView1.Items)
                {
                    sum = sum + double.Parse(item.SubItems[2].Text);
                }
                labelTotalPrice.Text = sum.ToString() + " Tk";

            }
            catch (Exception)
            {
                MessageBox.Show("Exception occured transaction failed");
            }
        }

        private void buttonAddDrug_Click(object sender, EventArgs e)
        {
            if (!textBoxDrugName.Text.Equals("") && !textBoxQuan.Text.Equals(""))
            {
                string[] str = { textBoxDrugName.Text, textBoxQuan.Text };
                ListViewItem item = new ListViewItem(str);
                listViewDrugList.Items.Add(item);
            }
        }

        private void buttonDropDrug_Click(object sender, EventArgs e)
        {
            if (listViewDrugList.SelectedItems.Count > 0)
            {
                listViewDrugList.Items.RemoveAt(listViewDrugList.SelectedIndices[0]);
            }
        }

        private void buttonPrepareSellingBill_Click(object sender, EventArgs e)
        {
            try
            {
                this.listViewSellingInfo.Items.Clear();

                foreach (ListViewItem item in listViewDrugList.Items)
                {
                    //Console.WriteLine(item.SubItems[0].Text);
                   // Console.WriteLine(item.SubItems[1].Text);
                    string[] details = DBIO.InsertSellingInfo(textBoxEmpId.Text, textBoxCustomerName.Text, textBoxDisPercent.Text, item.SubItems[0].Text, item.SubItems[1].Text);
                    ListViewItem det = new ListViewItem(details);
                    this.listViewSellingInfo.Items.Add(det);
                }

                double sum = 0;
                foreach(ListViewItem item in listViewSellingInfo.Items)
                {
                    sum = sum + double.Parse(item.SubItems[2].Text);
                }

                this.labelTotalSellingPrice.Text = sum.ToString() + " Tk";
                this.listViewDrugList.Items.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Transaction Failed");
            }
        }


    }
}
