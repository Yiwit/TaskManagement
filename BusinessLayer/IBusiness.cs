using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
  interface   IBusiness<T>
    {
        bool Add(T item);
        bool Remove(T item);
        bool Update(T item);

        T Get(int id);
        List<T> GetAll();
    }
}
