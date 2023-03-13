using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreApp
{
    public partial class SummaryForm : Form
    {
        public SummaryForm()
        {
            InitializeComponent();
        }

        private void ExitSummaryButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
