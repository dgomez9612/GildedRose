using GildedRose.Datos.Producto;
using GildedRose.Negocio.Articulos;

namespace GildedRose.Negocio.CatalogoArticulos;

public class ArticuloLegendario:Articulo
{
    public override Item AtualizarArticulo()
    {
        // base.AtualizarArticulo();
        //  Quality = Quality + 1;
        return this;
    }

    public ArticuloLegendario(string name, int sellIn, int quality) : base(name, sellIn, quality)
    {
    }
}