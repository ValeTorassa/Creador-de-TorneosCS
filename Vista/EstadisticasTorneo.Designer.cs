namespace Vista
{
    partial class EstadisticasTorneo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstadisticasTorneo));
            lblInformacion = new Label();
            dgvEquipo = new DataGridView();
            label1 = new Label();
            lbl2 = new Label();
            lbl = new Label();
            lblGanador = new Label();
            lblDatosGanador = new Label();
            lblDatosSegundo = new Label();
            lblSegundo = new Label();
            lblUltimo = new Label();
            lblTercero = new Label();
            label10 = new Label();
            label11 = new Label();
            lblDatosTercero = new Label();
            lblDatosUltimo = new Label();
            gbPuestos = new GroupBox();
            groupBox1 = new GroupBox();
            lblMapaMasJugado = new Label();
            lblDuracion = new Label();
            label18 = new Label();
            label19 = new Label();
            lblMasKills = new Label();
            label25 = new Label();
            lblRondasPerdidas = new Label();
            lblRondasGanadas = new Label();
            label20 = new Label();
            label22 = new Label();
            lblPerdidas = new Label();
            lblGanadas = new Label();
            label28 = new Label();
            label29 = new Label();
            lblKills = new Label();
            label15 = new Label();
            lblTotalPartidas = new Label();
            label27 = new Label();
            label30 = new Label();
            lblPorcentaje = new Label();
            btnGenerarReporte = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEquipo).BeginInit();
            gbPuestos.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblInformacion
            // 
            lblInformacion.AutoSize = true;
            lblInformacion.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblInformacion.Location = new Point(371, 9);
            lblInformacion.Name = "lblInformacion";
            lblInformacion.Size = new Size(163, 20);
            lblInformacion.TabIndex = 2;
            lblInformacion.Text = "Estadisticas del Torneo";
            // 
            // dgvEquipo
            // 
            dgvEquipo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipo.Location = new Point(28, 234);
            dgvEquipo.Name = "dgvEquipo";
            dgvEquipo.RowTemplate.Height = 25;
            dgvEquipo.Size = new Size(322, 263);
            dgvEquipo.TabIndex = 3;
            dgvEquipo.CellClick += dgvEquipo_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(28, 214);
            label1.Name = "label1";
            label1.Size = new Size(134, 17);
            label1.TabIndex = 4;
            label1.Text = "Estadisticas por Equipo";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl2.Location = new Point(6, 30);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(57, 15);
            lbl2.TabIndex = 5;
            lbl2.Text = "Ganador:";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl.Location = new Point(6, 66);
            lbl.Name = "lbl";
            lbl.Size = new Size(100, 15);
            lbl.TabIndex = 6;
            lbl.Text = "Segundo Puesto:";
            // 
            // lblGanador
            // 
            lblGanador.AutoSize = true;
            lblGanador.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblGanador.Location = new Point(72, 30);
            lblGanador.Name = "lblGanador";
            lblGanador.Size = new Size(74, 17);
            lblGanador.TabIndex = 7;
            lblGanador.Text = "Equipo Rojo";
            // 
            // lblDatosGanador
            // 
            lblDatosGanador.AutoSize = true;
            lblDatosGanador.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDatosGanador.Location = new Point(206, 30);
            lblDatosGanador.Name = "lblDatosGanador";
            lblDatosGanador.Size = new Size(376, 17);
            lblDatosGanador.TabIndex = 8;
            lblDatosGanador.Text = "Partidas Ganadas: 10, Rondas Ganadas: 10, Kills del equipo: 10";
            // 
            // lblDatosSegundo
            // 
            lblDatosSegundo.AutoSize = true;
            lblDatosSegundo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDatosSegundo.Location = new Point(206, 66);
            lblDatosSegundo.Name = "lblDatosSegundo";
            lblDatosSegundo.Size = new Size(376, 17);
            lblDatosSegundo.TabIndex = 10;
            lblDatosSegundo.Text = "Partidas Ganadas: 10, Rondas Ganadas: 10, Kills del equipo: 10";
            // 
            // lblSegundo
            // 
            lblSegundo.AutoSize = true;
            lblSegundo.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblSegundo.Location = new Point(105, 66);
            lblSegundo.Name = "lblSegundo";
            lblSegundo.Size = new Size(74, 17);
            lblSegundo.TabIndex = 9;
            lblSegundo.Text = "Equipo Rojo";
            // 
            // lblUltimo
            // 
            lblUltimo.AutoSize = true;
            lblUltimo.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblUltimo.Location = new Point(103, 142);
            lblUltimo.Name = "lblUltimo";
            lblUltimo.Size = new Size(74, 17);
            lblUltimo.TabIndex = 14;
            lblUltimo.Text = "Equipo Rojo";
            // 
            // lblTercero
            // 
            lblTercero.AutoSize = true;
            lblTercero.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblTercero.Location = new Point(98, 103);
            lblTercero.Name = "lblTercero";
            lblTercero.Size = new Size(74, 17);
            lblTercero.TabIndex = 13;
            lblTercero.Text = "Equipo Rojo";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(4, 142);
            label10.Name = "label10";
            label10.Size = new Size(89, 15);
            label10.TabIndex = 12;
            label10.Text = "Ultimo Puesto:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(6, 103);
            label11.Name = "label11";
            label11.Size = new Size(87, 15);
            label11.TabIndex = 11;
            label11.Text = "Tercer Puesto:";
            // 
            // lblDatosTercero
            // 
            lblDatosTercero.AutoSize = true;
            lblDatosTercero.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDatosTercero.Location = new Point(206, 103);
            lblDatosTercero.Name = "lblDatosTercero";
            lblDatosTercero.Size = new Size(376, 17);
            lblDatosTercero.TabIndex = 15;
            lblDatosTercero.Text = "Partidas Ganadas: 10, Rondas Ganadas: 10, Kills del equipo: 10";
            // 
            // lblDatosUltimo
            // 
            lblDatosUltimo.AutoSize = true;
            lblDatosUltimo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDatosUltimo.Location = new Point(211, 142);
            lblDatosUltimo.Name = "lblDatosUltimo";
            lblDatosUltimo.Size = new Size(261, 17);
            lblDatosUltimo.TabIndex = 16;
            lblDatosUltimo.Text = "Partidas Perdidas: 20, Rondas Perdidas: 10";
            // 
            // gbPuestos
            // 
            gbPuestos.Controls.Add(lblDatosUltimo);
            gbPuestos.Controls.Add(lblDatosTercero);
            gbPuestos.Controls.Add(lblUltimo);
            gbPuestos.Controls.Add(lblTercero);
            gbPuestos.Controls.Add(label10);
            gbPuestos.Controls.Add(label11);
            gbPuestos.Controls.Add(lblDatosSegundo);
            gbPuestos.Controls.Add(lblSegundo);
            gbPuestos.Controls.Add(lblDatosGanador);
            gbPuestos.Controls.Add(lblGanador);
            gbPuestos.Controls.Add(lbl);
            gbPuestos.Controls.Add(lbl2);
            gbPuestos.Location = new Point(22, 37);
            gbPuestos.Name = "gbPuestos";
            gbPuestos.Size = new Size(597, 174);
            gbPuestos.TabIndex = 17;
            gbPuestos.TabStop = false;
            gbPuestos.Text = "Posiciones";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblMapaMasJugado);
            groupBox1.Controls.Add(lblDuracion);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(lblMasKills);
            groupBox1.Controls.Add(label25);
            groupBox1.Location = new Point(660, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(254, 139);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Destacados";
            // 
            // lblMapaMasJugado
            // 
            lblMapaMasJugado.AutoSize = true;
            lblMapaMasJugado.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblMapaMasJugado.Location = new Point(141, 103);
            lblMapaMasJugado.Name = "lblMapaMasJugado";
            lblMapaMasJugado.Size = new Size(43, 17);
            lblMapaMasJugado.TabIndex = 14;
            lblMapaMasJugado.Text = "Dust II";
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblDuracion.Location = new Point(211, 66);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(37, 17);
            lblDuracion.TabIndex = 13;
            lblDuracion.Text = "50 m";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(12, 105);
            label18.Name = "label18";
            label18.Size = new Size(105, 15);
            label18.TabIndex = 12;
            label18.Text = "Mapa mas jugado:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(8, 66);
            label19.Name = "label19";
            label19.Size = new Size(201, 15);
            label19.TabIndex = 11;
            label19.Text = "Duracion Promedio de las partidas: ";
            // 
            // lblMasKills
            // 
            lblMasKills.AutoSize = true;
            lblMasKills.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblMasKills.Location = new Point(132, 28);
            lblMasKills.Name = "lblMasKills";
            lblMasKills.Size = new Size(74, 17);
            lblMasKills.TabIndex = 7;
            lblMasKills.Text = "Equipo Rojo";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label25.Location = new Point(6, 30);
            label25.Name = "label25";
            label25.Size = new Size(120, 15);
            label25.TabIndex = 5;
            label25.Text = "Equipo con mas Kills:";
            // 
            // lblRondasPerdidas
            // 
            lblRondasPerdidas.AutoSize = true;
            lblRondasPerdidas.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblRondasPerdidas.Location = new Point(505, 357);
            lblRondasPerdidas.Name = "lblRondasPerdidas";
            lblRondasPerdidas.Size = new Size(74, 17);
            lblRondasPerdidas.TabIndex = 24;
            lblRondasPerdidas.Text = "Equipo Rojo";
            // 
            // lblRondasGanadas
            // 
            lblRondasGanadas.AutoSize = true;
            lblRondasGanadas.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblRondasGanadas.Location = new Point(505, 318);
            lblRondasGanadas.Name = "lblRondasGanadas";
            lblRondasGanadas.Size = new Size(74, 17);
            lblRondasGanadas.TabIndex = 23;
            lblRondasGanadas.Text = "Equipo Rojo";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(394, 357);
            label20.Name = "label20";
            label20.Size = new Size(100, 15);
            label20.TabIndex = 22;
            label20.Text = "Rondas Perdidas:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label22.Location = new Point(394, 318);
            label22.Name = "label22";
            label22.Size = new Size(99, 15);
            label22.TabIndex = 21;
            label22.Text = "Rondas Ganadas:";
            // 
            // lblPerdidas
            // 
            lblPerdidas.AutoSize = true;
            lblPerdidas.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblPerdidas.Location = new Point(505, 279);
            lblPerdidas.Name = "lblPerdidas";
            lblPerdidas.Size = new Size(74, 17);
            lblPerdidas.TabIndex = 20;
            lblPerdidas.Text = "Equipo Rojo";
            // 
            // lblGanadas
            // 
            lblGanadas.AutoSize = true;
            lblGanadas.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblGanadas.Location = new Point(505, 245);
            lblGanadas.Name = "lblGanadas";
            lblGanadas.Size = new Size(74, 17);
            lblGanadas.TabIndex = 19;
            lblGanadas.Text = "Equipo Rojo";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label28.Location = new Point(393, 281);
            label28.Name = "label28";
            label28.Size = new Size(101, 15);
            label28.TabIndex = 18;
            label28.Text = "Partidas Perdidas";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label29.Location = new Point(391, 245);
            label29.Name = "label29";
            label29.Size = new Size(103, 15);
            label29.TabIndex = 17;
            label29.Text = "Partidas Ganadas:";
            // 
            // lblKills
            // 
            lblKills.AutoSize = true;
            lblKills.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblKills.Location = new Point(505, 394);
            lblKills.Name = "lblKills";
            lblKills.Size = new Size(74, 17);
            lblKills.TabIndex = 26;
            lblKills.Text = "Equipo Rojo";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(394, 394);
            label15.Name = "label15";
            label15.Size = new Size(93, 15);
            label15.TabIndex = 25;
            label15.Text = "Kills del equipo:";
            // 
            // lblTotalPartidas
            // 
            lblTotalPartidas.AutoSize = true;
            lblTotalPartidas.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblTotalPartidas.Location = new Point(505, 430);
            lblTotalPartidas.Name = "lblTotalPartidas";
            lblTotalPartidas.Size = new Size(74, 17);
            lblTotalPartidas.TabIndex = 28;
            lblTotalPartidas.Text = "Equipo Rojo";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label27.Location = new Point(394, 430);
            label27.Name = "label27";
            label27.Size = new Size(100, 15);
            label27.TabIndex = 27;
            label27.Text = "Partidas Jugadas:";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label30.Location = new Point(361, 464);
            label30.Name = "label30";
            label30.Size = new Size(137, 15);
            label30.TabIndex = 29;
            label30.Text = "Porcentaje de victorias:";
            // 
            // lblPorcentaje
            // 
            lblPorcentaje.AutoSize = true;
            lblPorcentaje.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblPorcentaje.Location = new Point(505, 464);
            lblPorcentaje.Name = "lblPorcentaje";
            lblPorcentaje.Size = new Size(74, 17);
            lblPorcentaje.TabIndex = 30;
            lblPorcentaje.Text = "Equipo Rojo";
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.Location = new Point(830, 478);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(107, 46);
            btnGenerarReporte.TabIndex = 31;
            btnGenerarReporte.Text = "Generar Reporte";
            btnGenerarReporte.UseVisualStyleBackColor = true;
            btnGenerarReporte.Click += btnGenerarReporte_Click;
            // 
            // EstadisticasTorneo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(939, 526);
            Controls.Add(btnGenerarReporte);
            Controls.Add(lblPorcentaje);
            Controls.Add(label30);
            Controls.Add(lblTotalPartidas);
            Controls.Add(label27);
            Controls.Add(lblKills);
            Controls.Add(label15);
            Controls.Add(lblRondasPerdidas);
            Controls.Add(groupBox1);
            Controls.Add(lblRondasGanadas);
            Controls.Add(gbPuestos);
            Controls.Add(label20);
            Controls.Add(label1);
            Controls.Add(label22);
            Controls.Add(lblPerdidas);
            Controls.Add(dgvEquipo);
            Controls.Add(lblGanadas);
            Controls.Add(lblInformacion);
            Controls.Add(label28);
            Controls.Add(label29);
            Name = "EstadisticasTorneo";
            Text = "Estadisticas Torneo";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEquipo).EndInit();
            gbPuestos.ResumeLayout(false);
            gbPuestos.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInformacion;
        private DataGridView dgvEquipo;
        private Label label1;
        private Label lbl2;
        private Label lbl;
        private Label lblGanador;
        private Label lblDatosGanador;
        private Label lblDatosSegundo;
        private Label lblSegundo;
        private Label lblUltimo;
        private Label lblTercero;
        private Label label10;
        private Label label11;
        private Label lblDatosTercero;
        private Label lblDatosUltimo;
        private GroupBox gbPuestos;
        private GroupBox groupBox1;
        private Label lblMapaMasJugado;
        private Label lblDuracion;
        private Label label18;
        private Label label19;
        private Label lblMasKills;
        private Label label25;
        private Label lblRondasPerdidas;
        private Label lblRondasGanadas;
        private Label label20;
        private Label label22;
        private Label lblPerdidas;
        private Label lblGanadas;
        private Label label28;
        private Label label29;
        private Label lblKills;
        private Label label15;
        private Label lblTotalPartidas;
        private Label label27;
        private Label label30;
        private Label lblPorcentaje;
        private Button btnGenerarReporte;
    }
}