using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.NameOf
{
    public static class NameOfRun
    {

        public static void Run()
        {

            Contact c = new Contact() {
                Id = 1,
                Name = "Caio",
                Phone = "123 33213 41"
            };
            Console.WriteLine(c.ToString());
            Console.WriteLine(c.ToString2());

        }

    }
}
