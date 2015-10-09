using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.StringInterpolation
{
    public class Square
    {

        public double Side { get; set; } = 2.25645;

        public string GetArea() => $"Area = {Side * Side}";

        public string GetSide() => $"Side = {Side:0.00}";

        
        
    }
}
