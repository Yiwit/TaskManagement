using _01_Entities;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class RequestBLL : IBusiness<Request>
    {
        UnitOfWork _uow;
        public RequestBLL()
        {
            _uow = new UnitOfWork();
        }

        public bool Add(Request item)
        {
            if (!string.IsNullOrWhiteSpace(item.RequestDetail) &&
                item.ProjectID != null && item.RequestTypeID != null)
            {
                _uow.RequestRepository.Add(item);
                return _uow.ApplyChanges();
            }
            return false;
        }

        public bool Update(Request item)
        {
            if (!string.IsNullOrWhiteSpace(item.RequestDetail) &&
                item.ProjectID != null && item.RequestTypeID != null)
            {
                _uow.RequestRepository.Update(item);
                return _uow.ApplyChanges();
            }
            return false;
        }

        public bool Remove(Request item)
        {
            _uow.RequestRepository.Remove(item);
            return _uow.ApplyChanges();
        }

        public Request Get(int id)
        {
            return _uow.RequestRepository.Get(id);
        }

        public List<Request> GetAll()
        {
            return _uow.RequestRepository.GetAll();
        }

        public object RequstGetAll()
        {

            return _uow.RequestRepository.RequestGetAll();
        }

        public object RequestComboBox(int request, int project)
        {
            return _uow.RequestRepository.ComboxFilter(request,project);

        }

    }
}
