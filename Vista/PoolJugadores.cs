using Modelo;
using System.Windows.Forms;

namespace Vista
{
    public partial class PoolJugadores : Form
    {
        //Constructor del Form1 que se ejecuta al iniciar el programa
        public PoolJugadores()
        {
            InitializeComponent();
        }
        // Metodo asociado al botón de "Agregar" jugador.
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(cmbRango.Text))
                {
                    var mensaje = GestorTorneo.Instancia.CrearJugador(txtNombre.Text, cmbRango.Text);
                    MessageBox.Show(mensaje);
                    ActualizarGrilla();
                }

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar jugador: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Metodo asociado al botón de "Eliminar" jugador.
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvJugadores.Rows.Count > 0)
                {
                    var jugadorSeleccionado = (Jugador)dgvJugadores.CurrentRow.DataBoundItem;

                    if (jugadorSeleccionado != null)
                    {
                        var mensaje = GestorTorneo.Instancia.EliminarJugador(jugadorSeleccionado);
                        MessageBox.Show(mensaje);
                        ActualizarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("El jugador no se ha podido eliminar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar jugador: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Metodo asociado al botón "Crear Torneo Casual"
        private void btnTorneos_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtNombreTorneo.Text) && numJugadores.Value <= GestorTorneo.Instancia.ObtenerJugadoresSinEquipo().Count)
                {
                    var mensaje = GestorTorneo.Instancia.CrearTorneoCasual(txtNombreTorneo.Text, Convert.ToInt32(numJugadores.Value));
                    MessageBox.Show(mensaje);

                    ActualizarCMBs();
                    ActualizarGrilla();
                }
                else
                {
                    MessageBox.Show("El torneo no se ha podido agregar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar Torneo Casual: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Metodo asociado al botón de "Ver Torneo Casual"
        private void btnVerTorneo_Click(object sender, EventArgs e)
        {
            try
            {
                string torneoSeleccionadoNombre = cmbTorneoCasual.Text;

                if (!string.IsNullOrEmpty(torneoSeleccionadoNombre))
                {
                    Modelo.Torneo torneoSeleccionado = GestorTorneo.Instancia.ObtenerTorneo(torneoSeleccionadoNombre);

                    Torneo form2 = new Torneo(torneoSeleccionado);
                    form2.Show();
                }
                else
                {
                    MessageBox.Show("Selecciona un torneo antes de continuar.");
                }

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir torneo Casual: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Metodo asociado al botón de "Eliminar Torneo" (Casual)
        private void btnEliminarTorneo_Click(object sender, EventArgs e)
        {
            try
            {
                string torneoSeleccionadoNombre = cmbTorneoCasual.Text;

                if (!string.IsNullOrEmpty(torneoSeleccionadoNombre))
                {
                    Modelo.Torneo torneoSeleccionado = GestorTorneo.Instancia.ObtenerTorneo(torneoSeleccionadoNombre);

                    var mensaje = GestorTorneo.Instancia.EliminarTorneoCasual(torneoSeleccionado);
                    MessageBox.Show(mensaje);

                    ActualizarCMBs();
                    ActualizarGrilla();
                }
                else
                {
                    MessageBox.Show("Selecciona un torneo antes de eliminarlo.");
                }

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar un torneo casual: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Metodo asociado al botón de "Ver Torneo Profesional"
        private void btnVerTorneoProfesional_Click(object sender, EventArgs e)
        {
            try
            {
                string torneoSeleccionadoNombre = cmbTorneosProfesionales.Text;

                if (!string.IsNullOrEmpty(torneoSeleccionadoNombre))
                {
                    TorneoProfesional torneoSeleccionado = GestorTorneo.Instancia.ObtenerTorneoProfesional(torneoSeleccionadoNombre);
                    Torneo form2 = new Torneo(torneoSeleccionado);
                    form2.Show();
                }
                else
                {
                    MessageBox.Show("Selecciona un torneo antes de continuar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir torneo profesional: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Metodo asociado al botón de "Eliminar Torneo Profesional"
        private void btnEliminarProfesional_Click(object sender, EventArgs e)
        {
            try
            {
                string torneoSeleccionadoNombre = cmbTorneosProfesionales.Text;

                if (!string.IsNullOrEmpty(torneoSeleccionadoNombre))
                {
                    TorneoProfesional torneoSeleccionado = GestorTorneo.Instancia.ObtenerTorneoProfesional(torneoSeleccionadoNombre);

                    var mensaje = GestorTorneo.Instancia.EliminarTorneoProfesional(torneoSeleccionado);
                    MessageBox.Show(mensaje);

                    ActualizarCMBs();
                    ActualizarGrilla();
                }
                else
                {
                    MessageBox.Show("Selecciona un torneo profesional antes de eliminarlo.");
                }

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar torneo profesional: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Metodo asociado al botón "Crear Torneo Profesional"
        private void btnTorneoProfesional_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtNombreTorneo.Text) && numJugadores.Value <= GestorTorneo.Instancia.ObtenerJugadoresSinEquipoProfesionales().Count && !string.IsNullOrEmpty(txtUbicacion.Text))
                {
                    var mensaje = GestorTorneo.Instancia.CrearTorneoProfesional(txtNombreTorneo.Text, Convert.ToInt32(numJugadores.Value), txtUbicacion.Text, Convert.ToInt32(numPremio.Value));
                    MessageBox.Show(mensaje);

                    ActualizarCMBs();
                    ActualizarGrilla();
                }
                else
                {
                    MessageBox.Show("El torneo profesional no se ha podido crear", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar torneo profesional: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Metodo asociado al evento Load del formulario
        private void PoolJugadores_Load(object sender, EventArgs e)
        {
            try
            {
                CreacionRangos();
                JugadoresAleatorios();
                ActualizarCMBs();
                ActualizarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en el cargar el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Metodo asociado al botón "Salir"
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Método para actualizar los ComboBoxes con información de torneos y rangos
        void ActualizarCMBs()
        {
            try
            {
                cmbTorneoCasual.DataSource = null;
                cmbTorneoCasual.DataSource = GestorTorneo.Instancia.ObtenerTorneosCasuales();
                cmbTorneoCasual.DisplayMember = "Nombre";

                cmbTorneosProfesionales.DataSource = null;
                cmbTorneosProfesionales.DataSource = GestorTorneo.Instancia.ObtenerTorneosProfesionales();
                cmbTorneosProfesionales.DisplayMember = "Nombre";

                cmbRango.DataSource = null;
                cmbRango.DataSource = GestorTorneo.Instancia.ObtenerRangos();
                cmbRango.DisplayMember = "Nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en el actualizar los comboboxs: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Metodo para actualizar la grilla de jugadores
        void ActualizarGrilla()
        {

            dgvJugadores.DataSource = null;

            dgvJugadores.DataSource = GestorTorneo.Instancia.ObtenerJugadoresSinEquipo();
        }


        // Método para generar jugadores aleatorios
        private void JugadoresAleatorios()
        {
            // Lista de nombres de usuarios
            List<string> nombresDeUsuarios = new List<string>
            {
                "AirWolf","Fessa", "DarkHallow", "NeitOH", "ElMaldito", "ElKaiser", "FJaime11", "SpectralSword", "NeonFury", "RogueWolf", "VortexSlayer", "PixelPirate", "MysticRider", "RapidFalcon", "EchoEnigma", "ChronoWraith"
            };

            Random random = new Random();

            for (int i = 1; i <= 40; i++)
            {

                // Seleccionar un rango aleatoriamente
                List<Rango> rangosDisponibles = GestorTorneo.Instancia.ObtenerRangos();


                Rango rangoSeleccionado = rangosDisponibles[random.Next(rangosDisponibles.Count)];
                string nombreRango = rangoSeleccionado.Nombre; // Asegúrate de adaptar esto según la estructura de tu clase Rango

                // Seleccionar un nombre de usuario aleatoriamente
                string nombreJugador = nombresDeUsuarios[random.Next(nombresDeUsuarios.Count)] + i;

                GestorTorneo.Instancia.CrearJugador(nombreJugador, nombreRango);
            }
        }

        // Método para crear rangos
        private void CreacionRangos()
        {
            // CrearRango se encarga de la creación del rango
            GestorTorneo.Instancia.CrearRango("global elite", 10);
            GestorTorneo.Instancia.CrearRango("silver", 1);
            GestorTorneo.Instancia.CrearRango("gold", 3);
            GestorTorneo.Instancia.CrearRango("AK", 7);
        }

        //Metodo para limpiar los campos de entradas.
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtNombreTorneo.Text = "";
            txtUbicacion.Text = "";
        }
    }
}