namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            float peso = Convert.ToSingle(txtpeso.Text);
            float altura = Convert.ToSingle(textaltura.Text);

            float imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                resultado.Text = "Abaixo do peso";
                resultvalor.Text = imc.ToString();
            }
            else if (18.5 >= imc && imc < 24.9)
            {
                resultado.Text = "Peso normal ";
                resultvalor.Text = imc.ToString();
            }
            else if (25 >= imc && imc < 29.9)
            {
                resultado.Text = "Sobrepeso";
                resultvalor.Text = imc.ToString();
            }
            else if (30 >= imc)
            {
                resultado.Text = "Obesidade";
                resultvalor.Text = imc.ToString();
            }
            else
            {
                resultado.Text = "Valor acima de 30";
                resultvalor.Text = imc.ToString();

            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}