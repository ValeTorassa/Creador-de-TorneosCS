using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioRango : IRepositorio
    {
        // Atributo privado para almacenar una lista de objetos de tipo Rango.
        private List<Rango> rangos;

        // Constructor de la clase RepositorioRango para inicializar la lista de rangos.
        public RepositorioRango()
        {
            rangos = new List<Rango>();
        }


        // Obtiene todos los rangos del repositorio
        public List<Rango> ObtenerTodos()
        {
            // Creamos una nueva lista para evitar modificar la original
            List<Rango> Rangos = rangos.ToList();

            return Rangos;
        }

        // Obtiene un rango por su nombre
        public Rango ObtenerPorNombre(string nombre)
        {
            return rangos.FirstOrDefault(r => r.Nombre.ToLower() == nombre.ToLower());
        }

        public bool Agregar(Rango rango)
        {
            if (rango is null) return false;

            var rangoEncontrado = ObtenerPorNombre(rango.Nombre);
            if (rangoEncontrado == null)
            {
                rangos.Add(rango);
                return true;
            }
            return false;
        }

        public bool Eliminar(Rango rango)
        {
            if (rangos.Contains(rango))
            {
                rangos.Remove(rango);
                return true;
            }
            return false;
        }

        public bool Actualizar(Rango rango)
        {
            Rango rangoExistente = rangos.Find(r => r.Nombre == rango.Nombre);
            if (rangoExistente != null)
            {
                rangoExistente.Escala = rango.Escala;
                return true;
            }
            return false;
        }

    }
}
