using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FAR_Review_File_Generator
{
    public partial class FileGenerator1 : Form
    {
        public FileGenerator1()
        {
            InitializeComponent();
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            DataObject o = (DataObject)Clipboard.GetDataObject();
            if (o.GetDataPresent(DataFormats.StringFormat))
            {
                string[] pastedRows = Regex.Split(o.GetData(DataFormats.StringFormat).ToString().TrimEnd("\r\n".ToCharArray()), "\r");
                int currentRow = 0;
                foreach (string pastedRow in pastedRows)
                {
                    DataGridViewRow gridRow = new DataGridViewRow();
                    gridRow.CreateCells(dataGridView, pastedRow.Split(new char[] { '\t' }));
                    dataGridView.Rows.Insert(currentRow, gridRow);
                    currentRow++;
                }
            }
        }

        private void btnTemplateBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Select template file";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                textBoxTemplateDir.Text = fdlg.FileName;
            }
        }

        private void buttonBrowseDestination_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxDestinationDir.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            int rowCount = dataGridView.Rows.Count - 1;
            int successCount = 0;
            int failureCount = 0;

            for(int counter=0; counter < rowCount; counter++)
            {
                if (dataGridView.Rows[counter] != null && dataGridView.Rows[counter].Cells[0].Value != null)
                {
                    try
                    {
                        string customerName = dataGridView.Rows[counter].Cells[0].Value.ToString().Trim();

                        string sourceFile = textBoxTemplateDir.Text;
                        string fileName = Path.GetFileName(sourceFile);
                        string destinationFile =
                            Path.Combine(textBoxDestinationDir.Text, fileName.Replace(".docx", "") + customerName + ".docx");
                                        
                        File.Copy(sourceFile, destinationFile, false);
                        successCount++;
                    }
                    catch(Exception ex)
                    {
                        failureCount++;
                    }
                }
                else
                    break;
            }
            

            MessageBox.Show("Done! " + successCount + " file(s) copied. " + failureCount + " failures.");
        }
    }
}
