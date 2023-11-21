using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioJugador : IRepositorio<Jugador>
    {
        //Almacena la lista de jugadores
        private List<Jugador> jugadores;

        //Constructor que inicializa una lista de jugadores en el repositorio
        public RepositorioJugador()
        {
            jugadores = new List<Jugador>();
        }

        // Obtiene todos los jugadores del repositorio
        public List<Jugador> ObtenerTodos()
        {
            // Creamos una nueva lista para evitar modificar la original
            List<Jugador> Jugadores = jugadores.ToList();

            return Jugadores;
        }

        // Obtiene un jugador por su nombre
        public Jugador ObtenerPorNombre(string nombre)
        {
            return jugadores.FirstOrDefault(j => j.Nombre.ToLower() == nombre.ToLower());
        }

        public bool Agregar(Jugador jugador)
        {
            var jugadorEncontrado = ObtenerPorNombre(jugador.Nombre);
            if (jugadorEncontrado == null)
            {
                jugadores.Add(jugador);
                return true;
            }
            return false;
        }

        public bool Eliminar(Jugador jugador)
        {
            if (jugadores.Contains(jugador))
            {
                jugadores.Remove(jugador);
                return true;
            }
            return false;
        }

        public bool Actualizar(Jugador jugador)
        {
            Jugador jugadorExistente = jugadores.Find(j => j.Nombre == jugador.Nombre);
            if (jugadorExistente != null)
            {
                // Actualizamos los puntos del jugador
                jugadorExistente = jugador;
                return true;
            }
            return false;
        }


        // Obtiene una lista de jugadores profesionales
        public List<Jugador> ObtenerProfesionales(List<Rango> rangos)
        {
            // Encontrar el rango con la mayor cantidad de puntos
            Rango rangoMaximo = rangos.OrderByDescending(r => r.Escala).FirstOrDefault();

           
                // Obtener todos los jugadores que tienen el rango máximo
                List<Jugador> jugadoresRangoMaximo = jugadores
                .Where(jugador => jugador.Rango.Nombre == rangoMaximo.Nombre)
                .ToList();

                return jugadoresRangoMaximo;
            
            
        }

        //Obtiene una lista de jugadores que no esta en algun equipo
        public List<Jugador> ObtenerJugadoresNoEnEquipo()
        {
            return jugadores.Where(j => j.EnEquipo == false).ToList();
        }

        //Obtiene una lista de jugadores Profesionales que no esta en algun equipo.
        public List<Jugador> ObtenerJugadoresNoEnEquipoProfesionales(List<Rango> rangos)
        {
            // Encontrar el rango con la mayor cantidad de puntos
            Rango rangoMaximo = rangos.OrderByDescending(r => r.Escala).FirstOrDefault();

            if (rangoMaximo != null)
            {
                return jugadores.Where(j => j.EnEquipo == false && j.Rango.Nombre == rangoMaximo.Nombre).ToList();
            }
            else
            {
                throw new Exception ("El rango maximo no existe");
            }
        }

    }
}
