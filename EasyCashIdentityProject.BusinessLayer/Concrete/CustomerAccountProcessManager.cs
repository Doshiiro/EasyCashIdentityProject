using EasyCashIdentityProject.BusinessLayer.Abstract;
using EasyCashIdentityProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.Concrete
{
    public class CustomerAccountProcessManager : ICustomerAccountProcessService
    {
        private readonly ICustomerAccountProcessService _customerAccountProcessService;

        public CustomerAccountProcessManager(ICustomerAccountProcessService customerAccountProcessService)
        {
            _customerAccountProcessService = customerAccountProcessService;
        }

        public void TDelete(CustomerAccountProcess t)
        {
           _customerAccountProcessService.TDelete(t);
        }

        public List<CustomerAccountProcess> TGetAll()
        {
            return _customerAccountProcessService.TGetAll();    
        }

        public CustomerAccountProcess TGetById(int id)
        {
           return _customerAccountProcessService.TGetById(id);
        }

        public void TInsert(CustomerAccountProcess t)
        {
            _customerAccountProcessService.TInsert(t);
        }

        public void TUpdate(CustomerAccountProcess t)
        {
            _customerAccountProcessService.TUpdate(t);
        }
    }
}
