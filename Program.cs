// See https://aka.ms/new-console-template for more information
using Company.ClassLibrary1;

using var context = new AppDbContext();
var servicio = new ProductoService(context);

servicio.Agregar("Mouse", 13000);
servicio.Agregar("Teclado", 88999);
servicio.Agregar("Auris", 27377);

Console.WriteLine("-----Lista de Productos el pepe-----");
foreach(var p in servicio.ObtenerTodos())
{
    Console.WriteLine($"{p.Id} - {p.Nombre} - ${p.Precio}");
}
