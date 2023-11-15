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
    public partial class ResultadosPartida : Form
    {
        // Indica si la partida ha sido modificada.
        private bool modificada = false;

        // Almacena la partida que se está registrando o modificando.
        private Partida partida;

        // Constructor del formulario Form3
        public ResultadosPartida(Partida partidaExistente)
        {
            try
            {
                InitializeComponent();

                // Configura las etiquetas de nombre de los equipos local y visitante en el formulario.
                lblLocal1.Text = "Local: " + partidaExistente.NombreLocal;
                lblLocal2.Text = "Local: " + partidaExistente.NombreLocal;
                lblLocal3.Text = "Local: " + partidaExistente.NombreLocal;
                lblVisitante1.Text = "Visitante: " + partidaExistente.NombreVisitante;
                lblVisitante2.Text = "Visitante: " + partidaExistente.NombreVisitante;
                lblVisitante3.Text = "Visitante: " + partidaExistente.NombreVisitante;

                if (partidaExistente.PartidaJugada == false)
                {
                    // Si la partida aún no se ha jugado, establece la partida que se está registrando.
                    partida = partidaExistente;

                    lblAgregarModificar.Text = "Subir Resultado";
                }
                else
                {
                    // Si la partida ya se ha jugado, llena los controles con los datos existentes de la partida.
                    LlenarDatos(partidaExistente);

                    // Indica que la partida ha sido modificada.
                    modificada = true;

                    lblAgregarModificar.Text = "Modificar Resultado";

                    // Establece la partida que se está modificando.
                    partida = partidaExistente;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al construir el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool Validar()
        {
            // Validar que el equipo marcado como ganador tenga más rondas ganadas
            if (radioButton1.Checked && numRondasLocal.Value < numRondasVisitante.Value)
            {
                MessageBox.Show("El Equipo Local debe tener igual o mas rondas ganadas que el visitante para ser marcado como ganador.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (radioButton2.Checked && numRondasVisitante.Value < numRondasLocal.Value)
            {
                MessageBox.Show("El Equipo Visitante debe tener igual o mas rondas ganadas que el local para ser marcado como ganador.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void LlenarDatos(Partida partida)
        {
            // Configurar los RadioButtons para el ganador
            if (partida.Resultado.GanadorLocal)
            {
                radioButton1.Checked = true;
            }
            else if (partida.Resultado.GanadorVisitante)
            {
                radioButton2.Checked = true;
            }

            // Configurar las rondas
            numRondasLocal.Value = partida.Resultado.RondasLocal;
            numRondasVisitante.Value = partida.Resultado.RondasVisitante;

            // Configurar las muertes
            numMuertesLocal.Value = partida.Resultado.MuertesLocal;
            numMuertesVisitantes.Value = partida.Resultado.MuertesVisitante;

            // Configurar la duración
            numDuracion.Value = partida.Resultado.Duracion;

            // Configurar el mapa
            cmbMapas.SelectedItem = partida.Resultado.Mapa;
        }


        // Maneja el evento cuando el valor del número de rondas local cambia.
        private void numRondasLocal_ValueChanged(object sender, EventArgs e)
        {
            // Calcula automáticamente el valor del número de rondas visitante para que la suma sea 30.
            numRondasVisitante.Value = 30 - numRondasLocal.Value;
        }

        // Maneja el evento cuando se hace clic en el botón "Aceptar" para confirmar y registrar/modificar el resultado de la partida.
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    // Crea un objeto ResultadoPartida con los valores de los controles en el formulario.
                    ResultadoPartida resultado = new ResultadoPartida(
                        radioButton1.Checked,
                        (int)numRondasLocal.Value,
                        (int)numMuertesLocal.Value,
                        radioButton2.Checked,
                        (int)numRondasVisitante.Value,
                        (int)numMuertesVisitantes.Value,
                        (int)numDuracion.Value,
                        cmbMapas.SelectedItem.ToString()
                    );

                    // Llama al método RegistrarModificarResultado en el GestorTorneo para registrar o modificar el resultado.
                    GestorTorneo.Instancia.RegistrarModificarResultado(partida, resultado);

                    this.Close(); // Cierra el formulario después de registrar/modificar el resultado.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar el resultado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Maneja el evento cuando se hace clic en el botón "Cancelar" para cancelar la operación y cerrar el formulario.
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario sin realizar ninguna acción.
        }

    }
}
