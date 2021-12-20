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
    public partial class Accesories : Form
    {
        // коллекция выбранных в DataGridView товаров
        static public List<Комплектующее> lstSelectedProduct = new List<Комплектующее>();
        // коллекция показываемых товаров
        List<Комплектующее> lstAccesories = new List<Комплектующее>();

        Model1 db = new Model1();
        public Accesories()
        {
            InitializeComponent();
        }

        private void Accesories_Load(object sender, EventArgs e)
        {

            // устанавливаем тип сортировки - "Без сортировка"
            SortCombo.SelectedIndex = 0;
            // загружаем список названий типов товаров
            List<string> lstTypes = db.Сотрудник.Select(a => a.Пол).ToList();
            lstTypes.Insert(0, "Любой поставщик");
            // передаем данные фильтру
            FiltrCombo.DataSource = lstTypes;

            accessoriesBindingSource.DataSource = db.Комплектующее.ToList();
            поставщикBindingSource.DataSource = db.Поставщик.ToList();
            // подготавливаем данные для показа
            PodgotovkaData();
        }

        ///////////////////////////////////////////////////////
        // параметры показа продукции 
        string filtr = "Любой поставщик"; // фильтр показа продукции;
        string sort = "Наименование"; // сортировки продукции
        string sortDirection = "возрастание"; // направление сортировки
        string search = "";  // поиск по наименованию и описанию

        ////////////////////////////////////////////////////////
        //  Подготовка данных для показа 
        //  выполнение фильтрации, поиска и сортировки
        public void PodgotovkaData()
        {
            // вначале выбираем все товары
            lstAccesories = db.Комплектующее.ToList();

            /////////////////////////////////////////////            
            // фильтрация по типам товаров
            if (filtr != "Любой поставщик")
            {
                // отбираем только по заданному производителю
                lstAccesories = lstAccesories.Where(p => (p.ID_поставщика.ToString() == filtr)).ToList();
            }
            /////////////////////////////////////////////
            // поиск по заданной строке
            if (search != "")
            {   // отбираем товары с заданной строкой в названии
                search = search.ToUpper();
                // поиск с учетом регистра
                // ToUpper() для пустой строки не срабатывает
                lstAccesories = lstAccesories
                    .Where(p => (p.Наименование.ToUpper().Contains(search)) ||
                        (p.Поставщик != null && // есть описание ?
                         p.Поставщик.ToString().Contains(search)))
                    .ToList();
            }
            /////////////////////////////////////////////
            // сортировка по разным полям
            if (sort != "Без сортировки")
            {
                if (sort == "Наименование")
                {   // сортируем отобранные товары по наименованию
                    if (sortDirection == "возрастание")
                        lstAccesories = lstAccesories.OrderBy(p => p.Наименование).ToList();
                    else
                        lstAccesories = lstAccesories.
                            OrderByDescending(p => p.Наименование).ToList();
                }
                if (sort == "Поставщик")
                {
                    if (sort == "Поставщик")
                    {   // сортируем отобранные товары по наименованию
                        if (sortDirection == "возрастание")
                            lstAccesories = lstAccesories.OrderBy(p => p.ID_поставщика).ToList();
                        else
                            lstAccesories = lstAccesories.
                                OrderByDescending(p => p.ID_поставщика).ToList();
                    }
                }
                if (sort == "Стоимость")
                {   // сортируем отобранные товары по наименованию
                    if (sortDirection == "возрастание")
                        lstAccesories = lstAccesories.OrderBy(p => p.СтоимостьШт).ToList();
                    else
                        lstAccesories = lstAccesories.
                                OrderByDescending(p => p.СтоимостьШт).ToList();
                }
            }

            /////////////////////////////////////////////////
            // показываем данные (все или одну страницу)
            ShowCurrentPage();

        }
        private void ShowCurrentPage()
        {
            //////////////////////////////////////////////////////////////////
            // в данной версии просто передаем данные промежуточному элементу
            // 
            accessoriesBindingSource.DataSource = lstAccesories;
          
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Admin FRMadm = new Admin();
            FRMadm.Show();
            this.Hide();
        }

        private void AddEmployeeBtn_Click(object sender, EventArgs e)
        {
            AddEditAccesories form = new AddEditAccesories();
            Комплектующее prd = (Комплектующее)accessoriesBindingSource.Current;
            form.prd = prd;

            DialogResult dr = form.ShowDialog();
            if (dr == DialogResult.OK)
            {
                PodgotovkaData();
            }
        }

        private void SortCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            sort = SortCombo.Text;
            PodgotovkaData();
        }

        private void DownCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (DownCheck.Checked)
                sortDirection = "убывание";
            else
                sortDirection = "возрастание";

            PodgotovkaData();
        }

        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            search = SearchTxt.Text;
            PodgotovkaData();
        }

        private void FiltrCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtr = FiltrCombo.Text;
            PodgotovkaData();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            AddEditAccesories form = new AddEditAccesories();
            Комплектующее prd = (Комплектующее)accessoriesBindingSource.Current;
            form.prd = prd;

            DialogResult dr = form.ShowDialog();
            if (dr == DialogResult.OK)
            {
                PodgotovkaData();
            }

        }
    }
}
