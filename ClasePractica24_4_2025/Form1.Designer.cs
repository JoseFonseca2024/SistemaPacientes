namespace ClasePractica24_4_2025
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            label6 = new Label();
            dtpFechaConsulta = new DateTimePicker();
            txtEdad = new TextBox();
            txtSegundoApellido = new TextBox();
            txtPrimerApellido = new TextBox();
            txtSegundoNombre = new TextBox();
            txtObservación = new TextBox();
            txtPrimerNombre = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvPacientes = new DataGridView();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dtpFechaConsulta);
            groupBox1.Controls.Add(txtEdad);
            groupBox1.Controls.Add(txtSegundoApellido);
            groupBox1.Controls.Add(txtPrimerApellido);
            groupBox1.Controls.Add(txtSegundoNombre);
            groupBox1.Controls.Add(txtObservación);
            groupBox1.Controls.Add(txtPrimerNombre);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(883, 280);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información Paciente";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(554, 219);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(134, 32);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar Campos";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += BotonLimpiarCampos;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(414, 219);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(134, 32);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar Paciente";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += EliminarPaciente;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(274, 219);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(134, 32);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "Actualizar Paciente";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += ActualizarPaciente;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(154, 219);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(114, 32);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar Paciente";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += AgregarPaciente;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(401, 39);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 4;
            label6.Text = "Observación:";
            // 
            // dtpFechaConsulta
            // 
            dtpFechaConsulta.Anchor = AnchorStyles.Left;
            dtpFechaConsulta.Location = new Point(152, 175);
            dtpFechaConsulta.Name = "dtpFechaConsulta";
            dtpFechaConsulta.Size = new Size(224, 23);
            dtpFechaConsulta.TabIndex = 6;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(128, 146);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(50, 23);
            txtEdad.TabIndex = 5;
            txtEdad.KeyPress += UnicamenteNumeros;
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Location = new Point(128, 118);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(163, 23);
            txtSegundoApellido.TabIndex = 4;
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Location = new Point(128, 89);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(163, 23);
            txtPrimerApellido.TabIndex = 3;
            // 
            // txtSegundoNombre
            // 
            txtSegundoNombre.Location = new Point(128, 59);
            txtSegundoNombre.Name = "txtSegundoNombre";
            txtSegundoNombre.Size = new Size(163, 23);
            txtSegundoNombre.TabIndex = 2;
            // 
            // txtObservación
            // 
            txtObservación.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtObservación.Location = new Point(401, 57);
            txtObservación.Multiline = true;
            txtObservación.Name = "txtObservación";
            txtObservación.Size = new Size(461, 141);
            txtObservación.TabIndex = 7;
            // 
            // txtPrimerNombre
            // 
            txtPrimerNombre.Location = new Point(128, 30);
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.Size = new Size(163, 23);
            txtPrimerNombre.TabIndex = 1;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(26, 152);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 0;
            label7.Text = "Edad:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(24, 181);
            label5.Name = "label5";
            label5.Size = new Size(107, 15);
            label5.TabIndex = 0;
            label5.Text = "Fecha de Consulta:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(24, 121);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 0;
            label4.Text = "Segundo Apellido";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(24, 92);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 0;
            label3.Text = "Primer Apellido";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(24, 60);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 0;
            label2.Text = "Segundo Nombre";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(24, 33);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Primer Nombre";
            // 
            // dgvPacientes
            // 
            dgvPacientes.AllowUserToAddRows = false;
            dgvPacientes.AllowUserToDeleteRows = false;
            dgvPacientes.AllowUserToResizeColumns = false;
            dgvPacientes.AllowUserToResizeRows = false;
            dgvPacientes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.Location = new Point(12, 347);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.ReadOnly = true;
            dgvPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPacientes.Size = new Size(883, 292);
            dgvPacientes.TabIndex = 1;
            dgvPacientes.CellClick += ExtraerValores;
            dgvPacientes.DataBindingComplete += dgvPacientes_DataBindingComplete;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(632, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(222, 67);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(12, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 651);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(dgvPacientes);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvPacientes;
        private Label label6;
        private DateTimePicker dtpFechaConsulta;
        private TextBox txtSegundoApellido;
        private TextBox txtPrimerApellido;
        private TextBox txtSegundoNombre;
        private TextBox txtObservación;
        private TextBox txtPrimerNombre;
        private Label label5;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnAgregar;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox txtEdad;
        private Label label7;
        private Button btnLimpiar;
    }
}
