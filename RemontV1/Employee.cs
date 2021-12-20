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
    public partial class Employee : Form
    {

        // коллекция выбранных в DataGridView товаров
        static public List<Сотрудник> lstSelectedProduct = new List<Сотрудник>();
        // коллекция показываемых товаров
        List<Сотрудник> lstProduct = new List<Сотрудник>();

        Model1 db = new Model1();
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            // устанавливаем тип сортировки - "Без сортировка"
            SortCombo.SelectedIndex = 0;
            // загружаем список названий типов товаров
            List<string> lstTypes = db.Сотрудник.Select(a => a.Пол).ToList();
            lstTypes.Insert(0, "Любой пол");
            // передаем данные фильтру
            FiltrCombo.DataSource = lstTypes;

            sotrydnikBindingSource.DataSource = db.Сотрудник.ToList();
            roleBindingSource.DataSource = db.Роль.ToList();
            authorizeBindingSource.DataSource = db.Авторизация.ToList();

            // подготавливаем данные для показа
            PodgotovkaData();
        }

        ///////////////////////////////////////////////////////
        // параметры показа продукции 
        string filtr = "Любой пол"; // фильтр показа продукции;
        string sort = "ФИО"; // сортировки продукции
        string sortDirection = "возрастание"; // направление сортировки
        string search = "";  // поиск по наименованию и описанию

        ////////////////////////////////////////////////////////
        //  Подготовка данных для показа 
        //  выполнение фильтрации, поиска и сортировки
        public void PodgotovkaData()
        {
            // вначале выбираем все товары
            lstProduct = db.Сотрудник.ToList();

            /////////////////////////////////////////////            
            // фильтрация по типам товаров
            if (filtr != "Любой пол")
            {
                // отбираем только по заданному производителю
                lstProduct = lstProduct.Where(p => (p.Пол == filtr)).ToList();
            }
            /////////////////////////////////////////////
            // поиск по заданной строке
            if (search != "")
            {   // отбираем товары с заданной строкой в названии
                search = search.ToUpper();
                // поиск с учетом регистра
                // ToUpper() для пустой строки не срабатывает
                lstProduct = lstProduct
                    .Where(p => (p.Пол.ToUpper().Contains(search)) ||
                        (p.Должность != null && // есть описание ?
                         p.Должность.ToUpper().Contains(search)))
                    .ToList();
            }
            /////////////////////////////////////////////
            // сортировка по разным полям
            if (sort != "Без сортировки")
            {
                if (sort == "ФИО")
                {   // сортируем отобранные товары по наименованию
                    if (sortDirection == "возрастание")
                        lstProduct = lstProduct.OrderBy(p => p.ФИО).ToList();
                    else
                        lstProduct = lstProduct.
                            OrderByDescending(p => p.ФИО).ToList();
                }
                if (sort == "Номер роли")
                {
                    if (sort == "Номер роли")
                    {   // сортируем отобранные товары по наименованию
                        if (sortDirection == "возрастание")
                            lstProduct = lstProduct.OrderBy(p => p.ID_роли).ToList();
                        else
                            lstProduct = lstProduct.
                                OrderByDescending(p => p.ID_роли).ToList();
                    }
                }
                if (sort == "Должность")
                {   // сортируем отобранные товары по наименованию
                    if (sortDirection == "возрастание")
                        lstProduct = lstProduct.OrderBy(p => p.Должность).ToList();
                    else
                        lstProduct = lstProduct.
                                OrderByDescending(p => p.Должность).ToList();
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
            sotrydnikBindingSource.DataSource = lstProduct;
        }





        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
           
                Admin FRMadm = new Admin();
                FRMadm.Show();
                this.Hide();
            
        }

        private void EmployeeBtn_Click(object sender, EventArgs e)
        {
            AddEditEmployeeFrm form = new AddEditEmployeeFrm();
            form.prd = null;
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
            AddEditEmployeeFrm form = new AddEditEmployeeFrm();
            Сотрудник prd = (Сотрудник)sotrydnikBindingSource.Current;
            form.prd = prd;

            DialogResult dr = form.ShowDialog();
            if (dr == DialogResult.OK)
            {
                PodgotovkaData();
            }
        }
    }
}
