namespace BuilderExample
{
    public class ConcreteBuilder : IProductBuilder
    {
        private Product _product = new Product();
        public void BuildPartA() { _product.PartA = "A1"; }
        public void BuildPartB() { _product.PartB = "B1"; }
        public Product GetResult() { return _product; }
    }
}
