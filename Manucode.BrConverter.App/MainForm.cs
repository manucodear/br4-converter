using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manucode.BrConverter.App
{
    public partial class MainForm : Form
    {
        private Converter converter;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            folderBrowser = new FolderBrowserDialog();
            if(ShowFolderDialog() != DialogResult.OK) this.Close();
            this.Activate();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            txtOutput.Text = string.Empty;
            SetControlEnable(false);
            try
            {
                converter.Convert();
            }
            catch(Exception exception)
            {
                txtOutput.Text = exception.Message;
            }
            finally
            {
                SetControlEnable(true);
            }
        }

        private void SetControlEnable(bool enable)
        {
            txtFolder.Enabled = enable;
            chkRecursive.Enabled = enable;
            btnConvert.Enabled = enable;
        }

        private void SetConverter()
        {
            converter = new Converter(txtFolder.Text, chkRecursive.Checked);
            converter.OutputCallback = text => txtOutput.AppendText($"{text}\r\n");
            lblNumberFiles.Text = $"Files to convert: {converter.NumberFiles}";
            txtOutputFolder.Text = converter.OutputFolder;
            progressBar1.Maximum = converter.NumberFiles;
            progressBar1.Step = 1;
            progressBar1.Value = 0;
            converter.ProgressCallback = files => progressBar1.Value = files;
        }

        private DialogResult ShowFolderDialog()
        {
            var dialog = folderBrowser.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                txtFolder.Text = folderBrowser.SelectedPath;
                SetConverter();
            }
            return dialog;
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            ShowFolderDialog();
        }

        private void chkRecursive_CheckedChanged(object sender, EventArgs e)
        {
            SetConverter();
        }
    }
}
