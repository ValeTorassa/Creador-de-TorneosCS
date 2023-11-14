using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class EstadisticasProvisionales : Form
    {
        private Modelo.Torneo torneo;

        public EstadisticasProvisionales(Modelo.Torneo torneoSeleccionado)
        {
            InitializeComponent();

            lblNombre.Text = "Nombre: " + torneoSeleccionado.Nombre;

            if (torneoSeleccionado is Modelo.TorneoProfesional torneoProfesional)
            {
                lblUbicacion.Text = "Ubicación: " + torneoProfesional.Ubicacion;
                lblPremio.Text = $"Premio en dólares: ${torneoProfesional.Premio}";
                lblTipoTorneo.Text = "Torneo Profesional";
            }
            else
            {
                lblTipoTorneo.Text = "Torneo Casual";
            }

            torneo = torneoSeleccionado;
        }

        private void EstadisticasProvisionales_Load(object sender, EventArgs e)
        {
            torneo.CalcularEstadisticas();

            dgvEquipo.DataSource = null;
            dgvEquipo.DataSource = torneo.GetEquipos();

            if (dgvEquipo.Rows.Count > 0)
            {
                var primerEquipo = (Equipo)dgvEquipo.Rows[0].DataBoundItem;
                ObtenerDatosEquipo(primerEquipo.Estadisticas);
            }

            ActualizarGrillaPartidas();
        }

        private void ObtenerDatosEquipo(EstadisticasEquipo estadisticas)
        {
            if (estadisticas != null)
            {
                lblGanadas.Text = estadisticas.Victorias.ToString();
                lblPerdidas.Text = estadisticas.Perdidas.ToString();
                lblRondasGanadas.Text = estadisticas.RondasGanadas.ToString();
                lblRondasPerdidas.Text = estadisticas.RondasPerdidas.ToString();
                lblKills.Text = estadisticas.Kills.ToString();
                lblTotalPartidas.Text = estadisticas.TotalPartidas.ToString();
                lblPorcentaje.Text = estadisticas.PorcentajeVictorias().ToString() + " %";
            }
            else
            {
                lblGanadas.Text = "Sin Partidas Jugadas";
                lblPerdidas.Text = "Sin Partidas Jugadas";
                lblRondasGanadas.Text = "Sin Partidas Jugadas";
                lblRondasPerdidas.Text = "Sin Partidas Jugadas";
                lblKills.Text = "Sin Partidas Jugadas";
                lblTotalPartidas.Text = "Sin Partidas Jugadas";
                lblPorcentaje.Text = "Sin Partidas Jugadas";
            }
        }

        private void dgvEquipo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEquipo.Rows.Count > 0)
            {
                var equipo = (Equipo)dgvEquipo.CurrentRow.DataBoundItem;

                ObtenerDatosEquipo(equipo.Estadisticas);
            }
        }


        private void ActualizarGrillaPartidas()
        {
            // Configura el DataGridView de las partidas.
            dgvPartidas.DataSource = null;
            dgvPartidas.DataSource = torneo.GetPartidas();

            // Agrega un evento de formateo de celda para cambiar el color de las filas según si la partida está jugada o no.
            dgvPartidas.CellFormatting += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    var partida = (Partida)dgvPartidas.Rows[e.RowIndex].DataBoundItem;

                    // Verifica si la partida está jugada y establece el color de fondo en verde.
                    if (partida.PartidaJugada)
                    {
                        e.CellStyle.BackColor = Color.Green;
                        e.CellStyle.ForeColor = Color.White;
                    }
                    else
                    {
                        // Si no está jugada, utiliza los colores predeterminados.
                        e.CellStyle.BackColor = dgvPartidas.DefaultCellStyle.BackColor;
                        e.CellStyle.ForeColor = dgvPartidas.DefaultCellStyle.ForeColor;
                    }
                }
            };
        }
    }
}
