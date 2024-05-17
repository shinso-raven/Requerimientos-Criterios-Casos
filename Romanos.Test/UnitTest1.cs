using NumerosRomanos;

namespace Romanos.Test
{
    public class Tests
    {

        /*
        **CP1**

- Entrada 4
- Accion: Convertidor.ConvertirDecimalRomano(int numDecimal): string
- Resultado: "IV"

CP2:

- Entrada: 6
- Accion: Convertidor.ConvertirDecimalRomano(int numDecimal): string
- Resultado: "VI"

CP3:

- Entrada: 500
- Accion: Convertidor.ConvertirDecimalRomano(int numDecimal): string
- Resultado: "D"
        CP5:
 
- Entrada: -10
- Accion: Convertidor.ConvertirDecimalRomano(int numDecimal): string
- Resultado: "Error: numero fuera de rango"

CP6:
 
- Entrada: 45
- Accion: Convertidor.ConvertirDecimalRomano(int numDecimal): string
- Resultado: "XLV"
         */



        [SetUp]
        public void Setup()
        {
        }

        [TestCase(4, "IV")]
        [TestCase(6, "VI")]
        [TestCase(500, "D")]
        [TestCase(-10, "Error: numero fuera de rango")]
        [TestCase(45, "XLV")]
        public void Test1(int entrada, string salida)
        {


            Convertidor convertidor = new Convertidor();
            string resultado = convertidor.ConvertirDecimalARomano(entrada);


            Assert.That(resultado, Is.EqualTo(salida));
        }
    }
}