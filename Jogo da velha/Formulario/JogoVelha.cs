using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class JogoVelha : Form
    {
        string valor = "X";
        

        public JogoVelha()
        {
            InitializeComponent();
        }

        public void Verifica()
        {
            if ((bt1.Text == "X" && bt2.Text == "X" && bt3.Text == "X") ||
                (bt1.Text == "X" && bt4.Text == "X" && bt7.Text == "X") ||
                (bt2.Text == "X" && bt5.Text == "X" && bt8.Text == "X") ||
                (bt4.Text == "X" && bt5.Text == "X" && bt6.Text == "X") ||
                (bt7.Text == "X" && bt8.Text == "X" && bt9.Text == "X") ||
                (bt1.Text == "X" && bt5.Text == "X" && bt9.Text == "X") ||
                (bt3.Text == "X" && bt5.Text == "X" && bt7.Text == "X") ||
                (bt3.Text == "X" && bt6.Text == "X" && bt9.Text == "X") || 
                (bt3.Text == "X" && bt6.Text == "X" && bt9.Text == "X")) 
            {
                MessageBox.Show("Acabou, Jogador _X_ Ganhou !");
                bt1.Enabled = false;
                bt2.Enabled = false;
                bt3.Enabled = false;
                bt4.Enabled = false;
                bt5.Enabled = false;
                bt6.Enabled = false;
                bt7.Enabled = false;
                bt8.Enabled = false;
                bt9.Enabled = false;

            }else if (
                (bt1.Text == "O" && bt2.Text == "O" && bt3.Text == "O") ||
                (bt1.Text == "O" && bt4.Text == "O" && bt7.Text == "O") ||
                (bt2.Text == "O" && bt5.Text == "O" && bt8.Text == "O") ||
                (bt4.Text == "O" && bt5.Text == "O" && bt6.Text == "O") ||
                (bt7.Text == "O" && bt8.Text == "O" && bt9.Text == "O") ||
                (bt1.Text == "O" && bt5.Text == "O" && bt9.Text == "O") ||
                (bt3.Text == "O" && bt5.Text == "O" && bt7.Text == "O") ||
                (bt3.Text == "O" && bt6.Text == "O" && bt9.Text == "O"))
            {
                MessageBox.Show("Jogador _O_ ganhou o jogo !");
                bt1.Enabled = false;
                bt2.Enabled = false;
                bt3.Enabled = false;
                bt4.Enabled = false;
                bt5.Enabled = false;
                bt6.Enabled = false;
                bt7.Enabled = false;
                bt8.Enabled = false;
                bt9.Enabled = false;
            }
             
        }

        public string MudaValor()
        {
            if (valor == "X")
            {
                valor = "O";
            }
            else
            {
                valor = "X";
            }
            return valor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bt1.Text = MudaValor();
            bt1.Enabled = false;
            Verifica();
            
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            bt2.Text = MudaValor();
            bt2.Enabled = false;
            Verifica();
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            bt3.Text = MudaValor();
            bt3.Enabled = false;
            Verifica();
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            bt4.Text = MudaValor();
            bt4.Enabled = false;
            Verifica();
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            bt5.Text = MudaValor();
            bt5.Enabled = false;
            Verifica();
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            bt6.Text = MudaValor();
            bt6.Enabled = false;
            Verifica();
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            bt7.Text = MudaValor();
            bt7.Enabled = false;
            Verifica();
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            bt8.Text = MudaValor();
            bt8.Enabled = false;
            Verifica();
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            bt9.Text = MudaValor();
            bt9.Enabled = false;
            Verifica();
        }
    }
}
