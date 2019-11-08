using Microsoft.VisualStudio.TestTools.UnitTesting;
using core;
using System;

namespace test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDividirPorCero()
        {
            Calculadora calcu = new Calculadora();
            //Assert.ThrowsExceptionAsync<DivideByZeroException>(() => calcu.Dividir(10,0));
            Assert.ThrowsException<AggregateException>(() => calcu.Dividir(10,0).Result);
        }
    }
}
