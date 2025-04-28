using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace HardLevel_PS2_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowseExe_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Executável PS2Client (*.exe)|*.exe";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtExePath.Text = ofd.FileName;
            }
        }

        private void btnBrowseElf_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Arquivo ELF (*.elf)|*.elf";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtElfPath.Text = ofd.FileName;
            }
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            string exePath = txtExePath.Text;
            string elfPath = txtElfPath.Text;
            string additionalParams = txtParams.Text;
            string ipAddress = txtIP.Text;

            if (!File.Exists(exePath))
            {
                MessageBox.Show("Arquivo ps2client.exe nao encontrado.");
                return;
            }

            if (!File.Exists(elfPath))
            {
                MessageBox.Show("Arquivo ELF nao encontrado.");
                return;
            }

            string arguments = $"-h {ipAddress} execee host:{Path.GetFileName(elfPath)} {additionalParams}";

            txtOutput.Clear();
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = exePath,
                    Arguments = arguments,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true,
                    WorkingDirectory = Path.GetDirectoryName(elfPath) // onde esta o .elf
                };

                using (Process proc = new Process())
                {
                    proc.StartInfo = psi;

                    proc.OutputDataReceived += (s, ev) => { if (ev.Data != null) AppendOutput(ev.Data); };
                    proc.ErrorDataReceived += (s, ev) => { if (ev.Data != null) AppendOutput(ev.Data); };

                    proc.Start();
                    proc.BeginOutputReadLine();
                    proc.BeginErrorReadLine();

                    await proc.WaitForExitAsync();
                }
            }
            catch (Exception ex)
            {
                AppendOutput($"Erro: {ex.Message}");
            }
        }

        private void AppendOutput(string text)
        {
            if (txtOutput.InvokeRequired)
            {
                txtOutput.Invoke(new Action<string>(AppendOutput), text);
            }
            else
            {
                txtOutput.AppendText(text + Environment.NewLine);
            }
        }
    }
}
