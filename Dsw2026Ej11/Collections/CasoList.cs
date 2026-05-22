namespace Dsw2026Ej11.Collections;

using Dsw2026Ej11.Domain;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    private List<Alumno> _alumnos = new List<Alumno>();
    public List<Alumno> Alumnos { get { return _alumnos; } set { _alumnos = value; } }

    public void AgregarAlumno(Alumno alu)
    {
        _alumnos.Add(alu);
    }

    public List<Alumno> ObtenerLista()
    {
        return _alumnos;
    }

    public Alumno? BuscarAlumno(string nombre)
    {
        foreach (Alumno a in _alumnos)
        {
            if (a.Nombre.Equals(nombre))
            {
                return a;
            }
        }
        return null;
    }

    public Alumno? BuscarAlumno(Alumno alu)
    {
        foreach (Alumno a in _alumnos)
        {
            if (alu == a)
            {
                return a;
            }
        }
        return null;
    }

    public bool BorrarAlumno(Alumno alu)
    {
        if (alu == null) return false;

        _alumnos.Remove(alu);
        return true;
    }

    public bool BorrarAlumno(int indice)
    {
        if (indice < 0 || indice >= _alumnos.Count)
        {
            return false;
        }
        else
        {
            _alumnos.RemoveAt(indice);
            return true;
        }
    }
}
