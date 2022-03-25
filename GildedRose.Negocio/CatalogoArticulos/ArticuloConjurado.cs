using GildedRose.Datos.Producto;
using GildedRose.Negocio.Articulos;

namespace GildedRose.Negocio.CatalogoArticulos;

public class ArticuloConjurado:Articulo
{
    private CondicionesGenerales CondicionesGenerales => CondicionesGenerales.GetInstance();
    
    public override Item AtualizarArticulo()
    {
        var articulo = this;
        articulo.Quality = CondicionesGenerales.DisminuirQuality(articulo.Quality, 2);
        return articulo;
    }

    public ArticuloConjurado(string name, int sellIn, int quality) : base(name, sellIn, quality)
    {
    }
    

}