using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using CoffeeShop.cs.Repository;
using CoffeeShop.cs.Model;

namespace CoffeeShop.cs.BLL
{
    public class CustomerManager
    {
        CustomerRepository _customerRepository = new CustomerRepository();

        public bool Addcustomer(CustomerModel customerModel)
        {
           return _customerRepository.Addcustomer(customerModel);
        }

        public bool Exitname(CustomerModel customerModel)
        {
            return _customerRepository.Exitname(customerModel);

        }
        public bool Deletecustomer(CustomerModel customerModel)
        {
            return _customerRepository.Deletecustomer(customerModel);

        }
       public bool Modificustomer(CustomerModel customerModel)

        {
            return _customerRepository.Modificustomer(customerModel);
        }
        public DataTable Showcustomer()
        {
            return _customerRepository.Showcustomer();
        }
        public DataTable Searchcustomer(CustomerModel customerModel)
        {
            return _customerRepository.Searchcustomer(customerModel);
        }
        public DataTable NameComboBox()
        {
           return _customerRepository.NameComboBox();
        }
    }
}
