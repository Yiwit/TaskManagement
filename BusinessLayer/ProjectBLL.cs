using _01_Entities;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ProjectBLL : IBusiness<Project>
    {
        UnitOfWork _uow;
        public ProjectBLL()
        {
            _uow = new UnitOfWork();
        }
         
        public bool Add(Project item)
        {
            if (!string.IsNullOrWhiteSpace(item.ProjectName) &&
                !string.IsNullOrWhiteSpace(item.ProjectDetail) &&
                item.CustomerID != null && item.ManagerID != null &&
                item.PlannedStartDate != null && item.PlannedEndDate != null)
            {
                _uow.ProjectRepository.Add(item);
                return _uow.ApplyChanges();
            }
            return false;
        }

        public bool Update(Project item)
        {
            if (!string.IsNullOrWhiteSpace(item.ProjectName) &&
                !string.IsNullOrWhiteSpace(item.ProjectDetail) &&
                item.CustomerID != null && item.ManagerID != null &&
                item.PlannedStartDate != null && item.PlannedEndDate != null)
            {
                _uow.ProjectRepository.Update(item);
                return _uow.ApplyChanges();
            }
            return false;
        }


        public bool Remove(Project item)
        {
            _uow.ProjectRepository.Remove(item);
            return _uow.ApplyChanges();
        }

        public Project Get(int id)
        {
            return _uow.ProjectRepository.Get(id);
        }

        public List<Project> GetAll()
        {
            return _uow.ProjectRepository.GetAll();
        }
        public object ProjectGetALL()
        {
            return _uow.ProjectRepository.ProjectGetAll();
        }

        public bool Add(Project project, out int projectID)
        {
            projectID = 0;
            _uow.ProjectRepository.Add(project);
            if (_uow.ApplyChanges())
            {
                projectID = _uow.ProjectRepository.GetID(project);
                return true;
            }
            return false;
        }

        public object CompanyNameSearch(int companyID)
        {
            return _uow.ProjectRepository.CompanyNameSearch(companyID);
        }

        public object DateSearch(DateTime date, bool rbtStart)
        {
            return _uow.ProjectRepository.DateSearch(date, rbtStart);
        }


    }
}
