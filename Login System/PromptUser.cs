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
    public partial class PromptUser : Form
    {
        public PromptUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseIO DBIO = new DatabaseIO();
            try
            {
                DBIO.ChangePassword(textBox1.Text);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Password changing unsuccessful");
            }
        }
    }
}
