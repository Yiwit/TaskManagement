using _01_Entities;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class WorkStatusBLL : IBusiness<WorkStatus>
    {
        UnitOfWork _uow;
        public WorkStatusBLL()
        {
            _uow = new UnitOfWork();
        }

        public bool Add(WorkStatus item)
        {
            if (!string.IsNullOrWhiteSpace(item.StatusName))
            {
                _uow.WorkStatusRepository.Add(item);
                return _uow.ApplyChanges();
            }
            return false;
        }

        public bool Update(WorkStatus item)
        {
            if (!string.IsNullOrWhiteSpace(item.StatusName))
            {
                _uow.WorkStatusRepository.Update(item);
                return _uow.ApplyChanges();
            }
            return false;
        }


        public bool Remove(WorkStatus item)
        {
            _uow.WorkStatusRepository.Remove(item);
            return _uow.ApplyChanges();
        }


        public WorkStatus Get(int id)
        {
            return _uow.WorkStatusRepository.Get(id);
        }

        public List<WorkStatus> GetAll()
        {
            return _uow.WorkStatusRepository.GetAll();
        }
    }
}
