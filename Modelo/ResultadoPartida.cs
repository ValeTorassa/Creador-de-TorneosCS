using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ResultadoPartida
    {
        // Propiedades públicas para obtener información del resultado de la partida.
        public bool GanadorLocal { get => _ganadorLocal; }
        public bool GanadorVisitante { get => _ganadorVisitante; }
        public int RondasLocal { get => _rondasLocal; }
        public int RondasVisitante { get => _rondasVisitante; }
        public int MuertesLocal { get => _muertesLocal; }
        public int MuertesVisitante { get => _muertesVisitante; }
        public int Duracion { get => _duracion; }
        public string Mapa { get => _mapa; }

        // Constructor de la clase ResultadoPartida para inicializar los resultados de una partida.
        public ResultadoPartida(bool ganadorLocal, int rondasLocal, int muertesLocal, bool ganadorVisitante, int rondasVisitante, int muertesVisitante, int duracion, string mapa)
        {
            _ganadorLocal = ganadorLocal;
            _rondasLocal = rondasLocal;
            _muertesLocal = muertesLocal;
            _ganadorVisitante = ganadorVisitante;
            _rondasVisitante = rondasVisitante;
            _muertesVisitante = muertesVisitante;
            _duracion = duracion;
            _mapa = mapa;
        }

        public override string ToString()
        {
            if (GanadorLocal)
            {
                return "Equipo Local";
            }
            else if (GanadorVisitante)
            {
                return "Equipo Visitante";
            }
            else
            {
                return "Empate";
            }
        }

        // Atributos privados de la clase ResultadoPartida
        private bool _ganadorLocal;
        private bool _ganadorVisitante;
        private int _rondasLocal;
        private int _rondasVisitante;
        private int _muertesLocal;
        private int _muertesVisitante;
        private int _duracion;
        private string _mapa;


    }
}
