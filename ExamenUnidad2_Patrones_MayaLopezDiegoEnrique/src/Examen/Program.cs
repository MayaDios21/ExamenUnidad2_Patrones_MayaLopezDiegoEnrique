using System;

namespace CentroEducativoVR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== LABORATORIO VIRTUAL DE ELECTRÓNICA ===\n");

            // Patrón Singleton
            var sesion = AdministradorSesionVR.Instancia;
            sesion.IniciarSesion("Diego Maya", "Módulo de Circuitos Básicos");

            // Patrón Object Pool - Componentes electrónicos
            var poolMultimetros = new PoolDeObjetos<Multimetro>(() => new Multimetro());
            var poolProtoboards = new PoolDeObjetos<Protoboard>(() => new Protoboard());
            var poolResistencias = new PoolDeObjetos<Resistencia>(() => new Resistencia());
            var poolLEDs = new PoolDeObjetos<LED>(() => new LED());
            var poolFuentes = new PoolDeObjetos<FuenteDePoder>(() => new FuenteDePoder());

            // Práctica 1: Circuito LED simple
            Console.WriteLine("\n--- PRÁCTICA 1: CIRCUITO LED SIMPLE ---");
            var protoboard1 = poolProtoboards.Obtener();
            protoboard1.Usar();

            var fuente1 = poolFuentes.Obtener();
            fuente1.Usar();

            var resistencia1 = poolResistencias.Obtener();
            resistencia1.Usar();

            var led1 = poolLEDs.Obtener();
            led1.Usar();

            var multimetro1 = poolMultimetros.Obtener();
            multimetro1.Usar();

            // Liberar algunos componentes
            Console.WriteLine("\n--- FINALIZANDO PRÁCTICA 1 ---");
            poolResistencias.Liberar(resistencia1);
            poolLEDs.Liberar(led1);

            // Práctica 2: Circuito en paralelo
            Console.WriteLine("\n--- PRÁCTICA 2: CIRCUITO EN PARALELO ---");
            var resistencia2 = poolResistencias.Obtener(); // Reutiliza
            resistencia2.Usar();

            var led2 = poolLEDs.Obtener(); // Reutiliza
            led2.Usar();

            var led3 = poolLEDs.Obtener(); // Crea nuevo
            led3.Usar();

            // Cambiar módulo
            Console.WriteLine("\n--- CAMBIANDO A MÓDULO AVANZADO ---");
            sesion.IniciarSesion("Diego Maya", "Módulo de Circuitos Integrados");

            // Usar más componentes
            var multimetro2 = poolMultimetros.Obtener();
            multimetro2.Usar();

            // Mostrar estadísticas finales
            sesion.MostrarEstadisticas();

            Console.WriteLine("\n=== FIN DEL LABORATORIO VIRTUAL ===");
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}