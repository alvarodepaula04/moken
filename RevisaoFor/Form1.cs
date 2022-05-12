using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevisaoFor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_soma_Click(object sender, EventArgs e)
        {

            int soma = 0;
            for (int i = 0; i <= 3; i++)
            {
                soma=soma + i;
            }
            MessageBox.Show("Soma:" + soma);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cont = 0;
            for(int i = 0;i <= 34154; i++)
            {
                cont++;
            }

            MessageBox.Show("Cont:" +cont);
        }

        private void btn_valor_Click(object sender, EventArgs e)
        {
            int maior = 0;
            for (int i = 0;i<= 10 ; i++)
            {
                if (i >= 5)
                {
                    maior++;
                }
            }
            MessageBox.Show("Maior:" + maior);
        }

        private void btn_par_Click(object sender, EventArgs e)
        {
            int par = 0;
            for(int i = 0; i <= 10; i++)
            {
                if(i%2 == 0)
                {
                    par++;
                }
            }
            MessageBox.Show("Par:" + par);
        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
            int mult = 1;
            for (int i =1;i <= 10; i++)
            {
                mult = mult* i ;
            }
            MessageBox.Show("Mult:" + mult);
        }

        private void btn_menor_Click(object sender, EventArgs e)
        {
            int menor = 0;
            for (int i = 0; i <= 10; i++)
            {
                if (i < 5)
                {
                    MessageBox.Show("menor:" +i);
                }
            }
            
        }
    }
}
