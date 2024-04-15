using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soft050_Project_Attempt_2
    //The existence of this form seems unnescessary but the methods called below weren't running correctly in Program.Main so I've moved them here with a button to trigger.
    //Later this could be repurposed as a login screen.
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnInitialise_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Logging.VerifyLogFile();
            DAL2.LocalServerVerification();
            form1.Show();
            this.Hide();
        }
    }
}
