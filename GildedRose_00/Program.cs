using System;
using System.Collections.Generic;
using GildedRose.Datos;
using GildedRose.Datos.Producto;
using GildedRose.Negocio.CatalogoArticulos;
using GildedRose.Negocio.Repositories;

namespace GildedRose_00
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IArticulosRepository articulosRepository = new ArticulosRepository();
            Console.WriteLine("OMGHAI!");
            IList<Item> productos = articulosRepository.GetProductos();
            var app = new GildedRose(productos);
            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var dia = 0; dia < productos.Count; dia++)
                {
                   var producto = productos[dia];
                    System.Console.WriteLine(producto.Name + ", " + producto.SellIn + ", " + producto.Quality);
                }
                Console.WriteLine("");
                app.UpdateQuality();
            }
        }
    }
}
