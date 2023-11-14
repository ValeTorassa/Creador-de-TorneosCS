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
        //Metodo asocioado al boton de " Agregar" jugador.
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Verifica si se ingreso nombre y rango del jugador
            if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(cmbRango.Text))
            {
                //Crea un nuevo jugador con los datos ingresados.
                var mensaje = GestorTorneo.Instancia.CrearJugador(txtNombre.Text, cmbRango.Text);
                MessageBox.Show(mensaje);
                //Actualiza la grilla de jugadores
                ActualizarGrilla();
            }

            //Limpia los campos de entrada.
            LimpiarCampos();
        }
        //Metodo asociado al boton de "Eliminar" jugador.
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Verifica que haya un jugador cargado en al grilla.
            if (dgvJugadores.Rows.Count > 0)
            {
                //Selecciona al jugador de la grilla.
                var jugadorSeleccionado = (Jugador)dgvJugadores.CurrentRow.DataBoundItem;

                if (jugadorSeleccionado != null)
                {
                    //Elimina el jugador seleccionado
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
        //Metodo asociado al boton "Crear Torneo Casual"
        private void btnTorneos_Click(object sender, EventArgs e)
        {
            //Verifica si se ingreso un Nombre y  numero de jugadores
            if (!string.IsNullOrEmpty(txtNombreTorneo.Text) && numJugadores.Value <= GestorTorneo.Instancia.ObtenerJugadoresSinEquipo().Count)
            {
                //Crea el torneo
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

        //Metodo para actualizar la grilla de jugadores
        void ActualizarGrilla()
        {

            dgvJugadores.DataSource = null;

            dgvJugadores.DataSource = GestorTorneo.Instancia.ObtenerJugadoresSinEquipo();
        }
        // Método para actualizar los ComboBoxes con información de torneos y rangos
        void ActualizarCMBs()
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
        //Metodo asociado al botn de  "Ver Torneo Casual"
        private void btnVerTorneo_Click(object sender, EventArgs e)
        {
            string torneoSeleccionadoNombre = cmbTorneoCasual.Text;
            //Verifica que haya un torneo seleccionado en el ComboBox
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

        //Metodo asociado al botn de  "Eliminar Torneo" (Casual)
        private void btnEliminarTorneo_Click(object sender, EventArgs e)
        {
            string torneoSeleccionadoNombre = cmbTorneoCasual.Text;
            //Verifica que haya un torneo seleccionado en el ComboBox
            if (!string.IsNullOrEmpty(torneoSeleccionadoNombre))
            {
                // Obtiene el objeto Torneo correspondiente al nombre seleccionado
                Modelo.Torneo torneoSeleccionado = GestorTorneo.Instancia.ObtenerTorneo(torneoSeleccionadoNombre);
                //Elimina el torneo seleccionado
                var mensaje = GestorTorneo.Instancia.EliminarTorneoCasual(torneoSeleccionado);
                MessageBox.Show(mensaje);
                // Actualiza los ComboBoxes y la grilla de jugadores después de eliminarlo
                ActualizarCMBs();
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Selecciona un torneo antes de eliminarlo.");
            }
            LimpiarCampos();
        }
        //Metodo asociado al boton "Ver Torneo Profesional"
        private void btnVerTorneoProfesional_Click(object sender, EventArgs e)
        {
            string torneoSeleccionadoNombre = cmbTorneosProfesionales.Text;

            if (!string.IsNullOrEmpty(torneoSeleccionadoNombre))
            {
                //Obtiene el Torneo Profesional correspondiente al nombre seleccionado en el ComboBox
                TorneoProfesional torneoSeleccionado = GestorTorneo.Instancia.ObtenerTorneoProfesional(torneoSeleccionadoNombre);
                //Abre una instancia y le pasa el torneo seleccionado
                Torneo form2 = new Torneo(torneoSeleccionado);
                form2.Show();
            }
            else
            {
                MessageBox.Show("Selecciona un torneo antes de continuar.");
            }
        }
        //Metodo asociado al botn de  "Eliminar Torneo Profesional"
        private void btnEliminarProfesional_Click(object sender, EventArgs e)
        {
            string torneoSeleccionadoNombre = cmbTorneosProfesionales.Text;
            //Verifica que haya un torneo seleccionado en el ComboBox
            if (!string.IsNullOrEmpty(torneoSeleccionadoNombre))
            {   // Obtiene el objeto Torneo correspondiente al nombre seleccionado
                TorneoProfesional torneoSeleccionado = GestorTorneo.Instancia.ObtenerTorneoProfesional(torneoSeleccionadoNombre);
                //Elimina el torneo seleccionado
                var mensaje = GestorTorneo.Instancia.EliminarTorneoProfesional(torneoSeleccionado);
                MessageBox.Show(mensaje);
                // Actualiza los ComboBoxes y la grilla de jugadores después de eliminarlo
                ActualizarCMBs();
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Selecciona un torneo profesional antes de eliminarlo.");
            }
            LimpiarCampos();
        }
        //Metodo para limpiar los campos de entradas.
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtNombreTorneo.Text = "";
            txtUbicacion.Text = "";
        }
        //Metodo asociado al boton "Crear Torneo Profesional"
        private void btnTorneoProfesional_Click(object sender, EventArgs e)
        {
            //Verifica si se ingreso un Nombre y  numero de jugadores
            if (!string.IsNullOrEmpty(txtNombreTorneo.Text) && numJugadores.Value <= GestorTorneo.Instancia.ObtenerJugadoresSinEquipoProfesionales().Count && !string.IsNullOrEmpty(txtUbicacion.Text))
            {   //Crea el Torneo
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
        //Metodo asociado al boton "Salir"
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Método para generar jugadores aleatorios
        private void JugadoresAleatorios()
        {
            // Lista de nombres de usuarios
            List<string> nombresDeUsuarios = new List<string>
            {
                "AirWolf","Fessa","AirWolf", "Fessa", "ShadowBlade", "LunaStorm", "NovaGamer", "CyberNinja", "PhoenixFire", "SpectralSword", "NeonFury", "RogueWolf", "VortexSlayer", "PixelPirate", "MysticRider", "RapidFalcon", "EchoEnigma", "ChronoWraith"
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

        private void Form1_Load(object sender, EventArgs e)
        {
            //Se crean los rangos 
            CreacionRangos();
            //Se crean jugadores y se añaden al DGV.
            JugadoresAleatorios();
            //Se actualizan las grillas
            ActualizarCMBs();
            ActualizarGrilla();
        }
    }
}