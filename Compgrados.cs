using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_Grados;

namespace Com_Grados
{
    public partial class Compgrados : UserControl
    {
        double g;
        public Compgrados()
        {
            InitializeComponent();
        }

        private void cel_Click(object sender, EventArgs e)
        {
            g = double.Parse(cel1.Text);

            cel2.Text = opgrados.caf(g).ToString();
        }

        private void fah_Click(object sender, EventArgs e)
        {
            g = double.Parse(far1.Text);

            far2.Text = Opgrados.fac(g).ToString();
        }
    }
}
