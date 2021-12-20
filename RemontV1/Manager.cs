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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Accesories FRMacc = new Accesories();
            FRMacc.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AuthFRM FRMath = new AuthFRM();
            FRMath.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Work WRK = new Work();
            WRK.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Request RQT = new Request();
            RQT.Show();
            this.Hide();
        }
    }
}
