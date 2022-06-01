using GildedRose.Datos.Producto;
using GildedRose.Negocio.Articulos;

namespace GildedRose.Negocio.CatalogoArticulos;

public class ArticuloBackstage:Articulo
{
    private CondicionesGenerales CondicionesGenerales => CondicionesGenerales.GetInstance();
    
    public ArticuloBackstage(string name, int sellIn, int quality) : base(name, sellIn, quality)
    {
    }
    
    public override Item AtualizarArticulo()
    {
        var articulo = this;
        base.AtualizarArticulo();
        if (!CondicionesGenerales.ValidateSellInMayorTo(articulo.SellIn, 0))
        {
            articulo.Quality = 0;
            return articulo;
        }

        if (CondicionesGenerales.ValidateSellInArticuloEspeciales(articulo.SellIn, 10))
            articulo.Quality = CondicionesGenerales.AumentarQuality(articulo.Quality, 2);
        else if (CondicionesGenerales.ValidateSellInArticuloEspeciales(articulo.SellIn, 5))
            articulo.Quality = CondicionesGenerales.AumentarQuality(articulo.Quality, 3);

        return articulo;
    }

    

}