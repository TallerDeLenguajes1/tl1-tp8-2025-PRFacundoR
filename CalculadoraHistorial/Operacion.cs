namespace CalculadoraHistorial
{
    public enum TipoOperacion
    {
        Suma = 1,
        Resta = 2,
        Multiplicacion = 3,
        Division = 4,
        Limpiar = 9
    }

    public class Operacion
    {
        private TipoOperacion operacion;
        public double NuevoValor { get; }          // Valor nuevo ingresado
        public double ResultadoAnterior { get; }   // Resultado antes de esta operación
        public double Resultado { get; private set; }

        public Operacion(TipoOperacion operacion, double nuevoValor, double resultadoAnterior)
        {
            this.operacion = operacion;
            this.NuevoValor = nuevoValor;
            this.ResultadoAnterior = resultadoAnterior;
            EjecutarOperacion(); // Se ejecuta al crear la operación
        }

        private void EjecutarOperacion()
        {
            switch (operacion)
            {
                case TipoOperacion.Suma:
                    Resultado = ResultadoAnterior + NuevoValor;
                    break;
                case TipoOperacion.Resta:
                    Resultado = ResultadoAnterior - NuevoValor;
                    break;
                case TipoOperacion.Multiplicacion:
                    Resultado = ResultadoAnterior * NuevoValor;
                    break;
                case TipoOperacion.Division:
                    if (NuevoValor != 0)
                        Resultado = ResultadoAnterior / NuevoValor;
                    else
                        Console.WriteLine("No se puede dividir por cero.");
                    break;

                    
                case TipoOperacion.Limpiar:
                    Resultado = 0;
                    break;
                default:
                    Resultado = double.NaN;
                    break;
            }
        }

        public TipoOperacion GetTipo() => operacion;
    }
}



