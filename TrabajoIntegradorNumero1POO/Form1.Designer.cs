namespace TrabajoIntegradorNumero1POO
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.btnBorrarAlumno = new System.Windows.Forms.Button();
            this.btnModificarAlumno = new System.Windows.Forms.Button();
            this.dgrListaAlumnos = new System.Windows.Forms.DataGridView();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant_Materia_Aprobadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAntiguedad = new System.Windows.Forms.TextBox();
            this.txtMateriaNoAprobadas = new System.Windows.Forms.TextBox();
            this.txtEdadDeIngreso = new System.Windows.Forms.TextBox();
            this.lblEdadDeIngreso = new System.Windows.Forms.Label();
            this.lblMateriaNoAprobadas = new System.Windows.Forms.Label();
            this.lblAntiguedad = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtCantidadDeMateriasAprobadas = new System.Windows.Forms.TextBox();
            this.cbxActivo = new System.Windows.Forms.CheckBox();
            this.dtpFechaDeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDeIngreso = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrListaAlumnos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.Location = new System.Drawing.Point(12, 38);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(181, 29);
            this.btnAgregarAlumno.TabIndex = 0;
            this.btnAgregarAlumno.Text = "Agregar Alumno";
            this.btnAgregarAlumno.UseVisualStyleBackColor = true;
            this.btnAgregarAlumno.Click += new System.EventHandler(this.btnAgregarAlumno_Click);
            // 
            // btnBorrarAlumno
            // 
            this.btnBorrarAlumno.Location = new System.Drawing.Point(12, 119);
            this.btnBorrarAlumno.Name = "btnBorrarAlumno";
            this.btnBorrarAlumno.Size = new System.Drawing.Size(181, 29);
            this.btnBorrarAlumno.TabIndex = 1;
            this.btnBorrarAlumno.Text = "Borrar alumno";
            this.btnBorrarAlumno.UseVisualStyleBackColor = true;
            this.btnBorrarAlumno.Click += new System.EventHandler(this.btnBorrarAlumno_Click);
            // 
            // btnModificarAlumno
            // 
            this.btnModificarAlumno.Location = new System.Drawing.Point(12, 195);
            this.btnModificarAlumno.Name = "btnModificarAlumno";
            this.btnModificarAlumno.Size = new System.Drawing.Size(181, 29);
            this.btnModificarAlumno.TabIndex = 2;
            this.btnModificarAlumno.Text = "Modificar Alumno";
            this.btnModificarAlumno.UseVisualStyleBackColor = true;
            this.btnModificarAlumno.Click += new System.EventHandler(this.btnModificarAlumno_Click);
            // 
            // dgrListaAlumnos
            // 
            this.dgrListaAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrListaAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Legajo,
            this.Nombre,
            this.Apellido,
            this.Fecha_Nacimiento,
            this.Fecha_Ingreso,
            this.Edad,
            this.Activo,
            this.Cant_Materia_Aprobadas});
            this.dgrListaAlumnos.Location = new System.Drawing.Point(12, 423);
            this.dgrListaAlumnos.Name = "dgrListaAlumnos";
            this.dgrListaAlumnos.Size = new System.Drawing.Size(890, 158);
            this.dgrListaAlumnos.TabIndex = 3;
            this.dgrListaAlumnos.SelectionChanged += new System.EventHandler(this.dgrListaAlumnos_SelectionChanged);
            // 
            // Legajo
            // 
            this.Legajo.HeaderText = "Legajo";
            this.Legajo.Name = "Legajo";
            this.Legajo.Width = 106;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 106;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.Width = 105;
            // 
            // Fecha_Nacimiento
            // 
            this.Fecha_Nacimiento.HeaderText = "Fecha_Nacimiento";
            this.Fecha_Nacimiento.Name = "Fecha_Nacimiento";
            this.Fecha_Nacimiento.Width = 106;
            // 
            // Fecha_Ingreso
            // 
            this.Fecha_Ingreso.HeaderText = "Fecha_Ingreso";
            this.Fecha_Ingreso.Name = "Fecha_Ingreso";
            this.Fecha_Ingreso.Width = 106;
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            this.Edad.Width = 106;
            // 
            // Activo
            // 
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.Width = 106;
            // 
            // Cant_Materia_Aprobadas
            // 
            this.Cant_Materia_Aprobadas.HeaderText = "Cant_Materia_Aprobadas";
            this.Cant_Materia_Aprobadas.Name = "Cant_Materia_Aprobadas";
            this.Cant_Materia_Aprobadas.Width = 106;
            // 
            // txtAntiguedad
            // 
            this.txtAntiguedad.Location = new System.Drawing.Point(15, 39);
            this.txtAntiguedad.Name = "txtAntiguedad";
            this.txtAntiguedad.Size = new System.Drawing.Size(181, 20);
            this.txtAntiguedad.TabIndex = 4;
            // 
            // txtMateriaNoAprobadas
            // 
            this.txtMateriaNoAprobadas.Location = new System.Drawing.Point(15, 94);
            this.txtMateriaNoAprobadas.Name = "txtMateriaNoAprobadas";
            this.txtMateriaNoAprobadas.Size = new System.Drawing.Size(181, 20);
            this.txtMateriaNoAprobadas.TabIndex = 5;
            // 
            // txtEdadDeIngreso
            // 
            this.txtEdadDeIngreso.Location = new System.Drawing.Point(15, 147);
            this.txtEdadDeIngreso.Name = "txtEdadDeIngreso";
            this.txtEdadDeIngreso.Size = new System.Drawing.Size(181, 20);
            this.txtEdadDeIngreso.TabIndex = 6;
            // 
            // lblEdadDeIngreso
            // 
            this.lblEdadDeIngreso.AutoSize = true;
            this.lblEdadDeIngreso.Location = new System.Drawing.Point(12, 131);
            this.lblEdadDeIngreso.Name = "lblEdadDeIngreso";
            this.lblEdadDeIngreso.Size = new System.Drawing.Size(84, 13);
            this.lblEdadDeIngreso.TabIndex = 7;
            this.lblEdadDeIngreso.Text = "Edad de ingreso";
            // 
            // lblMateriaNoAprobadas
            // 
            this.lblMateriaNoAprobadas.AutoSize = true;
            this.lblMateriaNoAprobadas.Location = new System.Drawing.Point(12, 78);
            this.lblMateriaNoAprobadas.Name = "lblMateriaNoAprobadas";
            this.lblMateriaNoAprobadas.Size = new System.Drawing.Size(110, 13);
            this.lblMateriaNoAprobadas.TabIndex = 8;
            this.lblMateriaNoAprobadas.Text = "Materia no aprobadas";
            // 
            // lblAntiguedad
            // 
            this.lblAntiguedad.AutoSize = true;
            this.lblAntiguedad.Location = new System.Drawing.Point(15, 20);
            this.lblAntiguedad.Name = "lblAntiguedad";
            this.lblAntiguedad.Size = new System.Drawing.Size(61, 13);
            this.lblAntiguedad.TabIndex = 9;
            this.lblAntiguedad.Text = "Antiguedad";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAntiguedad);
            this.groupBox1.Controls.Add(this.lblMateriaNoAprobadas);
            this.groupBox1.Controls.Add(this.lblEdadDeIngreso);
            this.groupBox1.Controls.Add(this.txtEdadDeIngreso);
            this.groupBox1.Controls.Add(this.txtMateriaNoAprobadas);
            this.groupBox1.Controls.Add(this.txtAntiguedad);
            this.groupBox1.Location = new System.Drawing.Point(652, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 190);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alumno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Legajo";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(6, 35);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(216, 20);
            this.txtLegajo.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(6, 77);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(216, 20);
            this.txtNombre.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(6, 119);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(216, 20);
            this.txtApellido.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Fecha de nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Fecha de ingreso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Edad";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(6, 256);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(216, 20);
            this.txtEdad.TabIndex = 20;
            // 
            // txtCantidadDeMateriasAprobadas
            // 
            this.txtCantidadDeMateriasAprobadas.Location = new System.Drawing.Point(6, 340);
            this.txtCantidadDeMateriasAprobadas.Name = "txtCantidadDeMateriasAprobadas";
            this.txtCantidadDeMateriasAprobadas.Size = new System.Drawing.Size(216, 20);
            this.txtCantidadDeMateriasAprobadas.TabIndex = 24;
            // 
            // cbxActivo
            // 
            this.cbxActivo.AutoSize = true;
            this.cbxActivo.Location = new System.Drawing.Point(66, 292);
            this.cbxActivo.Name = "cbxActivo";
            this.cbxActivo.Size = new System.Drawing.Size(94, 17);
            this.cbxActivo.TabIndex = 26;
            this.cbxActivo.Text = "Alumno Activo";
            this.cbxActivo.UseVisualStyleBackColor = true;
            this.cbxActivo.Click += new System.EventHandler(this.cbxActivo_Click);
            // 
            // dtpFechaDeNacimiento
            // 
            this.dtpFechaDeNacimiento.Location = new System.Drawing.Point(9, 166);
            this.dtpFechaDeNacimiento.Name = "dtpFechaDeNacimiento";
            this.dtpFechaDeNacimiento.Size = new System.Drawing.Size(213, 20);
            this.dtpFechaDeNacimiento.TabIndex = 27;
            this.dtpFechaDeNacimiento.ValueChanged += new System.EventHandler(this.dtpFechaDeNacimiento_ValueChanged);
            // 
            // dtpFechaDeIngreso
            // 
            this.dtpFechaDeIngreso.Location = new System.Drawing.Point(9, 211);
            this.dtpFechaDeIngreso.Name = "dtpFechaDeIngreso";
            this.dtpFechaDeIngreso.Size = new System.Drawing.Size(213, 20);
            this.dtpFechaDeIngreso.TabIndex = 28;
            this.dtpFechaDeIngreso.ValueChanged += new System.EventHandler(this.dtpFechaDeIngreso_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dtpFechaDeIngreso);
            this.groupBox2.Controls.Add(this.dtpFechaDeNacimiento);
            this.groupBox2.Controls.Add(this.cbxActivo);
            this.groupBox2.Controls.Add(this.txtCantidadDeMateriasAprobadas);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtEdad);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtApellido);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtLegajo);
            this.groupBox2.Location = new System.Drawing.Point(314, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 370);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Formulario de alumno";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Cantidad de materia aprobadas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 593);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgrListaAlumnos);
            this.Controls.Add(this.btnModificarAlumno);
            this.Controls.Add(this.btnBorrarAlumno);
            this.Controls.Add(this.btnAgregarAlumno);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgrListaAlumnos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarAlumno;
        private System.Windows.Forms.Button btnBorrarAlumno;
        private System.Windows.Forms.Button btnModificarAlumno;
        private System.Windows.Forms.DataGridView dgrListaAlumnos;
        private System.Windows.Forms.TextBox txtAntiguedad;
        private System.Windows.Forms.TextBox txtMateriaNoAprobadas;
        private System.Windows.Forms.TextBox txtEdadDeIngreso;
        private System.Windows.Forms.Label lblEdadDeIngreso;
        private System.Windows.Forms.Label lblMateriaNoAprobadas;
        private System.Windows.Forms.Label lblAntiguedad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Ingreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant_Materia_Aprobadas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtCantidadDeMateriasAprobadas;
        private System.Windows.Forms.CheckBox cbxActivo;
        private System.Windows.Forms.DateTimePicker dtpFechaDeNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaDeIngreso;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
    }
}

