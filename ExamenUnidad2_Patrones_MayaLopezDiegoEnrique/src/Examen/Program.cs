using System;

namespace CentroEducativoVR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SIMULADOR EDUCATIVO VR ===\n");

            // Patrón Singleton
            var sesion = AdministradorSesionVR.Instancia;
            sesion.IniciarSesion("Diego Maya", "Módulo de Biología");

            // Patrón Object Pool
            var poolAvatar = new PoolDeObjetos<AvatarInstructor>(() => new AvatarInstructor());
            var poolInstrumento = new PoolDeObjetos<InstrumentoEducativo>(() => new InstrumentoEducativo());
            var poolPanel = new PoolDeObjetos<PanelInteractivo>(() => new PanelInteractivo());

            // Usar objetos
            Console.WriteLine("\n--- SOLICITANDO OBJETOS ---");
            var avatar1 = poolAvatar.Obtener();
            avatar1.Usar();

            var instrumento1 = poolInstrumento.Obtener();
            instrumento1.Usar();

            var panel1 = poolPanel.Obtener();
            panel1.Usar();

            // Liberar objetos
            Console.WriteLine("\n--- LIBERANDO OBJETOS ---");
            poolAvatar.Liberar(avatar1);
            poolInstrumento.Liberar(instrumento1);

            // Reutilizar objetos
            Console.WriteLine("\n--- REUTILIZANDO OBJETOS ---");
            var avatar2 = poolAvatar.Obtener(); // Reutiliza
            avatar2.Usar();

            var instrumento2 = poolInstrumento.Obtener(); // Reutiliza
            instrumento2.Usar();

            var panel2 = poolPanel.Obtener(); // Crea nuevo
            panel2.Usar();

            // Cambiar módulo
            Console.WriteLine("\n--- CAMBIANDO MÓDULO ---");
            sesion = AdministradorSesionVR.Instancia;
            sesion.IniciarSesion("Diego Maya", "Módulo de Química");

            // Usar más objetos
            var avatar3 = poolAvatar.Obtener();
            avatar3.Usar();

            // Mostrar estadísticas finales
            sesion.MostrarEstadisticas();

            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}