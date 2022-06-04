using GildedRose.Negocio.Articulos;
using GildedRose.Negocio.CatalogoArticulos;

namespace GildedRose.Datos.Producto;

public class Item
{
    public string Name { get; }
    public int SellIn { get; protected set; }
    public int Quality { get; protected set; }


    public Item(string name, int sellIn, int quality)
    {
        if (String.IsNullOrEmpty(name)) throw new Exception("Valor Name Requerido");
        Name = name;
        SellIn = sellIn;
        Quality = quality;
    }

    public virtual Item AtualizarArticulo()
    {
        SellIn = SellIn - 1;
        return this;
    }
}