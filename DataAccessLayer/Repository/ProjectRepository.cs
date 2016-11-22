using _01_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class ProjectRepository : BaseRepository<Project>
    {
        TaskManagerContext _contex;
        internal ProjectRepository(TaskManagerContext context)
            : base(context)
        {
            _contex = context;
        }
        public object ProjectGetAll()
        {
            //var query = (from p in _contex.Set<Project>()
            //             join c in _contex.Set<Customer>()
            //             on p.CustomerID equals c.ID
            //             join m in _contex.Set<Employee>()
            //             on p.ManagerID equals m.ID
            //             select new
            //             {
            //                 p.ID,
            //                 p.ProjectName,
            //                 p.ProjectDetail,
            //                 c.CompanyName,
            //                 c.ContactName,
            //                 c.CustomerEmail,
            //                 FullName = m.FirstName + " " + m.LastName,
            //                 p.PlannedStartDate,
            //                 p.PlannedEndDate,
            //                 p.StartDate,
            //                 p.EndDate
            //             }).ToList();
            //return query;

            return _contex.Set<Project>().Join(_contex.Set<Customer>(), p => p.CustomerID, c => c.ID, (p, c) => new { p, c }).Join(_contex.Set<Employee>(), pc => pc.p.ManagerID, e => e.ID, (pc, e) => new { pc, e }).Select(x => new { x.pc.p.ID, x.pc.p.ProjectName, x.pc.p.ProjectDetail, x.pc.c.CompanyName, x.pc.c.ContactName, x.pc.c.CustomerEmail, FullName = x.e.FirstName + " " + x.e.LastName, x.pc.p.PlannedStartDate, x.pc.p.PlannedEndDate, x.pc.p.StartDate, x.pc.p.EndDate }).ToList();



        }

        public object CompanyNameSearch(int companyID)
        {
            return _contex.Set<Project>()
                .Join(_contex.Set<Customer>(), p => p.CustomerID, c => c.ID, (p, c) => new { p, c })
                .Join(_contex.Set<Employee>(), pc => pc.p.ManagerID, e => e.ID, (pc, e) => new { pc, e })
                .Where(x => x.pc.c.ID == companyID)
                .Select(x => new
                {
                    x.pc.p.ID,
                    x.pc.p.ProjectName,
                    x.pc.p.ProjectDetail,
                    x.pc.c.CompanyName,
                    x.pc.c.ContactName,
                    x.pc.c.CustomerEmail,
                    FullName = x.e.FirstName + " " + x.e.LastName,
                    x.pc.p.PlannedStartDate,
                    x.pc.p.PlannedEndDate,
                    x.pc.p.StartDate,
                    x.pc.p.EndDate
                }).ToList();

            //var query = (from pro in _contex.Set<Project>()
            //             join cus in _contex.Set<Customer>() on pro.CustomerID equals cus.ID
            //             join emp in _contex.Set<Employee>() on pro.ManagerID equals emp.ID
            //             where
            //             (
            //                cus.ID==companyID
            //             )
            //             select new
            //             {
            //                 pro.ID,
            //                 pro.ProjectName,
            //                 pro.ProjectDetail,
            //                 cus.CompanyName,
            //                 cus.ContactName,
            //                 cus.CustomerEmail,
            //                 FullName = emp.FirstName + " " + emp.LastName,
            //                 pro.PlannedStartDate,
            //                 pro.PlannedEndDate,
            //                 pro.StartDate,
            //                 pro.EndDate
            //             }).ToString();
            //return query;
        }



        public int GetID(Project project)
        {
            return _contex.Set<Project>().Where(p => p.ProjectName == project.ProjectName && p.ProjectDetail == project.ProjectDetail).Select(x => x.ID).FirstOrDefault();

        }

        public object DateSearch(DateTime date, bool rbtStart)
        {
            if (rbtStart == true)
            {
                return _contex.Set<Project>().Join(_contex.Set<Customer>(), p => p.CustomerID, c => c.ID, (p, c) => new { p, c }).Join(_contex.Set<Employee>(), pc => pc.p.ManagerID, e => e.ID, (pc, e) => new { pc, e }).Where(x => x.pc.p.PlannedStartDate > date).Select(x => new { x.pc.p.ID, x.pc.p.ProjectName, x.pc.p.ProjectDetail, x.pc.c.CompanyName, x.pc.c.ContactName, x.pc.c.CustomerEmail, FullName = x.e.FirstName + " " + x.e.LastName, x.pc.p.PlannedStartDate, x.pc.p.PlannedEndDate, x.pc.p.StartDate, x.pc.p.EndDate }
                    ).ToList();



                //    var query = (from p in _contex.Set<Project>()
                //             join c in _contex.Set<Customer>()
                //             on p.CustomerID equals c.ID
                //             join m in _contex.Set<Employee>()
                //             on p.ManagerID equals m.ID
                //             where
                //             (
                //                p.PlannedStartDate > date
                //             )
                //             select new
                //             {
                //                 p.ID,
                //                 p.ProjectName,
                //                 p.ProjectDetail,
                //                 c.CompanyName,
                //                 c.ContactName,
                //                 c.CustomerEmail,
                //                 FullName = m.FirstName + " " + m.LastName,
                //                 p.PlannedStartDate,
                //                 p.PlannedEndDate,
                //                 p.StartDate,
                //                 p.EndDate
                //             }).ToList();
                //return query;
            }
            else
            {
                return _contex.Set<Project>().Join(_contex.Set<Customer>(), p => p.CustomerID, c => c.ID, (p, c) => new { p, c }).Join(_contex.Set<Employee>(), pc => pc.p.ManagerID, e => e.ID, (pc, e) => new { pc, e }).Where(x => x.pc.p.PlannedEndDate > date).Select(x => new { x.pc.p.ID, x.pc.p.ProjectName, x.pc.p.ProjectDetail, x.pc.c.CompanyName, x.pc.c.ContactName, x.pc.c.CustomerEmail, FullName = x.e.FirstName + " " + x.e.LastName, x.pc.p.PlannedStartDate, x.pc.p.PlannedEndDate, x.pc.p.StartDate, x.pc.p.EndDate }
                    ).ToList();

                //var query = (from p in _contex.Set<Project>()
                //             join c in _contex.Set<Customer>()
                //             on p.CustomerID equals c.ID
                //             join m in _contex.Set<Employee>()
                //             on p.ManagerID equals m.ID
                //             where
                //             (
                //            p.PlannedEndDate < date
                //             )
                //             select new
                //             {
                //                 p.ID,
                //                 p.ProjectName,
                //                 p.ProjectDetail,
                //                 c.CompanyName,
                //                 c.ContactName,
                //                 c.CustomerEmail,
                //                 FullName = m.FirstName + " " + m.LastName,
                //                 p.PlannedStartDate,
                //                 p.PlannedEndDate,
                //                 p.StartDate,
                //                 p.EndDate
                //             }).ToList();
                //return query;
            }
        }


    }
}
