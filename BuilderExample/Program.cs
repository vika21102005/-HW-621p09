using System;
using System.IO;

namespace BuilderExample
{
    class Program
    {
        static void Main()
        {
            var director = new Director();
            var builder = new ConcreteBuilder();
            director.Construct(builder);
            var product = builder.GetResult();
            Console.WriteLine($"Parts: {product.PartA}, {product.PartB}");
        }
    }
}
