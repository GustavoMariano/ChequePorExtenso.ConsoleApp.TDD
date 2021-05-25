using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChequePorExtenso.ConsoleApp.TDD;

namespace Cheques.Tests
{
    [TestClass]
    public class Testes
    {
        [TestMethod]
        public void DeveRetornarUmReal()
        {
            ValorInicial valor = new ValorInicial();
            string resultado1 = valor.ManipularValor(1.00);

            Assert.AreEqual("um real", resultado1);
        }

        [TestMethod]
        public void DeveRetornarDoisReais()
        {
            ValorInicial valor = new ValorInicial();
            string resultado1 = valor.ManipularValor(2.00);

            Assert.AreEqual("dois reais", resultado1);
        }

        [TestMethod]
        public void DeveRetornarDezReais()
        {
            ValorInicial valor = new ValorInicial();
            string resultado = valor.ManipularValor(10.00);

            Assert.AreEqual("dez reais", resultado);
        }

        [TestMethod]
        public void DeveRetornarVinteEUmReais()
        {
            ValorInicial valor = new ValorInicial();
            string resultado = valor.ManipularValor(21.00);

            Assert.AreEqual("vinte e um reais", resultado);
        }

        [TestMethod]
        public void DeveRetornarCemReais()
        {
            ValorInicial valor = new ValorInicial();
            string resultado = valor.ManipularValor(100.00);

            Assert.AreEqual("cem reais", resultado);
        }

        [TestMethod]
        public void DeveRetornarDuzentosETresReais()
        {
            ValorInicial valor = new ValorInicial();
            string resultado = valor.ManipularValor(203.00);

            Assert.AreEqual("duzentos e três reais", resultado);
        }

        [TestMethod]
        public void DeveRetornarDuzentosETresReaisECinquentaCentavos()
        {
            ValorInicial valor = new ValorInicial();
            string resultado = valor.ManipularValor(203.50);

            Assert.AreEqual("duzentos e três reais e cinquenta centavos", resultado);
        }

        [TestMethod]
        public void DeveRetornarCincoCentavosDeReal()
        {
            ValorInicial valor = new ValorInicial();
            string resultado = valor.ManipularValor(0.05);

            Assert.AreEqual("cinco centavos de real", resultado);
        }

        [TestMethod]
        public void DeveRetornarValorInvalido()
        {
            ValorInicial valor = new ValorInicial();
            string resultado = valor.ManipularValor(0.00);

            Assert.AreEqual("valor invalido", resultado);
        }

        [TestMethod]
        public void DeveRetornarUmMilReais()
        {
            ValorInicial valor = new ValorInicial();
            string resultado = valor.ManipularValor(1000.00);

            Assert.AreEqual("um mil reais", resultado);
        }

        [TestMethod]
        public void DeveRetornarDoisMilReais()
        {
            ValorInicial valor = new ValorInicial();
            string resultado = valor.ManipularValor(2000.00);

            Assert.AreEqual("dois mil reais", resultado);
        }

        [TestMethod]
        public void DeveRetornarDoisMilCentoETresReais()
        {
            ValorInicial valor = new ValorInicial();
            string resultado = valor.ManipularValor(2103.00);

            Assert.AreEqual("dois mil cento e três reais", resultado);
        }

        [TestMethod]
        public void DeveRetornarDoisMilCentoETresReaisECinquetaCentavos()
        {
            ValorInicial valor = new ValorInicial();
            string resultado = valor.ManipularValor(2103.50);

            Assert.AreEqual("dois mil cento e três reais e cinquenta centavos", resultado);
        }

        [TestMethod]
        public void DeveRetornarDozeMilCentoETresReaisECinquetaCentavos()
        {
            ValorInicial valor = new ValorInicial();
            string resultado = valor.ManipularValor(12103.50);

            Assert.AreEqual("doze mil cento e três reais e cinquenta centavos", resultado);
        }

        [TestMethod]
        public void DeveRetornarCentoEDozeMilCentoETresReaisECinquetaCentavos()
        {
            ValorInicial valor = new ValorInicial();
            string resultado = valor.ManipularValor(112103.50);

            Assert.AreEqual("cento e doze mil cento e três reais e cinquenta centavos", resultado);
        }

        [TestMethod]
        public void DeveRetornarUmMilhaoCentoEDozeMilCentoETresReaisECinquetaCentavos()
        {
            ValorInicial valor = new ValorInicial();
            string resultado = valor.ManipularValor(1112103.50);

            Assert.AreEqual("um milhão cento e doze mil cento e três reais e cinquenta centavos", resultado);
        }
    }
}
