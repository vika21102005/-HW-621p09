namespace BuilderExample
{
    public interface IProductBuilder
    {
        void BuildPartA();
        void BuildPartB();
        Product GetResult();
    }
}
