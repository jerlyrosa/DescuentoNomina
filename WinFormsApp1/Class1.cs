using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionÁsignacion2
{
    class ClassNomina
    {

   public ClassNomina (double salarioBase, double horasExtras = 0)
    {
        this.SalarioBase = salarioBase;
        this.HorasExtras = horasExtras;






    }
        public double HorasExtras { get; set; }
        public double SalarioBase { get; set; }

        public double DescuentoARS { get; set; }
        public double DescuentoAFP { get; set; }
        public double DescuentoISR { get; set; }
        public double TotalDescuento { get; set; }
        public double SueldoNeto { get; set; }



        public string CalcularAFP()
        {
            DescuentoAFP = SalarioBase * 0.087;

            string valor = Convert.ToString(Math.Round(DescuentoAFP, 2));

            return valor;
        }


        public string CalcularARS()
        {
            DescuentoARS = SalarioBase * 0.0304;

            string valor = Convert.ToString(Math.Round(DescuentoARS, 2));

            return valor;
        }

        public string CalcularDescuentoTotal()
        {
            TotalDescuento = DescuentoAFP + DescuentoARS;

            string valor = Convert.ToString(Math.Round(TotalDescuento, 2));

            return valor;
        }
        public string CalcularSueldoNeto()
        {
            SueldoNeto = (SalarioBase - TotalDescuento) + HorasExtras;

            string valor = Convert.ToString(Math.Round(SueldoNeto, 2));

            return valor;
        }

        public string CalcularISR()
        {
           double valorAnual = SueldoNeto * 12;
            double porcentaje;

            if(valorAnual <= 416220)
            {
                DescuentoISR = 0;
            }else if(valorAnual >= 416221 && valorAnual <= 6243290)
            {
                porcentaje = ((valorAnual - 416221) * 15) / 100;
                DescuentoISR = porcentaje / 12;
            }
            else if (valorAnual >= 624339 && valorAnual <= 867123)
            {
                porcentaje = (((valorAnual - 624329) * 20)/100) + 31216;
                DescuentoISR = porcentaje / 12;
            }

            else if (valorAnual > 867123 )
            {
                porcentaje = (((valorAnual - 867124) * 25) / 100) + 79776;
                DescuentoISR = porcentaje / 12;
            }


            string valor = Convert.ToString(Math.Round(DescuentoISR, 2));

            return valor;
        }




    }








}
