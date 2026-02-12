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
    public partial class FormQueryDate : Form
    {
        public FormQueryDate()
        {
            InitializeComponent();
        }

        private void FormQueryDate_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Формуємо параметри для пошуку 
            

            string lastName = string.IsNullOrWhiteSpace(txtLastName.Text) ? "%" : "%" + txtLastName.Text.Trim() + "%";
            string phone = string.IsNullOrWhiteSpace(txtPhone.Text) ? "%" : "%" + txtPhone.Text.Trim() + "%";
            string title = string.IsNullOrWhiteSpace(txtProductTitle.Text) ? "%" : "%" + txtProductTitle.Text.Trim() + "%";
            string manufacturer = string.IsNullOrWhiteSpace(txtManufacturer.Text) ? "%" : "%" + txtManufacturer.Text.Trim() + "%";

            // Налаштування дат
            DateTime startDate = dateTimePickerStart.Value.Date;
            DateTime endDate = dateTimePickerEnd.Value.Date.AddDays(1).AddSeconds(-1);
            
            
            
            PharmacyDBDataSet dataSet = new PharmacyDBDataSet();

            dataSet.EnforceConstraints = false;

            PharmacyDBDataSetTableAdapters.SearchResultsTableAdapter adapter =
                new PharmacyDBDataSetTableAdapters.SearchResultsTableAdapter();

            try
            {
                // Виконуємо пошук
                adapter.FillByComplexSearch(
                    dataSet.SearchResults,
                    startDate,
                    endDate,
                    lastName,
                    phone,
                    title,
                    manufacturer
                );

                if (dataSet.SearchResults.Rows.Count > 0)
                {
                    dataGridViewResults.DataSource = dataSet.SearchResults;
                }
                else
                {
                    dataGridViewResults.DataSource = null;
                    MessageBox.Show("Нічого не знайдено за вашими критеріями.");
                }
            }
            catch (Exception ex)
            {
                // Виводимо  помилки
                MessageBox.Show("Помилка при пошуку: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
