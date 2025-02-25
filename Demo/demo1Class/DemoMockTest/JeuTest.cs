

using DemoMock;
using Moq;

namespace DemoMockTest
{
    [TestClass]
    public class JeuTest
    {

        [TestMethod]
        public void Jouer_Win()
        {
            IDe dewin = Mock.Of<IDe>();
            Mock.Get(dewin)
                .Setup(d => d.Lancer())
                .Returns(20);

            Jeu jeu = new(dewin);

            bool result = jeu.Jouer();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Jouer_Loose()
        {
            IDe DeLoose = Mock.Of<IDe>();
            Mock.Get(DeLoose)
                .Setup(d => d.Lancer())
                .Returns(19);

            Jeu jeu = new(DeLoose);

            bool result = jeu.Jouer();

            Assert.IsFalse(result);
        }
    }
}
