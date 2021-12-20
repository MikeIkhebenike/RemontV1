using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RemontV1.EF;

namespace RemontV1
{
    public partial class AddEditEmployeeFrm : Form
    {
        public Сотрудник prd { get; set; } = null;
        Model1 db = new Model1();
        public AddEditEmployeeFrm()
        {
            InitializeComponent();
        }

        private void AddEditEmployeeFrm_Load(object sender, EventArgs e)
        {
            сотрудникBindingSource.DataSource = db.Сотрудник.ToList();
            авторизацияBindingSource.DataSource = db.Авторизация.ToList();
            рольBindingSource.DataSource = db.Роль.ToList();

            if (prd == null)
            {
                // добавляем в промежуточный объект пустой объект - продукции
                сотрудникBindingSource.AddNew();
                // настраиваем картинку и надпись
                // запрещаем удаление еще не введенной продукции
                DeleteBtn.Enabled = false;
                employeeImage = @"сотрудники\picture.png";
                фотоPictureBox.Image = Image.FromFile(employeeImage);
                Text = "Добавление нового сотрудника";
                // добавление материалов не показываем
                // еще нет ID продукции
                Size = new Size(500, 400);
            }

            else
            {
                // передаем DataGridView коллекцию productMaterial
                // productMaterialBindingSource.DataSource = prd.ProductMaterial.ToList();
                авторизацияBindingSource.DataSource = db.Авторизация.ToList();
                // добавляем в промежуточный объект - объект-продукции
                сотрудникBindingSource.Add(prd);
                // показываем в PictureBox изображение продукции
                if (prd.Фото != "")
                    фотоPictureBox.Image = Image.FromFile(prd.Фото);
                else
                {
                    employeeImage = @"сотрудники\picture.png";
                    фотоPictureBox.Image = Image.FromFile(employeeImage);
                }

                Text = "Изменение данных сотрудника";
            }

        }

        string employeeImage = "";

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Файлы картинок|*.jpg;*.jpeg;*.png;";

            // задаем подкаталог "products"
            ofd.InitialDirectory = Environment.CurrentDirectory;
            ofd.InitialDirectory += @"\сотрудники\";

            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                // выделяем относительный путь
                string file = ofd.FileName;
                int n = file.IndexOf("сотрудники");
                file = file.Substring(n);
                ///////////////////////////////
                фотоTextBox.Text = file;
                employeeImage = file;
                фотоPictureBox.Image = Image.FromFile(file);
                ((Сотрудник)сотрудникBindingSource.Current).Фото = file;
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (prd == null)
            {
                prd = (Сотрудник)сотрудникBindingSource.Current;
                db.Сотрудник.Add(prd);
            }
            prd.Фото = employeeImage;
            try
            {
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы действительно хотите удалить сотрудника - " + prd.ФИО,
                "Удаление продукции", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                // Проверяем - можно ли удалять эту продукцию
                // проверяем - есть ли данные о продажах товара?
                //if (prd.ProductSale.Count > 0)
                //{
                //    MessageBox.Show("Данную продукцию удалить нельзя, т.к. есть данные о продажах!");
                //    return;
                //}
                // проверяем - есть данные о материалах?
                //if (prd.ProductMaterial.Count > 0)
                /*{*///  удаляем данные о материалах
                    //foreach (ProductMaterial prd_mtr in prd.ProductMaterial)
                    //{
                    //    Program.db.ProductMaterial.Remove(prd_mtr);
                    //}
                //    Program.db.ProductMaterial.RemoveRange(prd.ProductMaterial);
                //}
                //// проверяем - есть данные о истории стоимости?
                //if (prd.ProductCostHistory.Count > 0)
                /*{*///  удаляем данные о истории стоимости
                    //foreach (ProductCostHistory prd_hist in prd.ProductCostHistory)
                    //{
                    //    Program.db.ProductCostHistory.Remove(prd_hist);
                    //}
                    //Program.db.ProductCostHistory.RemoveRange(prd.ProductCostHistory);
                //}

                // удаляем выбранный объект из коллекции
                //Program.db.Product.Remove(prd);

                // сохраняем сделанные изменения в БД
                try  // обрабатываем исключения
                {
                    // сохраняем сделанные изменения в БД
                    db.SaveChanges();
                    // завершаем работу формы
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)  // если ошибка, то попадаем сюда
                {
                    // выводим сообщение SQL Server об ошибке
                    MessageBox.Show(ex.InnerException.InnerException.Message);
                }
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
