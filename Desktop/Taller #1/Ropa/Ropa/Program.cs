namespace Ropa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A cuantos empleados quieres realizar el cálculo?: ");
            int numempleado= Convert.ToInt32(Console.ReadLine());
            double totalSueldosNetos = 0;
            double totalDescuentosRenta = 0;
            double totalDescuentosAFP = 0;
            double totalDescuentosSeguroSocial = 0;
            for (int i = 0; i < numempleado; i++)
            {
                Console.WriteLine("Ingresa el sueldo del empleado: ");
                double sueldo = Convert.ToDouble(Console.ReadLine());

                double descRenta = sueldo * 0.1;
                double descConfia = sueldo * 0.05;
                double descSeguro= sueldo * 0.04;
                double sueldoNeto = sueldo - (descRenta + descConfia + descSeguro);

                totalSueldosNetos += sueldoNeto;
                totalDescuentosRenta += descRenta;
                totalDescuentosAFP += descConfia;
                totalDescuentosSeguroSocial += descSeguro;

                Console.WriteLine("Empleado #"+(i+1));
                Console.WriteLine("El descuento por Renta es de: "+descRenta);
                Console.WriteLine("El decuento de Confia es de: "+descConfia);
                Console.WriteLine("El descuento del seguro social es de1: "+descSeguro);
                Console.WriteLine("Sueldo Neto: "+ sueldoNeto);


            }
            Console.WriteLine($"Total a pagar en sueldos netos: {totalSueldosNetos}");
            Console.WriteLine($"Total retenido por renta: {totalDescuentosRenta}");
            Console.WriteLine($"Total retenido por AFP Confía: {totalDescuentosAFP}");
            Console.WriteLine($"Total retenido por Seguro Social: {totalDescuentosSeguroSocial}");

        }
    }
}
 