using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Login_System
{
    public partial class MainForm : Form
    {
        DatabaseIO DBIO;
        SearchSpeechRecognizer recognizer;
        public MainForm()
        {
            DBIO = new DatabaseIO();
            recognizer = new SearchSpeechRecognizer();
            InitializeComponent();
            this.SetAutoCompleteText();
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            
        }


        private void SetAutoCompleteText()
        {
            AutoCompleteStringCollection drugNames = new AutoCompleteStringCollection();
            drugNames = DBIO.GetAutoCompleteDrugNames();
            SearchTextbox.AutoCompleteCustomSource = drugNames;
        }

        // Code for login sign up and logout
        private void mouse_clicked2(object sender, MouseEventArgs e)
        {
            textBox2.SelectAll();
        }

        private void mouse_clicked1(object sender, MouseEventArgs e)
        {
            textBox1.SelectAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DBIO.checkUsernameAndPassword(textBox1.Text, textBox2.Text) == true)
                {
                    // labelLogin.Visible = false;
                    panel1.Visible = true;
                    textBox1.Text = "";
                    textBox2.Text = "";
                }

                else
                    MessageBox.Show("Invalid login. Please check your username and password");
            }
            catch (Exception)
            {
                MessageBox.Show("Login attemp failed");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelHome.Visible = true;
           // labelLogin.Visible = true;
            panel1.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (DatabaseIO.accountStatus.ToUpper().Equals("MANAGER"))
            {
                SignUp obj = new SignUp();
                obj.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sorry Only manager account can access this feature");
            }
            
        }

        private void label4_Leave(object sender, System.EventArgs e)
        {
            label4.ForeColor = Color.White;
        }

        private void label4_Enter(object sender, System.EventArgs e)
        {
            label4.ForeColor = Color.DodgerBlue;
        }

        private void VoiceSearchButton_Click(object sender, EventArgs e)
        {
            SearchTextbox.Text = "----";
            recognizer.StartRecognition(SearchTextbox);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string locId = null ,genName=null, price = null, power = null, quantity = null, manName = null;
                string locDir = null;
                string details = null;
                DBIO.GetDrugSearchResult(SearchTextbox.Text, out locId, out genName, out locDir, out price, out power, out quantity, out manName, out details);

                LocationAnsLabel.Text = locId + "  " + locDir;
                GenericNameAnsLabel.Text = genName;
                PriceAnsLabel.Text = price +" Tk";
                PowerAnsLabel.Text = power;
                QuantityAnsLabel.Text = quantity;
                ManuAnsLabel.Text = manName;
                DetailsTextbox.Text = details;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void SearchTextbox_TextChanged(object sender, EventArgs e)
        {
            LocationAnsLabel.Text = "--";
            GenericNameAnsLabel.Text = "--";
            PriceAnsLabel.Text = "--";
            PowerAnsLabel.Text = "--";
            QuantityAnsLabel.Text = "--";
            ManuAnsLabel.Text = "--";
            DetailsTextbox.Text = "--";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirmation Box", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void toolStripInventoryNotification_Click(object sender, EventArgs e)
        {
            InventoryNotification obj = new InventoryNotification();
            obj.ShowDialog();
        }

        private void bLACKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Black;
        }

        private void sKYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.DimGray;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.StartMedicalAssitant();
        }

        private void toolStripButtonInsert_Click(object sender, EventArgs e)
        {
            if (DatabaseIO.accountStatus.ToUpper().Equals("MANAGER"))
            {
                InsertData obj = new InsertData();
                obj.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sorry Only manager account can access this feature");
            }
            
        }

        private void iNSERTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DatabaseIO.accountStatus.ToUpper().Equals("MANAGER"))
            {
                InsertData obj = new InsertData();
                obj.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sorry Only manager account can access this feature");
            }
        }

        private void toolStripButtonMedicalAssistant_Click(object sender, EventArgs e)
        {

            this.StartMedicalAssitant();
        }

        private void StartMedicalAssitant()
        {
            MedicalAssistance obj = new MedicalAssistance();
            obj.Start(labelNeedHelp);
        }

        private void toolStripButtonBill_Click(object sender, EventArgs e)
        {
                PrepareBillForm obj = new PrepareBillForm();
                obj.ShowDialog();
          
            
        }

        private void lOGOUTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panelHome.Visible = true;
            // labelLogin.Visible = true;
            panel1.Visible = false;
        }

        private void eXITToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangePassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PromptUser obj = new PromptUser();
            obj.ShowDialog();
        }

        private void toolStripButtonShowAllInfo_Click(object sender, EventArgs e)
        {
            ShowDatabaseInfo obj = new ShowDatabaseInfo();
            obj.ShowDialog();
        }

        private void cREATEACCOUNTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DatabaseIO.accountStatus.ToUpper().Equals("MANAGER"))
            {
                SignUp obj = new SignUp();
                obj.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sorry Only manager account can access this feature");
            }
        }

        private void dELETEACCOUNTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DatabaseIO.accountStatus.ToUpper().Equals("MANAGER"))
            {
                DeleteAccountForm obj = new DeleteAccountForm();
                obj.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sorry Only manager account can access this feature");
            }
        }

        private void toolStripButtonShowDailyReport_Click(object sender, EventArgs e)
        {
            DailyReport obj = new DailyReport();
            obj.ShowDialog();
        }

        private void aBOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Intelligent pharmasoft is an advanced pharmacy management software developed by nahid chowdhury,mushfiq dewan and raj ahmed.\nversion 1.0\ncopyright reserved by nahid chowdhury and team.","About Software");
        }

        private void toolStripButtonUpdateDelete_Click(object sender, EventArgs e)
        {
            if (DatabaseIO.accountStatus.ToUpper().Equals("MANAGER"))
            {
                UpdateDeleteData obj = new UpdateDeleteData();
                obj.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sorry Only manager account can access this feature");
            }
        }

        private void uPDATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DatabaseIO.accountStatus.ToUpper().Equals("MANAGER"))
            {
                UpdateDeleteData obj = new UpdateDeleteData();
                obj.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sorry Only manager account can access this feature");
            }
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DatabaseIO.accountStatus.ToUpper().Equals("MANAGER"))
            {
                UpdateDeleteData obj = new UpdateDeleteData();
                obj.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sorry Only manager account can access this feature");
            }
        }

      




    }
}
