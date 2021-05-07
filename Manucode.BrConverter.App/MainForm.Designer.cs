namespace Manucode.BrConverter.App
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.lblFolder = new System.Windows.Forms.Label();
            this.chkRecursive = new System.Windows.Forms.CheckBox();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblNumberFiles = new System.Windows.Forms.Label();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.txtOutputFolder = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.picCar = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(23, 32);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(43, 15);
            this.lblFolder.TabIndex = 0;
            this.lblFolder.Text = "Folder:";
            // 
            // chkRecursive
            // 
            this.chkRecursive.AutoSize = true;
            this.chkRecursive.Checked = true;
            this.chkRecursive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRecursive.Location = new System.Drawing.Point(23, 58);
            this.chkRecursive.Name = "chkRecursive";
            this.chkRecursive.Size = new System.Drawing.Size(124, 19);
            this.chkRecursive.TabIndex = 1;
            this.chkRecursive.Text = "Include Subfolders";
            this.chkRecursive.UseVisualStyleBackColor = true;
            this.chkRecursive.CheckedChanged += new System.EventHandler(this.chkRecursive_CheckedChanged);
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(72, 29);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.ReadOnly = true;
            this.txtFolder.Size = new System.Drawing.Size(337, 23);
            this.txtFolder.TabIndex = 2;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(458, 29);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(100, 70);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(23, 105);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(535, 302);
            this.txtOutput.TabIndex = 4;
            this.txtOutput.WordWrap = false;
            // 
            // lblNumberFiles
            // 
            this.lblNumberFiles.AutoSize = true;
            this.lblNumberFiles.Location = new System.Drawing.Point(23, 84);
            this.lblNumberFiles.Name = "lblNumberFiles";
            this.lblNumberFiles.Size = new System.Drawing.Size(99, 15);
            this.lblNumberFiles.TabIndex = 5;
            this.lblNumberFiles.Text = "Files to convert: 0";
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(415, 29);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(27, 23);
            this.btnSelectFolder.TabIndex = 6;
            this.btnSelectFolder.Text = "...";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // txtOutputFolder
            // 
            this.txtOutputFolder.Location = new System.Drawing.Point(77, 415);
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.ReadOnly = true;
            this.txtOutputFolder.Size = new System.Drawing.Size(365, 23);
            this.txtOutputFolder.TabIndex = 8;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(23, 418);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(48, 15);
            this.lblOutput.TabIndex = 7;
            this.lblOutput.Text = "Output:";
            // 
            // picCar
            // 
            this.picCar.Image = global::Manucode.BrConverter.App.Properties.Resources.bmw;
            this.picCar.Location = new System.Drawing.Point(573, 29);
            this.picCar.Name = "picCar";
            this.picCar.Size = new System.Drawing.Size(478, 378);
            this.picCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCar.TabIndex = 9;
            this.picCar.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(573, 415);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(478, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.picCar);
            this.Controls.Add(this.txtOutputFolder);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.lblNumberFiles);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.chkRecursive);
            this.Controls.Add(this.lblFolder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "BR4 to MP3 Converter by Manucode";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.CheckBox chkRecursive;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblNumberFiles;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.TextBox txtOutputFolder;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.PictureBox picCar;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

