
namespace FAR_Review_File_Generator
{
    partial class FormFileGenerator
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
            this.textBoxDestinationDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTemplateDir = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OnboardingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Generate = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnBrowseTemplate = new System.Windows.Forms.Button();
            this.folderBrowserDestination = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonBrowseDestination = new System.Windows.Forms.Button();
            this.labelBuildVersion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSelectedCount = new System.Windows.Forms.Label();
            this.labelErrors = new System.Windows.Forms.Label();
            this.buttonValidate = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDestinationDir
            // 
            this.textBoxDestinationDir.Location = new System.Drawing.Point(295, 215);
            this.textBoxDestinationDir.Name = "textBoxDestinationDir";
            this.textBoxDestinationDir.Size = new System.Drawing.Size(949, 38);
            this.textBoxDestinationDir.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Destination folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Template file";
            // 
            // textBoxTemplateDir
            // 
            this.textBoxTemplateDir.Location = new System.Drawing.Point(293, 140);
            this.textBoxTemplateDir.Name = "textBoxTemplateDir";
            this.textBoxTemplateDir.Size = new System.Drawing.Size(951, 38);
            this.textBoxTemplateDir.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.CustomerName,
            this.IC,
            this.OnboardingID});
            this.dataGridView.Location = new System.Drawing.Point(45, 436);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 30;
            this.dataGridView.RowTemplate.Height = 40;
            this.dataGridView.Size = new System.Drawing.Size(1444, 780);
            this.dataGridView.TabIndex = 6;
            this.dataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView_RowsAdded);
            this.dataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView_RowsRemoved);
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 12;
            this.Date.Name = "Date";
            this.Date.Width = 250;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Name";
            this.CustomerName.MinimumWidth = 12;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Width = 175;
            // 
            // IC
            // 
            this.IC.HeaderText = "IC";
            this.IC.MinimumWidth = 12;
            this.IC.Name = "IC";
            this.IC.Width = 250;
            // 
            // OnboardingID
            // 
            this.OnboardingID.HeaderText = "Onboarding ID";
            this.OnboardingID.MinimumWidth = 12;
            this.OnboardingID.Name = "OnboardingID";
            this.OnboardingID.Width = 170;
            // 
            // Generate
            // 
            this.Generate.BackColor = System.Drawing.SystemColors.Control;
            this.Generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate.Location = new System.Drawing.Point(1266, 349);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(223, 71);
            this.Generate.TabIndex = 8;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(792, 349);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(223, 71);
            this.btnPaste.TabIndex = 7;
            this.btnPaste.Text = "Paste";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnBrowseTemplate
            // 
            this.btnBrowseTemplate.Location = new System.Drawing.Point(1266, 138);
            this.btnBrowseTemplate.Name = "btnBrowseTemplate";
            this.btnBrowseTemplate.Size = new System.Drawing.Size(223, 54);
            this.btnBrowseTemplate.TabIndex = 2;
            this.btnBrowseTemplate.Text = "Browse..";
            this.btnBrowseTemplate.UseVisualStyleBackColor = true;
            this.btnBrowseTemplate.Click += new System.EventHandler(this.btnTemplateBrowse_Click);
            // 
            // buttonBrowseDestination
            // 
            this.buttonBrowseDestination.Location = new System.Drawing.Point(1266, 215);
            this.buttonBrowseDestination.Name = "buttonBrowseDestination";
            this.buttonBrowseDestination.Size = new System.Drawing.Size(223, 54);
            this.buttonBrowseDestination.TabIndex = 4;
            this.buttonBrowseDestination.Text = "Browse..";
            this.buttonBrowseDestination.UseVisualStyleBackColor = true;
            this.buttonBrowseDestination.Click += new System.EventHandler(this.buttonBrowseDestination_Click);
            // 
            // labelBuildVersion
            // 
            this.labelBuildVersion.AutoSize = true;
            this.labelBuildVersion.Location = new System.Drawing.Point(1362, 54);
            this.labelBuildVersion.Name = "labelBuildVersion";
            this.labelBuildVersion.Size = new System.Drawing.Size(127, 32);
            this.labelBuildVersion.TabIndex = 1;
            this.labelBuildVersion.Text = "Build 1.3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(531, 46);
            this.label3.TabIndex = 1;
            this.label3.Text = "FAR Review File Generator";
            // 
            // labelSelectedCount
            // 
            this.labelSelectedCount.AutoSize = true;
            this.labelSelectedCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedCount.Location = new System.Drawing.Point(39, 388);
            this.labelSelectedCount.Name = "labelSelectedCount";
            this.labelSelectedCount.Size = new System.Drawing.Size(132, 32);
            this.labelSelectedCount.TabIndex = 1;
            this.labelSelectedCount.Text = "0 records";
            // 
            // labelErrors
            // 
            this.labelErrors.AutoSize = true;
            this.labelErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrors.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelErrors.Location = new System.Drawing.Point(247, 388);
            this.labelErrors.Name = "labelErrors";
            this.labelErrors.Size = new System.Drawing.Size(210, 32);
            this.labelErrors.TabIndex = 1;
            this.labelErrors.Text = "No errors found";
            this.labelErrors.Visible = false;
            this.labelErrors.Click += new System.EventHandler(this.labelErrors_Click);
            // 
            // buttonValidate
            // 
            this.buttonValidate.Location = new System.Drawing.Point(1029, 349);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(223, 71);
            this.buttonValidate.TabIndex = 7;
            this.buttonValidate.Text = "Validate";
            this.buttonValidate.UseVisualStyleBackColor = true;
            this.buttonValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // FormFileGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1554, 1970);
            this.Controls.Add(this.buttonBrowseDestination);
            this.Controls.Add(this.btnBrowseTemplate);
            this.Controls.Add(this.buttonValidate);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.textBoxTemplateDir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelBuildVersion);
            this.Controls.Add(this.labelErrors);
            this.Controls.Add(this.labelSelectedCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDestinationDir);
            this.Name = "FormFileGenerator";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.Text = "FAR Review File Generator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDestinationDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTemplateDir;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Button btnPaste;
        //private System.Windows.Forms.Button btnBrowseDestination;
        private System.Windows.Forms.Button btnBrowseTemplate;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDestination;
        private System.Windows.Forms.Button buttonBrowseDestination;
        private System.Windows.Forms.Label labelBuildVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSelectedCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IC;
        private System.Windows.Forms.DataGridViewTextBoxColumn OnboardingID;
        private System.Windows.Forms.Label labelErrors;
        private System.Windows.Forms.Button buttonValidate;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

