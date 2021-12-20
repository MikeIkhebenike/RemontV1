
namespace RemontV1
{
    partial class AddEditWork
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditWork));
            System.Windows.Forms.Label iD_заявкиLabel;
            System.Windows.Forms.Label iD_комплектующегоLabel;
            System.Windows.Forms.Label iD_работыLabel;
            System.Windows.Forms.Label iD_сотрудникаLabel;
            System.Windows.Forms.Label iD_статусаLabel;
            System.Windows.Forms.Label iD_услугиLabel;
            System.Windows.Forms.Label датаЗавершLabel;
            System.Windows.Forms.Label датаНачLabel;
            System.Windows.Forms.Label характер_ремонтаLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ремонтBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.iD_заявкиTextBox = new System.Windows.Forms.TextBox();
            this.iD_комплектующегоComboBox = new System.Windows.Forms.ComboBox();
            this.iD_работыTextBox = new System.Windows.Forms.TextBox();
            this.iD_сотрудникаComboBox = new System.Windows.Forms.ComboBox();
            this.iD_статусаComboBox = new System.Windows.Forms.ComboBox();
            this.iD_услугиComboBox = new System.Windows.Forms.ComboBox();
            this.датаЗавершTextBox = new System.Windows.Forms.TextBox();
            this.датаНачTextBox = new System.Windows.Forms.TextBox();
            this.характер_ремонтаTextBox = new System.Windows.Forms.TextBox();
            this.статусРаботBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.услугаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.комплектующееBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            iD_заявкиLabel = new System.Windows.Forms.Label();
            iD_комплектующегоLabel = new System.Windows.Forms.Label();
            iD_работыLabel = new System.Windows.Forms.Label();
            iD_сотрудникаLabel = new System.Windows.Forms.Label();
            iD_статусаLabel = new System.Windows.Forms.Label();
            iD_услугиLabel = new System.Windows.Forms.Label();
            датаЗавершLabel = new System.Windows.Forms.Label();
            датаНачLabel = new System.Windows.Forms.Label();
            характер_ремонтаLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ремонтBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.статусРаботBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.комплектующееBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1335, 155);
            this.panel1.TabIndex = 8;
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
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(590, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Список работ";
            // 
            // ремонтBindingSource
            // 
            this.ремонтBindingSource.DataSource = typeof(RemontV1.EF.Ремонт);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteBtn.Location = new System.Drawing.Point(905, 570);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(126, 36);
            this.DeleteBtn.TabIndex = 48;
            this.DeleteBtn.Text = "Удалить ";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(545, 570);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 36);
            this.button2.TabIndex = 46;
            this.button2.Text = "Выйти";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBtn.Location = new System.Drawing.Point(211, 570);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(106, 36);
            this.SaveBtn.TabIndex = 47;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            // 
            // iD_заявкиLabel
            // 
            iD_заявкиLabel.AutoSize = true;
            iD_заявкиLabel.Location = new System.Drawing.Point(268, 233);
            iD_заявкиLabel.Name = "iD_заявкиLabel";
            iD_заявкиLabel.Size = new System.Drawing.Size(86, 20);
            iD_заявкиLabel.TabIndex = 48;
            iD_заявкиLabel.Text = "ID заявки:";
            // 
            // iD_заявкиTextBox
            // 
            this.iD_заявкиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ремонтBindingSource, "ID_заявки", true));
            this.iD_заявкиTextBox.Location = new System.Drawing.Point(569, 233);
            this.iD_заявкиTextBox.Name = "iD_заявкиTextBox";
            this.iD_заявкиTextBox.Size = new System.Drawing.Size(233, 26);
            this.iD_заявкиTextBox.TabIndex = 49;
            // 
            // iD_комплектующегоLabel
            // 
            iD_комплектующегоLabel.AutoSize = true;
            iD_комплектующегоLabel.Location = new System.Drawing.Point(268, 527);
            iD_комплектующегоLabel.Name = "iD_комплектующегоLabel";
            iD_комплектующегоLabel.Size = new System.Drawing.Size(164, 20);
            iD_комплектующегоLabel.TabIndex = 50;
            iD_комплектующегоLabel.Text = "ID комплектующего:";
            // 
            // iD_комплектующегоComboBox
            // 
            this.iD_комплектующегоComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ремонтBindingSource, "ID_комплектующего", true));
            this.iD_комплектующегоComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ремонтBindingSource, "ID_комплектующего", true));
            this.iD_комплектующегоComboBox.DataSource = this.комплектующееBindingSource;
            this.iD_комплектующегоComboBox.DisplayMember = "Наименование";
            this.iD_комплектующегоComboBox.FormattingEnabled = true;
            this.iD_комплектующегоComboBox.Location = new System.Drawing.Point(569, 527);
            this.iD_комплектующегоComboBox.Name = "iD_комплектующегоComboBox";
            this.iD_комплектующегоComboBox.Size = new System.Drawing.Size(233, 28);
            this.iD_комплектующегоComboBox.TabIndex = 51;
            this.iD_комплектующегоComboBox.ValueMember = "ID_комплектующего";
            // 
            // iD_работыLabel
            // 
            iD_работыLabel.AutoSize = true;
            iD_работыLabel.Location = new System.Drawing.Point(268, 193);
            iD_работыLabel.Name = "iD_работыLabel";
            iD_работыLabel.Size = new System.Drawing.Size(90, 20);
            iD_работыLabel.TabIndex = 52;
            iD_работыLabel.Text = "ID работы:";
            // 
            // iD_работыTextBox
            // 
            this.iD_работыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ремонтBindingSource, "ID_работы", true));
            this.iD_работыTextBox.Location = new System.Drawing.Point(569, 193);
            this.iD_работыTextBox.Name = "iD_работыTextBox";
            this.iD_работыTextBox.Size = new System.Drawing.Size(233, 26);
            this.iD_работыTextBox.TabIndex = 53;
            // 
            // iD_сотрудникаLabel
            // 
            iD_сотрудникаLabel.AutoSize = true;
            iD_сотрудникаLabel.Location = new System.Drawing.Point(268, 314);
            iD_сотрудникаLabel.Name = "iD_сотрудникаLabel";
            iD_сотрудникаLabel.Size = new System.Drawing.Size(122, 20);
            iD_сотрудникаLabel.TabIndex = 54;
            iD_сотрудникаLabel.Text = "ID сотрудника:";
            // 
            // iD_сотрудникаComboBox
            // 
            this.iD_сотрудникаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ремонтBindingSource, "ID_сотрудника", true));
            this.iD_сотрудникаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ремонтBindingSource, "ID_сотрудника", true));
            this.iD_сотрудникаComboBox.DataSource = this.сотрудникBindingSource;
            this.iD_сотрудникаComboBox.DisplayMember = "ФИО";
            this.iD_сотрудникаComboBox.FormattingEnabled = true;
            this.iD_сотрудникаComboBox.Location = new System.Drawing.Point(569, 314);
            this.iD_сотрудникаComboBox.Name = "iD_сотрудникаComboBox";
            this.iD_сотрудникаComboBox.Size = new System.Drawing.Size(233, 28);
            this.iD_сотрудникаComboBox.TabIndex = 55;
            this.iD_сотрудникаComboBox.ValueMember = "ID_сотрудника";
            // 
            // iD_статусаLabel
            // 
            iD_статусаLabel.AutoSize = true;
            iD_статусаLabel.Location = new System.Drawing.Point(268, 444);
            iD_статусаLabel.Name = "iD_статусаLabel";
            iD_статусаLabel.Size = new System.Drawing.Size(93, 20);
            iD_статусаLabel.TabIndex = 56;
            iD_статусаLabel.Text = "ID статуса:";
            // 
            // iD_статусаComboBox
            // 
            this.iD_статусаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ремонтBindingSource, "ID_статуса", true));
            this.iD_статусаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ремонтBindingSource, "ID_статуса", true));
            this.iD_статусаComboBox.DataSource = this.статусРаботBindingSource;
            this.iD_статусаComboBox.DisplayMember = "Наименование";
            this.iD_статусаComboBox.FormattingEnabled = true;
            this.iD_статусаComboBox.Location = new System.Drawing.Point(569, 444);
            this.iD_статусаComboBox.Name = "iD_статусаComboBox";
            this.iD_статусаComboBox.Size = new System.Drawing.Size(233, 28);
            this.iD_статусаComboBox.TabIndex = 57;
            this.iD_статусаComboBox.ValueMember = "ID_статуса";
            // 
            // iD_услугиLabel
            // 
            iD_услугиLabel.AutoSize = true;
            iD_услугиLabel.Location = new System.Drawing.Point(268, 485);
            iD_услугиLabel.Name = "iD_услугиLabel";
            iD_услугиLabel.Size = new System.Drawing.Size(82, 20);
            iD_услугиLabel.TabIndex = 58;
            iD_услугиLabel.Text = "ID услуги:";
            // 
            // iD_услугиComboBox
            // 
            this.iD_услугиComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ремонтBindingSource, "ID_услуги", true));
            this.iD_услугиComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ремонтBindingSource, "ID_услуги", true));
            this.iD_услугиComboBox.DataSource = this.услугаBindingSource;
            this.iD_услугиComboBox.DisplayMember = "Наименование";
            this.iD_услугиComboBox.FormattingEnabled = true;
            this.iD_услугиComboBox.Location = new System.Drawing.Point(569, 485);
            this.iD_услугиComboBox.Name = "iD_услугиComboBox";
            this.iD_услугиComboBox.Size = new System.Drawing.Size(233, 28);
            this.iD_услугиComboBox.TabIndex = 59;
            this.iD_услугиComboBox.ValueMember = "ID_услуги";
            // 
            // датаЗавершLabel
            // 
            датаЗавершLabel.AutoSize = true;
            датаЗавершLabel.Location = new System.Drawing.Point(268, 402);
            датаЗавершLabel.Name = "датаЗавершLabel";
            датаЗавершLabel.Size = new System.Drawing.Size(116, 20);
            датаЗавершLabel.TabIndex = 60;
            датаЗавершLabel.Text = "Дата Заверш:";
            // 
            // датаЗавершTextBox
            // 
            this.датаЗавершTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ремонтBindingSource, "ДатаЗаверш", true));
            this.датаЗавершTextBox.Location = new System.Drawing.Point(569, 402);
            this.датаЗавершTextBox.Name = "датаЗавершTextBox";
            this.датаЗавершTextBox.Size = new System.Drawing.Size(233, 26);
            this.датаЗавершTextBox.TabIndex = 61;
            // 
            // датаНачLabel
            // 
            датаНачLabel.AutoSize = true;
            датаНачLabel.Location = new System.Drawing.Point(268, 360);
            датаНачLabel.Name = "датаНачLabel";
            датаНачLabel.Size = new System.Drawing.Size(86, 20);
            датаНачLabel.TabIndex = 62;
            датаНачLabel.Text = "Дата Нач:";
            // 
            // датаНачTextBox
            // 
            this.датаНачTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ремонтBindingSource, "ДатаНач", true));
            this.датаНачTextBox.Location = new System.Drawing.Point(569, 360);
            this.датаНачTextBox.Name = "датаНачTextBox";
            this.датаНачTextBox.Size = new System.Drawing.Size(233, 26);
            this.датаНачTextBox.TabIndex = 63;
            // 
            // характер_ремонтаLabel
            // 
            характер_ремонтаLabel.AutoSize = true;
            характер_ремонтаLabel.Location = new System.Drawing.Point(268, 274);
            характер_ремонтаLabel.Name = "характер_ремонтаLabel";
            характер_ремонтаLabel.Size = new System.Drawing.Size(155, 20);
            характер_ремонтаLabel.TabIndex = 64;
            характер_ремонтаLabel.Text = "Характер ремонта:";
            // 
            // характер_ремонтаTextBox
            // 
            this.характер_ремонтаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ремонтBindingSource, "Характер_ремонта", true));
            this.характер_ремонтаTextBox.Location = new System.Drawing.Point(569, 274);
            this.характер_ремонтаTextBox.Name = "характер_ремонтаTextBox";
            this.характер_ремонтаTextBox.Size = new System.Drawing.Size(233, 26);
            this.характер_ремонтаTextBox.TabIndex = 65;
            // 
            // статусРаботBindingSource
            // 
            this.статусРаботBindingSource.DataSource = typeof(RemontV1.EF.СтатусРабот);
            // 
            // услугаBindingSource
            // 
            this.услугаBindingSource.DataSource = typeof(RemontV1.EF.Услуга);
            // 
            // комплектующееBindingSource
            // 
            this.комплектующееBindingSource.DataSource = typeof(RemontV1.EF.Комплектующее);
            // 
            // сотрудникBindingSource
            // 
            this.сотрудникBindingSource.DataSource = typeof(RemontV1.EF.Сотрудник);
            // 
            // AddEditWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1335, 651);
            this.Controls.Add(iD_заявкиLabel);
            this.Controls.Add(this.iD_заявкиTextBox);
            this.Controls.Add(iD_комплектующегоLabel);
            this.Controls.Add(this.iD_комплектующегоComboBox);
            this.Controls.Add(iD_работыLabel);
            this.Controls.Add(this.iD_работыTextBox);
            this.Controls.Add(iD_сотрудникаLabel);
            this.Controls.Add(this.iD_сотрудникаComboBox);
            this.Controls.Add(iD_статусаLabel);
            this.Controls.Add(this.iD_статусаComboBox);
            this.Controls.Add(iD_услугиLabel);
            this.Controls.Add(this.iD_услугиComboBox);
            this.Controls.Add(датаЗавершLabel);
            this.Controls.Add(this.датаЗавершTextBox);
            this.Controls.Add(датаНачLabel);
            this.Controls.Add(this.датаНачTextBox);
            this.Controls.Add(характер_ремонтаLabel);
            this.Controls.Add(this.характер_ремонтаTextBox);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddEditWork";
            this.Text = "AddEditWork";
            this.Load += new System.EventHandler(this.AddEditWork_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ремонтBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.статусРаботBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.комплектующееBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource ремонтBindingSource;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox iD_заявкиTextBox;
        private System.Windows.Forms.ComboBox iD_комплектующегоComboBox;
        private System.Windows.Forms.BindingSource комплектующееBindingSource;
        private System.Windows.Forms.TextBox iD_работыTextBox;
        private System.Windows.Forms.ComboBox iD_сотрудникаComboBox;
        private System.Windows.Forms.BindingSource сотрудникBindingSource;
        private System.Windows.Forms.ComboBox iD_статусаComboBox;
        private System.Windows.Forms.BindingSource статусРаботBindingSource;
        private System.Windows.Forms.ComboBox iD_услугиComboBox;
        private System.Windows.Forms.BindingSource услугаBindingSource;
        private System.Windows.Forms.TextBox датаЗавершTextBox;
        private System.Windows.Forms.TextBox датаНачTextBox;
        private System.Windows.Forms.TextBox характер_ремонтаTextBox;
    }
}