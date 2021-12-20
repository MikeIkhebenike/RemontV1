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
    public partial class AddEditAccesories : Form
    {

        public Комплектующее prd { get; set; } = null;
        Model1 db = new Model1();

        public AddEditAccesories()
        {
            InitializeComponent();
        }

        private void AddEditAccesories_Load(object sender, EventArgs e)
        {

            accessoriesBindingSource.DataSource = db.Комплектующее.ToList();
            поставщикBindingSource.DataSource = db.Поставщик.ToList();

            if (prd == null)
            {
                // добавляем в промежуточный объект пустой объект - продукции
                accessoriesBindingSource.AddNew();
                // настраиваем картинку и надпись
                // запрещаем удаление еще не введенной продукции
                DeleteBtn.Enabled = false;
                accesoriesImage = @"Accessories\picture.png";
                изображениеPictureBox.Image = Image.FromFile(accesoriesImage);
                Text = "Добавление нового сотрудника";
                // добавление материалов не показываем
                // еще нет ID продукции
                Size = new Size(500, 400);
            }

            else
            {
                // передаем DataGridView коллекцию productMaterial
                // productMaterialBindingSource.DataSource = prd.ProductMaterial.ToList();
                поставщикBindingSource.DataSource = db.Поставка.ToList();
                // добавляем в промежуточный объект - объект-продукции
                accessoriesBindingSource.Add(prd);
                // показываем в PictureBox изображение продукции
                if (prd.Изображение != "")
                    изображениеPictureBox.Image = Image.FromFile(prd.Изображение);
                else
                {
                    accesoriesImage = @"сотрудники\picture.png";
                    изображениеPictureBox.Image = Image.FromFile(accesoriesImage);
                }

                Text = "Изменение данных сотрудника";
            }


        }
        string accesoriesImage = "";

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Файлы картинок|*.jpg;*.jpeg;*.png;";

            // задаем подкаталог "products"
            ofd.InitialDirectory = Environment.CurrentDirectory;
            ofd.InitialDirectory += @"\Accesories\";

            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                // выделяем относительный путь
                string file = ofd.FileName;
                int n = file.IndexOf("Accesories");
                file = file.Substring(n);
                ///////////////////////////////
                textBox1.Text = file;
                accesoriesImage = file;
                изображениеPictureBox.Image = Image.FromFile(file);
                ((Комплектующее)accessoriesBindingSource.Current).Изображение = file;
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (prd == null)
            {
                prd = (Комплектующее)accessoriesBindingSource.Current;
                db.Комплектующее.Add(prd);
            }
            prd.Изображение = accesoriesImage;
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
            DialogResult dr = MessageBox.Show("Вы действительно хотите удалить сотрудника - " + prd.Наименование,
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
    }
}
