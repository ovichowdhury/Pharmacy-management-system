namespace Login_System
{
    partial class InventoryNotification
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryNotification));
            this.NotificationLabel = new System.Windows.Forms.Label();
            this.dataGridViewNotification = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotification)).BeginInit();
            this.SuspendLayout();
            // 
            // NotificationLabel
            // 
            this.NotificationLabel.AutoSize = true;
            this.NotificationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotificationLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NotificationLabel.Location = new System.Drawing.Point(162, 41);
            this.NotificationLabel.Name = "NotificationLabel";
            this.NotificationLabel.Size = new System.Drawing.Size(189, 20);
            this.NotificationLabel.TabIndex = 0;
            this.NotificationLabel.Text = "Medicines out of stock";
            // 
            // dataGridViewNotification
            // 
            this.dataGridViewNotification.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dataGridViewNotification.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewNotification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewNotification.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewNotification.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridViewNotification.Location = new System.Drawing.Point(2, 86);
            this.dataGridViewNotification.Name = "dataGridViewNotification";
            this.dataGridViewNotification.Size = new System.Drawing.Size(528, 202);
            this.dataGridViewNotification.TabIndex = 1;
            // 
            // InventoryNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(532, 288);
            this.Controls.Add(this.dataGridViewNotification);
            this.Controls.Add(this.NotificationLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InventoryNotification";
            this.Text = "Inventory Notification";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotification)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NotificationLabel;
        private System.Windows.Forms.DataGridView dataGridViewNotification;
    }
}