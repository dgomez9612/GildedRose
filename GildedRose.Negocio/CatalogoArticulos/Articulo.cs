using GildedRose.Datos.Producto;

namespace GildedRose.Negocio.CatalogoArticulos;

public class Articulo : Item
{
    public Articulo(string name, int sellIn, int quality) : base(name, sellIn, quality)
    {
    }
}