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
    public partial class DeleteAccountForm : Form
    {
        DatabaseUpdateDelete DBIO;
        public DeleteAccountForm()
        {
            DBIO = new DatabaseUpdateDelete();
            InitializeComponent();
            this.SetLoginInfo();
        }

        private void SetLoginInfo()
        {
            try
            {
                DBIO.FillLoginInfo(dataGridViewLogin);
            }
            catch (Exception)
            {
                MessageBox.Show("Exception loading Login information");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DBIO.DeleteUserAccount(textBox1.Text);
                DBIO.FillLoginInfo(dataGridViewLogin);
                //MessageBox.Show("User account successfully deleted");
            }
            catch (Exception)
            {
                MessageBox.Show("Error deleting user account");
            }
        }


    }
}
