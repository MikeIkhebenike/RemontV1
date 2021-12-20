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
    public partial class Engineer : Form
    {
        public Engineer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Accesories FRMacc = new Accesories();
            FRMacc.Show();
            this.Hide();
        }
    }
}
