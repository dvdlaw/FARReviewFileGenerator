using DocumentFormat.OpenXml.Packaging;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FAR_Review_File_Generator
{
    public partial class FormFileGenerator : Form
    {
        public FormFileGenerator()
        {
            InitializeComponent();
            labelSelectedCount.Text = "";
            dateTimePicker.Value = DateTime.Now.AddDays(-1);
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

            labelSelectedCount.Text = dataGridView.Rows.Count - 1 + " records";
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
                        string customerName = dataGridView.Rows[counter].Cells[0].Value.ToString()
                                                    .Replace("/","")
                                                    .Replace(@"\", "")
                                                    .Trim();
                        string customerID = dataGridView.Rows[counter].Cells[1].Value.ToString().Trim().Insert(6,"-").Insert(9, "-");
                        string customerOnboardingID = dataGridView.Rows[counter].Cells[2].Value.ToString().Trim();
                        string applicationDate = dateTimePicker.Value.ToString("yyyy-MM-dd");

                        string sourceFile = textBoxTemplateDir.Text;
                        string fileName = Path.GetFileName(sourceFile);
                        string destinationFile = Path.Combine(textBoxDestinationDir.Text, dateTimePicker.Value.ToString("yyyyMMdd") + fileName.Replace(".docx", "") + customerName + ".docx");
                                       
                        //1. Copy file
                        File.Copy(sourceFile, destinationFile, false);

                        //2. Replace details into file
                        SearchAndReplace(destinationFile, customerName, customerID, customerOnboardingID, applicationDate);

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

        public static void SearchAndReplace(string document, string customerName, string customerID, string customerOnboardingID, string applicationDate)
        {
            using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(document, true))
            {
                string docText = null;
                using (StreamReader sr = new StreamReader(wordDoc.MainDocumentPart.GetStream()))
                {
                    docText = sr.ReadToEnd();
                }

                docText = docText.Replace("ApplicantName", customerName);
                docText = docText.Replace("MyKadNo", customerID);
                docText = docText.Replace("ApplicationDate", applicationDate);
                docText = docText.Replace("OnboardingID", customerOnboardingID);

                using (StreamWriter sw = new StreamWriter(wordDoc.MainDocumentPart.GetStream(FileMode.Create)))
                {
                    sw.Write(docText);
                }
            }
        }

        private void dataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            labelSelectedCount.Text = dataGridView.Rows.Count - 1 + " records";
        }

        private void dataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            labelSelectedCount.Text = dataGridView.Rows.Count - 1 + " records";
        }
    }
}
