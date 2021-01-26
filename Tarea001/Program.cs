using System;

namespace Tarea001
{
    class Program
    {
        static void Main(string[] args)
        {
            var producto = new Producto();
            producto.Marca = "Samsung";
            producto.Descripcion = "Televisor LED";
            producto.PesoEnKilogramos = 8;
            Console.WriteLine(
                $"Hemos creado un nuevo producto de la Marca = {producto.Marca.ToUpper()} \n" +
                $"Descripción del Producto = {producto.Descripcion} \n" +
                $"Este producto tiene un peso de  = {producto.PesoEnKilogramos} {"kg"} \n" +
                $"En Libras de = {producto.PesoEnLibra}{"lb"} \n");
            ;

        }
    }
}
