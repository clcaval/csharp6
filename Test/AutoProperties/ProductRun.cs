using System;

namespace Test.AutoProperties
{
    public static class ProductRun
    {

        public static void TestAutoPropertiesProductOld()
        {

            // 4.5 Inicialização padrão
            ProductOld prodOld = new ProductOld();
            Console.WriteLine(prodOld.ToString());

            // Inicialização por construtor, passando parâmetros
            prodOld = new ProductOld(1, "Produto 1", 120);
            Console.WriteLine(prodOld.ToString());

            // Inicialização acessando os atributos da classe
            prodOld = new ProductOld();
            prodOld.Id = 2;
            prodOld.Description = "Produto 2";
            //prodOld.Price = 1200;
            Console.WriteLine(prodOld.ToString());

            // Inicialização passando parâmetro (sem construtor)
            prodOld = new ProductOld()
            {
                Id = 3,
                Description = "Produto 3"
            };
            Console.WriteLine(prodOld.ToString());

            // Onliner
            prodOld = new ProductOld() { Id = 4, Description = "Produto 4" };
            Console.WriteLine(prodOld.ToString());

        }

        public static void TestAutoPropertiesProduct()
        {

            // 4.5 Inicialização padrão
            Product prod = new Product();
            Console.WriteLine(prod.ToString());

            // Inicialização acessando os atributos da classe
            prod = new Product();
            prod.Description = "Produto 2";
            prod.Price = 200;
            //prod.Qty = 500;
            Console.WriteLine(prod.ToString());

            prod = new Product();
            prod.Description = "Produto 3";
            prod.Price = 1;
            //prod.Qty = 500;
            Console.WriteLine(prod.ToString());
            

        }

    }
}
