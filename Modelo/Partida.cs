using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Modelo
{
    public class Partida
    {
        // Propiedades públicas para obtener información de la partida.
        public string NombreLocal { get => _nombreLocal; }
        public string NombreVisitante { get => _nombreVisitante; }
        public bool PartidaJugada { get => _partidaJugada; }
        public ResultadoPartida Resultado { get => _resultado; }

        // Constructor de la clase Partida que toma dos objetos de tipo Equipo como parámetros.
        public Partida(Equipo local, Equipo visitante)
        {
            _nombreLocal = local.Nombre;
            _nombreVisitante = visitante.Nombre;
        }

        // Método para registrar los resultados de la partida.
        public void RegistrarResultados(ResultadoPartida resultado)
        {
            if (PartidaJugada == false)
            {
                _resultado = resultado;
                _partidaJugada = true;
            }
        }

        // Método para modificar los resultados de la partida.
        public void ModificarResultados(ResultadoPartida resultado)
        {
            if (PartidaJugada == true)
            {
                _resultado = resultado;
            }
        }

        // Atributos privados de la clase Partida.
        private string _nombreLocal;
        private string _nombreVisitante;
        private bool _partidaJugada;
        private ResultadoPartida _resultado;

    }
}

