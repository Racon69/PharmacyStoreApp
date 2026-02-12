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
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();

                // Завершуємо редагування у верхній таблиці
                this.ordersBindingSource.EndEdit();

                // зберігаємо верхню таблицю 
                
                this.ordersTableAdapter.Update(this.computerStoreDBDataSet.Orders);
                this.orderDetailsBindingSource.EndEdit();

                //Зберігаємо нижню таблицю 
                this.orderDetailsTableAdapter.Update(this.computerStoreDBDataSet.OrderDetails);

                MessageBox.Show("Дані успішно збережено!");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Помилка збереження: " + ex.Message);
            }
        }

        private void FormOrders_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.computerStoreDBDataSet.Users);       
            this.productsTableAdapter.Fill(this.computerStoreDBDataSet.Products);
           
            this.productsTableAdapter.Fill(this.computerStoreDBDataSet.Products);
            this.usersTableAdapter.Fill(this.computerStoreDBDataSet.Users);
            this.orderDetailsTableAdapter.Fill(this.computerStoreDBDataSet.OrderDetails);
            this.ordersTableAdapter.Fill(this.computerStoreDBDataSet.Orders);

        }
        private void CalculateTotalAmount()
        {
            //не спрацювалао
        }
        private void orderDetailsDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
               
                DataGridView dgv = (DataGridView)sender;

                // перев зміну в колонці продуктАйди
                if (dgv.Columns[e.ColumnIndex].DataPropertyName == "ProductID")
                {
                    //отримуємо ID обраного товару
                    var cellValue = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                    if (cellValue != DBNull.Value && cellValue != null)
                    {
                        int selectedProductId = Convert.ToInt32(cellValue);

                        //Шукаємо товар у нашому пам'яті
                        
                        var productRow = this.computerStoreDBDataSet.Products.FindByProductID(selectedProductId);

                        if (productRow != null)
                        {
                            //Знаходимо колонку ціни 
                            
                            int priceColumnIndex = -1;
                            foreach (DataGridViewColumn col in dgv.Columns)
                            {
                                if (col.DataPropertyName == "PriceAtPurchase")
                                {
                                    priceColumnIndex = col.Index;
                                    break;
                                }
                            }

                            if (priceColumnIndex != -1)
                            {
                                dgv.Rows[e.RowIndex].Cells[priceColumnIndex].Value = productRow.Price;
                            }
                        }
                    }
                }
                
            }
            CalculateTotalAmount();
        }

        private void orderDetailsDataGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (orderDetailsDataGridView.IsCurrentCellDirty)
            {
                orderDetailsDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void orderDetailsDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            CalculateTotalAmount();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ordersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
