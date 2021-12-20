
namespace RemontV1
{
    partial class Work
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Work));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.DownCheck = new System.Windows.Forms.CheckBox();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.FiltrCombo = new System.Windows.Forms.ComboBox();
            this.SortCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.iDработыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDзаявкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.заявкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.характерремонтаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDсотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.сотрудникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.датаНачDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЗавершDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDстатусаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.статусРаботBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDуслугиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.услугаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDкомплектующегоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.комплектующееBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ремонтBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.статусРаботBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.комплектующееBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ремонтBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 155);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(90, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(508, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Список работ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDработыDataGridViewTextBoxColumn,
            this.iDзаявкиDataGridViewTextBoxColumn,
            this.характерремонтаDataGridViewTextBoxColumn,
            this.iDсотрудникаDataGridViewTextBoxColumn,
            this.датаНачDataGridViewTextBoxColumn,
            this.датаЗавершDataGridViewTextBoxColumn,
            this.iDстатусаDataGridViewTextBoxColumn,
            this.iDуслугиDataGridViewTextBoxColumn,
            this.iDкомплектующегоDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ремонтBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1176, 412);
            this.dataGridView1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 631);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(535, 631);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 42);
            this.button2.TabIndex = 9;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1088, 631);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 42);
            this.button3.TabIndex = 9;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // DownCheck
            // 
            this.DownCheck.AutoSize = true;
            this.DownCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DownCheck.Location = new System.Drawing.Point(340, 179);
            this.DownCheck.Name = "DownCheck";
            this.DownCheck.Size = new System.Drawing.Size(100, 24);
            this.DownCheck.TabIndex = 39;
            this.DownCheck.Text = "убывание";
            this.DownCheck.UseVisualStyleBackColor = true;
            // 
            // SearchTxt
            // 
            this.SearchTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTxt.Location = new System.Drawing.Point(606, 178);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(139, 26);
            this.SearchTxt.TabIndex = 38;
            // 
            // FiltrCombo
            // 
            this.FiltrCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FiltrCombo.FormattingEnabled = true;
            this.FiltrCombo.Items.AddRange(new object[] {
            "Любой поставщик"});
            this.FiltrCombo.Location = new System.Drawing.Point(1032, 177);
            this.FiltrCombo.Name = "FiltrCombo";
            this.FiltrCombo.Size = new System.Drawing.Size(157, 28);
            this.FiltrCombo.TabIndex = 36;
            // 
            // SortCombo
            // 
            this.SortCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortCombo.FormattingEnabled = true;
            this.SortCombo.Items.AddRange(new object[] {
            "Любой поставщик",
            "Наименование",
            "Поставщик",
            "Стоимость"});
            this.SortCombo.Location = new System.Drawing.Point(146, 176);
            this.SortCombo.Name = "SortCombo";
            this.SortCombo.Size = new System.Drawing.Size(138, 28);
            this.SortCombo.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(920, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Фильтрация";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(523, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Поиск";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(13, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Сортировка";
            // 
            // iDработыDataGridViewTextBoxColumn
            // 
            this.iDработыDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.iDработыDataGridViewTextBoxColumn.DataPropertyName = "ID_работы";
            this.iDработыDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDработыDataGridViewTextBoxColumn.Name = "iDработыDataGridViewTextBoxColumn";
            this.iDработыDataGridViewTextBoxColumn.Width = 51;
            // 
            // iDзаявкиDataGridViewTextBoxColumn
            // 
            this.iDзаявкиDataGridViewTextBoxColumn.DataPropertyName = "ID_заявки";
            this.iDзаявкиDataGridViewTextBoxColumn.DataSource = this.заявкаBindingSource;
            this.iDзаявкиDataGridViewTextBoxColumn.DisplayMember = "ID_заявки";
            this.iDзаявкиDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.iDзаявкиDataGridViewTextBoxColumn.HeaderText = "Заявка №";
            this.iDзаявкиDataGridViewTextBoxColumn.Name = "iDзаявкиDataGridViewTextBoxColumn";
            this.iDзаявкиDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDзаявкиDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDзаявкиDataGridViewTextBoxColumn.ValueMember = "ID_заявки";
            this.iDзаявкиDataGridViewTextBoxColumn.Width = 108;
            // 
            // заявкаBindingSource
            // 
            this.заявкаBindingSource.DataSource = typeof(RemontV1.EF.Заявка);
            // 
            // характерремонтаDataGridViewTextBoxColumn
            // 
            this.характерремонтаDataGridViewTextBoxColumn.DataPropertyName = "Характер_ремонта";
            this.характерремонтаDataGridViewTextBoxColumn.HeaderText = "Характер ремонта";
            this.характерремонтаDataGridViewTextBoxColumn.Name = "характерремонтаDataGridViewTextBoxColumn";
            // 
            // iDсотрудникаDataGridViewTextBoxColumn
            // 
            this.iDсотрудникаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDсотрудникаDataGridViewTextBoxColumn.DataPropertyName = "ID_сотрудника";
            this.iDсотрудникаDataGridViewTextBoxColumn.DataSource = this.сотрудникBindingSource;
            this.iDсотрудникаDataGridViewTextBoxColumn.DisplayMember = "ФИО";
            this.iDсотрудникаDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.iDсотрудникаDataGridViewTextBoxColumn.HeaderText = "Сотрудник";
            this.iDсотрудникаDataGridViewTextBoxColumn.Name = "iDсотрудникаDataGridViewTextBoxColumn";
            this.iDсотрудникаDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDсотрудникаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDсотрудникаDataGridViewTextBoxColumn.ValueMember = "ID_сотрудника";
            this.iDсотрудникаDataGridViewTextBoxColumn.Width = 116;
            // 
            // сотрудникBindingSource
            // 
            this.сотрудникBindingSource.DataSource = typeof(RemontV1.EF.Сотрудник);
            // 
            // датаНачDataGridViewTextBoxColumn
            // 
            this.датаНачDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.датаНачDataGridViewTextBoxColumn.DataPropertyName = "ДатаНач";
            this.датаНачDataGridViewTextBoxColumn.HeaderText = "ДатаНач";
            this.датаНачDataGridViewTextBoxColumn.Name = "датаНачDataGridViewTextBoxColumn";
            this.датаНачDataGridViewTextBoxColumn.Width = 103;
            // 
            // датаЗавершDataGridViewTextBoxColumn
            // 
            this.датаЗавершDataGridViewTextBoxColumn.DataPropertyName = "ДатаЗаверш";
            this.датаЗавершDataGridViewTextBoxColumn.HeaderText = "ДатаЗаверш";
            this.датаЗавершDataGridViewTextBoxColumn.Name = "датаЗавершDataGridViewTextBoxColumn";
            // 
            // iDстатусаDataGridViewTextBoxColumn
            // 
            this.iDстатусаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDстатусаDataGridViewTextBoxColumn.DataPropertyName = "ID_статуса";
            this.iDстатусаDataGridViewTextBoxColumn.DataSource = this.статусРаботBindingSource;
            this.iDстатусаDataGridViewTextBoxColumn.DisplayMember = "Наименование";
            this.iDстатусаDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.iDстатусаDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.iDстатусаDataGridViewTextBoxColumn.Name = "iDстатусаDataGridViewTextBoxColumn";
            this.iDстатусаDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDстатусаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDстатусаDataGridViewTextBoxColumn.ValueMember = "ID_статуса";
            // 
            // статусРаботBindingSource
            // 
            this.статусРаботBindingSource.DataSource = typeof(RemontV1.EF.СтатусРабот);
            // 
            // iDуслугиDataGridViewTextBoxColumn
            // 
            this.iDуслугиDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDуслугиDataGridViewTextBoxColumn.DataPropertyName = "ID_услуги";
            this.iDуслугиDataGridViewTextBoxColumn.DataSource = this.услугаBindingSource;
            this.iDуслугиDataGridViewTextBoxColumn.DisplayMember = "Наименование";
            this.iDуслугиDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.iDуслугиDataGridViewTextBoxColumn.HeaderText = "Услуга";
            this.iDуслугиDataGridViewTextBoxColumn.Name = "iDуслугиDataGridViewTextBoxColumn";
            this.iDуслугиDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDуслугиDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDуслугиDataGridViewTextBoxColumn.ValueMember = "ID_услуги";
            // 
            // услугаBindingSource
            // 
            this.услугаBindingSource.DataSource = typeof(RemontV1.EF.Услуга);
            // 
            // iDкомплектующегоDataGridViewTextBoxColumn
            // 
            this.iDкомплектующегоDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDкомплектующегоDataGridViewTextBoxColumn.DataPropertyName = "ID_комплектующего";
            this.iDкомплектующегоDataGridViewTextBoxColumn.DataSource = this.комплектующееBindingSource;
            this.iDкомплектующегоDataGridViewTextBoxColumn.DisplayMember = "Наименование";
            this.iDкомплектующегоDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.iDкомплектующегоDataGridViewTextBoxColumn.HeaderText = "Комплектующее";
            this.iDкомплектующегоDataGridViewTextBoxColumn.Name = "iDкомплектующегоDataGridViewTextBoxColumn";
            this.iDкомплектующегоDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDкомплектующегоDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDкомплектующегоDataGridViewTextBoxColumn.ValueMember = "ID_комплектующего";
            // 
            // комплектующееBindingSource
            // 
            this.комплектующееBindingSource.DataSource = typeof(RemontV1.EF.Комплектующее);
            // 
            // ремонтBindingSource
            // 
            this.ремонтBindingSource.DataSource = typeof(RemontV1.EF.Ремонт);
            // 
            // Work
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1200, 684);
            this.Controls.Add(this.DownCheck);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.FiltrCombo);
            this.Controls.Add(this.SortCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Work";
            this.Text = "Work";
            this.Load += new System.EventHandler(this.Work_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.статусРаботBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.комплектующееBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ремонтBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ремонтBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource заявкаBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDработыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDзаявкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn характерремонтаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDсотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource сотрудникBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаНачDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗавершDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDстатусаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource статусРаботBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDуслугиDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource услугаBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDкомплектующегоDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource комплектующееBindingSource;
        private System.Windows.Forms.CheckBox DownCheck;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.ComboBox FiltrCombo;
        private System.Windows.Forms.ComboBox SortCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}