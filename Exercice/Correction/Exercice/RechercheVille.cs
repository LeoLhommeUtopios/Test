
namespace Exercice
{
    public class RechercheVille
    {
        private List<String> _villes;

        public RechercheVille(List<String> viles)
        {
            _villes = viles;    
        }

        public List<String> Rechercher(String mot)
        {
            if(mot == "*")
                return _villes;
            if(mot.Length<2)
                throw new NotFoundException();
            return _villes.Where(v => v.ToLower().Contains(mot.ToLower())).ToList();
        }
    }
}
