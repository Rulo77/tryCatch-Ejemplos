using System;

namespace indexout
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arreglo = { 1, 2, 3 };

            try
            {
                int x =arreglo [ 3 ]; 
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("error  " + e.Message);
            }
            Console.ReadKey();

            
            // error al dividir entre cero
            int n1, n2;
            try
            {
                Console.WriteLine("ingresa los numeros a dividir: ");
                n1 = int.Parse(Console.ReadLine());
                n2 = int.Parse(Console.ReadLine());

                Console.WriteLine("el resultado es: " + (n1 / n2));
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("la divicion entre 0 no es valida");
            }
            Console.ReadKey();

            // para si ingresan letras en vez de un numero
            int n;
            
            try
            {
                Console.WriteLine("ingresa un numero: ");
                n = int.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("error de formato");
            }
            Console.ReadKey();
        }

    }
}
