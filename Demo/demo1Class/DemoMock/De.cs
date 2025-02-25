

namespace DemoMock
{
    public class De : IDe
    {
        private Random random = new Random();

        public int Lancer()
        {
            return random.Next(1, 21);
        }
    }
}
