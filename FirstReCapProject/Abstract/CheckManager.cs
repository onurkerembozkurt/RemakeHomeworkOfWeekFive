using FirstReCapProject.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstReCapProject.Abstract
{
    public class CheckManager : ICheckService
    {
        bool _checkService=true;
      
        public bool CheckIfRealPerson(Person person)
        {
            if (_checkService==true)
            {
                Console.WriteLine(person.FirstName + " " + person.LastName + " " + person.NationalId + " " + person.DateOfBirth + " " + person.NationalId);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
