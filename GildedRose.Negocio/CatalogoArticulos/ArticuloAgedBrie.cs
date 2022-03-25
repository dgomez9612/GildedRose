using GildedRose.Datos.Producto;
using GildedRose.Negocio.Articulos;

namespace GildedRose.Negocio.CatalogoArticulos;

public class ArticuloAgedBrie:Articulo
{
    private CondicionesGenerales CondicionesGenerales => CondicionesGenerales.GetInstance();
    
    public ArticuloAgedBrie(string name, int sellIn, int quality) : base(name, sellIn, quality)
    {
    }
    
    public override Item AtualizarArticulo()
    {
        base.AtualizarArticulo();
        
        if (CondicionesGenerales.ValidateSellInMayorTo(this.SellIn, 0))
        {
            this.Quality = CondicionesGenerales.AumentarQuality(this.Quality, 1);
        }
        else
        {
            this.Quality = CondicionesGenerales.AumentarQuality(this.Quality, 2);
        }
        return this;
    }
}