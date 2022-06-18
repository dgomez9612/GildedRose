using GildedRose.Datos.Producto;
using GildedRose.Negocio.Articulos;

namespace GildedRose.Negocio.CatalogoArticulos
{
    public class ArticuloGenerico:Articulo
    {
        private CondicionesGenerales CondicionesGenerales => CondicionesGenerales.GetInstance();
        public override Item ActualizarArticulo()
        {
            var articulo = this;
            base.ActualizarArticulo();
            if (!CondicionesGenerales.ValidateSellInMayorTo(articulo.SellIn, 0))
                articulo.Quality = CondicionesGenerales.DisminuirQuality(articulo.Quality, 2);
            
            return articulo;
        }

        public ArticuloGenerico(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
           
        }
       
    }
}