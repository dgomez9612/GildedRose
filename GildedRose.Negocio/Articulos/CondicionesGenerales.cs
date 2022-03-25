namespace GildedRose.Negocio.Articulos
{
    public class CondicionesGenerales
    {
        private static CondicionesGenerales Instance = new();

        public static CondicionesGenerales GetInstance()
        {
            return Instance;
        }
        public CondicionesGenerales()
        {
            GetInstance();
        }

        public bool IsMaxQuality(int calidadProducto)
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

        public int AumentarQuality(int calidadProducto, int cantidadToSumar)
        {
            if (!IsMaxQuality(calidadProducto)) return calidadProducto;
            
            if ((calidadProducto + cantidadToSumar) > 50)
                return 50;
            
            return calidadProducto + cantidadToSumar;

        }

        public int DisminuirQuality(int calidadProducto, int cantidadToRestar)
        {
            if (calidadProducto < 0) return calidadProducto;
            
            if (calidadProducto - cantidadToRestar < 0) return 0;
            
            return calidadProducto - cantidadToRestar;

        }
    }
}