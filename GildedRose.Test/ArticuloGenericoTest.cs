using System;
using GildedRose.Negocio.CatalogoArticulos;
using Xunit;

namespace GildedRose.Test;

public class ArticuloGenericoTest
{
    [Fact]
    public void Articulo_Debe_Disminuir_Quality_Al_Doble_After_Actualizar_Si_Sellin_Igual_A_Cero()
    {
        var qualityOriginal = 10;
        var articuloGenerico = new ArticuloGenerico("Test", 0, qualityOriginal);
        articuloGenerico.ActualizarArticulo();
        Assert.Equal((qualityOriginal-2), articuloGenerico.Quality);
    }
    [Fact]
    public void ArticuloGenerico_No_Debe_Disminuir_Quality_Al_Doble_After_Actualizar_Si_Sellin_Mayor_A_Uno()
    {
        var qualityOriginal = 10;
        var sellin = 2;
        var articuloGenerico = new ArticuloGenerico("Test", sellin, qualityOriginal);
        articuloGenerico.ActualizarArticulo();
        Assert.Equal(qualityOriginal, articuloGenerico.Quality);
    }

    [Fact]
    public void ArticuloGenerico_Debe_Tener_Un_Name()
    {
        Exception exception = null;
        try
        {
            var name = "Test";
            var articuloGenerico = new ArticuloGenerico(name, 0, 0);
        }
        catch (Exception e)
        {
            exception = e;
        }
        
        Assert.Null(exception);

    }
    
    [Fact]
    public void ArticuloGenerico_Debe_Mandar_Exception_Al_No_Tener_Un_Name()
    {
        Exception exception = null;
        try
        {
            var name = "";
            var articuloGenerico = new ArticuloGenerico(name, 0, 0);
        }
        catch (Exception e)
        {
            exception = e;
        }
        
        Assert.NotNull(exception);

    }
}