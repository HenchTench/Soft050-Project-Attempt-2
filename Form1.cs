using System.Data;

namespace Soft050_Project_Attempt_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAL2.CreateDataProperty();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable tabDataTable = DAL2.ReadDataProperty();
            testTable.DataSource = tabDataTable;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Logging.OpenLog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DAL2.LocalServerVerification();
        }
    }
}
