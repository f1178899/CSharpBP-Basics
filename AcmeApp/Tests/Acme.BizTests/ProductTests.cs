using Acme.Biz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.BizTests
{
    [TestClass()]
    public class ProductTests
    {
        [TestMethod()]
        public void SayHelloTest()
        {
            //Arrange
            var currentProduct = new Product();
            currentProduct.ProductName = "hahah";
            var expected = "Hello hahah0 Available on: ";
            //act
            var actural = currentProduct.SayHello();


            Assert.AreEqual(expected, actural);
        }

        [TestMethod()]
        public void ProductConstructorWithPrametersTest()
        {
            var currentProduct = new Product(12, "text Product", "this is a test");        
            var expected = "Hello text Product12 Available on: ";
            //act
            var actural = currentProduct.SayHello();


            Assert.AreEqual(expected, actural);
        }

        [TestMethod()]
        public void ConvertInchToMeterTest()
        {
            var expected = 24.44;
            //act
            var actural = 2 * Product.InchPerMeter;


            Assert.AreEqual(expected, actural);
        }
        [TestMethod()]
        public void ProdcutCodeTest()
        {
            var currentProduct = new Product(12, " text-Product    ", " this is a test ");
          
            var expected = "12-text-Product";
            //act
            var actural = currentProduct.ProductCode;
            Assert.AreEqual(expected, actural);
        }
    }
}