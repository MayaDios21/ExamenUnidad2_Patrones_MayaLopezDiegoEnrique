using System;

namespace CentroEducativoVR
{
    public class InstrumentoEducativo : ObjetoVR
    {
        public InstrumentoEducativo() : base("Instrumento Educativo") { }

        public override void Usar()
        {
            Console.WriteLine("[Instrumento] Realizando experimento educativo");
        }
    }
}