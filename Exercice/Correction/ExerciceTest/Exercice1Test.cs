using Exercice;

namespace ExerciceTest
{
    [TestClass]
    public class Exercice1Test
    {
        private Exercice1 _gradingCalculator;

        private void SetUp(int score, int attendancePercentage)
        {
            _gradingCalculator = new Exercice1()
            {
                Score = score,
                AttendancePercentage = attendancePercentage
            };
        }

  /*      [TestMethod]
        public void WhenGrade_95_90_Then_A()
        {
            SetUp(95, 90);

            char c = _gradingCalculator.GetGrade();

            Assert.AreEqual('A', c);
        }

        [TestMethod]
        public void WhenGrade_85_90_Then_B()
        {
            SetUp(85, 90);

            char c = _gradingCalculator.GetGrade();

            Assert.AreEqual('B', c);
        }

        [TestMethod]
        public void WhenGrade_65_90_Then_C()
        {
            SetUp(65, 90);

            char c = _gradingCalculator.GetGrade();

            Assert.AreEqual('C', c);
        }

        [TestMethod]
        public void WhenGrade_95_65_Then_B()
        {
            SetUp(95, 65);

            char c = _gradingCalculator.GetGrade();

            Assert.AreEqual('B', c);
        }

        [TestMethod]
        public void WhenGrade_95_55_Then_F()
        {
            SetUp(95,55);

            char c = _gradingCalculator.GetGrade();

            Assert.AreEqual('F', c);
        }

        [TestMethod]
        public void WhenGrade_65_55_Then_F()
        {
            SetUp(65, 55);

            char c = _gradingCalculator.GetGrade();

            Assert.AreEqual('F', c);
        }

        [TestMethod]
        public void WhenGrade_50_90_Then_F()
        {
            SetUp(50, 90);

            char c = _gradingCalculator.GetGrade();

            Assert.AreEqual('F', c);
        }*/

        [DataTestMethod]
        [DataRow(95,90,'A')]
        [DataRow(85, 90, 'B')]
        [DataRow(65, 90, 'C')]
        [DataRow(95, 65, 'B')]
        [DataRow(95, 55, 'F')]
        [DataRow(65, 55, 'F')]
        [DataRow(50, 90, 'F')]
        public void WhenGetGrade(int pct, int pres, char note)
        {
            SetUp(pct, pres);
            char c = _gradingCalculator.GetGrade();
            Assert.AreEqual(note, c);
        }
    }
}
