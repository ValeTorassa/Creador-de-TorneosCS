using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class GestorTorneo
    {
        // Atributo privado estático para almacenar la única instancia de la clase GestorTorneo.
        private static GestorTorneo instancia;

        // Propiedad pública estática para acceder a la instancia del GestorTorneo.
        public static GestorTorneo Instancia
        {
            get
            {
                // Verifica si la instancia ya existe; si no, la crea.
                if (instancia == null)
                {
                    instancia = new GestorTorneo();
                }
                return instancia;
            }
        }

        //Constructor que inicializa los repositorios
        private GestorTorneo()
        {
            repositorioTorneo = new RepositorioTorneo();
            repositorioRango  = new RepositorioRango();
            repositorioJugador = new RepositorioJugador();
            repositorioTorneoProfesional = new RepositorioTorneo();
        }


        //Metodo para crear un Torneo Casual
        public string CrearTorneoCasual(string nombre, int Total)
        {
            try
            {
                if (repositorioTorneo.ObtenerTodos().Any(t => t.Nombre == nombre)) return "Ya existe un torneo con ese nombre.";

                if (Total > ObtenerJugadoresSinEquipo().Count && Total <= 10) return "El torneo no tiene suficientes jugadores disponibles o son menos de 10.";

                Torneo torneo = new Torneo();
                torneo.Nombre = nombre;
                torneo.EquiposAleatorios(Total, ObtenerJugadoresSinEquipo());

                foreach (var equipo in torneo.GetEquipos())
                {
                    foreach (var jugador in equipo.GetJugadores())
                    {
                        jugador.EnEquipo = true;
                    }
                }

                return (repositorioTorneo.Agregar(torneo)) ? "El torneo se agregó correctamente." : "El torneo no se ha podido agregar.";

            }catch (Exception e)
            {
                return "Ha ocurrido una excepcion: " + e.Message;
            }

        }
    

        //Metodo para crear un Torneo Profesional
        public string CrearTorneoProfesional(string nombre, int Total, string ubicacion, int premio)
        {
            try 
            { 
                if (repositorioTorneoProfesional.ObtenerTodos().Any(t => t.Nombre == nombre)) return "Ya existe un torneo con ese nombre.";

                if (Total > ObtenerJugadoresSinEquipoProfesionales().Count && Total <= 10) return "El torneo no tiene suficientes jugadores disponibles o son menos de 10.";

                if (repositorioRango.ObtenerTodos().OrderByDescending(r => r.Escala).FirstOrDefault() == null) return "No hay rangos disponibles.";
                // Crea un torneo nuevo con los parámetros recibidos.
                TorneoProfesional torneo = new TorneoProfesional();
                torneo.Nombre = nombre;
                torneo.Ubicacion = ubicacion;
                torneo.Premio = premio;
                torneo.EquiposAleatorios(Total, repositorioJugador.ObtenerProfesionales(repositorioRango.ObtenerTodos()));

                // Marca a los jugadores como parte de un equipo
                foreach (var equipo in torneo.GetEquipos())
                {
                    foreach (var jugador in equipo.GetJugadores())
                    {
                        jugador.EnEquipo = true;
                    }
                }

                // Agrega el torneo profesional a su repositorio
                return (repositorioTorneoProfesional.Agregar(torneo)) ? "El torneo se agregó correctamente." : "El torneo no se ha podido agregar";
            }
            catch (Exception e)
            {
                return "Ha ocurrido una excepcion: " + e.Message;
            }

        }


        //Metodo para crear un nuevo Jugador
        public string CrearJugador(string nombre, string nombreRango)
        {
            try 
            { 
                if (repositorioJugador.ObtenerTodos().Any(j => j.Nombre == nombre)) return "Ya existe un jugador con ese nombre.";

                Rango rango = repositorioRango.ObtenerPorNombre(nombreRango);
                if (rango == null) return "El rango especificado no existe.";

                Jugador nuevoJugador = new Jugador
                {
                    Nombre = nombre,

                    Rango = rango 
                };

                return repositorioJugador.Agregar(nuevoJugador) ? "El jugador se agregó correctamente." : "Ha ocurrido un error al agregar el jugador.";

            }
            catch (Exception e)
            {
                return "Ha ocurrido una excepcion: " + e.Message;
            }
        }


        //Metodo para crear un nuevo Rango
        public string CrearRango(string nombre, int puntos)
        {
            try 
            { 
                if (repositorioRango.ObtenerTodos().Any(r => r.Nombre == nombre)) return "Ya existe un Rango con ese Nombre";

                Rango rango = new Rango(nombre, puntos);

                return (repositorioRango.Agregar(rango)) ? "El rango se ha agregado correctamente" : "Ha ocurrido un error al agregar el rango";
            }
            catch (Exception e)
            {
                return "Ha ocurrido una excepcion: " + e.Message;
            }
        }

        // Método para Eliminar un Torneo Casual
        public string EliminarTorneoCasual(Torneo torneo)
        {
            try 
            {
                if (!repositorioTorneo.ObtenerTodos().Any(t => t.Nombre == torneo.Nombre))
                {
                    return "No se encontró el torneo a eliminar.";
                }

                foreach (Equipo equipo in torneo.GetEquipos())
                {
                    foreach (Jugador jugador in equipo.GetJugadores())
                    {
                        jugador.EnEquipo = false;
                    }
                }

                return (repositorioTorneo.Eliminar(torneo)) ? "Torneo eliminado correctamente." : "Error al eliminar el torneo.";
            }
            catch (Exception e)
            {
                return "Ha ocurrido una excepcion: " + e.Message;
            }
}

        // Método para Eliminar un Torneo Profesional
        public string EliminarTorneoProfesional(TorneoProfesional torneo)
        {
            try
            {          
                if (!repositorioTorneoProfesional.ObtenerTodos().Any(t => t.Nombre == torneo.Nombre))
                {
                    return "No se encontró el torneo a eliminar.";
                }

                foreach (Equipo equipo in torneo.GetEquipos())
                {
                    foreach (Jugador jugador in equipo.GetJugadores())
                    {
                        jugador.EnEquipo = false;
                    }
                }

                return (repositorioTorneoProfesional.Eliminar(torneo)) ? "Torneo eliminado correctamente." : "Error al eliminar el torneo.";
            }
            catch (Exception e)
            {
                return "Ha ocurrido una excepcion: " + e.Message;
            }
}

        // Método para Eliminar un jugador del Repositorio
        public string EliminarJugador(Jugador jugador)
        {
            try { 
                if (!repositorioJugador.ObtenerTodos().Any(j => j.Nombre == jugador.Nombre))
                {
                    return "No se encontró el jugador a eliminar.";
                }

                return (repositorioJugador.Eliminar(jugador)) ? "Jugador eliminado correctamente." : "Error al eliminar el jugador.";
            }
            catch (Exception e)
            {
                return "Ha ocurrido una excepcion: " + e.Message;
            }
}

        // Método para eliminar un Rango
        public string EliminarRango(Rango rango)
        {
            try 
            { 
                if (!repositorioRango.ObtenerTodos().Any(j => j.Nombre == rango.Nombre))
                {
                    return "No se encontró el rango a eliminar.";
                }

                return (repositorioRango.Eliminar(rango)) ? "Rango eliminado correctamente." : "Error al eliminar el rango.";
            }
            catch (Exception e)
            {
                return "Ha ocurrido una excepcion: " + e.Message;
            }
        }

        //Metodo para obtener todos los Rangos
        public List<Rango> ObtenerRangos()
        {
            return repositorioRango.ObtenerTodos();
        }
        //Metodo para obtener todos los jugadores que no pertenecen a algun equipo
        public List<Jugador> ObtenerJugadoresSinEquipo()
        {
            return repositorioJugador.ObtenerJugadoresNoEnEquipo();
        }
        //Metodo para obtener todos los jugadores profesionales que no pertenecen a algun equipo
        public List<Jugador> ObtenerJugadoresSinEquipoProfesionales()
        {
            return repositorioJugador.ObtenerJugadoresNoEnEquipoProfesionales(repositorioRango.ObtenerTodos());
        }
        //Metodo para obtener el Torneo Casual por nombre
        public Torneo ObtenerTorneo(string nombre)
        {
            return repositorioTorneo.ObtenerPorNombre(nombre);          
        }

        //Metodo para obtener el Torneo Profesional por nombre
        public TorneoProfesional ObtenerTorneoProfesional(string nombre)
        {
            return (TorneoProfesional)repositorioTorneoProfesional.ObtenerPorNombre(nombre);
        }


        //Metodo para obtener todos los Torneos Casuales
        public List<Torneo> ObtenerTorneosCasuales()
        {
            return repositorioTorneo.ObtenerTodos();
        }

        //Metodo para obtener todos los Torneos Profesionales
        public List<Torneo> ObtenerTorneosProfesionales()
        {
            return repositorioTorneoProfesional.ObtenerTodos();
        }

        // Método para registrar o modificar un resultado de partida en función del estado de la partida.
        public string RegistrarModificarResultado(Partida partida, ResultadoPartida resultado)
        {
            try
            {
                if (!partida.PartidaJugada)
                {
                    partida.RegistrarResultados(resultado);
                    return "El resultado se ha registrado";
                }
                else
                {
                    partida.ModificarResultados(resultado);
                    return "El resultado se ha modificado";
                }
            }
            catch (Exception e)
            {
                return "Ha ocurrido una excepcion: " + e.Message;
            }
        }

        // Atributos privados para los repositorios de jugadores, rangos y torneos.
        private RepositorioJugador repositorioJugador;
        private RepositorioRango repositorioRango;
        private RepositorioTorneo repositorioTorneo;
        private RepositorioTorneo repositorioTorneoProfesional;

    }
}
