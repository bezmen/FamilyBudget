namespace FamilyBudget
{
    partial class Form1
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.buttonIncome = new System.Windows.Forms.Button();
            this.buttonExpense = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // buttonIncome
            // 
            this.buttonIncome.Location = new System.Drawing.Point(393, 292);
            this.buttonIncome.Name = "buttonIncome";
            this.buttonIncome.Size = new System.Drawing.Size(75, 23);
            this.buttonIncome.TabIndex = 0;
            this.buttonIncome.Text = "Доходы";
            this.buttonIncome.UseVisualStyleBackColor = true;
            // 
            // buttonExpense
            // 
            this.buttonExpense.Location = new System.Drawing.Point(393, 263);
            this.buttonExpense.Name = "buttonExpense";
            this.buttonExpense.Size = new System.Drawing.Size(75, 23);
            this.buttonExpense.TabIndex = 1;
            this.buttonExpense.Text = "Расходы";
            this.buttonExpense.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listView1.Location = new System.Drawing.Point(-3, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(494, 59);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 394);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonExpense);
            this.Controls.Add(this.buttonIncome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonIncome;
        private System.Windows.Forms.Button buttonExpense;
        private System.Windows.Forms.ListView listView1;
    }
}

