using System;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;

namespace core
{
    public class Calculadora
    {
        public async Task<int> Dividir(int operador, int divisor) {
            int resultado = -1;
            try {
                await Task.Delay(TimeSpan.FromSeconds(2));
                resultado = operador / divisor;
            } catch (Exception) {
                Console.WriteLine("Fallo en Calculadora");
                throw;
            }
            return  resultado;
        }
    }
}
