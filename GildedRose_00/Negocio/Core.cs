using GildedRose_00.Negocio.Articulos;
using GildedRose_00.Negocio.CatalogoArticulos;

namespace GildedRose_00.Negocio
{
    public class Core
    {
        private ArticuloEspecial ArticuloEspecial { get; set; }
        private ArticuloGenerico ArticuloGenerico { get; set; }
        private ArticulosOperacion ArticulosOperacion { get; set; }

        public Core()
        {
            ArticuloEspecial = new ArticuloEspecial();
            ArticuloGenerico = new ArticuloGenerico();
            ArticulosOperacion = new ArticulosOperacion();
        }

        public Item UpdateArticulos(Item articulo)
        {
            articulo.SellIn = ArticulosOperacion.DisminuirDias(articulo.SellIn);
            switch (articulo.Name)
            {
                case "Aged Brie" : 
                case"Backstage passes to a TAFKAL80ETC concert":
                case"Sulfuras, Hand of Ragnaros":
                    return ArticuloEspecial.WorkArticuloEspecial(articulo);
                default:
                    return ArticuloGenerico.WorkArticuloGenerico(articulo);
            }
        }

    }
}