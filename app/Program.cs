using System;
using core;

namespace throwapp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int operador = 1;
            int divisor = 0;

            try {
                Calculadora calcu = new Calculadora();
                int resultado = calcu.Dividir(operador, divisor).Result;
                //int resultado = operador / divisor;
                Console.WriteLine($"El resultado de dividir {operador} por {divisor} es {resultado}");
            } catch (AggregateException ae) {
                foreach (var e in ae.InnerExceptions) {
                    // Handle the custom exception.
                    if (e is DivideByZeroException) {
                        Console.WriteLine("Fallo por division por cero");
                    }
                    // Rethrow any other exception.
                    else {
                        throw;
                    }
                }                
            } catch (Exception ex) {
                Console.WriteLine("Fallo por algo");    
            }
            Console.WriteLine("Fin");
        }
    }
}
