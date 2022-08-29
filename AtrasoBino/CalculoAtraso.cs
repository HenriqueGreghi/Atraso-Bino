using System;
using System.Collections.Generic;
using System.Text;

namespace AtrasoBino
{
    class CalculoAtraso
    {
        private int Hora { get; set; }
        private int Minuto { get; set; }
        private string TempoAtraso { get; set; }

        public CalculoAtraso(int hora, int minuto)
        {
            Hora = hora;
            Minuto = minuto;
        }

        public void Atraso()
        {
            if (Hora < 7)
            {
               TempoAtraso = "Não se atrasou = 00:00";
            }
            else if (Hora == 7)
            {
                TempoAtraso = "Se atrasou = 00:" + Minuto;
            }
            else
            {
                TempoAtraso = "Se atrasou = " + (Hora - 7 + 1) + ":" + Minuto;
            }

            
        }
        public override string ToString()
        {
            return base.ToString()+ TempoAtraso;
        }
    }
}
