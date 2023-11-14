using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class EstadisticasEquipo
    {

        // Propiedad pública para obtener el número de victorias en partidas.
        // Al actualizar este valor, también se recalcula el número de derrotas.
        public int Victorias { get => _victorias; set { _victorias = value; _perdidas = CalcularPerdidas(); } }

        // Propiedad pública para obtener el número de derrotas en partidas.
        public int Perdidas { get => _perdidas; }

        // Propiedad pública para obtener el número de rondas ganadas en partidas.
        // Al actualizar este valor, también se recalcula el número de rondas perdidas.
        public int RondasGanadas { get => _rondasGanadas; set { _rondasGanadas = value; _rondasPerdidas = CalcularRondasPerdidas(); } }

        // Propiedad pública para obtener el número de rondas perdidas en partidas.
        // Esta propiedad no tiene un valor directo asignado, se calcula a partir de otros valores.
        public int RondasPerdidas { get => _rondasPerdidas; }

        // Propiedad pública para obtener el número de asesinatos (kills) en partidas.
        public int Kills { get => _kills; set => _kills = value; }

        // Propiedad pública para obtener el número total de partidas jugadas.
        // Al actualizar este valor, también se recalcula el número de derrotas.
        public int TotalPartidas { get => _totalPartidas; set { _totalPartidas = value; _perdidas = CalcularPerdidas(); } }

        // Propiedad pública para obtener el número total de rondas jugadas.
        // Al actualizar este valor, también se recalcula el número de rondas perdidas.
        public int TotalRondas { get => _totalRondas; set { _totalRondas = value; _rondasPerdidas = CalcularRondasPerdidas(); } }

        // Método privado para calcular el número de rondas perdidas.
        private int CalcularRondasPerdidas()
        {
            return _totalRondas - _rondasGanadas;
        }

        // Método privado para calcular el número de derrotas.
        private int CalcularPerdidas()
        {
            return _totalPartidas - _victorias;
        }

        // Método público para calcular el porcentaje de victorias.
        public int PorcentajeVictorias()
        {
            return Victorias * 100 / TotalPartidas;
        }

        public override string ToString()
        {
            return "Calculadas";
        }

        // Variables privadas utilizadas para almacenar los datos internamente en la clase.
        private int _victorias;
        private int _perdidas;
        private int _totalPartidas;
        private int _rondasGanadas;
        private int _rondasPerdidas;
        private int _totalRondas;
        private int _kills;


    }
}
