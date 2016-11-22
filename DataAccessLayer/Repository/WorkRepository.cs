using _01_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class WorkRepository : BaseRepository<Work>
    {
        TaskManagerContext _contex;
        internal WorkRepository(TaskManagerContext context)
            : base(context)
        {
            _contex = context;
        }
        public object WorkGetAll()
        {
            return _contex.Set<Work>()
                .Join(_contex.Set<Employee>(), w => w.ManagerID, e => e.ID, (w, e) => new { w, e })
             .Join(_contex.Set<Project>(), we => we.w.ProjectID, p => p.ID, (we, p) => new { we, p })
             .Join(_contex.Set<WorkStatus>(),wep=>wep.we.w.WorkStatusID, ws=>ws.ID,(wep,ws)=>new { wep,ws})
                .Select(x => new
                {
                    x.wep.we.w.ID,
                    x.wep.we.w.WorkDetail,
                    x.wep.we.w.CreationDate,
                    x.wep.p.ProjectName,
                    Manager = x.wep.we.e.FirstName + " " + x.wep.we.e.LastName,
                    Employee = _contex.Set<Work>()
                    .Join(_contex.Set<Employee>(), w => w.ManagerID, e => e.ID, (w, e) => new { w, e })
             .Join(_contex.Set<Project>(), we => we.w.ProjectID, p => p.ID, (we, p) => new { we, p })
             .Join(_contex.Set<Employee>(), wep => wep.we.w.EmployeeID, e2 => e2.ID, (wep, e2) => new { wep, e2 })
             .Where(y=>y.wep.we.w.ID==x.wep.we.w.ID && y.wep.p.ID==x.wep.p.ID)
             .Select(y =>new { FullName= y.e2.FirstName+" "+y.e2.LastName}).FirstOrDefault().FullName,
             x.wep.we.w.StartDate,
             x.wep.we.w.EndDate,
             x.ws.StatusName
                }).ToList();
        }

        public object ContinueWork(int ID, int workState)
        {
            return _contex.Set<Work>().Join(_contex.Set<Employee>(), w => w.ManagerID, e => e.ID, (w, e) => new { w, e })
             .Join(_contex.Set<Project>(), we => we.w.ProjectID, p => p.ID, (we, p) => new { we, p })
             .Join(_contex.Set<Employee>(), wep => wep.we.w.EmployeeID, e2 => e2.ID, (wep, e2) => new { wep, e2 })
             .Join(_contex.Set<WorkStatus>(), wepe => wepe.wep.we.w.WorkStatusID, ws => ws.ID, (wepe, ws) => new { wepe, ws })
             .Where(x => x.wepe.e2.ID == ID &&( x.wepe.wep.we.w.WorkStatusID == workState || x.wepe.wep.we.w.WorkStatusID == 1 || x.wepe.wep.we.w.WorkStatusID == 7) && x.wepe.wep.we.w.StartDate!=new DateTime(0001 , 01 , 01))
             .Select(x => new
             {
                 x.wepe.wep.we.w.ID,
                 x.wepe.wep.we.w.WorkDetail,
                 x.wepe.wep.we.w.CreationDate,
                 x.wepe.wep.p.ProjectName,
                 Manager = x.wepe.wep.we.e.FirstName + " " + x.wepe.wep.we.e.LastName,
                 Employee = x.wepe.e2.FirstName + " " + x.wepe.e2.LastName,
                 x.wepe.wep.we.w.StartDate,
                 x.wepe.wep.we.w.EndDate,
                 x.ws.StatusName
             }).ToList();
        }

        public List<Work> WorkControl(int ID)
        {
           return _contex.Set<Work>().Where(x => x.ProjectID == ID && x.EndDate == new DateTime(0001, 01, 01)).ToList();
        }

        public object NotStartedWork(int ID, int workState)
        {
            return _contex.Set<Work>().Join(_contex.Set<Employee>(), w => w.ManagerID, e => e.ID, (w, e) => new { w, e })
             .Join(_contex.Set<Project>(), we => we.w.ProjectID, p => p.ID, (we, p) => new { we, p })
             .Join(_contex.Set<Employee>(), wep => wep.we.w.EmployeeID, e2 => e2.ID, (wep, e2) => new { wep, e2 })
             .Join(_contex.Set<WorkStatus>(), wepe => wepe.wep.we.w.WorkStatusID, ws => ws.ID, (wepe, ws) => new { wepe, ws })
             .Where(x => x.wepe.e2.ID == ID && (x.wepe.wep.we.w.WorkStatusID == workState || x.wepe.wep.we.w.WorkStatusID==1 || x.wepe.wep.we.w.WorkStatusID==7) && x.wepe.wep.we.w.StartDate == new DateTime(0001, 01, 01))
             .Select(x => new
             {
                 x.wepe.wep.we.w.ID,
                 x.wepe.wep.we.w.WorkDetail,
                 x.wepe.wep.we.w.CreationDate,
                 x.wepe.wep.p.ProjectName,
                 Manager = x.wepe.wep.we.e.FirstName + " " + x.wepe.wep.we.e.LastName,
                 Employee = x.wepe.e2.FirstName + " " + x.wepe.e2.LastName,
                 x.wepe.wep.we.w.StartDate,
                 x.wepe.wep.we.w.EndDate,
                 x.ws.StatusName
             }).ToList();
        }





        public object EmployeeWorkGetAll(int ID, int workState)
        {
            return _contex.Set<Work>().Join(_contex.Set<Employee>(), w => w.ManagerID, e => e.ID, (w, e) => new { w, e })
             .Join(_contex.Set<Project>(), we => we.w.ProjectID, p => p.ID, (we, p) => new { we, p })
             .Join(_contex.Set<Employee>(), wep => wep.we.w.EmployeeID, e2 => e2.ID, (wep, e2) => new { wep, e2 })
             .Join(_contex.Set<WorkStatus>(), wepe => wepe.wep.we.w.WorkStatusID, ws => ws.ID, (wepe, ws) => new { wepe, ws })
             .Where(x => x.wepe.e2.ID == ID && (x.wepe.wep.we.w.WorkStatusID == workState || x.wepe.wep.we.w.WorkStatusID == 1))
             .Select(x => new
             {
                 x.wepe.wep.we.w.ID,
                 x.wepe.wep.we.w.WorkDetail,
                 x.wepe.wep.we.w.CreationDate,
                 x.wepe.wep.p.ProjectName,
                 Manager = x.wepe.wep.we.e.FirstName + " " + x.wepe.wep.we.e.LastName,
                 Employee = x.wepe.e2.FirstName + " " + x.wepe.e2.LastName,
                 x.wepe.wep.we.w.StartDate,
                 x.wepe.wep.we.w.EndDate,
                 x.ws.StatusName
             }).ToList();
        }
    }
}
