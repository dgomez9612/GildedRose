using GildedRose.Datos.Producto;
using GildedRose.Negocio.Articulos;

namespace GildedRose.Negocio.CatalogoArticulos;

public class ArticuloLegendario:Articulo
{
    public override Item AtualizarArticulo()
    {
        SellIn = SellIn + 1;
        return this;
    }

    public ArticuloLegendario(string name, int sellIn, int quality) : base(name, sellIn, quality)
    {
    }
}