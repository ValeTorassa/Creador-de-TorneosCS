using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace Vista
{
    public partial class EstadisticasTorneo : Form
    {
        private Modelo.Torneo torneo;

        public EstadisticasTorneo(Modelo.Torneo torneoSeleccionado)
        {
            InitializeComponent();

            torneo = torneoSeleccionado;
        }


        private void dgvEquipo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvEquipo.Rows.Count > 0)
                {
                    var equipo = (Equipo)dgvEquipo.CurrentRow.DataBoundItem;

                    ObtenerDatosEquipo(equipo.Estadisticas);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener las estadisticas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ObtenerDatosEquipo(EstadisticasEquipo estadisticas)
        {
            try
            {
                lblGanadas.Text = estadisticas.Victorias.ToString();
                lblPerdidas.Text = estadisticas.Perdidas.ToString();
                lblRondasGanadas.Text = estadisticas.RondasGanadas.ToString();
                lblRondasPerdidas.Text = estadisticas.RondasPerdidas.ToString();
                lblKills.Text = estadisticas.Kills.ToString();
                lblTotalPartidas.Text = estadisticas.TotalPartidas.ToString();
                lblPorcentaje.Text = estadisticas.PorcentajeVictorias().ToString() + " %";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CargarGBPosiciones(List<Equipo> equipos)
        {
            try
            {
                // Ordena la lista de estadísticas de equipos en función de criterios (victorias, rondas, kills).
                var equiposOrdenados = equipos.OrderByDescending(e => e.Estadisticas.Victorias)
                                                   .ThenByDescending(e => e.Estadisticas.RondasGanadas)
                                                   .ThenByDescending(e => e.Estadisticas.Kills)
                                                   .ToList();


                lblGanador.Text = equiposOrdenados[0].Nombre;

                lblDatosGanador.Text = $"Partidas Ganadas: {equiposOrdenados[0].Estadisticas.Victorias} , " +
                                       $"Rondas Ganadas: {equiposOrdenados[0].Estadisticas.RondasGanadas} , " +
                                       $"Kills del equipo: {equiposOrdenados[0].Estadisticas.Kills}";

                lblSegundo.Text = equiposOrdenados[1].Nombre;

                lblDatosSegundo.Text = $"Partidas Ganadas: {equiposOrdenados[1].Estadisticas.Victorias} , " +
                                       $"Rondas Ganadas: {equiposOrdenados[1].Estadisticas.RondasGanadas} , " +
                                       $"Kills del equipo: {equiposOrdenados[1].Estadisticas.Kills}";

                if (equiposOrdenados.Count > 2)
                {
                    lblTercero.Text = equiposOrdenados[2].Nombre;

                    lblDatosTercero.Text = $"Partidas Ganadas: {equiposOrdenados[2].Estadisticas.Victorias} , " +
                                           $"Rondas Ganadas: {equiposOrdenados[2].Estadisticas.RondasGanadas} , " +
                                           $"Kills del equipo: {equiposOrdenados[2].Estadisticas.Kills}";

                    lblUltimo.Text = equiposOrdenados.Last().Nombre;

                    lblDatosUltimo.Text = $"Partidas Perdidas: {equiposOrdenados.Last().Estadisticas.Perdidas} , " +
                               $"Rondas Perdidas: {equiposOrdenados.Last().Estadisticas.RondasPerdidas}";
                }
                else
                {
                    lblTercero.Text = "";

                    lblDatosTercero.Text = "";

                    lblUltimo.Text = "";

                    lblDatosUltimo.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las posiciones: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void CargarGBDestacados(Modelo.Torneo torneo)
        {
            try
            {
                lblDuracion.Text = torneo.DuracionPromedio.ToString() + " m";
                lblMapaMasJugado.Text = torneo.MapaMasJugado.ToString();

                var equipoConMasKills = torneo.Equipos.OrderByDescending(e => e.Estadisticas.Kills).FirstOrDefault();
                lblMasKills.Text = equipoConMasKills.Nombre + $" ({equipoConMasKills.Estadisticas.Kills})";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos de los destacados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            try
            {
                var mensaje = torneo.GenerarReporteEstadisticasGlobales();
                MessageBox.Show(mensaje);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EstadisticasTorneo_Load(object sender, EventArgs e)
        {
            try
            {
                torneo.CalcularEstadisticas();

                dgvEquipo.DataSource = null;
                dgvEquipo.DataSource = torneo.Equipos;

                if (dgvEquipo.Rows.Count > 0)
                {
                    var primerEquipo = (Equipo)dgvEquipo.Rows[0].DataBoundItem;
                    ObtenerDatosEquipo(primerEquipo.Estadisticas);
                }

                CargarGBPosiciones(torneo.Equipos);

                CargarGBDestacados(torneo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}