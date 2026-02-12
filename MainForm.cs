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
namespace PharmacyApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Відкриття вікон у верхній панелі

        //Функціонал кнопок верхньої панелі
        private void товариToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProducts formProducts = new FormProducts();
            formProducts.Show();
        }

        private void категоріїToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCategories formCategoies = new FormCategories();
           
            formCategoies.Show();
        }

        private void виробникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManufacturers formManufacturers = new FormManufacturers();
            formManufacturers.Show();
        }

        private void клієнтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsers formUsers = new FormUsers();
            formUsers.Show();
        }

        private void замовленняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOrders f = new FormOrders();
            
            f.Show();
        }

        private void пошукЗамовленьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQueryDate f = new FormQueryDate();
            
            f.Show();
        }

        private void додаванняТоваруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedicineEdit f = new MedicineEdit();
            
            f.Show();
        }

        private void замовленняToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormOrders f = new FormOrders();
            
            f.Show();
        }

        private void редагуванняЗамовленьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOrdersEdit f = new FormOrdersEdit();
            
            f.Show();
        }


        // відображення Діаграми і кнопок дій
        private void MainForm_Load(object sender, EventArgs e)
        {
            FormDashboard dashboard = new FormDashboard();

            dashboard.MdiParent = this;
            dashboard.Dock = DockStyle.Fill; 
            dashboard.Show();
        }

        private void вийтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
