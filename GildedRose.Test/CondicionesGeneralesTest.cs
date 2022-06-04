using GildedRose.Negocio.Articulos;
using Xunit;

namespace GildedRose.Test;

public class CondicionesGeneralesTest
{
    private CondicionesGenerales CondicionesGenerales => CondicionesGenerales.GetInstance();

    [Fact]
    public void Quality_No_Debe_de_ser_Mayor_a_50()
    {
        var quality = 51;
        var IsMaxQuality = CondicionesGenerales.IsMaxQuality(quality);
        Assert.False(IsMaxQuality);
    }

    [Fact]
    public void Quality_Maxima_Debe_ser_de_50()
    {
        var quality = 50;
        var IsMaxQuality = CondicionesGenerales.IsMaxQuality(quality);
        Assert.True(IsMaxQuality);
    }

    [Fact]
    public void Al_Aumentar_Quality_No_Debe_Superar_el_maximo_de_50()
    {
        var quality = CondicionesGenerales.AumentarQuality(49, 2);
        Assert.Equal(50, quality);
    }

    [Fact]
    public void Al_Disminuir_Quality_No_Debe_Ser_Menor_A_Cero()
    {
        var quality = CondicionesGenerales.DisminuirQuality(0, 1);
        Assert.True((quality >= 0));
    }
}