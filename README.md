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
> Alumno
> Profesor
> Curso
> Materia
```
// Objetos reales detectados en el dominio
// Alumno, Profesor, Curso, Materia
```
- [ ] Definir **atributos (estado)** y **comportamientos (métodos)** de cada objeto.
- [ ] Aplicar **abstracción** → transformar objetos reales en **clases**.

💡 *Ejemplo*:  
Un **Alumno** tiene atributos (`Legajo`, `Nombre`, `Apellido`) y comportamientos (`CalcularAntiguedad()`, `MateriasNoAprobadas()`).

---

## 2. Definición de clases
- [ ] Crear las **clases** principales necesarias.
- [ ] Definir **campos** y **constantes** internos.
- [ ] Implementar **propiedades** con `get` y `set` para controlar acceso.
- [ ] Respetar **encapsulamiento** (lo que se oculta / lo que se expone).
- [ ] Revisar **modularidad**: cohesión alta y acoplamiento bajo.

```
class Alumno {
    public string Nombre { get; set; }
    private int edad;

    public int Edad {
        get => edad;
        set {
            if (value > 0) edad = value;
        }
    }
}
```

3. Relaciones entre clases
- [ ] Determinar si existe relación “Es-Un” (Herencia).
- [ ] Determinar si existe relación “Todo-Parte” (Agregación/Composición).
- [ ] Establecer enlaces (mensajes entre objetos).

💡 Ejemplo:
```
Alumno es-un Persona.
Curso tiene muchos Alumnos.
```

4. Constructores y Finalizadores
- [ ] Definir un constructor por defecto si es necesario.
- [ ] Definir constructores con parámetros para inicializar atributos.
- [ ] (Opcional) Implementar un finalizador (~Clase) solo si hay recursos no administrados.
- [ ] Documentar cómo se crean y destruyen los objetos.
```
class Alumno {
    public string Nombre { get; set; }

    // Constructor
    public Alumno(string nombre) {
        Nombre = nombre;
    }

    // Finalizador (se ejecuta al liberar el objeto)
    ~Alumno() {
        Console.WriteLine($"Alumno {Nombre} finalizado.");
    }
}
```

5. Métodos y Propiedades
- [ ] Implementar métodos sin parámetros y con parámetros (valor y referencia).
- [ ] Definir valores de retorno.
- [ ] Usar sobrecarga de métodos cuando se necesite.
- [ ] Incorporar propiedades de solo lectura/escritura según corresponda.
- [ ] Evaluar si necesitas indizadores.

```
class Calculadora {
    public int Sumar(int a, int b) => a + b;       // Sobrecarga 1
    public double Sumar(double a, double b) => a + b; // Sobrecarga 2
}
```

6. Ciclo de vida y persistencia
- [ ] Analizar el ciclo de vida del objeto (creación → uso → destrucción).
- [ ] Definir si algún estado debe persistir más allá de la ejecución (archivo, base de datos).
- [ ] Considerar concurrencia si hay múltiples objetos activos al mismo tiempo.

7. Buenas prácticas de POO
- [ ] Aplicar abstracción: representar solo lo esencial.
- [ ] Aplicar encapsulamiento: exponer solo lo necesario mediante interfaces.
- [ ] Aplicar jerarquía: organizar con herencia y agregación.
- [ ] Revisar modularidad: clases claras, con una sola responsabilidad.
- [ ] Documentar la identidad, estado y comportamiento de cada objeto.
