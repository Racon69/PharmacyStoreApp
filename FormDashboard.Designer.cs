namespace PharmacyApp
{
    partial class FormDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnProductsEdit = new System.Windows.Forms.Button();
            this.btnOrdersEdit = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.chartCategories = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnClients = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProductsEdit
            // 
            this.btnProductsEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnProductsEdit.Location = new System.Drawing.Point(115, 12);
            this.btnProductsEdit.Name = "btnProductsEdit";
            this.btnProductsEdit.Size = new System.Drawing.Size(97, 43);
            this.btnProductsEdit.TabIndex = 22;
            this.btnProductsEdit.Text = "Редагувати ліків";
            this.btnProductsEdit.UseVisualStyleBackColor = true;
            this.btnProductsEdit.Click += new System.EventHandler(this.btnProductsEdit_Click_1);
            // 
            // btnOrdersEdit
            // 
            this.btnOrdersEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOrdersEdit.Location = new System.Drawing.Point(424, 12);
            this.btnOrdersEdit.Name = "btnOrdersEdit";
            this.btnOrdersEdit.Size = new System.Drawing.Size(97, 43);
            this.btnOrdersEdit.TabIndex = 21;
            this.btnOrdersEdit.Text = "Редагувати замовлення";
            this.btnOrdersEdit.UseVisualStyleBackColor = true;
            this.btnOrdersEdit.Click += new System.EventHandler(this.btnOrdersEdit_Click_1);
            // 
            // btnProducts
            // 
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnProducts.Location = new System.Drawing.Point(12, 12);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(97, 43);
            this.btnProducts.TabIndex = 18;
            this.btnProducts.Text = "Ліки";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click_2);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSearch.Location = new System.Drawing.Point(527, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 43);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Пошук замовлень";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // btnOrders
            // 
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOrders.Location = new System.Drawing.Point(321, 12);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(97, 43);
            this.btnOrders.TabIndex = 19;
            this.btnOrders.Text = "Замовлення";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // chartCategories
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCategories.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCategories.Legends.Add(legend1);
            this.chartCategories.Location = new System.Drawing.Point(115, 62);
            this.chartCategories.Name = "chartCategories";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartCategories.Series.Add(series1);
            this.chartCategories.Size = new System.Drawing.Size(419, 376);
            this.chartCategories.TabIndex = 17;
            this.chartCategories.Text = "chart1";
            // 
            // btnClients
            // 
            this.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClients.Location = new System.Drawing.Point(218, 12);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(97, 43);
            this.btnClients.TabIndex = 23;
            this.btnClients.Text = "Клієнти";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click_1);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.btnProductsEdit);
            this.Controls.Add(this.btnOrdersEdit);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.chartCategories);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDashboard";
            this.Text = "FormDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProductsEdit;
        private System.Windows.Forms.Button btnOrdersEdit;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCategories;
        private System.Windows.Forms.Button btnClients;
    }
}