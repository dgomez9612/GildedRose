using GildedRose.Negocio.CatalogoArticulos;
using Xunit;

namespace GildedRose.Test;

public class ArticuloAgedBrieTests
{
    [Fact]
    public void AgedBrie_Debe_Aumentar_Quality_After_Actualizar()
    {
        var agedBrie = new ArticuloAgedBrie("", 3, 0);
                                         
                                                 agedBrie.AtualizarArticulo();
                                                 
                                                 Assert.Equal(2, agedBrie.SellIn);
        Assert.Equal(1, agedBrie.Quality);
    }
        
    [Fact]
    public void AgedBrie_Debe_Aumentar_Al_Doble_Quality_After_Actualizar_When_SellIn_Is_0()
    {
        var agedBrie = new ArticuloAgedBrie("", 0, 0);

        agedBrie.AtualizarArticulo();
        
        Assert.Equal(2, agedBrie.Quality);
    }

}