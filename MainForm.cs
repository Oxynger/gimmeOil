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
            Console.Write("some");

            InitializeComponent();
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {
            Console.Write("some");
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Console.Write("some");

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Console.Write("some");


        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.Write("some");


        }

        // private void toolStripMenuItem2_Click(object sender, EventArgs e)
        // {
        //     this.toolStripMenuItem2.Text = "112";
        // }

        private void отчетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // this.toolStripMenuItem2.Text = "112";
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void actsToolStripButton_Click(object sender, EventArgs e)
        {
            ActsForm newActsFrom = new ActsForm();
            newActsFrom.Show();
        }
    }
}
