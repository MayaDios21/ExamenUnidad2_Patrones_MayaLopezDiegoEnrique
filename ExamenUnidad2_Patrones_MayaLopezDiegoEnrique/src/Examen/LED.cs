using System;

namespace CentroEducativoVR
{
    public class LED : ObjetoVR
    {
        public LED() : base("LED Rojo 5mm") { }

        public override void Usar()
        {
            Console.WriteLine("[LED] Emitiendo luz roja - Circuito funcionando correctamente");
        }
    }
}