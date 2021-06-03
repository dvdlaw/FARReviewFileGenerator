
namespace FAR_Review_File_Generator
{
    partial class FileGenerator1
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
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Generate = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnBrowseTemplate = new System.Windows.Forms.Button();
            this.folderBrowserDestination = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonBrowseDestination = new System.Windows.Forms.Button();
            this.labelBuildVersion = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDestinationDir
            // 
            this.textBoxDestinationDir.Location = new System.Drawing.Point(318, 212);
            this.textBoxDestinationDir.Name = "textBoxDestinationDir";
            this.textBoxDestinationDir.Size = new System.Drawing.Size(408, 38);
            this.textBoxDestinationDir.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Destination directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Template directory";
            // 
            // textBoxTemplateDir
            // 
            this.textBoxTemplateDir.Enabled = false;
            this.textBoxTemplateDir.Location = new System.Drawing.Point(318, 127);
            this.textBoxTemplateDir.Name = "textBoxTemplateDir";
            this.textBoxTemplateDir.Size = new System.Drawing.Size(408, 38);
            this.textBoxTemplateDir.TabIndex = 2;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerName});
            this.dataGridView.Location = new System.Drawing.Point(46, 434);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 102;
            this.dataGridView.RowTemplate.Height = 40;
            this.dataGridView.Size = new System.Drawing.Size(954, 349);
            this.dataGridView.TabIndex = 3;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.MinimumWidth = 12;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Width = 250;
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(777, 326);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(223, 71);
            this.Generate.TabIndex = 5;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(536, 326);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(223, 71);
            this.btnPaste.TabIndex = 5;
            this.btnPaste.Text = "Paste";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnBrowseTemplate
            // 
            this.btnBrowseTemplate.Location = new System.Drawing.Point(777, 113);
            this.btnBrowseTemplate.Name = "btnBrowseTemplate";
            this.btnBrowseTemplate.Size = new System.Drawing.Size(223, 71);
            this.btnBrowseTemplate.TabIndex = 5;
            this.btnBrowseTemplate.Text = "Browse";
            this.btnBrowseTemplate.UseVisualStyleBackColor = true;
            this.btnBrowseTemplate.Click += new System.EventHandler(this.btnTemplateBrowse_Click);
            // 
            // buttonBrowseDestination
            // 
            this.buttonBrowseDestination.Location = new System.Drawing.Point(777, 198);
            this.buttonBrowseDestination.Name = "buttonBrowseDestination";
            this.buttonBrowseDestination.Size = new System.Drawing.Size(223, 71);
            this.buttonBrowseDestination.TabIndex = 6;
            this.buttonBrowseDestination.Text = "Browse";
            this.buttonBrowseDestination.UseVisualStyleBackColor = true;
            this.buttonBrowseDestination.Click += new System.EventHandler(this.buttonBrowseDestination_Click);
            // 
            // labelBuildVersion
            // 
            this.labelBuildVersion.AutoSize = true;
            this.labelBuildVersion.Location = new System.Drawing.Point(873, 28);
            this.labelBuildVersion.Name = "labelBuildVersion";
            this.labelBuildVersion.Size = new System.Drawing.Size(127, 32);
            this.labelBuildVersion.TabIndex = 1;
            this.labelBuildVersion.Text = "Build 1.0";
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
            // FileGenerator1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 873);
            this.Controls.Add(this.buttonBrowseDestination);
            this.Controls.Add(this.btnBrowseTemplate);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.textBoxTemplateDir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelBuildVersion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDestinationDir);
            this.Name = "FileGenerator1";
            this.Text = "FAR Review File Generator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.Button buttonBrowseDestination;
        private System.Windows.Forms.Label labelBuildVersion;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label3;
    }
}

