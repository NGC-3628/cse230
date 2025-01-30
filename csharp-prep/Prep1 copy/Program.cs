using System;

namespace draft_Projecto_1_habilidades_dig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double HORARIO_MENSUAL_NORMAL = 160;

            double sueldoPorHora = 0;
            double pagoHorasExtras = 0;
            double descuentoPorFaltas = 0;
            double sueldoTotal = 0;

            // Entrada de datos
            Console.WriteLine("¿Cuántas horas trabajaste?");
            double horasTrabajadas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("¿Cuál es tu sueldo mensual base?");
            double sueldoMensual = Convert.ToDouble(Console.ReadLine());

            // Cálculo del sueldo por hora
            sueldoPorHora = sueldoMensual / HORARIO_MENSUAL_NORMAL;

            // Calcular horas extras o faltantes
            double horasExtras = 0;
            double horasFaltantes = 0;

            if (horasTrabajadas > HORARIO_MENSUAL_NORMAL)
            {
                horasExtras = horasTrabajadas - HORARIO_MENSUAL_NORMAL;
            }
            else if (horasTrabajadas < HORARIO_MENSUAL_NORMAL)
            {
                horasFaltantes = HORARIO_MENSUAL_NORMAL - horasTrabajadas;
            }

            // Cálculo de pago por horas extras
            if (horasExtras > 0)
            {
                if (horasExtras <= 5)
                {
                    pagoHorasExtras += horasExtras * sueldoPorHora * 1.05;
                }
                else if (horasExtras <= 10)
                {
                    pagoHorasExtras += 5 * sueldoPorHora * 1.05; // Primeras 5 horas
                    pagoHorasExtras += (horasExtras - 5) * sueldoPorHora * 1.07; // Siguientes 5 horas
                }
                else if (horasExtras <= 15)
                {
                    pagoHorasExtras += 5 * sueldoPorHora * 1.05; // Primeras 5 horas
                    pagoHorasExtras += 5 * sueldoPorHora * 1.07; // Siguientes 5 horas
                    pagoHorasExtras += (horasExtras - 10) * sueldoPorHora * 1.12; // Siguientes 5 horas
                }
                else
                {
                    pagoHorasExtras += 5 * sueldoPorHora * 1.05; // Primeras 5 horas
                    pagoHorasExtras += 5 * sueldoPorHora * 1.07; // Siguientes 5 horas
                    pagoHorasExtras += 5 * sueldoPorHora * 1.12; // Siguientes 5 horas
                    pagoHorasExtras += (horasExtras - 15) * sueldoPorHora * 1.15; // Horas adicionales al 15%
                }
            }

            // Cálculo de descuento por faltas
            if (horasFaltantes > 0)
            {
                descuentoPorFaltas += horasFaltantes * sueldoPorHora;

                // Descuento adicional por días completos de falta
                int diasFaltados = (int)(horasFaltantes / 8);
                descuentoPorFaltas += diasFaltados * (sueldoMensual * 0.01);
            }

            // Cálculo del sueldo total
            sueldoTotal = sueldoMensual + pagoHorasExtras - descuentoPorFaltas;

            // Salida de resultados
            Console.WriteLine("Horas trabajadas: " + horasTrabajadas);
            Console.WriteLine("Horas extras: " + horasExtras);
            Console.WriteLine("Horas faltantes: " + horasFaltantes);
            Console.WriteLine("Pago por horas extras: " + pagoHorasExtras);
            Console.WriteLine("Descuento por faltas: " + descuentoPorFaltas);
            Console.WriteLine("Sueldo total: " + sueldoTotal);

            Console.ReadKey();
        }
    }
}
