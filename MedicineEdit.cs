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
    public partial class MedicineEdit : Form
    {
        public MedicineEdit()
        {
            InitializeComponent();
        }

       

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDBDataSet);

        }

        private void productsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDBDataSet);

        }

        private void ProductEdit_Load(object sender, EventArgs e)
        {
            
            this.productsTableAdapter.Fill(this.pharmacyDBDataSet.Products);

        }

        private void productsBindingNavigator_RefreshItems(object sender, EventArgs e)
        {
            this.Validate(); // Перевірка даних
            this.productsBindingSource.EndEdit(); 
            this.tableAdapterManager.UpdateAll(this.pharmacyDBDataSet);
        }
    }
}
