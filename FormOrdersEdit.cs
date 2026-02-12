using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyApp
{
    public partial class FormOrdersEdit : Form
    {
        public FormOrdersEdit()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDBDataSet);

        }

        private void FormOrdersEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDBDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.pharmacyDBDataSet.Orders);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
