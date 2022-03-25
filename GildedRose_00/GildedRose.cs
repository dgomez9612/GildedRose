using System.Collections.Generic;
using GildedRose.Datos.Producto;
using GildedRose.Negocio;
using GildedRose.Negocio.Articulos;
using GildedRose.Negocio.CatalogoArticulos;

namespace GildedRose_00
{
    public class GildedRose
    {
        private CondicionesGenerales CondicionesGenerales => CondicionesGenerales.GetInstance();
        readonly IList<Item> _items;

        public GildedRose(IList<Item> Items)
        {
            this._items = Items;
        }

        public void UpdateQuality()
        {
            for (int i = 0; i < _items.Count; i++)
            {
                var articulo = _items[i];
                _items[i] = articulo.AtualizarArticulo();
            }
        }
    }
}