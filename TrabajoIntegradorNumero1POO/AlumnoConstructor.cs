using System;

namespace TrabajoIntegradorNumero1POO
{
    internal class AlumnoConstructor
    {
        public string Legajo;
        public string Nombre;
        public string Apellido;
        public DateTime Fecha_Nacimiento;
        public DateTime Fecha_Ingreso;
        public int Edad;
        public bool Activo;
        public int MateriaAprobadas;

        // 🔹 Constructor sin parámetros (valores por defecto)
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

        // 🔹 Constructor con todos los parámetros
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
    }
}
