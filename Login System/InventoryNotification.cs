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
    public partial class InventoryNotification : Form
    {
        private DatabaseIO DBIO; 
        public InventoryNotification()
        {
            InitializeComponent();
            DBIO = new DatabaseIO();
            this.FillDataGridWithNotifiedValue();
            this.MaximizeBox = false;
            
        }

        private void FillDataGridWithNotifiedValue()
        {
            DBIO.FillInventoryNotificationValues(dataGridViewNotification);
        }
    }
}
