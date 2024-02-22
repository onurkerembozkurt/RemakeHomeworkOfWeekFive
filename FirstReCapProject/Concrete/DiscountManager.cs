using FirstReCapProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstReCapProject.Concrete
{
    public class DiscountManager : BusinessManager
    {
        public override void Sell(Person person)
        {
            base.Sell(person);
            if (person.DateOfBirth>1998&&person.DateOfBirth<2025)
            {
                Console.WriteLine(person.NationalId + " " + person.DateOfBirth + " " + "Discount applied ");
            }
            else
            {
                Console.WriteLine("Selled item without discount");
            }
        } 
    }
}
