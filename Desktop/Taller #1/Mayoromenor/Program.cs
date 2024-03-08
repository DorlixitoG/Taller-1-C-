namespace Mayoromenor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el #1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el #2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el #3: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int mayor= Math.Max(num1,Math.Min(num2,num3));
            int menor = Math.Min(num1,Math.Min(num2,num3));

            Console.WriteLine("El número mayor: "+mayor);
            Console.WriteLine("El número menor: "+menor);
                

        }
    }
}
