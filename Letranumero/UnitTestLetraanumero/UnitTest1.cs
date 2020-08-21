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
            LiteralController literalController = new LiteralController(); //ctrl+. para poner libreria si está en rojo. Con mayuscula es la clase y cin minuscula el objeto
            int numero = 5;
            string esperado = "CINCO"; // Aquí tiene que ser igual a lo que escribí en Conversores 

            //Act
            string resultado = literalController.LiteralGet(numero); //Lo que hay en mi Get, porque LiteralController ya hereda de Conversores.

           
            //Assert
            Assert.AreEqual(esperado, resultado);
        }
        //Segundo UnitTest con Post
        [TestMethod]
        public void TestNumeroaLetra2()
        {
            //Arrange
            LiteralController literalController = new LiteralController(); 
        int numero = 8;
        string esperado = "OCHO"; 

        //Act
        string resultado = literalController.LiteralPost(numero); 


        //Assert
        Assert.AreEqual(esperado, resultado);
        }

}
}
