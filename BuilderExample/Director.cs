namespace BuilderExample
{
    public class Director
    {
        public void Construct(IProductBuilder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
