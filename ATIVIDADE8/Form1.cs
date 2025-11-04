using Microsoft.VisualBasic;
using System.Collections;
using System.Runtime.Intrinsics.X86;



namespace ATIVIDADE6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];
            string aux = "";

            for (int i = 0; i < vetor.Length; i++)
            {
                aux = Interaction.InputBox("Digite um número", "Caixa de entrada");

                if (!int.TryParse(aux, out vetor[i]))
                {
                    MessageBox.Show("Dados inválidos");
                    i--;
                }
            }

            Array.Reverse(vetor);
            aux = "";
            aux = String.Join("\n", vetor);

            MessageBox.Show(aux);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            ArrayList lista = new ArrayList()
            {
                "Ana",
                "André",
                "Beatriz",
                "Camila",
                "João",
                "Joana",
                "Otávio",
                "Marcelo",
                "Pedro",
                "Thaís"
            };

            string antes = String.Join("\n", lista.ToArray());
            MessageBox.Show("Antes: \n" + antes);


            lista.RemoveAt(6);

            string depois = String.Join("\n", lista.ToArray());
            MessageBox.Show("Depois: \n" + depois);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string resultado = "";
            string aux = "";
            double[,] notas = new double[20, 3];
            double[] medias = new double[20];


            for (int i = 0; i < 20; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    bool notaOK = false;
                    while (!notaOK)
                    {
                        aux = Interaction.InputBox($"Digite a nota {j + 1} do aluno {i + 1}");
                        if (double.TryParse(aux, out double nota))
                        {
                            if (nota >= 0 && nota <= 10)
                            {
                                notas[i, j] = nota;
                                notaOK = true;
                            }
                            else
                            {
                                MessageBox.Show("A nota deve estar entre 0 e 10");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Entrada Inválida");
                        }
                    }

                }
                medias[i] = (notas[i, 0] + notas[i, 1] + notas[i, 2]) / 3;
                resultado += "Aluno " + (i + 1) + ": média: " + medias[i].ToString("0.0") + "\n";

            }
            MessageBox.Show(resultado);
        }

        private void btnEx4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}

