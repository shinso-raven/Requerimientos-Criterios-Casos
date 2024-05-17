using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosRomanos
{


    public class Convertidor
    {


       public string ConvertirDecimalARomano(int numeroDecimal)
        {
            // Definir los valores romanos y sus equivalentes decimales
            string[] simbolosRomanos = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] valoresDecimales = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            // Inicializar la cadena vacía para el número romano
            string numeroRomano = "";


            // Validar el rango del número decimal
            if (numeroDecimal < 0 || numeroDecimal > 3999)
            {
                string erroro = "Error: numero fuera de rango";
                Console.WriteLine(erroro);
                return erroro;
            }




            // Recorrer los valores romanos y sus equivalentes decimales
            for (int i = 0; i < simbolosRomanos.Length; i++)
            {
                // Dividir el número decimal por el valor decimal actual
                int veces = numeroDecimal / valoresDecimales[i];

                // Agregar el símbolo romano actual la cantidad de veces correspondiente
                for (int j = 0; j < veces; j++)
                {
                    numeroRomano += simbolosRomanos[i];
                    numeroDecimal -= valoresDecimales[i];
                }
            }

            // Devolver el número romano convertido
            return  numeroRomano;
        }

    }

}
