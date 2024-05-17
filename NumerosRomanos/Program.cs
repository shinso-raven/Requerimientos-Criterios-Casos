
namespace NumerosRomanos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar el número decimal al usuario
            Console.WriteLine("Ingrese un número decimal (entre 0 y 3999):");
            int numeroDecimal = int.Parse(Console.ReadLine());


            // Convertir el número decimal a romano


            Convertidor convertidor = new Convertidor();

            string numeroRomano = convertidor.ConvertirDecimalARomano(numeroDecimal);

            if (!numeroRomano.Contains("Error"))
            {
            // Mostrar el resultado
            Console.WriteLine("El número romano equivalente es: " + numeroRomano);

            }

        }


       
    }
} 