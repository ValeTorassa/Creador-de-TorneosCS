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
            InitializeComponent();

            lblNombre.Text = "Nombre: " + torneoSeleccionado.Nombre;
            lblTipoTorneo.Text = "Torneo Casual";
            lblUbicacion.Text = "";
            lblPremio.Text = "";

            torneo = torneoSeleccionado;

            MostrarEquiposYPartidas();
        }


        //Constructor para Torneo Profesionales
        public Torneo(TorneoProfesional torneoSeleccionado)
        {
            InitializeComponent();
            lblNombre.Text = "Nombre: " + torneoSeleccionado.Nombre;
            lblUbicacion.Text = "Ubicación: " + torneoSeleccionado.Ubicacion;
            lblPremio.Text = $"Premio en dólares: ${torneoSeleccionado.Premio}";
            lblTipoTorneo.Text = "Torneo Profesional";

            torneo = torneoSeleccionado;

            MostrarEquiposYPartidas();
        }


        //Metodo para mostrar Equipos y Partidas en el formulario.
        private void MostrarEquiposYPartidas()
        {
            dgvEquipos.DataSource = null;
            dgvEquipos.DataSource = torneo.GetEquipos();

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
            if (dgvEquipos.Rows.Count > 0)
            {
                var equipo = (Equipo)dgvEquipos.CurrentRow.DataBoundItem;
                MostrarJugadoresEquipo(equipo);
            }
        }


        // Método para mostrar los jugadores de un equipo en el DataGridView
        private void MostrarJugadoresEquipo(Equipo equipo)
        {
            dgvEquipoSeleccionado.DataSource = null;
            dgvEquipoSeleccionado.DataSource = equipo.GetJugadores();
        }

        // Maneja el evento al hacer clic en el botón "Resultados".
        private void btnResultados_Click(object sender, EventArgs e)
        {
            if (dgvPartidas.Rows.Count > 0)
            {
                var partida = (Partida)dgvPartidas.CurrentRow.DataBoundItem;
                if (!partida.PartidaJugada)
                {
                    // Si la partida no ha sido jugada, muestra un formulario de resultados (Form3).
                    var form3 = new ResultadosPartida(partida);
                    form3.ShowDialog();
                }
                else
                {
                    // Si la partida ya ha sido jugada, muestra un mensaje de aviso.
                    MessageBox.Show("La partida ya ha sido jugada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            ActualizarGrillaPartidas(); // Actualiza la grilla de partidas .
        }

        // Maneja el evento al hacer clic en el botón "Modificar".
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvPartidas.Rows.Count > 0)
            {
                var partida = (Partida)dgvPartidas.CurrentRow.DataBoundItem;
                if (partida.PartidaJugada)
                {
                    // Si la partida ya ha sido jugada, muestra un formulario de modificación de resultados (Form3).
                    var form3 = new ResultadosPartida(partida);
                    form3.Show();
                }
                else
                {
                    // Si la partida no ha sido jugada, muestra un mensaje de aviso.
                    MessageBox.Show("La partida no ha sido jugada aún, no se puede modificar su resultado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            ActualizarGrillaPartidas(); // Actualiza la grilla de partidas .
        }



        // Maneja el evento al hacer clic en el botón "Información".
        private void btnInformacion_Click(object sender, EventArgs e)
        {
            // Busca una partida sin jugar en el torneo.
            var partidaSinJugar = torneo.GetPartidas().FirstOrDefault(p => !p.PartidaJugada);

            if (partidaSinJugar == null)
            {
                // Si no hay partidas sin jugar, abre un formulario de información (Form4).
                EstadisticasTorneo form4 = new EstadisticasTorneo(torneo);
                form4.ShowDialog();
            }
            else
            {
                var partidasJugadas = torneo.GetPartidas().Count(p => p.PartidaJugada);

                if (partidasJugadas == 0)
                {
                    MessageBox.Show("No hay partidas jugadas, registra al menos una partida para ver las estadisticas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    EstadisticasProvisionales form5 = new EstadisticasProvisionales(torneo);
                    form5.ShowDialog();
                }
            }
        }
    

        // Método para actualizar la presentación de la grilla de partidas en un DataGridView.
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
