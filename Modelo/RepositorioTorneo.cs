using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioTorneo : IRepositorio<Torneo>
    {
        private List<Torneo> torneos;

        public RepositorioTorneo()
        {
            // Inicialización del repositorio de torneos como una lista vacía.
            torneos = new List<Torneo>();
        }

        // Método para obtener un torneo por nombre
        public Torneo ObtenerPorNombre(string nombre)
        {
            // Utilizar LINQ para buscar(ignorando mayus) al primer torneo con el nombre proporcionado
            return torneos.FirstOrDefault(torneo => torneo.Nombre.ToLower() == nombre.ToLower());
        }

        // Método para obtener todos los torneos
        public List<Torneo> ObtenerTodos()
        {
            return torneos;
        }

        public bool Agregar(Torneo torneo)
        {
            if (torneo == null) return false;
            var torneoEncontrado = ObtenerPorNombre(torneo.Nombre);

            if (torneoEncontrado == null)
            {
                torneos.Add(torneo);
                return true;
            }
            return false;
        }

        public bool Eliminar(Torneo torneo)
        {
            if (torneos.Contains(torneo))
            {
                torneos.Remove(torneo);
                return true;
            }
            return false;
        }

        public bool Actualizar(Torneo torneo)
        {
            var torneoEncontrado = ObtenerPorNombre(torneo.Nombre);

            if (torneoEncontrado != null)
            {
                torneoEncontrado = torneo;
                return true;
            }
            return false;
        }

    }
}
