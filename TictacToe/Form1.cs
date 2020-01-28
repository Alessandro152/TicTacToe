using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TictacToe
{
    public partial class Form1 : Form
    {
        string[,] matriz;
        string Jogada;

        public Form1()
        {
            InitializeComponent();
            CarregarJogo();
        }

        private void CarregarJogo()
        {
            matriz = new string[3, 3];
            lblResultado.Text = "É a vez de X";

            foreach (var b in this.Controls.OfType<Button>())
            {
                b.Enabled = true;
                b.Text = string.Empty;
            }

            Jogada = string.Empty;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(Jogada == string.Empty || Jogada == "O")
            {
                Jogada = "X";
                btn1.Text = "X";
            }
            else
            {
                Jogada = "O";
                btn1.Text = "O";
            }

            btn1.Enabled = false;
            matriz[0, 0] = btn1.Text;
            VerificarJogo(matriz);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (Jogada == string.Empty || Jogada == "O")
            {
                Jogada = "X";
                btn2.Text = "X";
            }
            else
            {
                Jogada = "O";
                btn2.Text = "O";
            }

            btn2.Enabled = false;
            matriz[0, 1] = btn2.Text;
            VerificarJogo(matriz);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (Jogada == string.Empty || Jogada == "O")
            {
                Jogada = "X";
                btn3.Text = "X";
            }
            else
            {
                Jogada = "O";
                btn3.Text = "O";
            }

            btn3.Enabled = false;
            matriz[0, 2] = btn3.Text;
            VerificarJogo(matriz);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (Jogada == string.Empty || Jogada == "O")
            {
                Jogada = "X";
                btn4.Text = "X";
            }
            else
            {
                Jogada = "O";
                btn4.Text = "O";
            }

            btn4.Enabled = false;
            matriz[1, 0] = btn4.Text;
            VerificarJogo(matriz);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (Jogada == string.Empty || Jogada == "O")
            {
                Jogada = "X";
                btn5.Text = "X";
            }
            else
            {
                Jogada = "O";
                btn5.Text = "O";
            }

            btn5.Enabled = false;
            matriz[1, 1] = btn5.Text;
            VerificarJogo(matriz);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (Jogada == string.Empty || Jogada == "O")
            {
                Jogada = "X";
                btn6.Text = "X";
            }
            else
            {
                Jogada = "O";
                btn6.Text = "O";
            }

            btn6.Enabled = false;
            matriz[1, 2] = btn6.Text;
            VerificarJogo(matriz);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (Jogada == string.Empty || Jogada == "O")
            {
                Jogada = "X";
                btn7.Text = "X";
            }
            else
            {
                Jogada = "O";
                btn7.Text = "O";
            }

            btn7.Enabled = false;
            matriz[2, 0] = btn7.Text;
            VerificarJogo(matriz);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (Jogada == string.Empty || Jogada == "O")
            {
                Jogada = "X";
                btn8.Text = "X";
            }
            else
            {
                Jogada = "O";
                btn8.Text = "O";
            }

            btn8.Enabled = false;
            matriz[2, 1] = btn8.Text;
            VerificarJogo(matriz);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (Jogada == string.Empty || Jogada == "O")
            {
                Jogada = "X";
                btn9.Text = "X";
            }
            else
            {
                Jogada = "O";
                btn9.Text = "O";
            }

            btn9.Enabled = false;
            matriz[2, 2] = btn9.Text;
            VerificarJogo(matriz);
        }

        private void VerificarJogo(string[,] matriz)
        {
            var resultadoHorizontal = VerificarJogadaHorizontal(matriz);
            var resultadoVertical = VerificarJogadaVertical(matriz);
            var resultadoDiagonal = VerificarJogadaDiagonal(matriz);

            if (resultadoHorizontal.ToString() == string.Empty && resultadoVertical.ToString() == string.Empty && resultadoDiagonal.ToString() == string.Empty)
            {
                if (Jogada == "X")
                {
                    lblResultado.Text = "E a vez de O jogar";
                }
                else
                {
                    lblResultado.Text = "E a vez de X jogar";
                }
            }
        }

        private object VerificarJogadaDiagonal(string[,] matriz)
        {
            if (matriz[0, 0] == "X" && matriz[1, 1] == "X" && matriz[2, 2] == "X")
            {
                return lblResultado.Text = "X ganhou!!";
            }
            else if (matriz[0, 0] == "O" && matriz[1, 1] == "O" && matriz[2, 2] == "O")
            {
                return lblResultado.Text = "O ganhou!!";
            }
            else if (matriz[2, 0] == "X" && matriz[1, 1] == "X" && matriz[0, 2] == "X")
            {
                return lblResultado.Text = "X ganhou!!";
            }
            else if (matriz[2, 0] == "O" && matriz[1, 1] == "O" && matriz[0, 2] == "O")
            {
                return lblResultado.Text = "O ganhou!!";
            }

            return string.Empty;
        }

        private object VerificarJogadaVertical(string[,] matriz)
        {
            if (matriz[0, 0] == "X" && matriz[1, 0] == "X" && matriz[2, 0] == "X")
            {
                return lblResultado.Text = "X ganhou!!";
            }
            else if (matriz[0, 0] == "O" && matriz[1, 0] == "O" && matriz[2, 0] == "O")
            {
                return lblResultado.Text = "X ganhou!!";
            }
            else if (matriz[0, 1] == "X" && matriz[1, 1] == "X" && matriz[2, 1] == "X")
            {
                return lblResultado.Text = "X ganhou!!";
            }
            else if (matriz[0, 1] == "O" && matriz[1, 1] == "O" && matriz[2, 1] == "O")
            {
                return lblResultado.Text = "X ganhou!!";
            }
            else if (matriz[0, 2] == "X" && matriz[1, 2] == "X" && matriz[2, 2] == "X")
            {
                return lblResultado.Text = "X ganhou!!";
            }
            else if (matriz[0, 2] == "O" && matriz[1, 2] == "O" && matriz[2, 2] == "O")
            {
                return lblResultado.Text = "X ganhou!!";
            }

            return string.Empty;
        }

        private object VerificarJogadaHorizontal(string[,] matriz)
        {
            if (matriz[0, 0] == "X" && matriz[0, 1] == "X" && matriz[0, 2] == "X")
            {
                return lblResultado.Text = "X ganhou!!";
            }
            else if (matriz[0, 0] == "O" && matriz[0, 1] == "O" && matriz[0, 2] == "O")
            {
                return lblResultado.Text = "O ganhou!!";
            }
            else if (matriz[1, 0] == "X" && matriz[1, 1] == "X" && matriz[1, 2] == "X")
            {
                return lblResultado.Text = "X ganhou!!";
            }
            else if (matriz[1, 0] == "O" && matriz[1, 1] == "O" && matriz[1, 2] == "O")
            {
                return lblResultado.Text = "O ganhou!!";
            }
            else if (matriz[2, 0] == "X" && matriz[2, 1] == "X" && matriz[2, 2] == "X")
            {
                return lblResultado.Text = "X ganhou!!";
            }
            else if (matriz[2, 0] == "O" && matriz[2, 1] == "O" && matriz[2, 2] == "O")
            {
                return lblResultado.Text = "O ganhou!!";
            }

            return string.Empty;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            CarregarJogo();
        }
    }
}
