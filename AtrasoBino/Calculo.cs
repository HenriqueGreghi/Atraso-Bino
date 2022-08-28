using System;
using System.Collections.Generic;
using System.Text;

namespace AtrasoBino
{
    class Calculo
    {
        public int Hora { get; set; }
        public int Minuto { get; set; }

        public Calculo(int hora, int minuto)
        {
            Hora = hora;
            Minuto = minuto;
        }
        public string Atraso()
        {
            if (Hora < 7)
            {
                return "Não se atrasou = 00:00";
            }
            else if (Hora == 7)
            {
                return "Se atrasou = 00:" + Minuto;
            }
            else
            {
                return "Se atrasou = " + (Hora - 7 + 1) + ":" + Minuto;
            }
        }
    }
}
