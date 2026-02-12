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
    public partial class FormManufacturers : Form
    {
        public FormManufacturers()
        {
            InitializeComponent();
        }

        private void manufacturersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.manufacturersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDBDataSet);

        }

        private void FormManufacturers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDBDataSet.Manufacturers' table. You can move, or remove it, as needed.
            this.manufacturersTableAdapter.Fill(this.pharmacyDBDataSet.Manufacturers);

        }
    }
}
