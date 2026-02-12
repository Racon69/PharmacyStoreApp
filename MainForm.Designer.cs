namespace PharmacyApp
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.довідникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товариToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.категоріїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.виробникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клієнтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.замовленняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операціїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пошукЗамовленьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додаванняТоваруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуванняЗамовленьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вийтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.довідникиToolStripMenuItem,
            this.операціїToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(875, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // довідникиToolStripMenuItem
            // 
            this.довідникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.товариToolStripMenuItem,
            this.категоріїToolStripMenuItem,
            this.виробникиToolStripMenuItem,
            this.клієнтиToolStripMenuItem,
            this.замовленняToolStripMenuItem});
            this.довідникиToolStripMenuItem.Name = "довідникиToolStripMenuItem";
            this.довідникиToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.довідникиToolStripMenuItem.Text = "Дод. Реєстри";
            // 
            // товариToolStripMenuItem
            // 
            this.товариToolStripMenuItem.Name = "товариToolStripMenuItem";
            this.товариToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.товариToolStripMenuItem.Text = "Товари";
            this.товариToolStripMenuItem.Click += new System.EventHandler(this.товариToolStripMenuItem_Click);
            // 
            // категоріїToolStripMenuItem
            // 
            this.категоріїToolStripMenuItem.Name = "категоріїToolStripMenuItem";
            this.категоріїToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.категоріїToolStripMenuItem.Text = "Категорії ";
            this.категоріїToolStripMenuItem.Click += new System.EventHandler(this.категоріїToolStripMenuItem_Click);
            // 
            // виробникиToolStripMenuItem
            // 
            this.виробникиToolStripMenuItem.Name = "виробникиToolStripMenuItem";
            this.виробникиToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.виробникиToolStripMenuItem.Text = "Виробники";
            this.виробникиToolStripMenuItem.Click += new System.EventHandler(this.виробникиToolStripMenuItem_Click);
            // 
            // клієнтиToolStripMenuItem
            // 
            this.клієнтиToolStripMenuItem.Name = "клієнтиToolStripMenuItem";
            this.клієнтиToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.клієнтиToolStripMenuItem.Text = "Клієнти";
            this.клієнтиToolStripMenuItem.Click += new System.EventHandler(this.клієнтиToolStripMenuItem_Click);
            // 
            // замовленняToolStripMenuItem
            // 
            this.замовленняToolStripMenuItem.Name = "замовленняToolStripMenuItem";
            this.замовленняToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.замовленняToolStripMenuItem.Text = "Замовлення ";
            this.замовленняToolStripMenuItem.Click += new System.EventHandler(this.замовленняToolStripMenuItem_Click_1);
            // 
            // операціїToolStripMenuItem
            // 
            this.операціїToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пошукЗамовленьToolStripMenuItem,
            this.додаванняТоваруToolStripMenuItem,
            this.редагуванняЗамовленьToolStripMenuItem});
            this.операціїToolStripMenuItem.Name = "операціїToolStripMenuItem";
            this.операціїToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.операціїToolStripMenuItem.Text = "Операції";
            // 
            // пошукЗамовленьToolStripMenuItem
            // 
            this.пошукЗамовленьToolStripMenuItem.Name = "пошукЗамовленьToolStripMenuItem";
            this.пошукЗамовленьToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.пошукЗамовленьToolStripMenuItem.Text = "Пошук замовлень";
            this.пошукЗамовленьToolStripMenuItem.Click += new System.EventHandler(this.пошукЗамовленьToolStripMenuItem_Click);
            // 
            // додаванняТоваруToolStripMenuItem
            // 
            this.додаванняТоваруToolStripMenuItem.Name = "додаванняТоваруToolStripMenuItem";
            this.додаванняТоваруToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.додаванняТоваруToolStripMenuItem.Text = "Редагування товару";
            this.додаванняТоваруToolStripMenuItem.Click += new System.EventHandler(this.додаванняТоваруToolStripMenuItem_Click);
            // 
            // редагуванняЗамовленьToolStripMenuItem
            // 
            this.редагуванняЗамовленьToolStripMenuItem.Name = "редагуванняЗамовленьToolStripMenuItem";
            this.редагуванняЗамовленьToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.редагуванняЗамовленьToolStripMenuItem.Text = "Редагування замовлень";
            this.редагуванняЗамовленьToolStripMenuItem.Click += new System.EventHandler(this.редагуванняЗамовленьToolStripMenuItem_Click);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вийтиToolStripMenuItem});
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.вихідToolStripMenuItem.Text = "Вихід";
            // 
            // вийтиToolStripMenuItem
            // 
            this.вийтиToolStripMenuItem.Name = "вийтиToolStripMenuItem";
            this.вийтиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.вийтиToolStripMenuItem.Text = "Вийти...";
            this.вийтиToolStripMenuItem.Click += new System.EventHandler(this.вийтиToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 561);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem довідникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem товариToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem категоріїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клієнтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem операціїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пошукЗамовленьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem додаванняТоваруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem виробникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem замовленняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редагуванняЗамовленьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вийтиToolStripMenuItem;
    }
}

