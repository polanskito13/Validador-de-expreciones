using System;
using ValidadorExpresiones.Services;

namespace ValidadorExpresiones
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("🔎 Validador de Expresiones");
            var validador = new ValidadorService();

            while (true)
            {
                Console.Write("\nEscribe una expresión (o escribe 'salir'): ");
                string entrada = Console.ReadLine();
                if (entrada.ToLower() == "salir") break;

                var resultado = validador.Validar(entrada);
                Console.WriteLine(resultado.Mensaje);
            }

            Console.WriteLine("\n👋 ¡Gracias por usar el validador!");
        }
    }
}
