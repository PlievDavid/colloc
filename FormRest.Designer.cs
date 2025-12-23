namespace colloc
{
    partial class FormRest
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewRests = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDishes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewRests
            // 
            this.listViewRests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnDishes});
            this.listViewRests.HideSelection = false;
            this.listViewRests.Location = new System.Drawing.Point(68, 28);
            this.listViewRests.Name = "listViewRests";
            this.listViewRests.Size = new System.Drawing.Size(283, 309);
            this.listViewRests.TabIndex = 0;
            this.listViewRests.UseCompatibleStateImageBehavior = false;
            // 
            // columnName
            // 
            this.columnName.Text = "Название";
            // 
            // columnDishes
            // 
            this.columnDishes.Text = "Блюда";
            this.columnDishes.Width = 300;
            // 
            // FormRest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewRests);
            this.Name = "FormRest";
            this.Text = "Сеть ресторанов";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewRests;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnDishes;
    }
}

