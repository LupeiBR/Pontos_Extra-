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
    public partial class FrmExercicio03 : Form
    {
        public FrmExercicio03()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int[] i = new int[3];
            Random a = new Random();

            i[0] = a.Next(0, 500);
            i[1] = a.Next(0, 500);
            i[2] = a.Next(0, 500);

            MessageBox.Show("Valor 0 = " + i[0].ToString());
            MessageBox.Show("Valor 1 = " + i[1].ToString());
            MessageBox.Show("Valor 2 = " + i[2].ToString());

            Array.Reverse(i);

            MessageBox.Show("Valor 0 = " + i[0].ToString());
            MessageBox.Show("Valor 1 = " + i[1].ToString());
            MessageBox.Show("Valor 2 = " + i[2].ToString());
        }
    }
}
