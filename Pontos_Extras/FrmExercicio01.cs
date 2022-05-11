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
    public partial class FrmExercicio01 : Form
    {
        public FrmExercicio01()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int[] i = new int[6];

            i[0] = 100;
            i[1] = i[0] + i[0];
            i[2] = i[1] + i[1];
            i[3] = i[2] + i[2];
            i[4] = i[3] + i[3];
            i[5] = i[4] + i[4];

            lblResultado1.Text = ("Índice 0 = " + i[0]);
            lblResultado2.Text = ("Índice 1 = " + i[1]);
            lblResultado3.Text = ("Índice 2 = " + i[2]);
            lblResultado4.Text = ("Índice 3 = " + i[3]);
            lblResultado5.Text = ("Índice 4 = " + i[4]);
            lblResultado6.Text = ("Índice 5 = " + i[5]);
        }
    }
}
