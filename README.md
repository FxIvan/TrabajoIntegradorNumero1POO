# ✅ Checklist para Programación Orientada a Objetos (POO)

Guía práctica para comenzar un proyecto en POO.  
Basada en los contenidos de la materia **Programación Orientada a Objetos** (Unidad 1).

---

## 1. Análisis del dominio
- [ ] Identificar el **dominio del problema** (¿qué quiero modelar?).

Ejemplo: queremos modelar un sistema de gestión escolar para alumnos.
```
// Dominio: Sistema Escolar
// Objetivo: Administrar alumnos y su información académica
```
- [ ] Detectar los **objetos reales** que forman parte del dominio.

👉 Ejemplo: dentro del dominio escolar detectamos:
- Alumno
- Profesor
- Curso
- Materia

- [ ] Definir **atributos (estado)** y **comportamientos (métodos)** de cada objeto.

👉 Ejemplo con Alumno:
```
class Alumno
{
    // Atributos (estado del objeto)
    public string Legajo { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public DateTime FechaIngreso { get; set; }
    public int MateriasAprobadas { get; set; }

    // Comportamientos (métodos)
    public int CalcularAntiguedad()
    {
        return DateTime.Now.Year - FechaIngreso.Year;
    }

    public int MateriasRestantes()
    {
        const int TOTAL = 36;
        return TOTAL - MateriasAprobadas;
    }
}
```
- [ ] Aplicar **abstracción** → transformar objetos reales en **clases**.

👉 Ejemplo: abstraemos la realidad → un alumno de carne y hueso se convierte en un objeto Alumno dentro del sistema.

```
class Profesor
{
    public string Nombre { get; set; }
    public string Especialidad { get; set; }

    public void DictarClase()
    {
        Console.WriteLine($"{Nombre} está dictando su clase de {Especialidad}.");
    }
}

class Curso
{
    public string Nombre { get; set; }
    public Profesor ProfesorAsignado { get; set; }

    public void MostrarCurso()
    {
        Console.WriteLine($"Curso: {Nombre}, Profesor: {ProfesorAsignado.Nombre}");
    }
}

```
---

## 2. Definición de clases
- [ ] Crear las **clases** principales necesarias.

👉 Ejemplo: definimos las clases Alumno y Curso.
```
class Alumno { }
class Curso { }
```

- [ ] Definir **campos** y **constantes** internos.

👉 Los campos suelen ser privados, y las constantes son valores fijos dentro de la clase.
```
class Alumno
{
    // Campo privado
    private int edad;

    // Constante (nunca cambia)
    private const int TOTAL_MATERIAS = 36;
}

```
- [ ] Implementar **propiedades** con `get` y `set` para controlar acceso.

👉 Con las propiedades se puede controlar la lectura/escritura de los atributos.
```
class Alumno
{
    private int edad;

    // Propiedad con validación en el set
    public int Edad
    {
        get => edad;
        set
        {
            if (value >= 0) edad = value;
        }
    }

    // Propiedad autoimplementada
    public string Nombre { get; set; }
}

```
- [ ] Respetar **encapsulamiento** (lo que se oculta / lo que se expone).

👉 Se usan modificadores de acceso (public, private, protected, internal).
```
class Alumno
{
    // Campo privado (oculto al exterior)
    private string legajo;

    // Propiedad pública para exponer de forma controlada
    public string Legajo
    {
        get => legajo;
        set
        {
            if (!string.IsNullOrEmpty(value))
                legajo = value;
        }
    }
}
```

- [ ] Revisar **modularidad**: cohesión alta y acoplamiento bajo.

👉 Ejemplo: cada clase hace una sola cosa bien (principio SRP).
```
class Alumno
{
    public string Nombre { get; set; }
    public int MateriasAprobadas { get; set; }

    public int MateriasRestantes()
    {
        const int TOTAL = 36;
        return TOTAL - MateriasAprobadas;
    }
}

// Clase Curso no depende de la lógica de Alumno
class Curso
{
    public string Nombre { get; set; }
    public List<Alumno> Alumnos { get; set; } = new List<Alumno>();

    public void AgregarAlumno(Alumno alumno)
    {
        Alumnos.Add(alumno);
    }
}

```
---
3. Relaciones entre clases
- [ ] Determinar si existe relación “Es-Un” (Herencia).
- [ ] Determinar si existe relación “Todo-Parte” (Agregación/Composición).
- [ ] Establecer enlaces (mensajes entre objetos).

---
4. Constructores y Finalizadores
- [ ] Definir un constructor por defecto si es necesario.
- [ ] Definir constructores con parámetros para inicializar atributos.
- [ ] (Opcional) Implementar un finalizador (~Clase) solo si hay recursos no administrados.
- [ ] Documentar cómo se crean y destruyen los objetos.

---
5. Métodos y Propiedades
- [ ] Implementar métodos sin parámetros y con parámetros (valor y referencia).
- [ ] Definir valores de retorno.
- [ ] Usar sobrecarga de métodos cuando se necesite.
- [ ] Incorporar propiedades de solo lectura/escritura según corresponda.
- [ ] Evaluar si necesitas indizadores.

---
6. Ciclo de vida y persistencia
- [ ] Analizar el ciclo de vida del objeto (creación → uso → destrucción).
- [ ] Definir si algún estado debe persistir más allá de la ejecución (archivo, base de datos).
- [ ] Considerar concurrencia si hay múltiples objetos activos al mismo tiempo.

---
7. Buenas prácticas de POO
- [ ] Aplicar abstracción: representar solo lo esencial.
- [ ] Aplicar encapsulamiento: exponer solo lo necesario mediante interfaces.
- [ ] Aplicar jerarquía: organizar con herencia y agregación.
- [ ] Revisar modularidad: clases claras, con una sola responsabilidad.
- [ ] Documentar la identidad, estado y comportamiento de cada objeto.
