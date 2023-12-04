using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Equipo
    {
        //Propiedades públicas que definen los atributos del Equipo
        public string Nombre { get => _nombre; set => _nombre = value; }
        public Jugador Capitan{ get => _capitan ; } 
        public EstadisticasEquipo Estadisticas { get => _estadisticasEquipo; }

        //Metodo que devuelve la lista de Jugadores del Equipo
        public List<Jugador> Jugadores { get => _jugadores; }

        //Constructor de la clase Equipo
        public Equipo()
        {
            _jugadores = new List<Jugador>();
        }

        // Método para asignar un jugador al equipo
        public void AsignarJugadores(Jugador jugador)
        {          
            _jugadores.Add(jugador);

            if (_jugadores.Count == _cantidadIntegrantes) 
            {
                SeleccionarCapitan();
            }
        }

        //Metodo para Elegir un Capitan del equipo
        private void SeleccionarCapitan()
        {
            int valorRango = 0;
            int indexCapitan = 0;
            //Recorre todos los integrantes del equipo
            for (int i = 0; i < _cantidadIntegrantes; i++)
            {    // El primer jugador establece su rango como valor inicial
                if (i == 0)
                {
                    valorRango = _jugadores[0].Rango.Escala;
                }
                //Si el rango del jugador actual es mayor al valorRango, lo reemplaza
                if (_jugadores[i].Rango.Escala > valorRango)
                {
                    valorRango = _jugadores[i].Rango.Escala;
                    indexCapitan = i;
                }
            }

            // Asignar el jugador con el rango más alto como capitán del equipo
            _capitan = _jugadores[indexCapitan];
        }


        // Método para crear o actualizar las estadísticas del equipo en función del resultado de una partida.
        public void CrearoActualizarEstadisticas(bool ganador, int rondasGanadas, int kills)
        {
            if (_estadisticasEquipo == null)
            {
                // Si las estadísticas del equipo aún no existen, se crean y se inicializa el contador de partidas.
                _estadisticasEquipo = new EstadisticasEquipo();
                _estadisticasEquipo.TotalPartidas = 0;
            }

            // Se incrementa el contador de partidas jugadas por el equipo.
            _estadisticasEquipo.TotalPartidas++;

            if (ganador)
            {
                // Si el equipo ganó la partida, se incrementa el contador de victorias.
                _estadisticasEquipo.Victorias++;
            }

            // Se suma el número fijo de rondas (30) al total de rondas jugadas por el equipo.
            _estadisticasEquipo.TotalRondas += 30;

            // Se suman las rondas ganadas y los kills al equipo.
            _estadisticasEquipo.RondasGanadas += rondasGanadas;
            _estadisticasEquipo.Kills += kills;
        }

        // Atributos privados de la clase Equipo.
        private string _nombre;
        private List<Jugador> _jugadores;
        private Jugador _capitan;
        private int _cantidadIntegrantes = 5;
        private EstadisticasEquipo _estadisticasEquipo;

    }
}
