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
    public partial class ActsForm : Form
    {
        public ActsForm()
        {
            InitializeComponent();
        }

        private void UpdateRecord_Click(object sender, EventArgs e)
        {
            // TODO: implement create table handler
            DynamicUpdateForm updateForm = new DynamicUpdateForm();
            updateForm.Show();
        }

        private void CreateRecord_Click(object sender, EventArgs e)
        {
            // TODO: implement create table handler
            DynamicCreateForm createForm = new DynamicCreateForm();
            createForm.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeleteRecord_Click(object sender, EventArgs e)
        {
            // TODO: implement create table handler
            DynamicDeleteForm deleteForm = new DynamicDeleteForm();
            deleteForm.Show();
        }
    }
}
