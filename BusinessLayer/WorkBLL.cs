using _01_Entities;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class WorkBLL : IBusiness<Work>
    {
        UnitOfWork _uow;
        public WorkBLL()
        {
            _uow = new UnitOfWork();
        }

        public bool Add(Work item)
        {
            if ( item != null  && !string.IsNullOrWhiteSpace(item.WorkDetail))
            {
                _uow.WorkRepository.Add(item);
                return _uow.ApplyChanges();
            }
            return false;
        }

        public bool Update(Work item)
        {
            if (item.EmployeeID != null && item.ManagerID != null && item.ProjectID != null)
            {
                _uow.WorkRepository.Update(item);
                return _uow.ApplyChanges();
            }
            return false;
        }

        public bool Remove(Work item)
        {
            _uow.WorkRepository.Remove(item);
            return _uow.ApplyChanges();
        }


        public Work Get(int id)
        {
            return _uow.WorkRepository.Get(id);
        }
        public List<Work> GetAll()
        {
            return _uow.WorkRepository.GetAll();
        }
        public object WorkGetAll()
        {
            return _uow.WorkRepository.WorkGetAll();
        }

        public object EmployeeWorkList(int ID, int workState)
        {
            return _uow.WorkRepository.EmployeeWorkGetAll(ID, workState);
        }

        public object ContinueWork(int ID, int workState)
        {
            return _uow.WorkRepository.ContinueWork(ID, workState);
        }

        public object NotStartedWork(int ID, int workState)
        {
            return _uow.WorkRepository.NotStartedWork(ID, workState);
        }

        public bool WorkControl(int ID)
        {
           List<Work> work = _uow.WorkRepository.WorkControl(ID);

            if (work.Count > 0)
                return false;
            else
                return true;
        }

        public DateTime? GetEndDate(int ID)
        {
            List<Work> workList = _uow.WorkRepository.WorkControl(ID);
          Work work=  workList.OrderBy(x => x.EndDate).Take(1).FirstOrDefault();
            return work.EndDate;
        }
    }
}
