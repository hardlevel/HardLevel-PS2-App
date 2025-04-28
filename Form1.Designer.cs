namespace HardLevel_PS2_App
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtExePath = new System.Windows.Forms.TextBox();
            this.txtElfPath = new System.Windows.Forms.TextBox();
            this.txtParams = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnBrowseExe = new System.Windows.Forms.Button();
            this.btnBrowseElf = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // txtExePath
            this.txtExePath.Location = new System.Drawing.Point(12, 25);
            this.txtExePath.Size = new System.Drawing.Size(400, 23);

            // btnBrowseExe
            this.btnBrowseExe.Location = new System.Drawing.Point(418, 24);
            this.btnBrowseExe.Size = new System.Drawing.Size(75, 25);
            this.btnBrowseExe.Text = "Buscar";
            this.btnBrowseExe.Click += new System.EventHandler(this.btnBrowseExe_Click);

            // txtElfPath
            this.txtElfPath.Location = new System.Drawing.Point(12, 75);
            this.txtElfPath.Size = new System.Drawing.Size(400, 23);

            // btnBrowseElf
            this.btnBrowseElf.Location = new System.Drawing.Point(418, 74);
            this.btnBrowseElf.Size = new System.Drawing.Size(75, 25);
            this.btnBrowseElf.Text = "Buscar";
            this.btnBrowseElf.Click += new System.EventHandler(this.btnBrowseElf_Click);

            // txtParams
            this.txtParams.Location = new System.Drawing.Point(12, 125);
            this.txtParams.Size = new System.Drawing.Size(481, 23);

            // txtIP
            this.txtIP.Location = new System.Drawing.Point(12, 175);
            this.txtIP.Size = new System.Drawing.Size(481, 23);

            // btnStart
            this.btnStart.Location = new System.Drawing.Point(12, 215);
            this.btnStart.Size = new System.Drawing.Size(481, 30);
            this.btnStart.Text = "Iniciar";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);

            // txtOutput
            this.txtOutput.Location = new System.Drawing.Point(12, 260);
            this.txtOutput.Multiline = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(481, 180);

            // Form1
            this.ClientSize = new System.Drawing.Size(505, 460);
            this.Controls.Add(this.txtExePath);
            this.Controls.Add(this.btnBrowseExe);
            this.Controls.Add(this.txtElfPath);
            this.Controls.Add(this.btnBrowseElf);
            this.Controls.Add(this.txtParams);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtOutput);
            this.Name = "Form1";
            this.Text = "PS2 Client Launcher";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtExePath;
        private System.Windows.Forms.TextBox txtElfPath;
        private System.Windows.Forms.TextBox txtParams;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnBrowseExe;
        private System.Windows.Forms.Button btnBrowseElf;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtOutput;
    }
}
