using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public interface IRepositorio<T>
    {
        // Método para obtener todos los objetos
        List<T> ObtenerTodos();

        // Método para obtener un objeto por su nombre
        T ObtenerPorNombre(string nombre);

        // Método para agregar un objeto 
        bool Agregar(T obj);

        // Método para eliminar un objeto
        bool Eliminar(T obj);

        // Método para actualizar un objeto
        bool Actualizar(T objeto);    
    }
}
