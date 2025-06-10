using CalculadoraHistorial;

Calculadora c = new Calculadora();

bool salir = false;

while (!salir)
{
    Console.Clear();
    Console.WriteLine("===== CALCULADORA CON HISTORIAL =====");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Limpiar resultado");
    Console.WriteLine("6. Mostrar historial");
    Console.WriteLine("0. Salir");
    Console.Write("Seleccione una opción: ");

    string opcion = Console.ReadLine();
    double valor;

    switch (opcion)
    {
        case "1":
            Console.Write("Ingrese un número a sumar: ");
            if (double.TryParse(Console.ReadLine(), out valor))
                c.EjecutarOperacion(TipoOperacion.Suma, valor);
            else
                Console.WriteLine("Número inválido.");
            break;

        case "2":
            Console.Write("Ingrese un número a restar: ");
            if (double.TryParse(Console.ReadLine(), out valor))
                c.EjecutarOperacion(TipoOperacion.Resta, valor);
            else
                Console.WriteLine("Número inválido.");
            break;

        case "3":
            Console.Write("Ingrese un número a multiplicar: ");
            if (double.TryParse(Console.ReadLine(), out valor))
                c.EjecutarOperacion(TipoOperacion.Multiplicacion, valor);
            else
                Console.WriteLine("Número inválido.");
            break;

        case "4":
            Console.Write("Ingrese un número a dividir: ");
            if (double.TryParse(Console.ReadLine(), out valor))
                c.EjecutarOperacion(TipoOperacion.Division, valor);
            else
                Console.WriteLine("Número inválido.");
            break;

        case "5":
            c.EjecutarOperacion(TipoOperacion.Limpiar, 0);
            break;

        case "6":
            c.MostrarHistorial();
            Console.WriteLine("Presione una tecla para continuar...");
       
            break;

        case "0":
            salir = true;
            break;

        default:
            Console.WriteLine("Opción inválida.");
       
            break;
    }
    
    if(opcion != "6" && opcion != "0") 
    {
        Console.WriteLine("Presione una tecla para continuar...");
   
    }
}
