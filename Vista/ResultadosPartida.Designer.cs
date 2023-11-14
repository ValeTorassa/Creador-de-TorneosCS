namespace Vista
{
    partial class ResultadosPartida
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
            gbGanador = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            lblVisitante1 = new Label();
            lblLocal1 = new Label();
            lblAgregarModificar = new Label();
            gbRondas = new GroupBox();
            numRondasVisitante = new NumericUpDown();
            numRondasLocal = new NumericUpDown();
            lblVisitante2 = new Label();
            lblLocal2 = new Label();
            gbMuertes = new GroupBox();
            numMuertesVisitantes = new NumericUpDown();
            numMuertesLocal = new NumericUpDown();
            lblVisitante3 = new Label();
            lblLocal3 = new Label();
            groupBox3 = new GroupBox();
            cmbMapas = new ComboBox();
            numDuracion = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            gbGanador.SuspendLayout();
            gbRondas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numRondasVisitante).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRondasLocal).BeginInit();
            gbMuertes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMuertesVisitantes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMuertesLocal).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDuracion).BeginInit();
            SuspendLayout();
            // 
            // gbGanador
            // 
            gbGanador.Controls.Add(radioButton2);
            gbGanador.Controls.Add(radioButton1);
            gbGanador.Controls.Add(lblVisitante1);
            gbGanador.Controls.Add(lblLocal1);
            gbGanador.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            gbGanador.Location = new Point(12, 38);
            gbGanador.Name = "gbGanador";
            gbGanador.Size = new Size(249, 90);
            gbGanador.TabIndex = 0;
            gbGanador.TabStop = false;
            gbGanador.Text = "Equipo Ganador";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.Location = new Point(173, 56);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(69, 17);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "Ganador";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.Location = new Point(173, 27);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(69, 17);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Ganador";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // lblVisitante1
            // 
            lblVisitante1.AutoSize = true;
            lblVisitante1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblVisitante1.Location = new Point(6, 58);
            lblVisitante1.Name = "lblVisitante1";
            lblVisitante1.Size = new Size(124, 15);
            lblVisitante1.TabIndex = 3;
            lblVisitante1.Text = "Visitante: Equipo Rojo";
            // 
            // lblLocal1
            // 
            lblLocal1.AutoSize = true;
            lblLocal1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblLocal1.Location = new Point(6, 29);
            lblLocal1.Name = "lblLocal1";
            lblLocal1.Size = new Size(119, 15);
            lblLocal1.TabIndex = 2;
            lblLocal1.Text = "Local: Equipo Celeste";
            // 
            // lblAgregarModificar
            // 
            lblAgregarModificar.AutoSize = true;
            lblAgregarModificar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblAgregarModificar.Location = new Point(210, 9);
            lblAgregarModificar.Name = "lblAgregarModificar";
            lblAgregarModificar.Size = new Size(122, 20);
            lblAgregarModificar.TabIndex = 1;
            lblAgregarModificar.Text = "Subir Resultados";
            // 
            // gbRondas
            // 
            gbRondas.Controls.Add(numRondasVisitante);
            gbRondas.Controls.Add(numRondasLocal);
            gbRondas.Controls.Add(lblVisitante2);
            gbRondas.Controls.Add(lblLocal2);
            gbRondas.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            gbRondas.Location = new Point(12, 134);
            gbRondas.Name = "gbRondas";
            gbRondas.Size = new Size(249, 90);
            gbRondas.TabIndex = 5;
            gbRondas.TabStop = false;
            gbRondas.Text = "Rondas Ganadas (Total 30)";
            // 
            // numRondasVisitante
            // 
            numRondasVisitante.Enabled = false;
            numRondasVisitante.Location = new Point(154, 56);
            numRondasVisitante.Name = "numRondasVisitante";
            numRondasVisitante.Size = new Size(88, 22);
            numRondasVisitante.TabIndex = 7;
            numRondasVisitante.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // numRondasLocal
            // 
            numRondasLocal.Location = new Point(154, 22);
            numRondasLocal.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            numRondasLocal.Name = "numRondasLocal";
            numRondasLocal.Size = new Size(88, 22);
            numRondasLocal.TabIndex = 6;
            numRondasLocal.ValueChanged += numRondasLocal_ValueChanged;
            // 
            // lblVisitante2
            // 
            lblVisitante2.AutoSize = true;
            lblVisitante2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblVisitante2.Location = new Point(6, 58);
            lblVisitante2.Name = "lblVisitante2";
            lblVisitante2.Size = new Size(124, 15);
            lblVisitante2.TabIndex = 3;
            lblVisitante2.Text = "Visitante: Equipo Rojo";
            // 
            // lblLocal2
            // 
            lblLocal2.AutoSize = true;
            lblLocal2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblLocal2.Location = new Point(6, 29);
            lblLocal2.Name = "lblLocal2";
            lblLocal2.Size = new Size(119, 15);
            lblLocal2.TabIndex = 2;
            lblLocal2.Text = "Local: Equipo Celeste";
            // 
            // gbMuertes
            // 
            gbMuertes.Controls.Add(numMuertesVisitantes);
            gbMuertes.Controls.Add(numMuertesLocal);
            gbMuertes.Controls.Add(lblVisitante3);
            gbMuertes.Controls.Add(lblLocal3);
            gbMuertes.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            gbMuertes.Location = new Point(285, 38);
            gbMuertes.Name = "gbMuertes";
            gbMuertes.Size = new Size(249, 90);
            gbMuertes.TabIndex = 8;
            gbMuertes.TabStop = false;
            gbMuertes.Text = "Muertes Por Equipo";
            // 
            // numMuertesVisitantes
            // 
            numMuertesVisitantes.Location = new Point(154, 56);
            numMuertesVisitantes.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            numMuertesVisitantes.Name = "numMuertesVisitantes";
            numMuertesVisitantes.Size = new Size(88, 22);
            numMuertesVisitantes.TabIndex = 7;
            // 
            // numMuertesLocal
            // 
            numMuertesLocal.Location = new Point(154, 22);
            numMuertesLocal.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            numMuertesLocal.Name = "numMuertesLocal";
            numMuertesLocal.Size = new Size(88, 22);
            numMuertesLocal.TabIndex = 6;
            // 
            // lblVisitante3
            // 
            lblVisitante3.AutoSize = true;
            lblVisitante3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblVisitante3.Location = new Point(6, 58);
            lblVisitante3.Name = "lblVisitante3";
            lblVisitante3.Size = new Size(124, 15);
            lblVisitante3.TabIndex = 3;
            lblVisitante3.Text = "Visitante: Equipo Rojo";
            // 
            // lblLocal3
            // 
            lblLocal3.AutoSize = true;
            lblLocal3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblLocal3.Location = new Point(6, 29);
            lblLocal3.Name = "lblLocal3";
            lblLocal3.Size = new Size(119, 15);
            lblLocal3.TabIndex = 2;
            lblLocal3.Text = "Local: Equipo Celeste";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cmbMapas);
            groupBox3.Controls.Add(numDuracion);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label7);
            groupBox3.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(285, 134);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(249, 90);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos de la Partida";
            // 
            // cmbMapas
            // 
            cmbMapas.FormattingEnabled = true;
            cmbMapas.Items.AddRange(new object[] { "Dust II", "Inferno", "Mirage", "Train", "Nuke", "Overpass", "Vertigo", "Ancient" });
            cmbMapas.Location = new Point(122, 57);
            cmbMapas.Name = "cmbMapas";
            cmbMapas.Size = new Size(121, 21);
            cmbMapas.TabIndex = 9;
            cmbMapas.Text = "Dust II";
            // 
            // numDuracion
            // 
            numDuracion.Location = new Point(154, 28);
            numDuracion.Maximum = new decimal(new int[] { 75, 0, 0, 0 });
            numDuracion.Minimum = new decimal(new int[] { 30, 0, 0, 0 });
            numDuracion.Name = "numDuracion";
            numDuracion.Size = new Size(88, 22);
            numDuracion.TabIndex = 8;
            numDuracion.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(6, 58);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 3;
            label6.Text = "Mapa:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(6, 29);
            label7.Name = "label7";
            label7.Size = new Size(123, 15);
            label7.TabIndex = 2;
            label7.Text = "Duracion en minutos:";
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.Location = new Point(194, 230);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(67, 30);
            btnAceptar.TabIndex = 10;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(285, 230);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(69, 30);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(546, 272);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(groupBox3);
            Controls.Add(gbMuertes);
            Controls.Add(gbRondas);
            Controls.Add(lblAgregarModificar);
            Controls.Add(gbGanador);
            DoubleBuffered = true;
            Name = "Form3";
            Text = "Resultados Partidas";
            gbGanador.ResumeLayout(false);
            gbGanador.PerformLayout();
            gbRondas.ResumeLayout(false);
            gbRondas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numRondasVisitante).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRondasLocal).EndInit();
            gbMuertes.ResumeLayout(false);
            gbMuertes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMuertesVisitantes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMuertesLocal).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDuracion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbGanador;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label lblVisitante1;
        private Label lblLocal1;
        private Label lblAgregarModificar;
        private GroupBox gbRondas;
        private NumericUpDown numRondasVisitante;
        private NumericUpDown numRondasLocal;
        private Label lblVisitante2;
        private Label lblLocal2;
        private GroupBox gbMuertes;
        private NumericUpDown numMuertesVisitantes;
        private NumericUpDown numMuertesLocal;
        private Label lblVisitante3;
        private Label lblLocal3;
        private GroupBox groupBox3;
        private Label label6;
        private Label label7;
        private ComboBox cmbMapas;
        private NumericUpDown numDuracion;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}