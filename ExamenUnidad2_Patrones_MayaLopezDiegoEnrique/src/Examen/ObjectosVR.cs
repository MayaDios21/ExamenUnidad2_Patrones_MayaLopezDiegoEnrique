using System;
namespace CentroEducativoVR
{
    public abstract class ObjetoVR
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public bool EnUso { get; set; }

        protected ObjetoVR(string nombre)
        {

            Nombre = nombre;
            EnUso = false;
        }

        public abstract void Usar();

        public void Activar()
        {
            EnUso = true;
            Console.WriteLine($"[VRObjeto] {Nombre} (ID: {id}) activado.");
        }

        public void Liberar()
        {
            EnUso = false;
            Console.WriteLine($"[VRObjeto] {Nombre} (ID: {id}) liberado y listo para usar.");
        }

        public override string ToString()
        {
            return $"{Nombre} [ID: {id}, En uso: {EnUso}]";
        }
    }
}