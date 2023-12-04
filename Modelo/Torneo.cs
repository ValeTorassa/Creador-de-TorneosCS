using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Torneo
    {
        //Propiedades publicas de la clase Torneo
        public string Nombre { get => _nombre; set => _nombre = value; }

        // Propiedad para obtener la lista de partidas
        public List<Partida> Partidas { get => _partidas; }

        // Propiedad para obtener la lista de equipos
        public List<Equipo> Equipos { get => _equipos; }

        // Constructor de la clase Torneo
        public Torneo()
        {
            _equipos = new List<Equipo>();
            _partidas = new List<Partida>();
        }

        // Método para generar equipos aleatorios a partir de jugadores disponibles
        public void EquiposAleatorios(int Total, List<Jugador> jugadoresTotales)
        {
            List<Equipo> equiposAleatorios = new List<Equipo>();
            Random random = new Random();
            int jugadoresEquipos = 0;
            var jugadoresDisponibles = jugadoresTotales.OrderBy(jugadores => random.Next()).ToList();

            for (int i = 0; i < Total / 5; i++)
            {
                Equipo equipo = new Equipo();
                equipo.Nombre = "Equipo " + _colores[i];

                for (int j = 0; j < 5; j++)
                {
                    equipo.AsignarJugadores(jugadoresDisponibles[jugadoresEquipos]);
                    jugadoresEquipos++;
                }

                equiposAleatorios.Add(equipo);
            }

            _equipos = equiposAleatorios;

            Enfrentamientos();
        }

        // Método para generar enfrentamientos de todos los equipos contra todos los equipos
        public void Enfrentamientos()
        {
            // Obtener una lista de todos los equipos disponibles
            var equiposDisponibles = _equipos.ToList();

            // Crear una lista para almacenar todas las partidas
            List<Partida> todasLasPartidas = new List<Partida>();

            // Usar una variable para alternar entre local y visitante
            bool equipoEsLocal = true;

            // Recorrer todos los equipos en un bucle anidado para crear las combinaciones de enfrentamientos
            for (int i = 0; i < equiposDisponibles.Count - 1; i++)
            {
                for (int j = i + 1; j < equiposDisponibles.Count; j++)
                {
                    // Determinar qué equipo será local y cuál visitante en esta partida
                    Equipo equipoLocal, equipoVisitante;
                    if (equipoEsLocal)
                    {
                        equipoLocal = equiposDisponibles[i];
                        equipoVisitante = equiposDisponibles[j];
                    }
                    else
                    {
                        equipoLocal = equiposDisponibles[j];
                        equipoVisitante = equiposDisponibles[i];
                    }

                    // Alternar para la próxima partida
                    equipoEsLocal = !equipoEsLocal;

                    // Crear una nueva partida con los equipos actuales en las posiciones i y j
                    var partida = new Partida(equipoLocal, equipoVisitante);

                    // Agregar la partida a la lista de todas las partidas
                    todasLasPartidas.Add(partida);
                }

                // Desordenar aleatoriamente las partidas para distribuir los enfrentamientos
                var random = new Random();
                todasLasPartidas = todasLasPartidas.OrderBy(partida => random.Next()).ToList();
            }

            // Asignar las partidas creadas a la propiedad _partidas del torneo
            _partidas = todasLasPartidas;
        }

        // Método para obtener las estadísticas de todos los equipos en el torneo.
        public List<EstadisticasEquipo> ObtenerEstadisticas()
        {
            List<EstadisticasEquipo> resultados = new List<EstadisticasEquipo>();

            // Itera a través de todos los equipos y agrega sus estadísticas a la lista de resultados.
            foreach (var equipo in _equipos)
            {
                resultados.Add(equipo.Estadisticas);
            }

            return resultados;
        }

        // Método para calcular estadísticas globales del torneo.
        public void CalcularEstadisticas()
        {
            List<string> mapas = new List<string>();

            // Itera a través de todas las partidas en el torneo.
            foreach (var partida in _partidas.Where(p => p.PartidaJugada))
            {
                // Encuentra los equipos correspondientes a las partidas.
                var equipoLocal = _equipos.FirstOrDefault(e => e.Nombre == partida.NombreLocal);
                var equipoVisitante = _equipos.FirstOrDefault(e => e.Nombre == partida.NombreVisitante);

                // Actualiza las estadísticas de los equipos en función de los resultados de la partida.
                ActualizarEstadisticas(
                                        equipoLocal,
                                        partida.Resultado.GanadorLocal,
                                        partida.Resultado.RondasLocal,
                                        partida.Resultado.MuertesLocal
                                        );

                ActualizarEstadisticas(
                                        equipoVisitante,
                                        partida.Resultado.GanadorVisitante,
                                        partida.Resultado.RondasVisitante,
                                        partida.Resultado.MuertesVisitante
                                        );

                _duracionPromedio = _duracionPromedio + partida.Resultado.Duracion;

                mapas.Add(partida.Resultado.Mapa);
            }

            // Calcula la duración promedio de las partidas y el mapa más jugado.
            _duracionPromedio = _duracionPromedio / _partidas.Count;
            _mapaMasJugado = mapas.GroupBy(mapa => mapa).OrderByDescending(mapas => mapas.Count()).First().Key;
        }

        // Propiedad pública para obtener la duración promedio de las partidas en el torneo.
        public int DuracionPromedio { get => _duracionPromedio; }

        // Propiedad pública para obtener el mapa más jugado en el torneo.
        public string MapaMasJugado { get => _mapaMasJugado; }

        // Método privado para actualizar las estadísticas de un equipo en función de los resultados de la partida.
        private void ActualizarEstadisticas(Equipo equipo, bool ganada, int rondasGanadas, int kills)
        {
            equipo.CrearoActualizarEstadisticas(ganada, rondasGanadas, kills);
        }

        public string GenerarReporteEstadisticasGlobales()
        {
            try{
                string nombreArchivo = Nombre + ".html";
                string rutaCarpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "html");
                string rutaArchivo = Path.Combine(rutaCarpeta, nombreArchivo);

                if (!Directory.Exists(rutaCarpeta))
                {
                    Directory.CreateDirectory(rutaCarpeta);
                }


                string contenidoHTML = "<html><head><title>Reporte de Estadisticas del Torneo</title></head><body>";

                contenidoHTML += "<h1>Estadisticas del Torneo</h1>";

                contenidoHTML += "<h2>Posiciones</h2>";
                contenidoHTML += "<ul>";

                var equiposOrdenados = Equipos.OrderByDescending(e => e.Estadisticas.Victorias).ToList();
                foreach (var equipo in equiposOrdenados)
                {
                    contenidoHTML += $"<li>{equipo.Nombre}: Victorias - {equipo.Estadisticas.Victorias}, Rondas Ganadas - {equipo.Estadisticas.RondasGanadas}, Kills - {equipo.Estadisticas.Kills}</li>";
                }

                contenidoHTML += "</ul>";

                contenidoHTML += "<h2>Destacados</h2>";
                contenidoHTML += $"<p>Duracion Promedio: {DuracionPromedio} minutos</p>";
                contenidoHTML += $"<p>Mapa Mas Jugado: {MapaMasJugado}</p>";

                var equipoConMasKills = Equipos.OrderByDescending(e => e.Estadisticas.Kills).FirstOrDefault();
                contenidoHTML += $"<p>Equipo con mas Kills: {equipoConMasKills.Nombre} ({equipoConMasKills.Estadisticas.Kills})</p>";

                contenidoHTML += "</body></html>";

                File.WriteAllText(rutaArchivo, contenidoHTML);

                Process.Start(new ProcessStartInfo(rutaArchivo) { UseShellExecute = true });

                return "El Reporte se ha generado con exito en la ruta " + rutaArchivo;
            }catch(Exception e)
            {
                return "No se ha podido generar el reporte. Excpecion: " + e.Message;
            }

        }

        // Atributos privados de la clase Torneo
        private string _nombre;
        private List<Partida> _partidas;
        private List<Equipo> _equipos;
        private string[] _colores = {
            "Rojo", "Amarillo", "Verde", "Azul", "Violeta",
            "Rosa", "Naranja", "Turquesa", "Cyan", "Azul marino",
            "Morado", "Fucsia", "Carmesí", "Magenta", "Ocre",
            "Blanco", "Negro", "Gris", "Plateado", "Dorado" };
        private int _duracionPromedio;
        private string _mapaMasJugado;

    }
}
