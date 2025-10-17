using System;

namespace CentroEducativoVR
{
    public class PanelInteractivo : ObjetoVR
    {
        public PanelInteractivo() : base("Panel Interactivo") { }

        public override void Usar()
        {
            Console.WriteLine("[Panel] Mostrando información interactiva");
        }
    }
}