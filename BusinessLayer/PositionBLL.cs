using _01_Entities;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class PositionBLL : IBusiness<Position>
    {
        UnitOfWork _uow;
        public PositionBLL()
        {
            _uow = new UnitOfWork();
        }

        public bool Add(Position item)
        {
            if (!string.IsNullOrWhiteSpace(item.PositionName))
            {
                _uow.PositionRepository.Add(item);
                return _uow.ApplyChanges();
            }
            return false;
        }

        public bool Update(Position item)
        {
            if (!string.IsNullOrWhiteSpace(item.PositionName))
            {
                _uow.PositionRepository.Update(item);
                return _uow.ApplyChanges();
            }
            return false;
        }

        public bool Remove(Position item)
        {
            _uow.PositionRepository.Remove(item);
            return _uow.ApplyChanges();
        }



        public Position Get(int id)
        {
            return _uow.PositionRepository.Get(id);
        }

        public List<Position> GetAll()
        {
            return _uow.PositionRepository.GetAll();
        }



    }
}
