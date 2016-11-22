using _01_Entities;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class RequestTypeBLL : IBusiness<RequestType>
    {
        UnitOfWork _uow;
        public RequestTypeBLL()
        {
            _uow = new UnitOfWork();
        }

        public bool Add(RequestType item)
        {
            if (!string.IsNullOrWhiteSpace(item.TypeName))
            {
                _uow.RequestTypeRepository.Add(item);
                return _uow.ApplyChanges();
            }
            return false;
        }

        public bool Update(RequestType item)
        {
            if (!string.IsNullOrWhiteSpace(item.TypeName))
            {
                _uow.RequestTypeRepository.Update(item);
                return _uow.ApplyChanges();
            }
            return false;
        }

        public bool Remove(RequestType item)
        {
            _uow.RequestTypeRepository.Remove(item);
            return _uow.ApplyChanges();
        }

        public RequestType Get(int id)
        {
            return _uow.RequestTypeRepository.Get(id);
        }

        public List<RequestType> GetAll()
        {
            return _uow.RequestTypeRepository.GetAll();
        }
    }
}
