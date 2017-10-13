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
    public partial class SignUp : Form
    {
        DatabaseIO DBIO;
        public SignUp()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 50 || textBox1.Text.Length < 8)
            {
                label3.Visible = true;
                label3.Text = "Username should be more than 8 caracter and less than 50 character";
            }
            else if (textBox2.Text.Length > 20 || textBox2.Text.Length < 4)
            {
                label3.Visible = true;
                label3.Text = "Password should be more than 4 caracter and less than 20 character";
            }
            else
            {
                DBIO = new DatabaseIO();
                DBIO.CreateUser(textBox1.Text, textBox2.Text,textBoxStatus.Text);
            }
        }


    }
}
