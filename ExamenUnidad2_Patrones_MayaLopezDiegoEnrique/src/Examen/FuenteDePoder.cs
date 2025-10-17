using System;

namespace CentroEducativoVR
{
    public class FuenteDePoder : ObjetoVR
    {
        public FuenteDePoder() : base("Fuente de Poder 0-30V") { }

        public override void Usar()
        {
            Console.WriteLine("[Fuente] Suministrando 5V DC al protoboard");
        }
    }
}