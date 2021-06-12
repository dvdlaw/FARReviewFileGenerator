using System.Collections.Generic;
using System.Windows.Forms;

namespace FAR_Review_File_Generator
{
    public partial class FormErrorList : Form
    {
        public FormErrorList()
        {
            InitializeComponent();
        }

        public void InitializeErrorObjects(List<ErrorObject> errorObjects)
        {
            this.dataGridView1.RowTemplate.Height = 20;
            int row = 0;
            foreach(ErrorObject obj in errorObjects)
            {
                this.dataGridView1.Rows.Insert(row, obj.ErrorMessage, obj.CustomerName, obj.CustomerIC);
                row++;
            }
            
        }
    }
}
