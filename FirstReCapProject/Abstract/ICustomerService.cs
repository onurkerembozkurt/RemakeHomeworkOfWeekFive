using FirstReCapProject.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstReCapProject.Abstract
{
    public interface ICustomerService
    {
        void Add(Person entity);
        void Update(Person entity);
        void Delete(Person entity);

    }
}
