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
            txtExePath = new TextBox();
            txtElfPath = new TextBox();
            txtParams = new TextBox();
            txtIP = new TextBox();
            btnBrowseExe = new Button();
            btnBrowseElf = new Button();
            btnStart = new Button();
            txtOutput = new TextBox();
            exeLabel = new Label();
            elfLabel = new Label();
            paramLabel = new Label();
            ipLabel = new Label();
            consoleLabel = new Label();
            SuspendLayout();
            // 
            // txtExePath
            // 
            txtExePath.Location = new Point(12, 25);
            txtExePath.Name = "txtExePath";
            txtExePath.Size = new Size(903, 23);
            txtExePath.TabIndex = 0;
            // 
            // txtElfPath
            // 
            txtElfPath.Location = new Point(12, 75);
            txtElfPath.Name = "txtElfPath";
            txtElfPath.Size = new Size(903, 23);
            txtElfPath.TabIndex = 2;
            // 
            // txtParams
            // 
            txtParams.Location = new Point(12, 125);
            txtParams.Name = "txtParams";
            txtParams.Size = new Size(731, 23);
            txtParams.TabIndex = 4;
            // 
            // txtIP
            // 
            txtIP.Location = new Point(749, 125);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(247, 23);
            txtIP.TabIndex = 5;
            // 
            // btnBrowseExe
            // 
            btnBrowseExe.Location = new Point(921, 25);
            btnBrowseExe.Name = "btnBrowseExe";
            btnBrowseExe.Size = new Size(75, 25);
            btnBrowseExe.TabIndex = 1;
            btnBrowseExe.Text = "Buscar";
            btnBrowseExe.Click += btnBrowseExe_Click;
            // 
            // btnBrowseElf
            // 
            btnBrowseElf.Location = new Point(921, 73);
            btnBrowseElf.Name = "btnBrowseElf";
            btnBrowseElf.Size = new Size(75, 25);
            btnBrowseElf.TabIndex = 3;
            btnBrowseElf.Text = "Buscar";
            btnBrowseElf.Click += btnBrowseElf_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(9, 167);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(987, 30);
            btnStart.TabIndex = 6;
            btnStart.Text = "Iniciar";
            btnStart.Click += btnStart_Click;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(9, 229);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(987, 520);
            txtOutput.TabIndex = 7;
            // 
            // exeLabel
            // 
            exeLabel.AutoSize = true;
            exeLabel.Location = new Point(12, 7);
            exeLabel.Name = "exeLabel";
            exeLabel.Size = new Size(168, 15);
            exeLabel.TabIndex = 8;
            exeLabel.Text = "Caminho do EXE do PS2 Client";
            // 
            // elfLabel
            // 
            elfLabel.AutoSize = true;
            elfLabel.Location = new Point(12, 57);
            elfLabel.Name = "elfLabel";
            elfLabel.Size = new Size(178, 15);
            elfLabel.TabIndex = 9;
            elfLabel.Text = "Caminho do ELF a ser executado";
            // 
            // paramLabel
            // 
            paramLabel.AutoSize = true;
            paramLabel.Location = new Point(12, 107);
            paramLabel.Name = "paramLabel";
            paramLabel.Size = new Size(180, 15);
            paramLabel.TabIndex = 10;
            paramLabel.Text = "Parâmetros adicionais (opcional)";
            // 
            // ipLabel
            // 
            ipLabel.AutoSize = true;
            ipLabel.Location = new Point(749, 107);
            ipLabel.Name = "ipLabel";
            ipLabel.Size = new Size(56, 15);
            ipLabel.TabIndex = 11;
            ipLabel.Text = "IP do PS2";
            // 
            // consoleLabel
            // 
            consoleLabel.AutoSize = true;
            consoleLabel.Location = new Point(12, 211);
            consoleLabel.Name = "consoleLabel";
            consoleLabel.Size = new Size(59, 15);
            consoleLabel.TabIndex = 12;
            consoleLabel.Text = "Resultado";
            // 
            // Form1
            // 
            ClientSize = new Size(1008, 761);
            Controls.Add(consoleLabel);
            Controls.Add(ipLabel);
            Controls.Add(paramLabel);
            Controls.Add(elfLabel);
            Controls.Add(exeLabel);
            Controls.Add(txtExePath);
            Controls.Add(btnBrowseExe);
            Controls.Add(txtElfPath);
            Controls.Add(btnBrowseElf);
            Controls.Add(txtParams);
            Controls.Add(txtIP);
            Controls.Add(btnStart);
            Controls.Add(txtOutput);
            Name = "Form1";
            Text = "PS2 Client Launcher";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtExePath;
        private System.Windows.Forms.TextBox txtElfPath;
        private System.Windows.Forms.TextBox txtParams;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnBrowseExe;
        private System.Windows.Forms.Button btnBrowseElf;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtOutput;
        private Label exeLabel;
        private Label elfLabel;
        private Label paramLabel;
        private Label ipLabel;
        private Label consoleLabel;
    }
}
