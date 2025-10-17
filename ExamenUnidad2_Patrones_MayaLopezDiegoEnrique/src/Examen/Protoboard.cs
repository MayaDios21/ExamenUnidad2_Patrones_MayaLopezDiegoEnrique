using System;

namespace CentroEducativoVR
{
    public class Protoboard : ObjetoVR
    {
        public Protoboard() : base("Protoboard 830 puntos") { }

        public override void Usar()
        {
            Console.WriteLine("[Protoboard] Conectando componentes en la placa de pruebas");
        }
    }
}