using System;

namespace CentroEducativoVR
{
    public class Resistencia : ObjetoVR
    {
        public Resistencia() : base("Resistencia 220Ω") { }

        public override void Usar()
        {
            Console.WriteLine("[Resistencia] Limitando corriente en el circuito LED");
        }
    }
}