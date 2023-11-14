namespace Vista
{
    partial class Torneo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Torneo));
            dgvEquipos = new DataGridView();
            dgvPartidas = new DataGridView();
            dgvEquipoSeleccionado = new DataGridView();
            label1 = new Label();
            lblPremio = new Label();
            lblUbicacion = new Label();
            lblNombre = new Label();
            lblTipoTorneo = new Label();
            label2 = new Label();
            label3 = new Label();
            btnResultados = new Button();
            btnInformacion = new Button();
            label4 = new Label();
            btnModificar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPartidas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEquipoSeleccionado).BeginInit();
            SuspendLayout();
            // 
            // dgvEquipos
            // 
            dgvEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipos.Location = new Point(12, 40);
            dgvEquipos.Name = "dgvEquipos";
            dgvEquipos.ReadOnly = true;
            dgvEquipos.RowTemplate.Height = 25;
            dgvEquipos.Size = new Size(253, 150);
            dgvEquipos.TabIndex = 0;
            dgvEquipos.CellClick += dgvEquipos_CellClick;
            // 
            // dgvPartidas
            // 
            dgvPartidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPartidas.Location = new Point(12, 221);
            dgvPartidas.Name = "dgvPartidas";
            dgvPartidas.ReadOnly = true;
            dgvPartidas.RowTemplate.Height = 25;
            dgvPartidas.Size = new Size(265, 150);
            dgvPartidas.TabIndex = 1;
            // 
            // dgvEquipoSeleccionado
            // 
            dgvEquipoSeleccionado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipoSeleccionado.Location = new Point(321, 40);
            dgvEquipoSeleccionado.Name = "dgvEquipoSeleccionado";
            dgvEquipoSeleccionado.ReadOnly = true;
            dgvEquipoSeleccionado.RowTemplate.Height = 25;
            dgvEquipoSeleccionado.Size = new Size(258, 150);
            dgvEquipoSeleccionado.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(102, 201);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 3;
            label1.Text = "Partidas";
            // 
            // lblPremio
            // 
            lblPremio.AutoSize = true;
            lblPremio.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblPremio.Location = new Point(381, 319);
            lblPremio.Name = "lblPremio";
            lblPremio.Size = new Size(86, 15);
            lblPremio.TabIndex = 4;
            lblPremio.Text = "Premio: $5000";
            // 
            // lblUbicacion
            // 
            lblUbicacion.AutoSize = true;
            lblUbicacion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblUbicacion.Location = new Point(353, 295);
            lblUbicacion.Name = "lblUbicacion";
            lblUbicacion.Size = new Size(148, 15);
            lblUbicacion.TabIndex = 5;
            lblUbicacion.Text = "Ubicacion: Movistar Arena";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblNombre.Location = new Point(300, 257);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(155, 17);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre: nombre torneo";
            // 
            // lblTipoTorneo
            // 
            lblTipoTorneo.AutoSize = true;
            lblTipoTorneo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblTipoTorneo.Location = new Point(461, 259);
            lblTipoTorneo.Name = "lblTipoTorneo";
            lblTipoTorneo.Size = new Size(118, 15);
            lblTipoTorneo.TabIndex = 7;
            lblTipoTorneo.Text = "(Torneo Profesional)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(105, 20);
            label2.Name = "label2";
            label2.Size = new Size(53, 17);
            label2.TabIndex = 8;
            label2.Text = "Equipos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(351, 20);
            label3.Name = "label3";
            label3.Size = new Size(194, 17);
            label3.TabIndex = 9;
            label3.Text = "Jugadores equipo seleccionados";
            // 
            // btnResultados
            // 
            btnResultados.Location = new Point(12, 377);
            btnResultados.Name = "btnResultados";
            btnResultados.Size = new Size(103, 39);
            btnResultados.TabIndex = 10;
            btnResultados.Text = "Subir Resultados";
            btnResultados.UseVisualStyleBackColor = true;
            btnResultados.Click += btnResultados_Click;
            // 
            // btnInformacion
            // 
            btnInformacion.Location = new Point(479, 400);
            btnInformacion.Name = "btnInformacion";
            btnInformacion.Size = new Size(100, 42);
            btnInformacion.TabIndex = 11;
            btnInformacion.Text = "Estadisticas";
            btnInformacion.UseVisualStyleBackColor = true;
            btnInformacion.Click += btnInformacion_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(31, 427);
            label4.Name = "label4";
            label4.Size = new Size(234, 15);
            label4.TabIndex = 12;
            label4.Text = "Las partidas disputadas aparecen en verde";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(177, 377);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(100, 39);
            btnModificar.TabIndex = 13;
            btnModificar.Text = "Modificar Resultados";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(591, 453);
            Controls.Add(btnModificar);
            Controls.Add(label4);
            Controls.Add(btnInformacion);
            Controls.Add(btnResultados);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblTipoTorneo);
            Controls.Add(lblNombre);
            Controls.Add(lblUbicacion);
            Controls.Add(lblPremio);
            Controls.Add(label1);
            Controls.Add(dgvEquipoSeleccionado);
            Controls.Add(dgvPartidas);
            Controls.Add(dgvEquipos);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form2";
            Text = "Torneo Seleccionado";
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPartidas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEquipoSeleccionado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEquipos;
        private DataGridView dgvPartidas;
        private DataGridView dgvEquipoSeleccionado;
        private Label label1;
        private Label lblPremio;
        private Label lblUbicacion;
        private Label lblNombre;
        private Label lblTipoTorneo;
        private Label label2;
        private Label label3;
        private Button btnResultados;
        private Button btnInformacion;
        private Label label4;
        private Button btnModificar;
    }
}