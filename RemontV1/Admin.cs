using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemontV1
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AuthFRM ATH = new AuthFRM();
            ATH.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee EMP = new Employee();
            EMP.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Accesories FRMacc = new Accesories();
            FRMacc.Show();
            this.Hide();
        }
    }
}
