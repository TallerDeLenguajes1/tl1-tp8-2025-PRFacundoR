namespace CalculadoraHistorial
{
    public class Calculadora
    {
        private List<Operacion> Historial { get; set; } = new();
        private double resultadoActual = 0;

        public void EjecutarOperacion(TipoOperacion tipo, double nuevoValor)
        {
            var op = new Operacion(tipo, nuevoValor, resultadoActual);
            resultadoActual = op.Resultado;
            Historial.Add(op);
        }

        public void MostrarHistorial()
        {
            foreach (var op in Historial)
            {
                Console.WriteLine($"Operación: {op.GetTipo()} | {op.ResultadoAnterior} con {op.NuevoValor} = {op.Resultado}");
            }
        }
    }

}