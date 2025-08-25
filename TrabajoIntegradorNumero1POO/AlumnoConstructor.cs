using System;

namespace TrabajoIntegradorNumero1POO
{
    internal class AlumnoConstructor
    {
        // 🔹 Propiedades (encapsulan los campos)
        public string Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public int Edad { get; set; }
        public bool Activo { get; set; }
        public int MateriaAprobadas { get; set; }

        // 🔹 Constructor sin parámetros (por defecto)
        public AlumnoConstructor()
        {
            Legajo = "Sin asignar";
            Nombre = "Sin asignar";
            Apellido = "Sin asignar";
            Fecha_Nacimiento = DateTime.MinValue;
            Fecha_Ingreso = DateTime.Now;
            Edad = 0;
            Activo = false;
            MateriaAprobadas = 0;
        }

        // 🔹 Constructor con parámetros
        public AlumnoConstructor(
            string legajo,
            string nombre,
            string apellido,
            DateTime fechaNacimiento,
            DateTime fechaIngreso,
            int edad,
            bool activo,
            int materiaAprobadas)
        {
            Legajo = legajo;
            Nombre = nombre;
            Apellido = apellido;
            Fecha_Nacimiento = fechaNacimiento;
            Fecha_Ingreso = fechaIngreso;
            Edad = edad;
            Activo = activo;
            MateriaAprobadas = materiaAprobadas;
        }

        // ================== MÉTODOS (comportamiento del alumno) ==================

        // 🔹 Antigüedad en la institución
        public string CalcularAntiguedad()
        {
            TimeSpan diferencia = DateTime.Now - Fecha_Ingreso;
            int diasTotales = (int)diferencia.TotalDays;
            int años = (int)(diferencia.TotalDays / 365.25);
            int meses = diasTotales / 30;

            return $"{años} Años / {meses} Meses / {diasTotales} Días";
        }

        // 🔹 Materias faltantes para recibirse
        public int MateriasNoAprobadas()
        {
            const int TOTAL_MATERIAS = 36;
            return TOTAL_MATERIAS - MateriaAprobadas;
        }

        // 🔹 Edad actual (si no querés depender de lo ingresado en txtEdad)
        public int CalcularEdadActual()
        {
            TimeSpan diferencia = DateTime.Now - Fecha_Nacimiento;
            return (int)(diferencia.TotalDays / 365.25);
        }
    }
}
