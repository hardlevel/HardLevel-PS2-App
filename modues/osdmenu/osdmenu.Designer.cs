namespace HardLevel_PS2_App.modues.osdmenu
{
    partial class osdmenu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnLoadConfig;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSettings;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.Button btnNewConfig;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelItems;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnLoadConfig = new System.Windows.Forms.Button();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.btnNewConfig = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.flowLayoutPanelSettings = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelItems = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();

            // btnLoadConfig
            this.btnLoadConfig.Location = new System.Drawing.Point(12, 12);
            this.btnLoadConfig.Size = new System.Drawing.Size(120, 30);
            this.btnLoadConfig.Text = "Carregar CNF";
            this.btnLoadConfig.Click += new System.EventHandler(this.btnLoadConfig_Click);

            // btnSaveConfig
            this.btnSaveConfig.Location = new System.Drawing.Point(140, 12);
            this.btnSaveConfig.Size = new System.Drawing.Size(120, 30);
            this.btnSaveConfig.Text = "Salvar CNF";
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);

            // btnNewConfig
            this.btnNewConfig.Location = new System.Drawing.Point(270, 12);
            this.btnNewConfig.Size = new System.Drawing.Size(120, 30);
            this.btnNewConfig.Text = "Novo CNF";
            this.btnNewConfig.Click += new System.EventHandler(this.btnNewConfig_Click);

            // btnAddItem
            this.btnAddItem.Location = new System.Drawing.Point(400, 12);
            this.btnAddItem.Size = new System.Drawing.Size(160, 30);
            this.btnAddItem.Text = "Adicionar Item do Menu";
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);

            // flowLayoutPanelSettings
            this.flowLayoutPanelSettings.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.flowLayoutPanelSettings.AutoScroll = true;
            this.flowLayoutPanelSettings.Location = new System.Drawing.Point(12, 50);
            this.flowLayoutPanelSettings.Size = new System.Drawing.Size(760, 250);

            // flowLayoutPanelItems
            this.flowLayoutPanelItems.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.flowLayoutPanelItems.AutoScroll = true;
            this.flowLayoutPanelItems.Location = new System.Drawing.Point(12, 310);
            this.flowLayoutPanelItems.Size = new System.Drawing.Size(760, 240);

            // OsdMenuForm
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnLoadConfig);
            this.Controls.Add(this.btnSaveConfig);
            this.Controls.Add(this.btnNewConfig);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.flowLayoutPanelSettings);
            this.Controls.Add(this.flowLayoutPanelItems);
            this.Text = "Editor OSDMenu CNF";
            this.ResumeLayout(false);
        }
    }
}