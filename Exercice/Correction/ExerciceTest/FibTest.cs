

using Exercice;

namespace ExerciceTest
{
    [TestClass]
    public class FibTest
    {

        private Fib _fib;

        private void SetUp(int r)
        {
            _fib = new Fib(r);
        }

        [TestMethod]
        public void WhenGetFibSeries_Range1_ThenResultIsNotEmpty()
        {
            SetUp(1);

            List<int> result = _fib.GetFibSeries();

            Assert.AreNotEqual(0, result.Count);
        }

        [TestMethod]
        public void WhenGetFibSeries_IfRange1_ThenResultContain0()
        {
            SetUp(1);
            List<int> result = _fib.GetFibSeries();

            CollectionAssert.Contains(result, 0);

     /*       var list0 = new List<int>() { 0 };
            CollectionAssert.AreEquivalent(list0, result);*/
        }

        [TestMethod]
        public void WhenGetFibSeries_IfRange6_ThenResultContains3()
        {
            SetUp(6);
            List<int> result = _fib.GetFibSeries();
            CollectionAssert.Contains(result, 3);
        }

        [TestMethod]
        public void WhenGetFibSeries_IfRange6_ThenResultContains6Elements()
        {
            SetUp(6);
            List<int> result = _fib.GetFibSeries();
            Assert.AreEqual(6,result.Count);
        }

        public void WhenGetFibSeries_IfRange6_ThenResultDoesNotContains4()
        {
            SetUp(6);
            List<int> result = _fib.GetFibSeries();
            CollectionAssert.DoesNotContain(result, 4);
        }

        public void WhenGetFibSeries_IfRange6_ThenResultContains_0_1_1_2_3_5()
        {
            SetUp(6);
            List<int> expected = new List<int>() {0,1,1,2,3,5 };
            List<int> result = _fib.GetFibSeries();
            CollectionAssert.AreEquivalent(expected,result);
        }

        public void WhenGetFibSeries_IfRange6_ThenResultIsSortedAscending()
        {
            SetUp(6);
            List<int> result = _fib.GetFibSeries();
            List<int> expected = new List<int>(result);
            expected.Sort();
            CollectionAssert.AreEquivalent(expected, result);
        }
    }
}
