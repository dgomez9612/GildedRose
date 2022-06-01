using GildedRose.Negocio.CatalogoArticulos;
using Xunit;

namespace GildedRose.Test;

public class ArticuloLegendarioTests
{
    [Fact]
    public void No_Debe_Aumentar_Quality_After_Actualizar()
    {
        var qualityOriginal = 80;
        var legendario = new ArticuloLegendario("", 0, qualityOriginal);
        
        legendario.AtualizarArticulo();
        
        Assert.Equal(legendario.Quality, qualityOriginal);
    }
    
    [Fact]
    public void No_Debe_Aumentar_Sellin_After_Actualizar()
    {
        var sellin = 3;
        var legendario = new ArticuloLegendario("", sellin, 0);
        
        legendario.AtualizarArticulo();
        
        Assert.Equal(legendario.SellIn, sellin);
    }
}