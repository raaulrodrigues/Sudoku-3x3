namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        private int[,] tabela; //cria a matriz

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            GerarSudoku();
            PreencherTextBoxes();
        }

        private void GerarSudoku()
        {
            tabela = new int[3, 3]; //forma uma matriz de tamanho 3x3

            Random rand = new Random(); //usado para gerar números random
            List<int> numeros = Enumerable.Range(1, 9).ToList();//cria uma lista utilizando apenas números de 1-9

            for (int i = 0; i < numeros.Count; i++)//um for para embaralhar os números random da lista
            {
                int temp = numeros[i];
                int randomIndex = rand.Next(i, numeros.Count);
                numeros[i] = numeros[randomIndex];
                numeros[randomIndex] = temp;
            }

            for (int k = 0; k < 3; k++)//for para preencher as casas com os números random
            {
                int i = rand.Next(0, 3);
                int j = rand.Next(0, 3);
                while (tabela[i, j] != 0)
                {
                    i = rand.Next(0, 3);
                    j = rand.Next(0, 3);
                }
                tabela[i, j] = numeros[k];
            }
        }

        private void PreencherTextBoxes()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (tabela[i, j] != 0)
                    {
                        Control textBox = this.Controls.Find("txtBx" + (i * 3 + j + 1), true)[0];
                        textBox.Text = tabela[i, j].ToString();
                        textBox.Enabled = false;//deixa o campo sem poder editar
                    }
                    else
                    {
                        Control textBox = this.Controls.Find("txtBx" + (i * 3 + j + 1), true)[0];
                        textBox.Text = "";
                        textBox.Enabled = true;//deixa o campo editavel
                    }
                }
            }
        }

        private bool RevisarSudoku()
        {
            for (int i = 0; i < 3; i++)
            {
                if (!VerificarNumeros(tabela[i, 0], tabela[i, 1], tabela[i, 2]) ||//verifica as linhas
                    !VerificarNumeros(tabela[0, i], tabela[1, i], tabela[2, i]))//verifica as colunas
                {
                    return false;
                }
            }
            return true;
        }


        private void btnRevisar_Click(object sender, EventArgs e)
        {
            if (RevisarSudoku() && EntradaUsuario())
            {
                MessageBox.Show("Sudoku certo.", "Correção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sudoku errado.", "Correção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool EntradaUsuario()
        {
            HashSet<int> numerosRepetidos = new HashSet<int>();


            for (int i = 1; i <= 9; i++)//verifica todas as textbox editaveis
            {
                Control textBox = this.Controls.Find("txtBx" + i, true)[0];
                if (textBox.Enabled)
                {
                    if (!int.TryParse(textBox.Text, out int numero)) //se for um número errado, da false
                        return false;

                    if (numero != 0 && !numerosRepetidos.Add(numero)) //se o número já tiver sido usado, da false
                        return false;
                }
            }

            return true; //os números inseridos pelo usuario está certo return true
        }


        private bool VerificarNumeros(params int[] numeros)
       {
            var numerosDistintos = numeros.Where(num => num != 0).Distinct().ToList();//aqui filtra os números repetidos e diferentes de 0
            return numerosDistintos.Count == numeros.Where(num => num != 0).Count();//se numerosDistinstos for igual a numeros return true
       }
    }
}