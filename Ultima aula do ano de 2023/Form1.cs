namespace Ultima_aula_do_ano_de_2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            Random random = new Random();
            int numeroAlvo = 7;
            int quantidadeNumeros = 10;

            for (int a = 0; a < quantidadeNumeros; a++)
            {
                int numeroGerado = random.Next(1, 10);
                listBox1.Items.Add(numeroGerado);

                if (numeroGerado == numeroAlvo)
                {
                    MessageBox.Show("O número foi encontrado: " + numeroAlvo);
                    break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int numeroAlvo = 7;

            int contador = 0;
            while (true)
            {
                int numeroGerado = random.Next(1, 10);
                listBox1.Items.Add(numeroGerado);

                contador++;

                if (numeroGerado == numeroAlvo)
                {
                    MessageBox.Show("O número foi encontrado após " + contador + " tentativas: " + numeroAlvo);
                    break;
                }
            }
        }
    }
}


 