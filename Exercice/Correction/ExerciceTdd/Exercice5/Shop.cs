
namespace ExerciceTdd.Exercice5
{
    public class Shop
    {
  

        public void Update(Product product)
        {
            if(product.Quality <= 0)
            {
                product.Quality = 0;
            }
            else if(product.Quality >= 50) 
            {
                product.Quality = 50;
            }
            else
            {
                if(product.Type == "l")
                {
                    if(product.Name == "Brie")
                    {
                        product.Quality++;
                    }
                    else
                    {
                        if(product.Sellin == 0)
                        {
                            product.Quality -= 4;
                        }
                        else
                        {
                            product.Quality -= 2;
                        }
                    }
                }
                else
                {
                    if (product.Sellin == 0)
                        {
                        product.Quality -= 2;
                    }
                    else{
                        product.Quality -= 1;
                    }
                   
                }
            }

            if(product.Sellin >0) 
            {
                product.Sellin--;
                    }
        }
    }
}
