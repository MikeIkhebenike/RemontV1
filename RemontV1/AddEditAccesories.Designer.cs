
namespace RemontV1
{
    partial class AddEditAccesories
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
            System.Windows.Forms.Label iD_комплектующегоLabel;
            System.Windows.Forms.Label iD_поставщикаLabel;
            System.Windows.Forms.Label изображениеLabel;
            System.Windows.Forms.Label количествоВналичLabel;
            System.Windows.Forms.Label наименованиеLabel;
            System.Windows.Forms.Label стоимостьШтLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditAccesories));
            this.iD_комплектующегоTextBox = new System.Windows.Forms.TextBox();
            this.accessoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iD_поставщикаComboBox = new System.Windows.Forms.ComboBox();
            this.поставщикBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.изображениеPictureBox = new System.Windows.Forms.PictureBox();
            this.количествоВналичTextBox = new System.Windows.Forms.TextBox();
            this.наименованиеTextBox = new System.Windows.Forms.TextBox();
            this.стоимостьШтTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            iD_комплектующегоLabel = new System.Windows.Forms.Label();
            iD_поставщикаLabel = new System.Windows.Forms.Label();
            изображениеLabel = new System.Windows.Forms.Label();
            количествоВналичLabel = new System.Windows.Forms.Label();
            наименованиеLabel = new System.Windows.Forms.Label();
            стоимостьШтLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.accessoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.изображениеPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_комплектующегоLabel
            // 
            iD_комплектующегоLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            iD_комплектующегоLabel.AutoSize = true;
            iD_комплектующегоLabel.BackColor = System.Drawing.SystemColors.Info;
            iD_комплектующегоLabel.Location = new System.Drawing.Point(35, 211);
            iD_комплектующегоLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            iD_комплектующегоLabel.Name = "iD_комплектующегоLabel";
            iD_комплектующегоLabel.Size = new System.Drawing.Size(164, 20);
            iD_комплектующегоLabel.TabIndex = 1;
            iD_комплектующегоLabel.Text = "ID комплектующего:";
            // 
            // iD_поставщикаLabel
            // 
            iD_поставщикаLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            iD_поставщикаLabel.AutoSize = true;
            iD_поставщикаLabel.Location = new System.Drawing.Point(35, 265);
            iD_поставщикаLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            iD_поставщикаLabel.Name = "iD_поставщикаLabel";
            iD_поставщикаLabel.Size = new System.Drawing.Size(126, 20);
            iD_поставщикаLabel.TabIndex = 3;
            iD_поставщикаLabel.Text = "ID поставщика:";
            // 
            // изображениеLabel
            // 
            изображениеLabel.AutoSize = true;
            изображениеLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            изображениеLabel.Location = new System.Drawing.Point(633, 183);
            изображениеLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            изображениеLabel.Name = "изображениеLabel";
            изображениеLabel.Size = new System.Drawing.Size(115, 20);
            изображениеLabel.TabIndex = 5;
            изображениеLabel.Text = "Изображение:";
            // 
            // количествоВналичLabel
            // 
            количествоВналичLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            количествоВналичLabel.AutoSize = true;
            количествоВналичLabel.Location = new System.Drawing.Point(35, 382);
            количествоВналичLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            количествоВналичLabel.Name = "количествоВналичLabel";
            количествоВналичLabel.Size = new System.Drawing.Size(185, 20);
            количествоВналичLabel.TabIndex = 7;
            количествоВналичLabel.Text = "Количество в наличии:";
            // 
            // наименованиеLabel
            // 
            наименованиеLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            наименованиеLabel.AutoSize = true;
            наименованиеLabel.Location = new System.Drawing.Point(35, 440);
            наименованиеLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            наименованиеLabel.Name = "наименованиеLabel";
            наименованиеLabel.Size = new System.Drawing.Size(126, 20);
            наименованиеLabel.TabIndex = 9;
            наименованиеLabel.Text = "Наименование:";
            // 
            // стоимостьШтLabel
            // 
            стоимостьШтLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            стоимостьШтLabel.AutoSize = true;
            стоимостьШтLabel.Location = new System.Drawing.Point(35, 494);
            стоимостьШтLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            стоимостьШтLabel.Name = "стоимостьШтLabel";
            стоимостьШтLabel.Size = new System.Drawing.Size(123, 20);
            стоимостьШтLabel.TabIndex = 11;
            стоимостьШтLabel.Text = "Стоимость Шт:";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(35, 327);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(115, 20);
            label1.TabIndex = 5;
            label1.Text = "Изображение:";
            // 
            // iD_комплектующегоTextBox
            // 
            this.iD_комплектующегоTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.iD_комплектующегоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accessoriesBindingSource, "ID_комплектующего", true));
            this.iD_комплектующегоTextBox.Location = new System.Drawing.Point(273, 208);
            this.iD_комплектующегоTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iD_комплектующегоTextBox.Name = "iD_комплектующегоTextBox";
            this.iD_комплектующегоTextBox.Size = new System.Drawing.Size(180, 26);
            this.iD_комплектующегоTextBox.TabIndex = 2;
            // 
            // accessoriesBindingSource
            // 
            this.accessoriesBindingSource.DataSource = typeof(RemontV1.EF.Комплектующее);
            // 
            // iD_поставщикаComboBox
            // 
            this.iD_поставщикаComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.iD_поставщикаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accessoriesBindingSource, "ID_поставщика", true));
            this.iD_поставщикаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.accessoriesBindingSource, "ID_поставщика", true));
            this.iD_поставщикаComboBox.DataSource = this.поставщикBindingSource;
            this.iD_поставщикаComboBox.DisplayMember = "Наименование";
            this.iD_поставщикаComboBox.FormattingEnabled = true;
            this.iD_поставщикаComboBox.Location = new System.Drawing.Point(273, 262);
            this.iD_поставщикаComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iD_поставщикаComboBox.Name = "iD_поставщикаComboBox";
            this.iD_поставщикаComboBox.Size = new System.Drawing.Size(180, 28);
            this.iD_поставщикаComboBox.TabIndex = 4;
            this.iD_поставщикаComboBox.ValueMember = "ID_поставщика";
            // 
            // поставщикBindingSource
            // 
            this.поставщикBindingSource.DataSource = typeof(RemontV1.EF.Поставщик);
            // 
            // изображениеPictureBox
            // 
            this.изображениеPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.изображениеPictureBox.BackColor = System.Drawing.SystemColors.Info;
            this.изображениеPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.изображениеPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.accessoriesBindingSource, "Изображение", true));
            this.изображениеPictureBox.Location = new System.Drawing.Point(597, 208);
            this.изображениеPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.изображениеPictureBox.Name = "изображениеPictureBox";
            this.изображениеPictureBox.Size = new System.Drawing.Size(188, 170);
            this.изображениеPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.изображениеPictureBox.TabIndex = 6;
            this.изображениеPictureBox.TabStop = false;
            // 
            // количествоВналичTextBox
            // 
            this.количествоВналичTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.количествоВналичTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accessoriesBindingSource, "КоличествоВналич", true));
            this.количествоВналичTextBox.Location = new System.Drawing.Point(273, 378);
            this.количествоВналичTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.количествоВналичTextBox.Name = "количествоВналичTextBox";
            this.количествоВналичTextBox.Size = new System.Drawing.Size(180, 26);
            this.количествоВналичTextBox.TabIndex = 8;
            // 
            // наименованиеTextBox
            // 
            this.наименованиеTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.наименованиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accessoriesBindingSource, "Наименование", true));
            this.наименованиеTextBox.Location = new System.Drawing.Point(273, 436);
            this.наименованиеTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.наименованиеTextBox.Name = "наименованиеTextBox";
            this.наименованиеTextBox.Size = new System.Drawing.Size(180, 26);
            this.наименованиеTextBox.TabIndex = 10;
            // 
            // стоимостьШтTextBox
            // 
            this.стоимостьШтTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.стоимостьШтTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accessoriesBindingSource, "СтоимостьШт", true));
            this.стоимостьШтTextBox.Location = new System.Drawing.Point(273, 490);
            this.стоимостьШтTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.стоимостьШтTextBox.Name = "стоимостьШтTextBox";
            this.стоимостьШтTextBox.Size = new System.Drawing.Size(180, 26);
            this.стоимостьШтTextBox.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1.Location = new System.Drawing.Point(273, 321);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 26);
            this.textBox1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 157);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(4, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(86, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(301, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(609, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Добавление и редактирование комплектующих";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DeleteBtn.Location = new System.Drawing.Point(327, 551);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(126, 36);
            this.DeleteBtn.TabIndex = 45;
            this.DeleteBtn.Text = "Удалить ";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.Location = new System.Drawing.Point(168, 551);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 36);
            this.button2.TabIndex = 43;
            this.button2.Text = "Выйти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SaveBtn.Location = new System.Drawing.Point(31, 551);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(106, 36);
            this.SaveBtn.TabIndex = 44;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(637, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 35);
            this.button1.TabIndex = 46;
            this.button1.Text = "Выбрать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddEditAccesories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(iD_комплектующегоLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.iD_комплектующегоTextBox);
            this.Controls.Add(iD_поставщикаLabel);
            this.Controls.Add(this.iD_поставщикаComboBox);
            this.Controls.Add(label1);
            this.Controls.Add(изображениеLabel);
            this.Controls.Add(this.изображениеPictureBox);
            this.Controls.Add(количествоВналичLabel);
            this.Controls.Add(this.количествоВналичTextBox);
            this.Controls.Add(наименованиеLabel);
            this.Controls.Add(this.наименованиеTextBox);
            this.Controls.Add(стоимостьШтLabel);
            this.Controls.Add(this.стоимостьШтTextBox);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddEditAccesories";
            this.Text = "AddEditAccesories";
            this.Load += new System.EventHandler(this.AddEditAccesories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accessoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.изображениеPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource accessoriesBindingSource;
        private System.Windows.Forms.TextBox iD_комплектующегоTextBox;
        private System.Windows.Forms.ComboBox iD_поставщикаComboBox;
        private System.Windows.Forms.PictureBox изображениеPictureBox;
        private System.Windows.Forms.TextBox количествоВналичTextBox;
        private System.Windows.Forms.TextBox наименованиеTextBox;
        private System.Windows.Forms.TextBox стоимостьШтTextBox;
        private System.Windows.Forms.BindingSource поставщикBindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button button1;
    }
}