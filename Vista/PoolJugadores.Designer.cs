namespace Vista
{
    partial class PoolJugadores
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PoolJugadores));
            dgvJugadores = new DataGridView();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            btnTorneos = new Button();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            cmbRango = new ComboBox();
            btnVerTorneo = new Button();
            cmbTorneoCasual = new ComboBox();
            cmbTorneosProfesionales = new ComboBox();
            label1 = new Label();
            txtNombreTorneo = new TextBox();
            label4 = new Label();
            label5 = new Label();
            numJugadores = new NumericUpDown();
            btnEliminarCasual = new Button();
            btnTorneoProfesional = new Button();
            numPremio = new NumericUpDown();
            txtUbicacion = new TextBox();
            label6 = new Label();
            label7 = new Label();
            btnEliminarProfesional = new Button();
            btnVerTorneoProfesional = new Button();
            label8 = new Label();
            label9 = new Label();
            gbTorneos = new GroupBox();
            gbJugadores = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvJugadores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numJugadores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPremio).BeginInit();
            gbTorneos.SuspendLayout();
            gbJugadores.SuspendLayout();
            SuspendLayout();
            // 
            // dgvJugadores
            // 
            dgvJugadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJugadores.Location = new Point(24, 22);
            dgvJugadores.Name = "dgvJugadores";
            dgvJugadores.ReadOnly = true;
            dgvJugadores.RowTemplate.Height = 25;
            dgvJugadores.Size = new Size(263, 270);
            dgvJugadores.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAgregar.Location = new Point(24, 310);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(85, 34);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnEliminar.Location = new Point(197, 310);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 34);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSalir.Location = new Point(771, 448);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(77, 38);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnTorneos
            // 
            btnTorneos.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnTorneos.Location = new Point(85, 166);
            btnTorneos.Name = "btnTorneos";
            btnTorneos.Size = new Size(90, 38);
            btnTorneos.TabIndex = 4;
            btnTorneos.Text = "Crear Torneo Casual";
            btnTorneos.UseVisualStyleBackColor = true;
            btnTorneos.Click += btnTorneos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(38, 369);
            label2.Name = "label2";
            label2.Size = new Size(58, 17);
            label2.TabIndex = 6;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(38, 405);
            label3.Name = "label3";
            label3.Size = new Size(48, 17);
            label3.TabIndex = 7;
            label3.Text = "Rango:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(105, 366);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(123, 23);
            txtNombre.TabIndex = 8;
            // 
            // cmbRango
            // 
            cmbRango.FormattingEnabled = true;
            cmbRango.Location = new Point(105, 404);
            cmbRango.Name = "cmbRango";
            cmbRango.Size = new Size(121, 23);
            cmbRango.TabIndex = 12;
            // 
            // btnVerTorneo
            // 
            btnVerTorneo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnVerTorneo.Location = new Point(21, 277);
            btnVerTorneo.Name = "btnVerTorneo";
            btnVerTorneo.Size = new Size(76, 49);
            btnVerTorneo.TabIndex = 13;
            btnVerTorneo.Text = "Ver torneo Casual";
            btnVerTorneo.UseVisualStyleBackColor = true;
            btnVerTorneo.Click += btnVerTorneo_Click;
            // 
            // cmbTorneoCasual
            // 
            cmbTorneoCasual.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTorneoCasual.FormattingEnabled = true;
            cmbTorneoCasual.Location = new Point(33, 248);
            cmbTorneoCasual.Name = "cmbTorneoCasual";
            cmbTorneoCasual.Size = new Size(153, 23);
            cmbTorneoCasual.TabIndex = 14;
            // 
            // cmbTorneosProfesionales
            // 
            cmbTorneosProfesionales.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTorneosProfesionales.FormattingEnabled = true;
            cmbTorneosProfesionales.Location = new Point(240, 245);
            cmbTorneosProfesionales.Name = "cmbTorneosProfesionales";
            cmbTorneosProfesionales.Size = new Size(152, 23);
            cmbTorneosProfesionales.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(485, 29);
            label1.Name = "label1";
            label1.Size = new Size(293, 25);
            label1.TabIndex = 16;
            label1.Text = "Torneos casuales y profesionales";
            // 
            // txtNombreTorneo
            // 
            txtNombreTorneo.Location = new Point(74, 49);
            txtNombreTorneo.Name = "txtNombreTorneo";
            txtNombreTorneo.Size = new Size(123, 23);
            txtNombreTorneo.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(7, 101);
            label4.Name = "label4";
            label4.Size = new Size(69, 17);
            label4.TabIndex = 19;
            label4.Text = "Jugadores:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(18, 52);
            label5.Name = "label5";
            label5.Size = new Size(58, 17);
            label5.TabIndex = 18;
            label5.Text = "Nombre:";
            // 
            // numJugadores
            // 
            numJugadores.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numJugadores.Location = new Point(76, 99);
            numJugadores.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numJugadores.Name = "numJugadores";
            numJugadores.ReadOnly = true;
            numJugadores.Size = new Size(120, 23);
            numJugadores.TabIndex = 21;
            numJugadores.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // btnEliminarCasual
            // 
            btnEliminarCasual.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnEliminarCasual.Location = new Point(103, 282);
            btnEliminarCasual.Name = "btnEliminarCasual";
            btnEliminarCasual.Size = new Size(93, 38);
            btnEliminarCasual.TabIndex = 22;
            btnEliminarCasual.Text = "Eliminar Torneo Casual";
            btnEliminarCasual.UseVisualStyleBackColor = true;
            btnEliminarCasual.Click += btnEliminarTorneo_Click;
            // 
            // btnTorneoProfesional
            // 
            btnTorneoProfesional.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnTorneoProfesional.Location = new Point(272, 163);
            btnTorneoProfesional.Name = "btnTorneoProfesional";
            btnTorneoProfesional.Size = new Size(90, 41);
            btnTorneoProfesional.TabIndex = 23;
            btnTorneoProfesional.Text = "Crear Torneo Profesional";
            btnTorneoProfesional.UseVisualStyleBackColor = true;
            btnTorneoProfesional.Click += btnTorneoProfesional_Click;
            // 
            // numPremio
            // 
            numPremio.Location = new Point(272, 94);
            numPremio.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            numPremio.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            numPremio.Name = "numPremio";
            numPremio.Size = new Size(120, 23);
            numPremio.TabIndex = 27;
            numPremio.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // txtUbicacion
            // 
            txtUbicacion.Location = new Point(269, 49);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(123, 23);
            txtUbicacion.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(215, 96);
            label6.Name = "label6";
            label6.Size = new Size(53, 17);
            label6.TabIndex = 25;
            label6.Text = "Premio:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(203, 52);
            label7.Name = "label7";
            label7.Size = new Size(69, 17);
            label7.TabIndex = 24;
            label7.Text = "Ubicacion:";
            // 
            // btnEliminarProfesional
            // 
            btnEliminarProfesional.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnEliminarProfesional.Location = new Point(307, 274);
            btnEliminarProfesional.Name = "btnEliminarProfesional";
            btnEliminarProfesional.Size = new Size(105, 49);
            btnEliminarProfesional.TabIndex = 29;
            btnEliminarProfesional.Text = "Eliminar Torneo Profesional";
            btnEliminarProfesional.UseVisualStyleBackColor = true;
            btnEliminarProfesional.Click += btnEliminarProfesional_Click;
            // 
            // btnVerTorneoProfesional
            // 
            btnVerTorneoProfesional.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnVerTorneoProfesional.Location = new Point(225, 274);
            btnVerTorneoProfesional.Name = "btnVerTorneoProfesional";
            btnVerTorneoProfesional.Size = new Size(76, 49);
            btnVerTorneoProfesional.TabIndex = 28;
            btnVerTorneoProfesional.Text = "Ver torneo Profesional";
            btnVerTorneoProfesional.UseVisualStyleBackColor = true;
            btnVerTorneoProfesional.Click += btnVerTorneoProfesional_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(230, 19);
            label8.Name = "label8";
            label8.Size = new Size(162, 13);
            label8.TabIndex = 30;
            label8.Text = "Solo para torneos profesionales";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(117, 9);
            label9.Name = "label9";
            label9.Size = new Size(99, 25);
            label9.TabIndex = 31;
            label9.Text = "Jugadores";
            // 
            // gbTorneos
            // 
            gbTorneos.BackColor = Color.Snow;
            gbTorneos.Controls.Add(label8);
            gbTorneos.Controls.Add(btnEliminarProfesional);
            gbTorneos.Controls.Add(btnVerTorneoProfesional);
            gbTorneos.Controls.Add(numPremio);
            gbTorneos.Controls.Add(txtUbicacion);
            gbTorneos.Controls.Add(label6);
            gbTorneos.Controls.Add(label7);
            gbTorneos.Controls.Add(btnTorneoProfesional);
            gbTorneos.Controls.Add(btnEliminarCasual);
            gbTorneos.Controls.Add(numJugadores);
            gbTorneos.Controls.Add(txtNombreTorneo);
            gbTorneos.Controls.Add(label4);
            gbTorneos.Controls.Add(label5);
            gbTorneos.Controls.Add(cmbTorneosProfesionales);
            gbTorneos.Controls.Add(cmbTorneoCasual);
            gbTorneos.Controls.Add(btnVerTorneo);
            gbTorneos.Controls.Add(btnTorneos);
            gbTorneos.Location = new Point(418, 70);
            gbTorneos.Name = "gbTorneos";
            gbTorneos.Size = new Size(430, 346);
            gbTorneos.TabIndex = 32;
            gbTorneos.TabStop = false;
            gbTorneos.Text = "Torneos";
            // 
            // gbJugadores
            // 
            gbJugadores.BackColor = Color.Snow;
            gbJugadores.Controls.Add(cmbRango);
            gbJugadores.Controls.Add(txtNombre);
            gbJugadores.Controls.Add(label3);
            gbJugadores.Controls.Add(label2);
            gbJugadores.Controls.Add(btnEliminar);
            gbJugadores.Controls.Add(btnAgregar);
            gbJugadores.Controls.Add(dgvJugadores);
            gbJugadores.Location = new Point(12, 48);
            gbJugadores.Name = "gbJugadores";
            gbJugadores.Size = new Size(314, 438);
            gbJugadores.TabIndex = 33;
            gbJugadores.TabStop = false;
            gbJugadores.Text = "Jugadores";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(858, 504);
            Controls.Add(gbJugadores);
            Controls.Add(gbTorneos);
            Controls.Add(label9);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Menu";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvJugadores).EndInit();
            ((System.ComponentModel.ISupportInitialize)numJugadores).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPremio).EndInit();
            gbTorneos.ResumeLayout(false);
            gbTorneos.PerformLayout();
            gbJugadores.ResumeLayout(false);
            gbJugadores.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvJugadores;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnSalir;
        private Button btnTorneos;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private ComboBox cmbRango;
        private Button btnVerTorneo;
        private ComboBox cmbTorneoCasual;
        private ComboBox cmbTorneosProfesionales;
        private Label label1;
        private TextBox txtNombreTorneo;
        private Label label4;
        private Label label5;
        private NumericUpDown numJugadores;
        private Button btnEliminarCasual;
        private Button btnTorneoProfesional;
        private NumericUpDown numPremio;
        private TextBox txtUbicacion;
        private Label label6;
        private Label label7;
        private Button btnEliminarProfesional;
        private Button btnVerTorneoProfesional;
        private Label label8;
        private Label label9;
        private GroupBox gbTorneos;
        private GroupBox gbJugadores;
    }
}