

namespace DemoMock
{
    public class Jeu
    {
        private IDe _de;

        public Jeu(IDe de) 
        {
            _de= de;
        }

        public bool Jouer()
        {
            return _de.Lancer() ==  20;
        }
    }
}
