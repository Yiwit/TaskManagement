using _01_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class CustomerRepository : BaseRepository<Customer>
    {
        TaskManagerContext _context;

        internal CustomerRepository(TaskManagerContext context)
            : base(context)
        {
            _context = context;
        }

        public object ProjectFilter(int companyName)
        {
            return _context.Set<Customer>().Where(x => x.ID == companyName).Select(x => new { x.ID, x.CompanyName, x.ContactName, x.CustomerEmail }).ToList();

            //var query = (
            //            from cus in _context.Set<Customer>()
            //            where
            //            (
            //                cus.ID == companyName
            //            )
            //            select new
            //            {
            //                cus.ID,
            //                cus.CompanyName,
            //                cus.ContactName,
            //                cus.CustomerEmail
            //            }).ToList();
            //return query;
        }
    }
}
