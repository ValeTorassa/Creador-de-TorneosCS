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
    public partial class Torneo : Form
    {
        Modelo.Torneo torneo;

        //Constructor para Torneo Casuales
        public Torneo(Modelo.Torneo torneoSeleccionado)
        {
            try
            {
                InitializeComponent();

                lblNombre.Text = "Nombre: " + torneoSeleccionado.Nombre;
                lblTipoTorneo.Text = "Torneo Casual";
                lblUbicacion.Text = "";
                lblPremio.Text = "";

                torneo = torneoSeleccionado;

                MostrarEquiposYPartidas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al construir el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Constructor para Torneo Profesionales
        public Torneo(TorneoProfesional torneoSeleccionado)
        {
            try
            {
                InitializeComponent();
                lblNombre.Text = "Nombre: " + torneoSeleccionado.Nombre;
                lblUbicacion.Text = "Ubicación: " + torneoSeleccionado.Ubicacion;
                lblPremio.Text = $"Premio en dólares: ${torneoSeleccionado.Premio}";
                lblTipoTorneo.Text = "Torneo Profesional";

                torneo = torneoSeleccionado;

                MostrarEquiposYPartidas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al construir el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //Metodo para mostrar Equipos y Partidas en el formulario.
        private void MostrarEquiposYPartidas()
        {
            dgvEquipos.DataSource = null;
            dgvEquipos.DataSource = torneo.Equipos;

            ActualizarGrillaPartidas();

            // Mostrar jugadores del primer equipo si hay equipos disponibles
            if (dgvEquipos.Rows.Count > 0)
            {
                var primerEquipo = (Equipo)dgvEquipos.Rows[0].DataBoundItem;
                MostrarJugadoresEquipo(primerEquipo);
            }
        }


        //Maneja el evento al hacer clic en una celda del DataGridView de equipos
        private void dgvEquipos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvEquipos.Rows.Count > 0)
                {
                    var equipo = (Equipo)dgvEquipos.CurrentRow.DataBoundItem;
                    MostrarJugadoresEquipo(equipo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar jugadores del equipo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Método para mostrar los jugadores de un equipo en el DataGridView
        private void MostrarJugadoresEquipo(Equipo equipo)
        {
            dgvEquipoSeleccionado.DataSource = null;
            dgvEquipoSeleccionado.DataSource = equipo.Jugadores;
        }

        // Maneja el evento al hacer clic en el botón "Resultados".
        private void btnResultados_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPartidas.Rows.Count > 0)
                {
                    var partida = (Partida)dgvPartidas.CurrentRow.DataBoundItem;
                    if (!partida.PartidaJugada)
                    {
                        var form3 = new ResultadosPartida(partida);
                        form3.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("La partida ya ha sido jugada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                ActualizarGrillaPartidas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar resultados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Maneja el evento al hacer clic en el botón "Modificar".
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPartidas.Rows.Count > 0)
                {
                    var partida = (Partida)dgvPartidas.CurrentRow.DataBoundItem;
                    if (partida.PartidaJugada)
                    {
                        var form3 = new ResultadosPartida(partida);
                        form3.Show();
                    }
                    else
                    {
                        MessageBox.Show("La partida no ha sido jugada aún, no se puede modificar su resultado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                ActualizarGrillaPartidas(); // Actualiza la grilla de partidas .
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar los resultados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Maneja el evento al hacer clic en el botón "Información".
        private void btnInformacion_Click(object sender, EventArgs e)
        {
            try
            {
                var partidaSinJugar = torneo.Partidas.FirstOrDefault(p => !p.PartidaJugada);

                if (partidaSinJugar == null)
                {
                    EstadisticasTorneo form4 = new EstadisticasTorneo(torneo);
                    form4.ShowDialog();
                }
                else
                {
                    var partidasJugadas = torneo.Partidas.Count(p => p.PartidaJugada);

                    if (partidasJugadas == 0)
                    {
                        MessageBox.Show("No hay partidas jugadas, registra al menos una partida para ver las estadísticas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        EstadisticasProvisionales form5 = new EstadisticasProvisionales(torneo);
                        form5.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en mostrar las estadisticas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Método para actualizar la presentación de la grilla de partidas en un DataGridView.
        private void ActualizarGrillaPartidas()
        {
            try
            {
                dgvPartidas.DataSource = null;
                dgvPartidas.DataSource = torneo.Partidas;

                dgvPartidas.CellFormatting += (sender, e) =>
                {
                    if (e.RowIndex >= 0)
                    {
                        var partida = (Partida)dgvPartidas.Rows[e.RowIndex].DataBoundItem;

                        if (partida.PartidaJugada)
                        {
                            e.CellStyle.BackColor = Color.Green;
                            e.CellStyle.ForeColor = Color.White;
                        }
                        else
                        {
                            e.CellStyle.BackColor = dgvPartidas.DefaultCellStyle.BackColor;
                            e.CellStyle.ForeColor = dgvPartidas.DefaultCellStyle.ForeColor;
                        }
                    }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en el Actualizar la grilla de partidas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
