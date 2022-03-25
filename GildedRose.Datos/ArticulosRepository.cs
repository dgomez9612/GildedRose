using GildedRose.Datos.Producto;
using GildedRose.Negocio.CatalogoArticulos;
using GildedRose.Negocio.Repositories;

namespace GildedRose.Datos;

public class ArticulosRepository : IArticulosRepository
{
    public IList<Item> GetProductos()
    {
        IList<Item> items = new List<Item>
        {
            new ArticuloGenerico("+5 Dexterity Vest", 10, 20),
            new ArticuloAgedBrie("Aged Brie", 2, 0),
            new ArticuloGenerico("Elixir of the Mongoose", 5, 7),
            new ArticuloLegendario("Sulfuras, Hand of Ragnaros", 0, 80),
            new ArticuloLegendario
            (
                "Sulfuras, Hand of Ragnaros", -1, 80
            ),
            new ArticuloBackstage
            (
                "Backstage passes to a TAFKAL80ETC concert",
                15,
                20
            ),
            new ArticuloBackstage
            (
                "Backstage passes to a TAFKAL80ETC concert",
                10,
                49
            ),
            new ArticuloBackstage
            (
                "Backstage passes to a TAFKAL80ETC concert",
                5,
                49
            ),
            // this conjured item does not work properly yet
            new ArticuloConjurado("Conjured Mana Cake", 3, 6)
        };
        return items;
    }
}