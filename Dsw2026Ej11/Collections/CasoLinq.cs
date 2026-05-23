using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

/*
 * Para cada punto crear un método que permita:
 * 1. Obtener el primer libro (GetPrimero)
 * 2. Obtener el último libro (GetUltimo)
 * 3. Obtener la suma de precios (GetTotalPrecios)
 * 4. Obtener el promedio de precios (GetPromedioPrecios)
 * 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
 * 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
 * 7. Obtener el libro con el precio más alto (GetMayorPrecio)
 * 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
 * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
 * 10. Obtener los libros ordenados por título de forma descendente
 * En todos los casos debe aplicarse LINQ
 */
public class CasoLinq
{
    private List<Libro> _libros = Libro.CrearLista();
    public Libro GetPrimero() => _libros.First();

    public Libro GetUltimo() => _libros.Last();

    public decimal GetTotalPrecios()
    {
        decimal a =0;
        a = _libros.Sum(x => x.Precio);
        return a;
    }

    public decimal GetPromedioPrecios()
    {
        decimal a = 0;
        a=_libros.Average(x=>x.Precio);
        return a;
    }

    public IEnumerable<Libro> GetListById() => _libros.Where(x => x.Id > 15);

    public List<string> GetLibros()
    {
        List<string> listado;
        listado = _libros.Select(x => $"{x.Titulo}-{x.Precio:C}").ToList();
        return listado;
    }

    public Libro? GetMayorPrecio() => _libros.MaxBy(x => x.Precio);

    public Libro? GetMenorPrecio() => _libros.MinBy(x => x.Precio);

    public IEnumerable<Libro> GetMayorPromedio() => _libros.Where(x => x.Precio > _libros.Average(p => p.Precio));

    public IEnumerable<Libro> GetLibrosOrdenadosDesc() => _libros.OrderByDescending(x => x.Titulo);


}

