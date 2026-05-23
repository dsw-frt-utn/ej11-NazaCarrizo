using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList listadoAlumnos = new CasoList();

        listadoAlumnos.AgregarAlumno(new Alumno(58007, "Nazareno Carrizo", 8.0));
        listadoAlumnos.AgregarAlumno(new Alumno(58304, "Jose Lopez", 8.5));
        listadoAlumnos.AgregarAlumno(new Alumno(53234, "Ana Juarez", 7.0));
        Console.WriteLine("Alumnos: ");
        MostrarAlumnos(listadoAlumnos);
        
        Console.WriteLine("Buscando alumno existente por nombre: ");
        Alumno? a = listadoAlumnos.BuscarAlumno("Nazareno Carrizo");
        Console.WriteLine(ComprobarAlumno(a));
        Console.WriteLine("Buscando alumno inexistente: ");
        a = listadoAlumnos.BuscarAlumno("Juan Valdez");
        Console.WriteLine(ComprobarAlumno(a));

        //eliminamos un alumno
        a = listadoAlumnos.BuscarAlumno("Ana Juarez");
        listadoAlumnos.BorrarAlumno(a);
        Console.WriteLine("Eliminada la Alumna Ana Juarez");
        MostrarAlumnos(listadoAlumnos);
        //Eliminamos al primero
        Console.WriteLine("Eliminado el primer alumno");
        listadoAlumnos.BorrarAlumno(0);
        MostrarAlumnos(listadoAlumnos);
    }

    public static void MostrarAlumnos(CasoList lista)
    {
        foreach(Alumno alu in lista.ObtenerLista())
        {
            Console.WriteLine(alu.ToString());
        }
    }

    public static string ComprobarAlumno(Alumno? a)
    {
        if (a != null)
        {
            return a.ToString();
        }
        return "No existe";
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        var diccionarioAlumnos = new CasoDictionary();

        diccionarioAlumnos.AgregarAlumno(new Alumno(58007, "Nazareno Carrizo", 8.0));
        diccionarioAlumnos.AgregarAlumno(new Alumno(58304, "Jose Lopez", 8.5));
        diccionarioAlumnos.AgregarAlumno(new Alumno(53234, "Ana Juarez", 7.0));
        Console.WriteLine("Alumnos cargados: ");
        MostrarAlumnosDictionary(diccionarioAlumnos);
        Console.WriteLine("Busqueda de alumno");
        Alumno? a = diccionarioAlumnos.BuscarAlumno(58007);
        Console.WriteLine(ComprobarAlumno(a));

        Console.WriteLine("Busqueda de alumno no existente: ");
        a = diccionarioAlumnos.BuscarAlumno(50000);
        Console.WriteLine(ComprobarAlumno(a));

        Console.WriteLine("Eliminando alumno");
        diccionarioAlumnos.BorrarAlumno(53234);
        MostrarAlumnosDictionary(diccionarioAlumnos);

    }


    public static void MostrarAlumnosDictionary(CasoDictionary diccionario)
    {
        if (diccionario != null)
        {
            foreach(KeyValuePair<int,Alumno> alu in diccionario.ObtenerDiccionario())
            {
                Console.WriteLine(alu.Value.ToString());
            }
        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        var librosLinq = new CasoLinq();
        //Metodo de obtener el primero
        Console.WriteLine(librosLinq.GetPrimero().ToString());

        //Metodo obtener el ultimo
        Console.WriteLine(librosLinq.GetUltimo().ToString());
        //Metodo precios
        Console.WriteLine($"Precio total de los libros: {librosLinq.GetTotalPrecios()}");
        //Metodo de promedios
        Console.WriteLine($"Promedio total de los libros:{librosLinq.GetPromedioPrecios()} ");
        //Metodo Id mayor a 15
        Console.WriteLine("Libros con ID mayor a 15: ");
        MostrarListadoLibros(librosLinq.GetListById());
        Console.WriteLine("Libros en formato moneda: ");
        foreach(string cad in librosLinq.GetLibros())
        {
            Console.WriteLine(cad);
        }
        //Libros con precio mas alto
        Console.WriteLine($"Libro con precio mas alto: {librosLinq.GetMayorPrecio()}");
        //Libro con precio mas bajo
        Console.WriteLine($"Libro con precio mas bajo: {librosLinq.GetMenorPrecio()}");
        //Metodo de listado de Libros con precio mayor al promedio
        Console.WriteLine("Listado de libros con precio mayor al promedio: ");
        MostrarListadoLibros(librosLinq.GetMayorPromedio());
        //Metodo de listado de libros ordenados de manera descendente
        Console.WriteLine("Listado de libros ordenados de manera descendente: ");
        MostrarListadoLibros(librosLinq.GetLibrosOrdenadosDesc());



    }

    public static void MostrarListadoLibros(IEnumerable<Libro> lista)
    {
        foreach(Libro libro in lista)
        {
            Console.WriteLine(libro.ToString());
        }
    }
}
