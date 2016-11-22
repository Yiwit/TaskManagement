using _01_Entities;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class EmployeeBLL : IBusiness<Employee>
    {
        UnitOfWork _uow;
        public EmployeeBLL()
        {
            _uow = new UnitOfWork();
        }

        public bool Add(Employee item)
        {
            if (!string.IsNullOrWhiteSpace(item.FirstName) &&
                !string.IsNullOrWhiteSpace(item.LastName) &&
                !string.IsNullOrWhiteSpace(item.Password) &&
                !string.IsNullOrWhiteSpace(item.EMail) &&
                item.PositionID >0)
            {
                _uow.EmployeeRepository.Add(item);
                return _uow.ApplyChanges();
            }
            return false;
        }

        public Employee Get(string mail, string password)
        {
            if (!string.IsNullOrWhiteSpace(mail) && !string.IsNullOrWhiteSpace(password))
            {
                return _uow.EmployeeRepository.Get(mail, password);
            }
            return null;
        }
        

        public object EmployeePositionGetAll(int projectID)
        {
            return _uow.EmployeeRepository.EmployeePositionGetAll(projectID);
        }

        public bool Update(Employee item)
        {
            if (!string.IsNullOrWhiteSpace(item.FirstName) &&
                !string.IsNullOrWhiteSpace(item.LastName) &&
                !string.IsNullOrWhiteSpace(item.Password) &&
                !string.IsNullOrWhiteSpace(item.EMail) &&
                item.PositionID > 0)
            {
                _uow.EmployeeRepository.Update(item);
                return _uow.ApplyChanges();
            }
            return false;
        }

        public bool Remove(Employee item)
        {
            _uow.EmployeeRepository.Remove(item);
            return _uow.ApplyChanges();
        }



        public Employee Get(int id)
        {
            return _uow.EmployeeRepository.Get(id);
        }

        public List<Employee> GetAll()
        {
            return _uow.EmployeeRepository.GetAll();
        }

        public object EmployeeGetAll()
        {
            return _uow.EmployeeRepository.EmployeeGetAll();
        }

        public object ButtonFilter(string firstName, int position)
        {
            return _uow.EmployeeRepository.ButtonFilter(firstName, position);
        }

        public object ComboBoxFilter(string firstName, int position)
        {

            return _uow.EmployeeRepository.ComboBoxFilter(firstName, position);
        }

        public List<Employee> ProjectEmployeeGet(int ID)
        {
            return _uow.ProjectEmployeeGet(ID);
        }
    }
}
