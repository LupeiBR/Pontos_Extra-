using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista03
{
    public partial class FrmExercicio02 : Form
    {
        public FrmExercicio02()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int[] i = new int[8];
            Random a = new Random();
           

            i[0] = a.Next(0, 500);
            i[1] = a.Next(0, 500);
            i[2] = a.Next(0, 500);
            i[3] = a.Next(0, 500);
            i[4] = a.Next(0, 500);
            i[5] = a.Next(0, 500);
            i[6] = a.Next(0, 500);
            i[7] = a.Next(0, 500);

            int maxi = Array.IndexOf(i, i.Max());

            MessageBox.Show("Valor 0 = " + i[0].ToString());
            MessageBox.Show("Valor 1 = " + i[1].ToString());
            MessageBox.Show("Valor 2 = " + i[2].ToString());
            MessageBox.Show("Valor 3 = " + i[3].ToString());
            MessageBox.Show("Valor 4 = " + i[4].ToString());
            MessageBox.Show("Valor 5 = " + i[5].ToString());
            MessageBox.Show("Valor 6 = " + i[6].ToString());
            MessageBox.Show("Valor 7 = " + i[7].ToString());

            MessageBox.Show("O maior Valor é " + i.Max() + ", presente na posição " +maxi);
        }
    }
}
