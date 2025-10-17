using System;
using System.Collections.Generic;

namespace CentroEducativoVR
{
    public class PoolDeObjetos<T> where T : ObjetoVR
    {
        private List<T> _objetos = new List<T>();
        private Func<T> _crear;

        public PoolDeObjetos(Func<T> crear)
        {
            _crear = crear;
        }

        public T Obtener()
        {
            // Buscar objeto libre
            foreach (var obj in _objetos)
            {
                if (!obj.EnUso)
                {
                    Console.WriteLine("[Pool] Reutilizando objeto");
                    obj.Activar();
                    return obj;
                }
            }

            // Crear nuevo objeto
            Console.WriteLine("[Pool] Creando nuevo objeto");
            var nuevo = _crear();
            nuevo.Activar();
            _objetos.Add(nuevo);
            return nuevo;
        }

        public void Liberar(T objeto)
        {
            objeto.Liberar();
        }
    }
}