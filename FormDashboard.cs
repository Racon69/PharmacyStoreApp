using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.DataVisualization.Charting;

namespace PharmacyApp
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }
        private void LoadChartCategories()
        {
            //Отримуємо дані з БД 
            
            var adapter = new PharmacyDBDataSetTableAdapters.StatsCategoriesTableAdapter();
            DataTable dt = adapter.GetDataByCategories();

            // Налаштовання для графікц
            chartCategories.Series.Clear();
            chartCategories.Titles.Clear();
            chartCategories.Titles.Add("Продажі за категоріями");

            // Створюємо нову серію даних
            Series series = new Series("Categories");
            series.ChartType = SeriesChartType.Pie;

            //показуєм цифри 
            series.IsValueShownAsLabel = true; 

            //заповнюємо даними
            foreach (DataRow row in dt.Rows)
            {
              
              
                string category = row["CategoryName"].ToString();
               
                decimal total = Convert.ToDecimal(row["TotalSales"]);

                series.Points.AddXY(category, total);
            }

            chartCategories.Series.Add(series);
        }
        private void FormDashboard_Load(object sender, EventArgs e)
        {

            LoadChartCategories();

        }
        /*--------------------*/
        //Фунціонал кнопок, для відкриття вікон
      
        private void btnProducts_Click_2(object sender, EventArgs e)
        {
            FormProducts productsForm = new FormProducts();


            productsForm.Show();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            FormOrders ordersForm = new FormOrders();
            ordersForm.Show();
        }

        private void btnProductsEdit_Click_1(object sender, EventArgs e)
        {
            MedicineEdit productsEdit = new MedicineEdit();
            productsEdit.Show();
        }

        private void btnOrdersEdit_Click_1(object sender, EventArgs e)
        {
            FormOrdersEdit formOrdersEdit = new FormOrdersEdit();
            formOrdersEdit.Show();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            FormQueryDate searchForm = new FormQueryDate();
            searchForm.Show();
        }

        private void btnClients_Click_1(object sender, EventArgs e)
        {
            FormUsers formUsers = new FormUsers();
            formUsers.Show();
        }
    }
}
