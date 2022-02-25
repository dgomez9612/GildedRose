using System.Collections.Generic;
using GildedRose_00.Negocio;

namespace GildedRose_00
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }
        public void UpdateQuality()
        {
            Core coreGildRose = new Core();
            for (int i = 0; i < Items.Count; i++)
            {
                Items[i] = coreGildRose.UpdateArticulos(Items[i]);
            }
        }
    }
}
