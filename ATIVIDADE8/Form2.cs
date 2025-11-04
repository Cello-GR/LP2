using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            string[] nomes = new string[10];
            int[] quantidade = new int[10];

            for (int i = 0; i < 10; i++)
            {
                bool NomeOK = false;
                while (!NomeOK)
                {
                    string aux = Interaction.InputBox($"Digite o nome da pessoa {i + 1}:");
                    {
                        if (!string.IsNullOrWhiteSpace(aux))
                        {
                            nomes[i] = aux;
                            quantidade[i] = aux.Replace(" ", "").Length;
                            nomeOK = true;
                        }
                        else
                        {
                            MessageBox.Show("O nome digitado é inválido");
                        }
                    }
                }

            }
        }
    }
}
