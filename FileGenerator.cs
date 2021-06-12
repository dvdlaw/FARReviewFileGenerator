using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
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
        }

        List<string> duplicatedNames = new List<string>();
        List<string> invalidICs = new List<string>();
        bool unableToValidate = false;
        List<ErrorObject> errorObjects = new List<ErrorObject>();

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
                        string applicationDate = dataGridView.Rows[counter].Cells[0].Value.ToString().Trim().Substring(0, 10);
                        string customerName = dataGridView.Rows[counter].Cells[1].Value.ToString()
                                                    .Replace("/","")
                                                    .Replace(@"\", "")
                                                    .Trim();
                        string customerID = dataGridView.Rows[counter].Cells[2].Value.ToString().Trim().Insert(6,"-").Insert(9, "-");
                        string customerOnboardingID = dataGridView.Rows[counter].Cells[3].Value.ToString().Trim();

                        string sourceFile = textBoxTemplateDir.Text;
                        string fileName = Path.GetFileName(sourceFile);
                        string destinationFile = Path.Combine(textBoxDestinationDir.Text, applicationDate.Replace("-","") + fileName.Replace(".docx", "") + customerName + ".docx");
                                       
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

        public void SearchAndReplace(string document, string customerName, string customerID, string customerOnboardingID, string applicationDate)
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

        public void ValidateData()
        {
            unableToValidate = false;
            duplicatedNames = new List<string>();
            invalidICs = new List<string>();

            int rowCount = dataGridView.Rows.Count - 1;
            for (int counter = 0; counter < rowCount; counter++)
            {
                try
                {
                    if (dataGridView.Rows[counter] != null && dataGridView.Rows[counter].Cells[0].Value != null)
                    {
                        //1. Check duplicated name
                        string customerName = dataGridView.Rows[counter].Cells[1].Value.ToString().Trim();

                        for (int innerCounter = counter + 1; innerCounter < rowCount; innerCounter++)
                        {                            
                            string innerCustomerName = dataGridView.Rows[innerCounter].Cells[1].Value.ToString().Trim();

                            if (customerName.Equals(innerCustomerName, StringComparison.OrdinalIgnoreCase) && !duplicatedNames.Exists(x => x.Equals(innerCustomerName)))
                                duplicatedNames.Add(innerCustomerName);
                        }

                        //2. Check invalid IC
                        string customerID = dataGridView.Rows[counter].Cells[2].Value.ToString().Trim();
                        if (customerID.Length != 12 && !invalidICs.Exists(x => x.Equals(customerID)))
                            invalidICs.Add(customerID);
                    }
                }
                catch(Exception ex)
                {
                    unableToValidate = true;
                    break;
                }
            }

            if (unableToValidate)
                labelErrors.Text = "Invalid data. Check pasted records";
            else if (duplicatedNames.Count + invalidICs.Count > 0)
            {
                SetErrorObjects();
                labelErrors.Text = errorObjects.Count + " errors found";
            }
            else
                labelErrors.Text = "No errors found";

            labelErrors.Visible = true;
        }


        private void dataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            labelSelectedCount.Text = dataGridView.Rows.Count - 1 + " records";
        }

        private void dataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            labelSelectedCount.Text = dataGridView.Rows.Count - 1 + " records";
        }

        private void labelErrors_Click(object sender, EventArgs e)
        {
            if (unableToValidate)
                return;

            var formPopup = new FormErrorList();
            formPopup.InitializeErrorObjects(errorObjects);
            formPopup.Show(this);
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            ValidateData();
        }

        private void SetErrorObjects()
        {
            errorObjects = new List<ErrorObject>();

            foreach (string name in duplicatedNames)
            {
                int rowCount = dataGridView.Rows.Count - 1;
                for (int counter = 0; counter < rowCount; counter++)
                {
                    if (dataGridView.Rows[counter].Cells[1].Value.ToString().Trim().Equals(name, StringComparison.OrdinalIgnoreCase))
                        errorObjects.Add(new ErrorObject()
                        {
                            CustomerIC = dataGridView.Rows[counter].Cells[2].Value.ToString().Trim(),
                            CustomerName = dataGridView.Rows[counter].Cells[1].Value.ToString().Trim(),
                            ErrorMessage = "Duplicated name"
                        });
                }
            }

            foreach (string ic in invalidICs)
            {
                int rowCount = dataGridView.Rows.Count - 1;
                for (int counter = 0; counter < rowCount; counter++)
                {
                    if (dataGridView.Rows[counter].Cells[2].Value.ToString().Trim().Equals(ic, StringComparison.OrdinalIgnoreCase))
                        errorObjects.Add(new ErrorObject()
                        {
                            CustomerIC = dataGridView.Rows[counter].Cells[2].Value.ToString().Trim(),
                            CustomerName = dataGridView.Rows[counter].Cells[1].Value.ToString().Trim(),
                            ErrorMessage = "Invalid IC"
                        });
                }
            }
        }
    }
}
