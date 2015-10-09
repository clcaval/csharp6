using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.ExceptionFilters
{
    public class ExceptionFilter
    {

        public int Privilege { get; set; } = 42;

        public void RunErro()
        {

            try
            {
                string s = null;
                var q = s[1];

            }
            catch (NullReferenceException) when (Privilege == 42)
            {
                // faz nada porque sou tenho todos privilégios :D
            }
            catch (NullReferenceException ex)
            {
                throw new Exception("Null reference + não tem os privilégios tudo", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro genérico ou algo assim", ex);
            }
            

        }

    }
}
