using System.Globalization;

namespace calculadora_IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void altura_TextChanged(object sender, EventArgs e)
        {

        }

        private void peso_TextChanged(object sender, EventArgs e)
        {

        }

        private void resultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Ler e converter valores das TextBox
                double peso = Convert.ToDouble(txtPeso.Text, CultureInfo.InvariantCulture);
                double altura = Convert.ToDouble(txtAltura.Text, CultureInfo.InvariantCulture);

                // Calcular o IMC
                double imc = peso / (altura * altura);

                // Exibir o IMC em uma Label
                valorIMC.Text = imc.ToString("F2");
                valorIMC.Visible = true;

                // Determinar a classificação
                string classificacao = string.Empty;

                if (imc < 16.9)
                    classificacao = "Muito abaixo do peso";
                else if (imc >= 17 && imc <= 18.4)
                    classificacao = "Abaixo do peso";
                else if (imc >= 18.5 && imc <= 24.9)
                    classificacao = "Peso Normal";
                else if (imc >= 25 && imc <= 29.9)
                    classificacao = "Acima do Peso";
                else if (imc >= 30 && imc <= 34.9)
                    classificacao = "Obesidade grau 1";
                else if (imc >= 35 && imc <= 40)
                    classificacao = "Obesidade grau 2";
                else if (imc > 40)
                    classificacao = "Obesidade grau 3";

                // Exibir a classificação em outra Label
                resultado.Text = classificacao;
                resultado.Visible = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores numéricos válidos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpar os campos de entrada e o resultado
            txtAltura.Clear();
            txtPeso.Clear();
            resultado.Clear();
        }
    }
}
