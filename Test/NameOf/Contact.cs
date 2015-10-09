using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.NameOf
{
    public class Contact
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
    
        public Contact() : this(0, null, null) { }

        public Contact(int _id, string _name, string _phone)
        {
            this.Id = _id;
            this.Name = _name;
            this.Phone = _phone;
        }
        
        public override string ToString()
        {
            return $"Nome da propriedade de identificação = {nameof(Id)}, da propriedade nome {nameof(Name)} e da propriedade de telefone {nameof(Phone)}";
        }

        public string ToString2()
        {
            return $"Valor da propriedade {nameof(Id)} = {Id}, da propriedade {nameof(Name)} = {Name} e da propriedade de {nameof(Phone)} = {Phone}";
        }
            
    }

}
