using System;

namespace CentroEducativoVR
{
    public class Multimetro : ObjetoVR
    {
        public Multimetro() : base("Multímetro Fluke 117") { }

        public override void Usar()
        {
            Console.WriteLine("[Multímetro] Midiendo voltaje del circuito: 5.2V DC");
        }
    }
}