using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.ExpressionBodiedMembers
{
    public static class PersonRun
    {

        public static void Run()
        {

            PersonController personCont = new PersonController();
            Console.WriteLine();
           
            // Pegar todos os homens *vish*
            Console.WriteLine("Buscando todos os homens");
            var men = personCont.GetMen();
            printList<IEnumerable<Person>>(men);
            Console.WriteLine();

            // Pegar todos os menores de idade *cadeia*
            Console.WriteLine("Buscando os menores de idade");
            var minors = personCont.GetMinors();
            printList<IEnumerable<Person>>(minors);
            Console.WriteLine();

            Console.WriteLine("Buscando os homens menores de idade");
            // Pegar todos homens menores de idade
            var menMinors = personCont.GetMenMinors();
            printList<IEnumerable<Person>>(menMinors);
            Console.WriteLine();

        }

        private static void printList<T>(dynamic list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }

        
    }
}
