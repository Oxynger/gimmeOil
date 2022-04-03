using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gimme_oil
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void actsToolStripButton_Click(object sender, EventArgs e)
        {
            ActsForm newFrom = new ActsForm();
            newFrom.Show();
        }

        private void assigmentsToolStripButton_Click(object sender, EventArgs e)
        {
            AssigmentsFrom newFrom = new AssigmentsFrom();
            newFrom.Show();
        }
    }
}
