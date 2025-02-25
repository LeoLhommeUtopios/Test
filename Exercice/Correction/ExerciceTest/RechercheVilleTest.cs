using Exercice;

namespace ExerciceTest
{
    [TestClass]
    public class RechercheVilleTest
    {
        private RechercheVille _rechercheVille = new RechercheVille(new List<String>()
        {
            "Paris","Budapest","Rotterdam","Valence","Vienne","Amsterdam"
        });

        [TestMethod]
        public void WhenLess_2_Char_RaiseNotFoundException()
        {
            Assert.ThrowsException<NotFoundException>(() => _rechercheVille.Rechercher("a"));
        }

        [TestMethod]
        public void WhenGt_2_Char_Return_CitiesStartedWithChar()
        {
            List<String> result = _rechercheVille.Rechercher("Va");

            CollectionAssert.AreEqual(new List<String>() { "Valence" }, result);
        }

        [TestMethod]
        public void WhenGt_NoCaseSensitive()
        {
            List<String> result = _rechercheVille.Rechercher("vA");

            CollectionAssert.AreEqual(new List<String>() { "Valence" }, result);
        }

        [TestMethod]
        public void WhenGt_2_CharReturnCitiesContainsWithChar()
        {
            List<String> result = _rechercheVille.Rechercher("ape");
            CollectionAssert.AreEqual(new List<String>() { "Budapest" }, result);
        }

        [TestMethod]
        public void When_CharAsterisk_ReturnAllCities()
        {
            List<String> result = _rechercheVille.Rechercher("*");
            CollectionAssert.AreEqual(new List<String>() { "Paris", "Budapest", "Rotterdam", "Valence", "Vienne", "Amsterdam" }, result);
        }
    }
}
