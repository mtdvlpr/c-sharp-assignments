using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace LogicLayer
{
    public class CustomerService
    {
        private CustomerDAO customerDAO = new CustomerDAO();

        public List<Customer> GetAll()
        {
            return customerDAO.GetAll();
        }

        public Customer GetById(int id)
        {
            return customerDAO.GetById(id);
        }
    }
}
