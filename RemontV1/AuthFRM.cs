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
    
    public partial class AuthFRM : Form
    {
       
        public static Авторизация UFN { get; set; }
        public static AuthFRM ATH { get; set; }


        Model1 db = new Model1();
        public AuthFRM()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (LoginTxt.Text == "" || PassTxt.Text == "")
            {
                MessageBox.Show("Введите логин и пароль!");
                return;
            }
            Авторизация UsersFind = db.Авторизация.Find(LoginTxt.Text);
            if ((UsersFind != null) && (UsersFind.Пароль == PassTxt.Text))
            {
                UFN = UsersFind;
                ATH = this;
                if (UFN.Сотрудник.ID_роли == 1)
                {
                    //LoggedRole ="1" ;
                    Admin FRMadm = new Admin();
                    FRMadm.Show();
                    this.Hide();
                }

                else if (UFN.Сотрудник.ID_роли == 2)
                {
                    //LoggedRole = "2";
                    Manager FRMmang = new Manager();
                    FRMmang.Show();
                    this.Hide();
                }

                else if (UFN.Сотрудник.ID_роли == 3)
                {
                    //LoggedRole = "3";
                    Engineer FRMeng = new Engineer();
                    FRMeng.Show();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("Логин или пароль введены неверно!");
                return;
            }


     
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
