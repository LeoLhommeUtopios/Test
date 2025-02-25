namespace ClassLibrary1
{
    public class Class1
    {
        public double Addition (double x,double y)
        {
            return x + y;
        }

        public double Division (double x,double y)
        {
            if(y != 0)
                return x / y;
            throw new DivideByZeroException("division par 0 impossile");
        }
    }
}
