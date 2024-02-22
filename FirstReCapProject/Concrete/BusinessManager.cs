using FirstReCapProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstReCapProject.Concrete
{
    public abstract class BusinessManager : IBusinessService
    {
        public virtual void Sell(Person person)
        {
            Console.WriteLine(person.FirstName+" "+"satış yapıldı");
        }
    }
}
