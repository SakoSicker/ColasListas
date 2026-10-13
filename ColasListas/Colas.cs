using System;
using System.Collections.Generic;
using System.Text;

namespace ColasListas
{
    internal class Colas
    {
        private List<string> _cola;

        public Colas()
        {
            _cola = new List<string>();
        }

        public void Agregar(string dato)
        {
            _cola.Add(dato);
        }

        public void Eliminar()
        {
            if (_cola.Count == 0)
            {
                throw new Exception("La cola está vacía.");
            }
            _cola.RemoveAt(0);
        }

        public string ObtenerDatos()
        {
            StringBuilder datos = new StringBuilder();
            foreach (string dato in _cola)
            {
                datos.AppendLine(dato);
            }
            return datos.ToString();
        }
    }
}
    