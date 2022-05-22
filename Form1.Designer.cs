
namespace laba4
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.worksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publicationHouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uDKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workplaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scienceDegreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worksBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1135, 255);
            this.dataGridView1.TabIndex = 0;
            // 
            // worksBindingSource
            // 
            this.worksBindingSource.DataMember = "Works";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить работу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(450, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 66);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить работу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(666, 343);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(210, 66);
            this.button3.TabIndex = 3;
            this.button3.Text = "Добавить авторов";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(882, 343);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(210, 66);
            this.button4.TabIndex = 4;
            this.button4.Text = "Добавить соединение";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(231, 343);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(213, 66);
            this.button5.TabIndex = 5;
            this.button5.Text = "Изменить работу";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(755, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "Для того, чтобы удалить или изменить работу, кликните на нужную строку и нажмите " +
    "соответствующую кнопку.\r\n\r\n";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1344, 30);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formsToolStripMenuItem
            // 
            this.formsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.publicationHouseToolStripMenuItem,
            this.uDKToolStripMenuItem,
            this.workplaceToolStripMenuItem,
            this.scienceDegreeToolStripMenuItem});
            this.formsToolStripMenuItem.Name = "formsToolStripMenuItem";
            this.formsToolStripMenuItem.Size = new System.Drawing.Size(74, 26);
            this.formsToolStripMenuItem.Text = "Формы";
            // 
            // publicationHouseToolStripMenuItem
            // 
            this.publicationHouseToolStripMenuItem.Name = "publicationHouseToolStripMenuItem";
            this.publicationHouseToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.publicationHouseToolStripMenuItem.Text = "Издательство";
            this.publicationHouseToolStripMenuItem.Click += new System.EventHandler(this.publicationHouseToolStripMenuItem_Click);
            // 
            // uDKToolStripMenuItem
            // 
            this.uDKToolStripMenuItem.Name = "uDKToolStripMenuItem";
            this.uDKToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.uDKToolStripMenuItem.Text = "УДК";
            this.uDKToolStripMenuItem.Click += new System.EventHandler(this.uDKToolStripMenuItem_Click);
            // 
            // workplaceToolStripMenuItem
            // 
            this.workplaceToolStripMenuItem.Name = "workplaceToolStripMenuItem";
            this.workplaceToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.workplaceToolStripMenuItem.Text = "Место работы";
            this.workplaceToolStripMenuItem.Click += new System.EventHandler(this.workplaceToolStripMenuItem_Click);
            // 
            // scienceDegreeToolStripMenuItem
            // 
            this.scienceDegreeToolStripMenuItem.Name = "scienceDegreeToolStripMenuItem";
            this.scienceDegreeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.scienceDegreeToolStripMenuItem.Text = "Учёная степень";
            this.scienceDegreeToolStripMenuItem.Click += new System.EventHandler(this.scienceDegreeToolStripMenuItem_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Код";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Название";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Страницы";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "УДК";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Дата ";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Издательство";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "ДОИ";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 433);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Работы";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worksBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource worksBindingSource;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publicationHouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uDKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workplaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scienceDegreeToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}

