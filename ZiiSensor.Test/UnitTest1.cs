using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZiiSensor.Test.TemperaturaServiceTest;

namespace ZiiSensor.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            TemperaturaServicoClient client = new TemperaturaServicoClient();
            var retorno = client.ObterTodos();
        }
    }
}
