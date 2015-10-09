using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DictionaryInitializer
{
    public class DictionaryExample
    {

        // Jeito antigo
        public Dictionary<int, string> dict { get; set; }  = new Dictionary<int, string>
            {
                {1, "Apple" },
                {2, "Microsoft" },
                {3, "IBM" }
            };

        // Outra forma
        public Dictionary<int, dynamic> dictNew = new Dictionary<int, dynamic>
        {
            [1291] = 1,
            [2] = "Microsoft",
            [3] = new DateTime()        };
    }
}
