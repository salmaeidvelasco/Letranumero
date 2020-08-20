using Letranumero.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLetraanumero
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNumeroaLetra()
        {
            //Arrange
            LiteralController literalController = new LiteralController(); //ctrl+. para poner libreria si est� en rojo. Con mayuscula es la clase y cin minuscula el objeto
            int numero = 5;
            string esperado = "CINCO PESOS 00 /100"; // Aqu� tiene que ser igual a lo que escrib� en Conversores 

            //Act
           string resultado = literalController.LiteralGet(numero); //Lo que hay en mi Get, porque LiteralController ya hereda de Conversores.


            //Assert
            Assert.AreEqual(esperado, resultado);
        }
    }
}
