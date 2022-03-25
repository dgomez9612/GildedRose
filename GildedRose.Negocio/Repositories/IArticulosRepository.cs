using GildedRose.Datos.Producto;

namespace GildedRose.Negocio.Repositories;

public interface IArticulosRepository
{
    IList<Item> GetProductos();
}
