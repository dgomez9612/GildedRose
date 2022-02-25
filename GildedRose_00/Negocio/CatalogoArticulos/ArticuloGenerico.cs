using GildedRose_00.Negocio.Articulos;

namespace GildedRose_00.Negocio.CatalogoArticulos
{
    public class ArticuloGenerico
    {
        private ArticulosOperacion ArticulosOperacion { get; set; }

        public ArticuloGenerico()
        {
            ArticulosOperacion = new ArticulosOperacion();
        }

        public Item WorkArticuloGenerico(Item articulo)
        {
            if(!ArticulosOperacion.ValidateSellInMayorTo(articulo.SellIn,0))articulo.Quality = ArticulosOperacion.DisminuirQualitiy(articulo.Quality, 2);
            return articulo;
        }
    }
}