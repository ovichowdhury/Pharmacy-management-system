using System.Windows.Forms;
namespace Login_System
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label3 = new System.Windows.Forms.Label();
            this.panelHome = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GenericNameAnsLabel = new System.Windows.Forms.Label();
            this.GenericNameLabel = new System.Windows.Forms.Label();
            this.labelNeedHelp = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelImage = new System.Windows.Forms.ToolStripLabel();
            this.toolStripInventoryNotification = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonInsert = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUpdateDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBill = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonShowDailyReport = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonShowAllInfo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMedicalAssistant = new System.Windows.Forms.ToolStripButton();
            this.VoiceSearchButton = new System.Windows.Forms.Button();
            this.DetailsTextbox = new System.Windows.Forms.TextBox();
            this.ManuAnsLabel = new System.Windows.Forms.Label();
            this.QuantityAnsLabel = new System.Windows.Forms.Label();
            this.PowerAnsLabel = new System.Windows.Forms.Label();
            this.PriceAnsLabel = new System.Windows.Forms.Label();
            this.LocationAnsLabel = new System.Windows.Forms.Label();
            this.DetailsLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.PowerLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cREATEACCOUNTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEACCOUNTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOUTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bACKGROUNDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bLACKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sKYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hELPToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.iNSERTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uPDATEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hELPToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aBOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.panelHome.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(210, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "You are logged in";
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.SystemColors.GrayText;
            this.panelHome.BackgroundImage = global::Login_System.Properties.Resources.background1;
            this.panelHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelHome.Controls.Add(this.panel1);
            this.panelHome.Controls.Add(this.button1);
            this.panelHome.Controls.Add(this.textBox2);
            this.panelHome.Controls.Add(this.textBox1);
            this.panelHome.Controls.Add(this.label2);
            this.panelHome.Controls.Add(this.label1);
            this.panelHome.Controls.Add(this.labelLogin);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Margin = new System.Windows.Forms.Padding(0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(929, 560);
            this.panelHome.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.GenericNameAnsLabel);
            this.panel1.Controls.Add(this.GenericNameLabel);
            this.panel1.Controls.Add(this.labelNeedHelp);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.VoiceSearchButton);
            this.panel1.Controls.Add(this.DetailsTextbox);
            this.panel1.Controls.Add(this.ManuAnsLabel);
            this.panel1.Controls.Add(this.QuantityAnsLabel);
            this.panel1.Controls.Add(this.PowerAnsLabel);
            this.panel1.Controls.Add(this.PriceAnsLabel);
            this.panel1.Controls.Add(this.LocationAnsLabel);
            this.panel1.Controls.Add(this.DetailsLabel);
            this.panel1.Controls.Add(this.ManufacturerLabel);
            this.panel1.Controls.Add(this.QuantityLabel);
            this.panel1.Controls.Add(this.PowerLabel);
            this.panel1.Controls.Add(this.PriceLabel);
            this.panel1.Controls.Add(this.LocationLabel);
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Controls.Add(this.SearchTextbox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 560);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // GenericNameAnsLabel
            // 
            this.GenericNameAnsLabel.AutoSize = true;
            this.GenericNameAnsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenericNameAnsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GenericNameAnsLabel.Location = new System.Drawing.Point(343, 202);
            this.GenericNameAnsLabel.Name = "GenericNameAnsLabel";
            this.GenericNameAnsLabel.Size = new System.Drawing.Size(21, 20);
            this.GenericNameAnsLabel.TabIndex = 31;
            this.GenericNameAnsLabel.Text = "--";
            // 
            // GenericNameLabel
            // 
            this.GenericNameLabel.AutoSize = true;
            this.GenericNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenericNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GenericNameLabel.Location = new System.Drawing.Point(198, 202);
            this.GenericNameLabel.Name = "GenericNameLabel";
            this.GenericNameLabel.Size = new System.Drawing.Size(123, 20);
            this.GenericNameLabel.TabIndex = 30;
            this.GenericNameLabel.Text = "Generic Name";
            // 
            // labelNeedHelp
            // 
            this.labelNeedHelp.AutoSize = true;
            this.labelNeedHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNeedHelp.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelNeedHelp.Location = new System.Drawing.Point(784, 351);
            this.labelNeedHelp.Name = "labelNeedHelp";
            this.labelNeedHelp.Size = new System.Drawing.Size(100, 18);
            this.labelNeedHelp.TabIndex = 29;
            this.labelNeedHelp.Text = "Need Help ?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Login_System.Properties.Resources.doctor_icon;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(735, 98);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 235);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelImage,
            this.toolStripInventoryNotification,
            this.toolStripButtonInsert,
            this.toolStripButtonUpdateDelete,
            this.toolStripButtonBill,
            this.toolStripButtonShowDailyReport,
            this.toolStripButtonShowAllInfo,
            this.toolStripButtonMedicalAssistant});
            this.toolStrip1.Location = new System.Drawing.Point(0, 31);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(139, 529);
            this.toolStrip1.TabIndex = 27;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabelImage
            // 
            this.toolStripLabelImage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabelImage.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.toolStripLabelImage.Image = global::Login_System.Properties.Resources.toolstripImage1;
            this.toolStripLabelImage.Name = "toolStripLabelImage";
            this.toolStripLabelImage.Padding = new System.Windows.Forms.Padding(10);
            this.toolStripLabelImage.Size = new System.Drawing.Size(136, 37);
            this.toolStripLabelImage.Text = "Options";
            // 
            // toolStripInventoryNotification
            // 
            this.toolStripInventoryNotification.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripInventoryNotification.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripInventoryNotification.ForeColor = System.Drawing.Color.DimGray;
            this.toolStripInventoryNotification.Image = ((System.Drawing.Image)(resources.GetObject("toolStripInventoryNotification.Image")));
            this.toolStripInventoryNotification.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripInventoryNotification.Name = "toolStripInventoryNotification";
            this.toolStripInventoryNotification.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.toolStripInventoryNotification.Size = new System.Drawing.Size(136, 41);
            this.toolStripInventoryNotification.Text = "Inventory Status";
            this.toolStripInventoryNotification.Click += new System.EventHandler(this.toolStripInventoryNotification_Click);
            // 
            // toolStripButtonInsert
            // 
            this.toolStripButtonInsert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonInsert.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonInsert.ForeColor = System.Drawing.Color.DimGray;
            this.toolStripButtonInsert.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonInsert.Image")));
            this.toolStripButtonInsert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInsert.Name = "toolStripButtonInsert";
            this.toolStripButtonInsert.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.toolStripButtonInsert.Size = new System.Drawing.Size(136, 41);
            this.toolStripButtonInsert.Text = "Insert Data";
            this.toolStripButtonInsert.Click += new System.EventHandler(this.toolStripButtonInsert_Click);
            // 
            // toolStripButtonUpdateDelete
            // 
            this.toolStripButtonUpdateDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonUpdateDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonUpdateDelete.ForeColor = System.Drawing.Color.DimGray;
            this.toolStripButtonUpdateDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUpdateDelete.Image")));
            this.toolStripButtonUpdateDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUpdateDelete.Name = "toolStripButtonUpdateDelete";
            this.toolStripButtonUpdateDelete.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.toolStripButtonUpdateDelete.Size = new System.Drawing.Size(136, 41);
            this.toolStripButtonUpdateDelete.Text = "Update/Delete";
            this.toolStripButtonUpdateDelete.Click += new System.EventHandler(this.toolStripButtonUpdateDelete_Click);
            // 
            // toolStripButtonBill
            // 
            this.toolStripButtonBill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonBill.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonBill.ForeColor = System.Drawing.Color.DimGray;
            this.toolStripButtonBill.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBill.Image")));
            this.toolStripButtonBill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBill.Name = "toolStripButtonBill";
            this.toolStripButtonBill.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.toolStripButtonBill.Size = new System.Drawing.Size(136, 41);
            this.toolStripButtonBill.Text = "Prepare Bill";
            this.toolStripButtonBill.Click += new System.EventHandler(this.toolStripButtonBill_Click);
            // 
            // toolStripButtonShowDailyReport
            // 
            this.toolStripButtonShowDailyReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonShowDailyReport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonShowDailyReport.ForeColor = System.Drawing.Color.DimGray;
            this.toolStripButtonShowDailyReport.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShowDailyReport.Image")));
            this.toolStripButtonShowDailyReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShowDailyReport.Name = "toolStripButtonShowDailyReport";
            this.toolStripButtonShowDailyReport.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.toolStripButtonShowDailyReport.Size = new System.Drawing.Size(136, 36);
            this.toolStripButtonShowDailyReport.Text = "Daily Report";
            this.toolStripButtonShowDailyReport.Click += new System.EventHandler(this.toolStripButtonShowDailyReport_Click);
            // 
            // toolStripButtonShowAllInfo
            // 
            this.toolStripButtonShowAllInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonShowAllInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonShowAllInfo.ForeColor = System.Drawing.Color.DimGray;
            this.toolStripButtonShowAllInfo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShowAllInfo.Image")));
            this.toolStripButtonShowAllInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShowAllInfo.Name = "toolStripButtonShowAllInfo";
            this.toolStripButtonShowAllInfo.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.toolStripButtonShowAllInfo.Size = new System.Drawing.Size(136, 36);
            this.toolStripButtonShowAllInfo.Text = "Database";
            this.toolStripButtonShowAllInfo.Click += new System.EventHandler(this.toolStripButtonShowAllInfo_Click);
            // 
            // toolStripButtonMedicalAssistant
            // 
            this.toolStripButtonMedicalAssistant.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonMedicalAssistant.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonMedicalAssistant.ForeColor = System.Drawing.Color.DimGray;
            this.toolStripButtonMedicalAssistant.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMedicalAssistant.Image")));
            this.toolStripButtonMedicalAssistant.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMedicalAssistant.Name = "toolStripButtonMedicalAssistant";
            this.toolStripButtonMedicalAssistant.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.toolStripButtonMedicalAssistant.Size = new System.Drawing.Size(136, 36);
            this.toolStripButtonMedicalAssistant.Text = "Medical Assistance";
            this.toolStripButtonMedicalAssistant.Click += new System.EventHandler(this.toolStripButtonMedicalAssistant_Click);
            // 
            // VoiceSearchButton
            // 
            this.VoiceSearchButton.BackgroundImage = global::Login_System.Properties.Resources.logovoiceorg1;
            this.VoiceSearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VoiceSearchButton.Location = new System.Drawing.Point(620, 98);
            this.VoiceSearchButton.Name = "VoiceSearchButton";
            this.VoiceSearchButton.Size = new System.Drawing.Size(30, 35);
            this.VoiceSearchButton.TabIndex = 25;
            this.VoiceSearchButton.UseVisualStyleBackColor = true;
            this.VoiceSearchButton.Click += new System.EventHandler(this.VoiceSearchButton_Click);
            // 
            // DetailsTextbox
            // 
            this.DetailsTextbox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.DetailsTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsTextbox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DetailsTextbox.Location = new System.Drawing.Point(347, 372);
            this.DetailsTextbox.Multiline = true;
            this.DetailsTextbox.Name = "DetailsTextbox";
            this.DetailsTextbox.ReadOnly = true;
            this.DetailsTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DetailsTextbox.Size = new System.Drawing.Size(292, 58);
            this.DetailsTextbox.TabIndex = 24;
            this.DetailsTextbox.Text = "--";
            // 
            // ManuAnsLabel
            // 
            this.ManuAnsLabel.AutoSize = true;
            this.ManuAnsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManuAnsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ManuAnsLabel.Location = new System.Drawing.Point(343, 333);
            this.ManuAnsLabel.Name = "ManuAnsLabel";
            this.ManuAnsLabel.Size = new System.Drawing.Size(21, 20);
            this.ManuAnsLabel.TabIndex = 23;
            this.ManuAnsLabel.Text = "--";
            // 
            // QuantityAnsLabel
            // 
            this.QuantityAnsLabel.AutoSize = true;
            this.QuantityAnsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityAnsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.QuantityAnsLabel.Location = new System.Drawing.Point(343, 300);
            this.QuantityAnsLabel.Name = "QuantityAnsLabel";
            this.QuantityAnsLabel.Size = new System.Drawing.Size(21, 20);
            this.QuantityAnsLabel.TabIndex = 22;
            this.QuantityAnsLabel.Text = "--";
            // 
            // PowerAnsLabel
            // 
            this.PowerAnsLabel.AutoSize = true;
            this.PowerAnsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PowerAnsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PowerAnsLabel.Location = new System.Drawing.Point(343, 264);
            this.PowerAnsLabel.Name = "PowerAnsLabel";
            this.PowerAnsLabel.Size = new System.Drawing.Size(21, 20);
            this.PowerAnsLabel.TabIndex = 21;
            this.PowerAnsLabel.Text = "--";
            // 
            // PriceAnsLabel
            // 
            this.PriceAnsLabel.AutoSize = true;
            this.PriceAnsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceAnsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PriceAnsLabel.Location = new System.Drawing.Point(343, 231);
            this.PriceAnsLabel.Name = "PriceAnsLabel";
            this.PriceAnsLabel.Size = new System.Drawing.Size(21, 20);
            this.PriceAnsLabel.TabIndex = 20;
            this.PriceAnsLabel.Text = "--";
            // 
            // LocationAnsLabel
            // 
            this.LocationAnsLabel.AutoSize = true;
            this.LocationAnsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationAnsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LocationAnsLabel.Location = new System.Drawing.Point(343, 171);
            this.LocationAnsLabel.Name = "LocationAnsLabel";
            this.LocationAnsLabel.Size = new System.Drawing.Size(21, 20);
            this.LocationAnsLabel.TabIndex = 19;
            this.LocationAnsLabel.Text = "--";
            // 
            // DetailsLabel
            // 
            this.DetailsLabel.AutoSize = true;
            this.DetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DetailsLabel.Location = new System.Drawing.Point(198, 372);
            this.DetailsLabel.Name = "DetailsLabel";
            this.DetailsLabel.Size = new System.Drawing.Size(65, 20);
            this.DetailsLabel.TabIndex = 18;
            this.DetailsLabel.Text = "Details";
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManufacturerLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ManufacturerLabel.Location = new System.Drawing.Point(198, 333);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(116, 20);
            this.ManufacturerLabel.TabIndex = 17;
            this.ManufacturerLabel.Text = "Manufacturer";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.QuantityLabel.Location = new System.Drawing.Point(198, 297);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(76, 20);
            this.QuantityLabel.TabIndex = 16;
            this.QuantityLabel.Text = "Quantity";
            // 
            // PowerLabel
            // 
            this.PowerLabel.AutoSize = true;
            this.PowerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PowerLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PowerLabel.Location = new System.Drawing.Point(198, 264);
            this.PowerLabel.Name = "PowerLabel";
            this.PowerLabel.Size = new System.Drawing.Size(58, 20);
            this.PowerLabel.TabIndex = 15;
            this.PowerLabel.Text = "Power";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PriceLabel.Location = new System.Drawing.Point(198, 231);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(49, 20);
            this.PriceLabel.TabIndex = 14;
            this.PriceLabel.Text = "Price";
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LocationLabel.Location = new System.Drawing.Point(198, 171);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(78, 20);
            this.LocationLabel.TabIndex = 13;
            this.LocationLabel.Text = "Location";
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(647, 98);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(71, 35);
            this.SearchButton.TabIndex = 12;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.SearchTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SearchTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextbox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.SearchTextbox.Location = new System.Drawing.Point(198, 98);
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(423, 35);
            this.SearchTextbox.TabIndex = 11;
            this.SearchTextbox.TextChanged += new System.EventHandler(this.SearchTextbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(787, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Create Account";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            this.label4.MouseEnter += new System.EventHandler(this.label4_Enter);
            this.label4.MouseLeave += new System.EventHandler(this.label4_Leave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button2.Location = new System.Drawing.Point(836, 537);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem,
            this.HelpMenuItem,
            this.hELPToolStripMenuItem1,
            this.hELPToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 10);
            this.menuStrip1.Size = new System.Drawing.Size(929, 31);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserToolStripMenuItem,
            this.ChangePassToolStripMenuItem,
            this.lOGOUTToolStripMenuItem1,
            this.eXITToolStripMenuItem1});
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(40, 19);
            this.fILEToolStripMenuItem.Text = "FILE";
            // 
            // UserToolStripMenuItem
            // 
            this.UserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cREATEACCOUNTToolStripMenuItem,
            this.dELETEACCOUNTToolStripMenuItem});
            this.UserToolStripMenuItem.Name = "UserToolStripMenuItem";
            this.UserToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.UserToolStripMenuItem.Text = "USER MANAGEMENT";
            // 
            // cREATEACCOUNTToolStripMenuItem
            // 
            this.cREATEACCOUNTToolStripMenuItem.Name = "cREATEACCOUNTToolStripMenuItem";
            this.cREATEACCOUNTToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.cREATEACCOUNTToolStripMenuItem.Text = "CREATE ACCOUNT";
            this.cREATEACCOUNTToolStripMenuItem.Click += new System.EventHandler(this.cREATEACCOUNTToolStripMenuItem_Click);
            // 
            // dELETEACCOUNTToolStripMenuItem
            // 
            this.dELETEACCOUNTToolStripMenuItem.Name = "dELETEACCOUNTToolStripMenuItem";
            this.dELETEACCOUNTToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.dELETEACCOUNTToolStripMenuItem.Text = "DELETE ACCOUNT";
            this.dELETEACCOUNTToolStripMenuItem.Click += new System.EventHandler(this.dELETEACCOUNTToolStripMenuItem_Click);
            // 
            // ChangePassToolStripMenuItem
            // 
            this.ChangePassToolStripMenuItem.Name = "ChangePassToolStripMenuItem";
            this.ChangePassToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.ChangePassToolStripMenuItem.Text = "CHANGE PASSWORD";
            this.ChangePassToolStripMenuItem.Click += new System.EventHandler(this.ChangePassToolStripMenuItem_Click);
            // 
            // lOGOUTToolStripMenuItem1
            // 
            this.lOGOUTToolStripMenuItem1.Name = "lOGOUTToolStripMenuItem1";
            this.lOGOUTToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.lOGOUTToolStripMenuItem1.Text = "LOGOUT";
            this.lOGOUTToolStripMenuItem1.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem1_Click);
            // 
            // eXITToolStripMenuItem1
            // 
            this.eXITToolStripMenuItem1.Name = "eXITToolStripMenuItem1";
            this.eXITToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.eXITToolStripMenuItem1.Text = "EXIT";
            this.eXITToolStripMenuItem1.Click += new System.EventHandler(this.eXITToolStripMenuItem1_Click);
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bACKGROUNDToolStripMenuItem});
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(46, 19);
            this.HelpMenuItem.Text = "VIEW";
            // 
            // bACKGROUNDToolStripMenuItem
            // 
            this.bACKGROUNDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bLACKToolStripMenuItem,
            this.sKYToolStripMenuItem});
            this.bACKGROUNDToolStripMenuItem.Name = "bACKGROUNDToolStripMenuItem";
            this.bACKGROUNDToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.bACKGROUNDToolStripMenuItem.Text = "BACKGROUND ";
            // 
            // bLACKToolStripMenuItem
            // 
            this.bLACKToolStripMenuItem.Name = "bLACKToolStripMenuItem";
            this.bLACKToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.bLACKToolStripMenuItem.Text = "BLACK";
            this.bLACKToolStripMenuItem.Click += new System.EventHandler(this.bLACKToolStripMenuItem_Click);
            // 
            // sKYToolStripMenuItem
            // 
            this.sKYToolStripMenuItem.Name = "sKYToolStripMenuItem";
            this.sKYToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.sKYToolStripMenuItem.Text = "GRAY";
            this.sKYToolStripMenuItem.Click += new System.EventHandler(this.sKYToolStripMenuItem_Click);
            // 
            // hELPToolStripMenuItem1
            // 
            this.hELPToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNSERTToolStripMenuItem,
            this.uPDATEToolStripMenuItem,
            this.dELETEToolStripMenuItem});
            this.hELPToolStripMenuItem1.Name = "hELPToolStripMenuItem1";
            this.hELPToolStripMenuItem1.Size = new System.Drawing.Size(90, 19);
            this.hELPToolStripMenuItem1.Text = "OPERATIONS";
            // 
            // iNSERTToolStripMenuItem
            // 
            this.iNSERTToolStripMenuItem.Name = "iNSERTToolStripMenuItem";
            this.iNSERTToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.iNSERTToolStripMenuItem.Text = "INSERT DATA";
            this.iNSERTToolStripMenuItem.Click += new System.EventHandler(this.iNSERTToolStripMenuItem_Click);
            // 
            // uPDATEToolStripMenuItem
            // 
            this.uPDATEToolStripMenuItem.Name = "uPDATEToolStripMenuItem";
            this.uPDATEToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.uPDATEToolStripMenuItem.Text = "UPDATE DATA";
            this.uPDATEToolStripMenuItem.Click += new System.EventHandler(this.uPDATEToolStripMenuItem_Click);
            // 
            // dELETEToolStripMenuItem
            // 
            this.dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
            this.dELETEToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dELETEToolStripMenuItem.Text = "DELETE DATA";
            this.dELETEToolStripMenuItem.Click += new System.EventHandler(this.dELETEToolStripMenuItem_Click);
            // 
            // hELPToolStripMenuItem2
            // 
            this.hELPToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBOUTToolStripMenuItem});
            this.hELPToolStripMenuItem2.Name = "hELPToolStripMenuItem2";
            this.hELPToolStripMenuItem2.Size = new System.Drawing.Size(47, 19);
            this.hELPToolStripMenuItem2.Text = "HELP";
            // 
            // aBOUTToolStripMenuItem
            // 
            this.aBOUTToolStripMenuItem.Name = "aBOUTToolStripMenuItem";
            this.aBOUTToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.aBOUTToolStripMenuItem.Text = "ABOUT";
            this.aBOUTToolStripMenuItem.Click += new System.EventHandler(this.aBOUTToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(282, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(202, 372);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(170, 26);
            this.textBox2.TabIndex = 3;
            this.textBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouse_clicked2);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(202, 321);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouse_clicked1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(64, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(64, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLogin.Location = new System.Drawing.Point(50, 231);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(349, 31);
            this.labelLogin.TabIndex = 8;
            this.labelLogin.Text = "Please Login To Continue";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 560);
            this.Controls.Add(this.panelHome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "pms+";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label label4;
        private TextBox SearchTextbox;
        private Button SearchButton;
        private TextBox DetailsTextbox;
        private Label ManuAnsLabel;
        private Label QuantityAnsLabel;
        private Label PowerAnsLabel;
        private Label PriceAnsLabel;
        private Label LocationAnsLabel;
        private Label DetailsLabel;
        private Label ManufacturerLabel;
        private Label QuantityLabel;
        private Label PowerLabel;
        private Label PriceLabel;
        private Label LocationLabel;
        private Button VoiceSearchButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fILEToolStripMenuItem;
        private ToolStripMenuItem UserToolStripMenuItem;
        private ToolStripMenuItem HelpMenuItem;
        private ToolStripMenuItem ChangePassToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabelImage;
        private ToolStripButton toolStripInventoryNotification;
        private ToolStripMenuItem hELPToolStripMenuItem1;
        private ToolStripMenuItem bACKGROUNDToolStripMenuItem;
        private ToolStripMenuItem bLACKToolStripMenuItem;
        private ToolStripMenuItem sKYToolStripMenuItem;
        private ToolStripMenuItem iNSERTToolStripMenuItem;
        private ToolStripMenuItem uPDATEToolStripMenuItem;
        private ToolStripMenuItem dELETEToolStripMenuItem;
        private ToolStripMenuItem hELPToolStripMenuItem2;
        private ToolStripButton toolStripButtonInsert;
        private ToolStripButton toolStripButtonUpdateDelete;
        private ToolStripButton toolStripButtonBill;
        private ToolStripButton toolStripButtonMedicalAssistant;
        private PictureBox pictureBox1;
        private Label labelNeedHelp;
        private ToolStripButton toolStripButtonShowDailyReport;
        private ToolStripButton toolStripButtonShowAllInfo;
        private ToolStripMenuItem lOGOUTToolStripMenuItem1;
        private ToolStripMenuItem eXITToolStripMenuItem1;
        private ToolStripMenuItem cREATEACCOUNTToolStripMenuItem;
        private ToolStripMenuItem dELETEACCOUNTToolStripMenuItem;
        private ToolStripMenuItem aBOUTToolStripMenuItem;
        private Label GenericNameAnsLabel;
        private Label GenericNameLabel;
    }
}

