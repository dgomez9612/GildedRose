using GildedRose_00.Negocio.Articulos;

namespace GildedRose_00.Negocio.CatalogoArticulos
{
    public class ArticuloEspecial
    {
        private ArticulosOperacion ArticulosOperacion { get; set; }

        public ArticuloEspecial()
        {
            ArticulosOperacion = new ArticulosOperacion();
        }

        public Item WorkArticuloEspecial(Item articulo)
        {
            switch (articulo.Name)
            {
                case "Aged Brie":
                    return ToWorkAgedBried(articulo);
                case "Backstage passes to a TAFKAL80ETC concert":
                    return ToWorkBackstage(articulo);
                default:
                     articulo.SellIn=articulo.SellIn+1;
                     return articulo;
            }
        }

        private Item ToWorkAgedBried(Item articulo)
        {
            if (ArticulosOperacion.ValidateSellInMayorTo(articulo.SellIn, 0))
            {
                articulo.Quality = ArticulosOperacion.AumentarQualitiy(articulo.Quality, 1);
            }
            else
            {
                articulo.Quality = ArticulosOperacion.AumentarQualitiy(articulo.Quality, 2);
            }

            return articulo;
        }

        private Item ToWorkBackstage(Item articulo)
        {
            if (!ArticulosOperacion.ValidateSellInMayorTo(articulo.SellIn, 0))
            {
                articulo.Quality = 0;
                return articulo;
            }
            if (ArticulosOperacion.ValidateSellInArticuloEspeciales(articulo.SellIn, 10))
                articulo.Quality = ArticulosOperacion.AumentarQualitiy(articulo.Quality, 2);
            else if (ArticulosOperacion.ValidateSellInArticuloEspeciales(articulo.SellIn, 5))
                articulo.Quality = ArticulosOperacion.AumentarQualitiy(articulo.Quality, 3);
            return articulo;
        }
    }
}