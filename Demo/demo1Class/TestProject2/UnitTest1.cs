using ClassLibrary1;

namespace TestProject2
{
    [TestFixture]
    public class Tests
    {
        private Class1? _calcul;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _calcul = new Class1();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            _calcul = null;
        }

        [Test]
        public void WhenDivision_30_10_Then_3()
        {
            double result = _calcul.Division(30, 10);

            Assert.That(result, Is.EqualTo(3));
        }
    }
}
