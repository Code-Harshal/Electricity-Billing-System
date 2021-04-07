namespace ElectricityBilling
{
    partial class MasterPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterPage));
            this.panelSide = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meterConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitChargeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitChargeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billGenerateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billPrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payAmountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelSide.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelSide.Controls.Add(this.panel1);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(119, 631);
            this.panelSide.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(169, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 67);
            this.panel1.TabIndex = 0;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(119, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1025, 58);
            this.panelHeader.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Castellar", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(296, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Electricity Billing System";
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelFooter.Controls.Add(this.label2);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(119, 601);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1025, 30);
            this.panelFooter.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(873, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Copyright act 2019-2020";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(85)))));
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMain.ForeColor = System.Drawing.Color.White;
            this.panelMain.Location = new System.Drawing.Point(119, 58);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1025, 543);
            this.panelMain.TabIndex = 3;
           // this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(100)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.connectionToolStripMenuItem,
            this.unitToolStripMenuItem,
            this.billGenerateToolStripMenuItem,
            this.paymentToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1025, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createCustomerToolStripMenuItem,
            this.viewCustomerToolStripMenuItem});
            this.customerToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.customerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("customerToolStripMenuItem.Image")));
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(101, 21);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // createCustomerToolStripMenuItem
            // 
            this.createCustomerToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.createCustomerToolStripMenuItem.Name = "createCustomerToolStripMenuItem";
            this.createCustomerToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.createCustomerToolStripMenuItem.Text = "Create Customer";
            this.createCustomerToolStripMenuItem.Click += new System.EventHandler(this.createCustomerToolStripMenuItem_Click);
            // 
            // viewCustomerToolStripMenuItem
            // 
            this.viewCustomerToolStripMenuItem.Name = "viewCustomerToolStripMenuItem";
            this.viewCustomerToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.viewCustomerToolStripMenuItem.Text = "View Customer";
            this.viewCustomerToolStripMenuItem.Click += new System.EventHandler(this.viewCustomerToolStripMenuItem_Click);
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meterConnectionToolStripMenuItem});
            this.connectionToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.connectionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("connectionToolStripMenuItem.Image")));
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(111, 21);
            this.connectionToolStripMenuItem.Text = "Connection";
            // 
            // meterConnectionToolStripMenuItem
            // 
            this.meterConnectionToolStripMenuItem.Name = "meterConnectionToolStripMenuItem";
            this.meterConnectionToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.meterConnectionToolStripMenuItem.Text = "Meter Connection";
            this.meterConnectionToolStripMenuItem.Click += new System.EventHandler(this.meterConnectionToolStripMenuItem_Click);
            // 
            // unitToolStripMenuItem
            // 
            this.unitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unitChargeToolStripMenuItem,
            this.unitChargeDetailsToolStripMenuItem});
            this.unitToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.unitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("unitToolStripMenuItem.Image")));
            this.unitToolStripMenuItem.Name = "unitToolStripMenuItem";
            this.unitToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.unitToolStripMenuItem.Text = "Unit";
            // 
            // unitChargeToolStripMenuItem
            // 
            this.unitChargeToolStripMenuItem.Name = "unitChargeToolStripMenuItem";
            this.unitChargeToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.unitChargeToolStripMenuItem.Text = "Unit Charge";
            this.unitChargeToolStripMenuItem.Click += new System.EventHandler(this.unitChargeToolStripMenuItem_Click);
            // 
            // unitChargeDetailsToolStripMenuItem
            // 
            this.unitChargeDetailsToolStripMenuItem.Name = "unitChargeDetailsToolStripMenuItem";
            this.unitChargeDetailsToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.unitChargeDetailsToolStripMenuItem.Text = "Unit Charge Details";
            this.unitChargeDetailsToolStripMenuItem.Click += new System.EventHandler(this.unitChargeDetailsToolStripMenuItem_Click);
            // 
            // billGenerateToolStripMenuItem
            // 
            this.billGenerateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readingToolStripMenuItem,
            this.billPrintToolStripMenuItem});
            this.billGenerateToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billGenerateToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.billGenerateToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("billGenerateToolStripMenuItem.Image")));
            this.billGenerateToolStripMenuItem.Name = "billGenerateToolStripMenuItem";
            this.billGenerateToolStripMenuItem.Size = new System.Drawing.Size(124, 21);
            this.billGenerateToolStripMenuItem.Text = "Bill Generate";
            // 
            // readingToolStripMenuItem
            // 
            this.readingToolStripMenuItem.Name = "readingToolStripMenuItem";
            this.readingToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.readingToolStripMenuItem.Text = "Reading";
            this.readingToolStripMenuItem.Click += new System.EventHandler(this.readingToolStripMenuItem_Click);
            // 
            // billPrintToolStripMenuItem
            // 
            this.billPrintToolStripMenuItem.Name = "billPrintToolStripMenuItem";
            this.billPrintToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.billPrintToolStripMenuItem.Text = "Bill Print";
            this.billPrintToolStripMenuItem.Click += new System.EventHandler(this.billPrintToolStripMenuItem_Click);
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.payAmountToolStripMenuItem,
            this.paymentDetailsToolStripMenuItem});
            this.paymentToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.paymentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("paymentToolStripMenuItem.Image")));
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.paymentToolStripMenuItem.Text = "Payment";
            // 
            // payAmountToolStripMenuItem
            // 
            this.payAmountToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("payAmountToolStripMenuItem.Image")));
            this.payAmountToolStripMenuItem.Name = "payAmountToolStripMenuItem";
            this.payAmountToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.payAmountToolStripMenuItem.Text = "Pay Amount";
            this.payAmountToolStripMenuItem.Click += new System.EventHandler(this.payAmountToolStripMenuItem_Click);
            // 
            // paymentDetailsToolStripMenuItem
            // 
            this.paymentDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("paymentDetailsToolStripMenuItem.Image")));
            this.paymentDetailsToolStripMenuItem.Name = "paymentDetailsToolStripMenuItem";
            this.paymentDetailsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.paymentDetailsToolStripMenuItem.Text = "Payment Details";
            this.paymentDetailsToolStripMenuItem.Click += new System.EventHandler(this.paymentDetailsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(119, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1025, 25);
            this.panel2.TabIndex = 1;
            // 
            // MasterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1144, 631);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MasterPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MasterPage";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MasterPage_Load);
            this.panelSide.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meterConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unitChargeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unitChargeDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billGenerateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billPrintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payAmountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentDetailsToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}