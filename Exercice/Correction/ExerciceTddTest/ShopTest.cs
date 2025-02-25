using ExerciceTdd.Exercice5;

namespace ExerciceTddTest
{
    [TestClass]
    public class ShopTest
    {
        private Shop _shop = new Shop();

        [TestMethod]
        public void Update_Desc_Sellin_Simple()
        {
            Product product = new Product()
            {
                Type = "s",
                Sellin = 10,
                Quality = 10,
                Name = "name",
            };

            _shop.Update(product);

            Assert.AreEqual(9, product.Sellin);
        }

        [TestMethod]
        public void Update_Desc_Sellin_0()
        {
            Product product = new Product()
            {
                Type = "s",
                Sellin = 0,
                Quality = 10,
                Name = "name",
            };

            _shop.Update(product);

            Assert.AreEqual(0,product.Sellin);
        }

        [TestMethod]
        public void Update_Desc_Qulity_simple()
        {
            Product product = new Product()
            {
                Type = "s",
                Sellin =10,
                Quality = 10,
                Name = "name",
            };

            _shop.Update(product);

            Assert.AreEqual(9, product.Quality);
        }

        [TestMethod]
        public void Update_Desc_Quality_Simple_Product_Sellin_0()
        {
            Product product = new Product()
            {
                Type = "s",
                Sellin = 0,
                Quality = 10,
                Name = "name",
            };

            _shop.Update(product);

            Assert.AreEqual(8, product.Quality);
        }

        [TestMethod]
        public void Update_Desc_QUality_Lai_Product_Not_Brie()
        {
            Product product = new Product()
            {
                Type = "l",
                Sellin = 10,
                Quality = 10,
                Name = "name",
            };

            _shop.Update(product);

            Assert.AreEqual(8, product.Quality);
        }

        [TestMethod]
        public void Update_Desc_Quality_0_NotBrie()
        {
            Product product = new Product()
            {
                Type = "s",
                Sellin = 10,
                Quality = -1,
                Name = "name",
            };

            _shop.Update(product);

            Assert.AreEqual(0, product.Quality);
        }

        [TestMethod]
        public void Update_Asc_Quality_50()
        {
            Product product = new Product()
            {
                Type = "s",
                Sellin = 10,
                Quality = 52,
                Name = "name",
            };

            _shop.Update(product);

            Assert.AreEqual(50, product.Quality);
        }

        [TestMethod]
        public void update_Quality_Brie()
        {
            Product product = new Product()
            {
                Type = "l",
                Sellin = 10,
                Quality = 10,
                Name = "Brie",
            };

            _shop.Update(product);

            Assert.AreEqual(11, product.Quality);
        }
    }
}
