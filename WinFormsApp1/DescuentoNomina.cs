using System;
using Programacion¡signacion2;


namespace WinFormsApp1

{
    public partial class DescuentoNomina : Form
    {
        public DescuentoNomina()
        {
            InitializeComponent();
        }

        private void calcular_Click(object sender, EventArgs e)
        {

            bool isvalorAFP = double.TryParse(InputSalarioMensual.Text, out double valorAFP);
            bool isvalorExtras = double.TryParse(InputHorasExtras.Text, out double valorHX);
            if (isvalorAFP)
            {
                if(valorAFP < 0 ||  valorHX < 0)
                {
                    MessageBox.Show("Ingresa un sueldo mayor a cero");
                    InputSalarioMensual.Clear();

                }
                else
                {
                    ClassNomina classNomina = new ClassNomina(valorAFP, valorHX);

                    InputAfp.Text = classNomina.CalcularAFP();
                    inputArs.Text = classNomina.CalcularARS();
                    InputTotalDescuento.Text = classNomina.CalcularDescuentoTotal();
                    InputSueldoNeto.Text = classNomina.CalcularSueldoNeto();
                    InputIsr.Text = classNomina.CalcularISR();
                }
            }
            else
            {
                MessageBox.Show("Valor invalido");
                InputSalarioMensual.Clear();

            }



        }
    }
}