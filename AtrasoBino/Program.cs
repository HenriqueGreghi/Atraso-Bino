using System;

namespace AtrasoBino
{
    class Program
    {
        static void Main(string[] args)
        { 

            Console.WriteLine("Qual o horário que o Bino acordou?");
            string[] valores = Console.ReadLine().Split(':');
            int hora = int.Parse(valores[0]);
            int minuto = int.Parse(valores[1]);

            Calculo calc = new Calculo(hora, minuto);

            Console.WriteLine(calc.Atraso());
        }
    }
}
