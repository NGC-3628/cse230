using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD13._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int HorasTrabajadasSemanal = 0;
            double SueldoMensual = 0;

            Console.WriteLine("Ingrese las horas trabajadas en la semana: ");
            HorasTrabajadasSemanal = int.Parse(Console.ReadLine());

            if (HorasTrabajadasSemanal > 168)
            {
                Console.WriteLine("Usted NO pudo haber trabajado más de 168 horas en la semana.");
            }
            else
            {
                Console.WriteLine("Ingrese su salario mensual: ");
                SueldoMensual = double.Parse(Console.ReadLine());

                const int JornadaMesCompleto = 4;
                const int JornadaSemanalCompleta = 40;
                const int JornadaDiaria = 8;
                const int LimiteTEPorcentaje = 5;

                double Residuo = HorasTrabajadasSemanal - JornadaSemanalCompleta;
                double Porciento = 0.05;
                double ContadorDeTE = 0;
                double SueldoPorHora = (SueldoMensual / (JornadaSemanalCompleta * JornadaMesCompleto));
                double AuxiliarDeResiduo = Residuo;

                double HorasBase = Residuo > 0 ? JornadaSemanalCompleta : HorasTrabajadasSemanal;

                while (Residuo > 0)
                {
                    if (Residuo <= LimiteTEPorcentaje || Porciento == 0.15)
                    {
                        ContadorDeTE += Residuo * (SueldoPorHora * (1 + Porciento));
                        Residuo = 0;
                    }
                    else
                    {
                        ContadorDeTE += LimiteTEPorcentaje * (SueldoPorHora * (1 + Porciento));
                        Residuo -= LimiteTEPorcentaje;
                        Porciento += 0.02;
                    }
                }

                double PorcentajeDescuentoPorHr = 0.01;
                double ContadorDeDescuento = 0;
                while (Residuo < 0)
                {
                    if (Residuo>-JornadaDiaria)
                    {
                        ContadorDeDescuento -= Residuo * SueldoPorHora;
                        Residuo = 0;
                    }
                    else
                    {
                        ContadorDeDescuento -= SueldoPorHora * JornadaDiaria - (SueldoMensual * PorcentajeDescuentoPorHr);
                        Residuo += JornadaDiaria;
                    }
                }

                double TotalSueldo = (HorasBase * SueldoPorHora) + ContadorDeTE - ContadorDeDescuento;

                Console.WriteLine("Sueldo total: $" + TotalSueldo);

                if (AuxiliarDeResiduo>0)
                {
                    Console.WriteLine("Total sueldo horas extras: $" + ContadorDeTE);
                    Console.WriteLine("Total de horas extras: " + AuxiliarDeResiduo);
                }
                else if (AuxiliarDeResiduo<0)
                {
                    Console.WriteLine("Total descuento de horas de ausencia: $" + ContadorDeDescuento);
                    Console.WriteLine("Total horas faltantes: " + AuxiliarDeResiduo);
                }
                else
                {
                    Console.WriteLine("Sin calculos de horas extras, ni deducciones extras.");
                }
                Console.ReadKey();
            }
        }
    }
}
