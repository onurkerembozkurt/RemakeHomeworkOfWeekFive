using FirstReCapProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstReCapProject.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICheckService _checkService;
        public CustomerManager(ICheckService checkService)
        {
            _checkService = checkService;
        }
        public void Add(Person entity)
        {
            _checkService.CheckIfRealPerson(entity);
            Console.WriteLine("Sisteme Eklendi"+" "+entity.FirstName);
        }

        public void Delete(Person entity)
        {

            Console.WriteLine("Sistemden Silindi"+entity.FirstName);
        }

        public void Update(Person entity)
        {
            Console.WriteLine("Sistemde Güncellendi" + entity.FirstName);
        }
    }
}
