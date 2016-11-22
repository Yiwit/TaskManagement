using _01_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class RequestRepository : BaseRepository<Request>
    {
        TaskManagerContext _context;
        internal RequestRepository(TaskManagerContext context)
            : base(context)
        {
            _context = context;
        }

        public object RequestGetAll()
        {
            //var query = (from req in _context.Set<Request>()
            //             join project in _context.Set<Project>()
            //             on req.ProjectID equals project.ID
            //             join emp in _context.Set<Employee>()
            //             on req.EmployeeID equals emp.ID
            //             join requesttype in _context.Set<RequestType>()
            //             on req.RequestTypeID equals requesttype.ID
            //             select new
            //             {
            //                 req.ID,
            //                 req.RequestDetail,
            //                 project.ProjectName,
            //                 TalepEden = emp.FirstName + " " + emp.LastName,
            //                 requesttype.TypeName,


            //             }
            //                 ).ToList();
            //                 return query;

            return _context.Set<Request>().Join(_context.Set<Project>(),r => r.ProjectID, p=> p.ID,(r,p)=> new {r,p})
                .Join(_context.Set<Employee>(),pr => pr.p.ManagerID, e=>e.ID,(pr,e)=> new {pr,e}).Join(_context.Set<RequestType>(),pre=> pre.pr.r.RequestTypeID,re=> re.ID,(pre,re)=> new {pre,re})
                .Where(x=>x.pre.pr.r.State==true)
                .Select(x=> new
            {
            ID = x.pre.pr.r.ID,
            TalepDetayı =  x.pre.pr.r.RequestDetail,
            ProjeIsmi =  x.pre.pr.p.ProjectName,
            TalepEden = x.pre.e.FirstName + " " + x.pre.e.LastName,
            TalepTürü =  x.re.TypeName
            }).ToList();

        }

        public object ComboxFilter(int request,int project)
        {


            var query = (from requestyp in _context.Set<RequestType>()
                         join requestt in _context.Set<Request>() on requestyp.ID equals requestt.RequestTypeID
                         join projectt in _context.Set<Project>() on requestt.ProjectID equals projectt.ID

                         where
                      (

                         requestyp.ID == request && projectt.ID == project
                      )
                         select new
                         {
                             requestt.ID,
                             requestt.RequestDetail,
                             projectt.ProjectName,
                             TalepEden = requestt.Employee.FirstName + " " + requestt.Employee.LastName,
                             requestyp.TypeName



                         }).ToList();
            return query;

        }

    }
}
