using System;

namespace Test.AutoProperties
{
    public class ProductOld
    {

        public int Id { get; set; }
        public string Description { get; set; }

        // Só get
        public readonly decimal Price;
                
        public ProductOld() : this(0, "Produto 0", 0) { }

        public ProductOld(int _id, string _description, decimal _price)
        {
            this.Id = _id;
            this.Description = _description;
            this.Price = _price;
        }

        public override string ToString()
        {
            return String.Format("Produto com GUID: {0}; Descrição: {1}; Preço: {2}", this.Id, this.Description, this.Price);
        }

    }
}
