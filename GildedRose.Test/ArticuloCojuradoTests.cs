using GildedRose.Negocio.CatalogoArticulos;
using Xunit;

namespace GildedRose.Test;

public class ArticuloCojuradoTests
{
    [Fact]
    public void Debe_Disminuir_Quality_Al_Doble_After_Actualizar()
    {
        var qulity = 10;
        var conjurado = new ArticuloConjurado("Test", 3, qulity);

        conjurado.ActualizarArticulo();
        
        Assert.Equal((qulity-2), conjurado.Quality);
    }
}