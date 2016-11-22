using _01_Entities;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CustomerBLL : IBusiness<Customer>
    {
        UnitOfWork _uow;
        public CustomerBLL()
        {
            _uow = new UnitOfWork();
        }

        public bool Add(Customer item)
        {
            if (!string.IsNullOrWhiteSpace(item.CompanyName) && !string.IsNullOrWhiteSpace(item.ContactName))
            {
                _uow.CustomerRepository.Add(item);
                return _uow.ApplyChanges();
            }
            return false;
        }

        public bool Update(Customer item)
        {
            if (!string.IsNullOrWhiteSpace(item.CompanyName) && !string.IsNullOrWhiteSpace(item.ContactName))
            {
                _uow.CustomerRepository.Update(item);
                return _uow.ApplyChanges();
            }
            return false;
        }


        public bool Remove(Customer item)
        {
            _uow.CustomerRepository.Remove(item);
            return _uow.ApplyChanges();
        }



        public Customer Get(int id)
        {
            return _uow.CustomerRepository.Get(id);
        }

        public List<Customer> WorkGetAll()
        {
            return _uow.CustomerRepository.GetAll();
        }

        public object ProjectFilter(int companyName)
        {
            return _uow.CustomerRepository.ProjectFilter(companyName);
        }

        public List<Customer> GetAll()
        {
            return _uow.CustomerRepository.GetAll();
        }
    }
}
