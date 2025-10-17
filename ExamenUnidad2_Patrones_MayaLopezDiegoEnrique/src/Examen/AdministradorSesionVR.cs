using System;
using System.Collections.Generic;

namespace CentroEducativoVR
{
    public class AdministradorSesionVR
    {
        private static AdministradorSesionVR _instancia;
        
        public string Usuario { get; private set; }
        public string Modulo { get; private set; }
        public int ObjetosUsados { get; private set; }

        private AdministradorSesionVR() { }

        public static AdministradorSesionVR Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new AdministradorSesionVR();
                return _instancia;
            }
        }

        public void IniciarSesion(string usuario, string modulo)
        {
            Usuario = usuario;
            Modulo = modulo;
            ObjetosUsados = 0;
            Console.WriteLine($"[SesionVR] Sesión iniciada: {usuario} en {modulo}");
        }

        public void RegistrarUso()
        {
            ObjetosUsados++;
        }

        public void MostrarEstadisticas()
        {
            Console.WriteLine($"\n=== ESTADÍSTICAS ===");
            Console.WriteLine($"Usuario: {Usuario}");
            Console.WriteLine($"Módulo: {Modulo}");
            Console.WriteLine($"Objetos usados: {ObjetosUsados}");
            Console.WriteLine($"===================\n");
        }
    }
}