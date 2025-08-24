using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoIntegradorNumero1POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargarAlumnosDePrueba();
            LlenarLista();
        }

        List<AlumnoConstructor> alumnos = new List<AlumnoConstructor>();


        bool insertoNuevaFechaDeIngreso = false;
        bool insertoNuevaFechaDeNacimiento = false;
        bool modificoElActivo = false;

        string Antiguedad(AlumnoConstructor alumno)
        {
            TimeSpan diferencia = DateTime.Now - alumno.Fecha_Ingreso;
            int años = (int)(diferencia.TotalDays / 365.25);
            return años.ToString();
        }


        // ############## Metodos relacionado a data griew view ####################
        AlumnoConstructor RowSelect()
        {
            return alumnos[dgrListaAlumnos.CurrentRow.Index];
        }

        void RowDeleted()
        {
            alumnos.RemoveAt(dgrListaAlumnos.CurrentRow.Index);
        }

        private int ParseOrDefault(string input, int defaultValue)
        {
            return int.TryParse(input, out int parsed) ? parsed : defaultValue;
        }

        private bool IsEmpty(TextBox txt)
        {
            return string.IsNullOrWhiteSpace(txt.Text);
        }

        void LlenarInputs()
        {
            AlumnoConstructor alumnoSeleccionado = RowSelect();
            txtLegajo.Text = alumnoSeleccionado.Legajo.ToString();
            txtNombre.Text = alumnoSeleccionado.Nombre.ToString();
            txtApellido.Text = alumnoSeleccionado.Apellido.ToString();
            dtpFechaDeNacimiento.Value = alumnoSeleccionado.Fecha_Nacimiento;
            dtpFechaDeIngreso.Value = alumnoSeleccionado.Fecha_Ingreso;
            txtEdad.Text = alumnoSeleccionado.Edad.ToString();
            cbxActivo.Checked = alumnoSeleccionado.Activo;
            txtCantidadDeMateriasAprobadas.Text = alumnoSeleccionado.MateriaAprobadas.ToString();
        }

        void ClearInputs()
        {
            txtLegajo.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            dtpFechaDeNacimiento.Value = DateTime.Now;
            dtpFechaDeIngreso.Value = DateTime.Now;
            txtEdad.Text = "";
            cbxActivo.Checked = false;
            txtCantidadDeMateriasAprobadas.Text = "";
        }
        void RowModification()
        {

            AlumnoConstructor alumnoSeleccionado = RowSelect();

            string legajo = txtLegajo.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            DateTime fechaNacimiento = dtpFechaDeNacimiento.Value;
            DateTime fechaIngreso = dtpFechaDeIngreso.Value;
            int edad = ParseOrDefault(txtEdad.Text, alumnoSeleccionado.Edad);
            bool activo = cbxActivo.Checked;
            int materiasAprobadas = ParseOrDefault(txtCantidadDeMateriasAprobadas.Text, alumnoSeleccionado.MateriaAprobadas);

            if (!IsEmpty(txtLegajo) && alumnoSeleccionado.Legajo != legajo) alumnoSeleccionado.Legajo = legajo;
            if (!IsEmpty(txtNombre) && alumnoSeleccionado.Nombre != nombre) alumnoSeleccionado.Nombre = nombre;
            if (!IsEmpty(txtApellido) && alumnoSeleccionado.Apellido != apellido) alumnoSeleccionado.Apellido = apellido;
            if (insertoNuevaFechaDeNacimiento && alumnoSeleccionado.Fecha_Nacimiento != fechaNacimiento) alumnoSeleccionado.Fecha_Nacimiento = fechaNacimiento;
            if (insertoNuevaFechaDeIngreso && alumnoSeleccionado.Fecha_Ingreso != fechaIngreso) alumnoSeleccionado.Fecha_Ingreso = fechaIngreso;
            if (!IsEmpty(txtEdad) && alumnoSeleccionado.Edad != edad) alumnoSeleccionado.Edad = edad;
            if (modificoElActivo && alumnoSeleccionado.Activo != activo) alumnoSeleccionado.Activo = activo;
            if (!IsEmpty(txtCantidadDeMateriasAprobadas) && alumnoSeleccionado.MateriaAprobadas != materiasAprobadas) alumnoSeleccionado.MateriaAprobadas = materiasAprobadas;

            LlenarLista();
            ClearInputs();
        }

        // ############################

        // 🔹 Esta función crea datos de ejemplo automáticamente
        void CargarAlumnosDePrueba()
        {
            alumnos.Clear();

            alumnos.Add(new AlumnoConstructor("001", "Juan", "Pérez",
                new DateTime(2000, 5, 20), new DateTime(2025, 8, 21), 24, true, 10));

            alumnos.Add(new AlumnoConstructor("002", "María", "Gómez",
                new DateTime(1999, 3, 15), new DateTime(2025, 8, 22), 25, false, 12));

            alumnos.Add(new AlumnoConstructor("003", "Carlos", "López",
                new DateTime(2001, 7, 10), new DateTime(2025, 8, 23), 23, true, 8));

            alumnos.Add(new AlumnoConstructor("004", "Lucía", "Martínez",
                new DateTime(2002, 9, 30), new DateTime(2025, 8, 24), 22, true, 5));
        }

        void LlenarLista()
        {
            dgrListaAlumnos.Rows.Clear();
            foreach (AlumnoConstructor alumno in alumnos)
            {
                dgrListaAlumnos.Rows.Add(
                    alumno.Legajo,
                    alumno.Nombre,
                    alumno.Apellido,
                    alumno.Fecha_Nacimiento.ToShortDateString(),
                    alumno.Fecha_Ingreso.ToShortDateString(),
                    alumno.Edad,
                    alumno.Activo ? "Sí" : "No",
                    alumno.MateriaAprobadas
                );
            }
        }


        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {

            string legajo = txtLegajo.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            DateTime fechaNacimiento = dtpFechaDeNacimiento.Value;
            DateTime fechaIngreso = dtpFechaDeIngreso.Value;
            int edad = Convert.ToInt32(txtEdad.Text);
            bool activo = cbxActivo.Checked;
            int materiasAprobadas = Convert.ToInt32(txtCantidadDeMateriasAprobadas.Text);

            AlumnoConstructor nuevoAlumno = new AlumnoConstructor(
                legajo,
                nombre,
                apellido,
                fechaNacimiento,
                fechaIngreso,
                edad,
                activo,
                materiasAprobadas
            );

            alumnos.Add(nuevoAlumno);
            LlenarLista();
            ClearInputs();
        }

        private void btnBorrarAlumno_Click(object sender, EventArgs e)
        {
            AlumnoConstructor alumno = RowSelect();
            DialogResult result = MessageBox.Show(
                $"Alumno a eliminar: {alumno.Apellido}",
                "Información",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.OK) RowDeleted();
            LlenarLista();
            ClearInputs();
        }

        private void btnModificarAlumno_Click(object sender, EventArgs e)
        {
            RowModification();
        }

        private void dgrListaAlumnos_SelectionChanged(object sender, EventArgs e)
        { 
            //Escucha Eveto de seleccion
            // LlenarInputs();
        }

        private void dtpFechaDeIngreso_ValueChanged(object sender, EventArgs e)
        {
            insertoNuevaFechaDeIngreso = true;
        }

        private void dtpFechaDeNacimiento_ValueChanged(object sender, EventArgs e)
        {
            insertoNuevaFechaDeNacimiento = true;
        }

        private void cbxActivo_Click(object sender, EventArgs e)
        {
            modificoElActivo = true;
        }
    }
}
