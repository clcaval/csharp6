using System;

namespace Test.AutoProperties
{
    public class Product
    {

        public int Id { get; } = 0;
        public string Description { get; set; } = "Produto 0";

        // Get apenas
        public decimal Price { get; set; } = 100;

        // Set privado
        public int Qty { get; private set; } = 1000;
            
        public override string ToString()
        {
                return $"{this.Description} tem ID igual a {Id}, custa {Price} {(Price > 1 ? "reais" : "real")}, e temos {this.Qty} em estoque";
        }
        
    }
}
