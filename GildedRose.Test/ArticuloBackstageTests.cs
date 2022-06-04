using GildedRose.Negocio.CatalogoArticulos;
using Xunit;

namespace GildedRose.Test;

public class ArticuloBackstageTests
{
    [Fact]
    public void Backstage_TenDays_To_Concert_Quality_Increment_Two()
    {
        var sellIn = 10;
        var backstage = new ArticuloBackstage("Tests", 11, sellIn);

        backstage.ActualizarArticulo();

        Assert.Equal(10, backstage.SellIn);

        Assert.Equal(2, backstage.Quality);
    }

    [Fact]
    public void Backstage_FiveDays_To_Concert_Quality_Increment_Three()
    {
        var sellIn = 5;
        var backstage = new ArticuloBackstage("Tests", 6, sellIn);

        backstage.ActualizarArticulo();

        Assert.Equal(5, backstage.SellIn);

        Assert.Equal(3, backstage.Quality);
    }

    [Fact]
    public void Backstage_After__Date_Sale_Quality_Equal_Zero()
    {
        var sellIn = 0;
        var quality = 0;
        var backstage = new ArticuloBackstage("Tests", 0, sellIn);

        backstage.ActualizarArticulo();

        Assert.Equal(quality = 0, backstage.Quality);

    }
}
