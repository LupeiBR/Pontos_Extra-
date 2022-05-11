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
    public partial class FrmExercicio04 : Form
    {
        public FrmExercicio04()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int rodada;
            Random a = new Random();
            int[] jogadores = new int[3];

            for (rodada = 0; rodada <= 3; rodada++)
            {
                jogadores[0] = a.Next(1, 3);
                jogadores[1] = a.Next(1, 3);
                jogadores[2] = a.Next(1, 3);

                MessageBox.Show(jogadores[0].ToString() + jogadores[1].ToString() + jogadores[2].ToString());

                if (jogadores[0] == 1 && jogadores[1] == 1 && jogadores[2] == 2)
                {
                    MessageBox.Show("Jogador de posição 3 Ganhou!!!");
                }
                else if (jogadores[0] == 1 && jogadores[1] == 2 && jogadores[2] == 1)
                {
                    MessageBox.Show("Jogador de posição 2 Ganhou!!!");
                }
                else if (jogadores[0] == 2 && jogadores[1] == 1 && jogadores[2] == 1)
                {
                    MessageBox.Show("Jogador de posição 1 Ganhou!!!");
                }


                else if (jogadores[0] == 2 && jogadores[1] == 2 && jogadores[2] == 1)
                {
                    MessageBox.Show("Jogador de posição 3 Ganhou!!!");
                }
                else if (jogadores[0] == 2 && jogadores[1] == 1 && jogadores[2] == 2)
                {
                    MessageBox.Show("Jogador de posição 2 Ganhou!!!");
                }
                else if (jogadores[0] == 1 && jogadores[1] == 2 && jogadores[2] == 2)
                {
                    MessageBox.Show("Jogador de posição 1 Ganhou!!!");
                }

                else
                {
                    MessageBox.Show("Empate...");
                }
            }
        }
    }
}
