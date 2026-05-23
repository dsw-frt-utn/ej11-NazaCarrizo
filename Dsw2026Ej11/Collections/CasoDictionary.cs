namespace Dsw2026Ej11.Collections;
using Domain;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    private Dictionary<int, Alumno> _alumnos=new Dictionary<int, Alumno>();

    public Dictionary<int, Alumno> Alumnos
    {
        get
        {
            return _alumnos;
        }
        set
        {
            _alumnos = value;
        }
    }

    public bool AgregarAlumno(Alumno alu)
    {
        if (_alumnos.ContainsKey(alu.Id)) return false;
        _alumnos.Add(alu.Id, alu);
        return true;
    }

    public Alumno? BuscarAlumno(int legajo)
    {
        Alumno? alu = null;
        if (_alumnos.ContainsKey(legajo)) alu=_alumnos[legajo];
        return alu;
    }

    public Dictionary<int, Alumno> ObtenerDiccionario()
    {
        return _alumnos;
    }

    public bool BorrarAlumno(int legajo)
    {
        return _alumnos.Remove(legajo);
    }

}
