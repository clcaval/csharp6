using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.ExpressionBodiedMembers;

namespace Test.NullConditional
{
    public class Account
    {

        public Guid Id { get; set; }
        public string Login { get; set; }
        private IEnumerable<Address> Address { get; set; } //= new List<Address>();

        public Account() : this(null) { }

        public Account(IEnumerable<Address> _address)
        {
            this.Address = _address;
        }

        // Exemplo (jeito antigo)
        public int GetAddressCountOldWay()
        {
            if (this.Address != null)
                return Address.Count();
            else
                return 0;
        }

        // Exemplo 2 (jeito antigo)
        public int GetAddressCountOldWay2()
        {
            return Address == null ? 0 : Address.Count();
        }
        
        // Exemplo 1
        public int? GetAddressCount() => Address?.Count();


        // Exemplo 2
        public int GetAddressCount2() => Address?.Count() ?? 0;

        // null se não existir 
        public Address GetFirstAddress(int i) => Address?.ToList()[i];
        


    }
}
