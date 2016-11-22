using _01_Entities;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ProjectEmployeeBLL : IBusiness<ProjectEmployee>
    {
        UnitOfWork _uow;
        public ProjectEmployeeBLL()
        {
            _uow = new UnitOfWork();
        }

        public bool Add(ProjectEmployee item)
        {
            if (item.EmployeeID != null && item.ProjectID != null)
            {
                _uow.ProjectEmployeeRepository.Add(item);
                return _uow.ApplyChanges();
            }
            return false;
        }


        public bool Update(ProjectEmployee item)
        {
            if (item.EmployeeID != null && item.ProjectID != null)
            {
                _uow.ProjectEmployeeRepository.Update(item);
                return _uow.ApplyChanges();
            }
            return false;
        }

        public bool Remove(ProjectEmployee item)
        {
            _uow.ProjectEmployeeRepository.Remove(item);
            return _uow.ApplyChanges();
        }

        public ProjectEmployee Get(int id)
        {
            return _uow.ProjectEmployeeRepository.Get(id);
        }

        public List<ProjectEmployee> GetAll()
        {
            return _uow.ProjectEmployeeRepository.GetAll();
        }


    }
}
