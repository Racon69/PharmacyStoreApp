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
    public partial class FormProducts : Form
    {
        public FormProducts()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDBDataSet);

        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
            // Завантаження даних 
            this.productsTableAdapter.Fill(this.pharmacyDBDataSet.Products);
            this.categoriesTableAdapter.Fill(this.pharmacyDBDataSet.Categories);
            this.manufacturersTableAdapter.Fill(this.pharmacyDBDataSet.Manufacturers);

            
            comboBoxFilterCategory.SelectedIndex = -1;
            comboBoxFilterManuf.SelectedIndex = -1;
            // TODO: This line of code loads data into the 'pharmacyDBDataSet.Manufacturers' table. You can move, or remove it, as needed.
            this.manufacturersTableAdapter.Fill(this.pharmacyDBDataSet.Manufacturers);
            // TODO: This line of code loads data into the 'pharmacyDBDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.pharmacyDBDataSet.Categories);
            // TODO: This line of code loads data into the 'pharmacyDBDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.pharmacyDBDataSet.Products);

        }

        private void productsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ApplyFilters()
        {
            //починаємо з порожнього фільтру
            string filter = "";
            List<string> conditions = new List<string>();

            //Перевіряємо категорію
            if (comboBoxFilterCategory.SelectedValue != null)
            {
                // Перевірка чи вибране значення є числом
                if (int.TryParse(comboBoxFilterCategory.SelectedValue.ToString(), out int catId))
                {
                    conditions.Add(string.Format("CategoryID = {0}", catId));
                }
            }

            //перевіряємо виробника
            if (comboBoxFilterManuf.SelectedValue != null)
            {
                if (int.TryParse(comboBoxFilterManuf.SelectedValue.ToString(), out int manId))
                {
                    conditions.Add(string.Format("ManufacturerID = {0}", manId));
                }
            }

            // з'єднуємо умови через AND
            if (conditions.Count > 0)
            {
                filter = string.Join(" AND ", conditions);
            }

            //Застосовання фільтру до таблиці товарів
            productsBindingSource.Filter = filter;
        }
        private void comboBoxFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxFilterCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void comboBoxFilterManuf_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ApplyFilters();
        }
        //функціоанл кнопки скиду
        private void buttonReset_Click(object sender, EventArgs e)
        {
            // Скидаємо вибір у списках 
            comboBoxFilterCategory.SelectedIndex = -1;
            comboBoxFilterManuf.SelectedIndex = -1;

            // очистка фільтру таблиці
            productsBindingSource.RemoveFilter();
        }
    }
}
