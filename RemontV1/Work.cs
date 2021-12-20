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
    public partial class Work : Form
    {

        // коллекция выбранных в DataGridView товаров
        static public List<Ремонт> lstSelectedProduct = new List<Ремонт>();
        // коллекция показываемых товаров
        List<Ремонт> lstProduct = new List<Ремонт>();


        Model1 db = new Model1();
        public Work()
        {
            InitializeComponent();
        }

        private void Work_Load(object sender, EventArgs e)
        {

            // устанавливаем тип сортировки - "Без сортировка"
            SortCombo.SelectedIndex = 0;
            // загружаем список названий типов товаров
            List<string> lstTypes = db.Ремонт.Select(a => a.ID_заявки).ToList();
            lstTypes.Insert(0, "Любой пол");
            // передаем данные фильтру
            FiltrCombo.DataSource = lstTypes;

            ремонтBindingSource.DataSource = db.Ремонт.ToList();
            заявкаBindingSource.DataSource = db.Заявка.ToList();
            сотрудникBindingSource.DataSource = db.Сотрудник.ToList();
            статусРаботBindingSource.DataSource = db.СтатусРабот.ToList();
            услугаBindingSource.DataSource = db.Услуга.ToList();
            комплектующееBindingSource.DataSource = db.Комплектующее.ToList();
        }
    }
}
