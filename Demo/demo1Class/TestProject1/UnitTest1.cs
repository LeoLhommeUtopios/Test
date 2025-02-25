using ClassLibrary1;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1 
    {
        private Class1 _calcul;

        [TestInitialize]
        public void SetUp()
        {
            _calcul = new Class1();
        }

        [TestCleanup]
        public void TearDown()
        {
            _calcul = null;
        }

        [TestMethod]
        public void WhenAddition_10_30_Then_40()
        {
            var result = _calcul.Addition(10, 30);

            Assert.AreEqual(40, result);
        }

        [TestMethod]
        public void WhenDivision_30_10_Then_3()
        {
            //Arrange
            var calcul = new Class1();

            //Act
            double result = calcul.Division(30, 10);

            //Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void WhenDivision_1_0_Then_DIvideByZeroExecption()
        {
            Assert.ThrowsException<DivideByZeroException>(() => { _calcul.Division(1, 0); });
        }
    }
}
