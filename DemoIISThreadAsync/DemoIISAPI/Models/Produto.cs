using System.Collections.Generic;

namespace DemoIISAPI.Models
{
    public class Produto
    {
        public Produto() { }   // empty ctor required
        public Produto(int cnt)
        {
            Id = cnt;
            Name = "Produto " + cnt.ToString();
            Price = .99M + cnt;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        // Simulate a call to a back end store such as SQL Server
        public static IEnumerable<Produto> GetProducts()
        {
            for (int i = 1; i < 4; i++)
            {
                yield return new Produto(i);
            }
        }
    }
}