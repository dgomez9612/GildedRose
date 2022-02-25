namespace GildedRose_00.Negocio.Articulos
{
    public class ArticulosOperacion
    {
        public int DisminuirDias(int dia)
        {
            return dia - 1;
        }

        public bool ValidateQuality(int calidadProducto)
        {
            return calidadProducto <= 50;
        }

        public bool ValidateSellInMayorTo(int dias, int diasBase)
        {
            return dias > diasBase;
        }
        public bool ValidateSellInArticuloEspeciales(int dias, int diasBase)
        {
            return dias <= diasBase;
        }

        public int AumentarQualitiy(int calidadProducto, int cantidadToSumar)
        {
            if (ValidateQuality(calidadProducto))
            {
                if ((calidadProducto + cantidadToSumar) > 50)
                    return 50;
                return calidadProducto + cantidadToSumar;
            }
            return calidadProducto;
        }
        public int DisminuirQualitiy(int calidadProducto, int cantidadToRestar)
        {
            if (calidadProducto >= 0)
            {
                if (calidadProducto - cantidadToRestar < 0) return 0;
                return   calidadProducto - cantidadToRestar;
            }
            return calidadProducto;
        }
    }
}