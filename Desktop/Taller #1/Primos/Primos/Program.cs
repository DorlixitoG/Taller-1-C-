namespace Primos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de números primos que desea generar: ");
            int cantidad = int.Parse(Console.ReadLine());

            int contador = 0;
            int numero = 2;

            while (contador < cantidad)
            {
                bool esPrimo = true;
                for (int i = 2; i <= Math.Sqrt(numero); i++)
                {
                    if (numero % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
                if (esPrimo)
                {
                    Console.Write(numero + " ");
                    contador++;
                }
                numero++;
                
            }
        }
    }
}
