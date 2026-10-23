using System;

namespace Company.ClassLibrary1;

public class ProductoService
{
private readonly AppDbContext _context
    {
        _context = context;
    }
public void Agregar (string nombre, decimal precio)
{
       nombre = nombre;
       precio = precio;
}
    _context.Producto.Add(producto):
    _context.SaveChanges();
    public List<Producto>ObtenerTodos()
    {
        return _context.Producto.ToList();
    }
}

