using _01_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class EmployeeRepository : BaseRepository<Employee>
    {
        TaskManagerContext _context;
        internal EmployeeRepository(TaskManagerContext context)
            : base(context)
        {
            _context = context;
        }

        public Employee Get(string mail, string password)
        {
            return _context.Set<Employee>().Where(x => x.EMail == mail && x.Password == password).FirstOrDefault();
        }



        public object EmployeeGetAll()
        {
            return _context.Set<Employee>().Join(_context.Set<Position>(), e => e.PositionID, p => p.ID, (e, p) => new { e, p })
                 .Select(x => new
                 {
                     ID = x.e.ID,
                     Adı=x.e.FirstName,
                     Soyadı=x.e.LastName,
                     Pozisyon = x.p.PositionName,
                     Şifre = x.e.Password,
                     Mail = x.e.EMail,
                     
                 }).ToList();
        }

        public object ButtonFilter(string firstName, int position)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {

                //var query = (
                //       from emp in _context.Set<Employee>()
                //       join pos in _context.Set<Position>() on emp.PositionID equals pos.ID
                //       select new
                //       {
                //           emp.ID,
                //           emp.FirstName,
                //           emp.LastName,
                //           pos.PositionName,
                //           emp.Password,
                //           emp.EMail
                //       }).ToList();
                //return query;
                return _context.Set<Employee>().Join(_context.Set<Position>(), e => e.PositionID, p => p.ID, (e, p) => new { e, p })
                    .Select(x => new { x.e.ID, x.e.FirstName, x.e.LastName, x.p.PositionName, x.e.Password, x.e.EMail }).ToList();
            }
            else
            {

                return _context.Set<Employee>().Join(_context.Set<Position>(), e => e.PositionID, p => p.ID, (e, p) => new { e, p }).Where(x => x.e.FirstName == firstName).Select(x => new { x.e.ID, x.e.FirstName, x.e.LastName, x.p.PositionName, x.e.Password, x.e.EMail }).ToList();

                //var query = (
                //       from emp in _context.Set<Employee>()
                //       join pos in _context.Set<Position>() on emp.PositionID equals pos.ID
                //       where (
                //                emp.FirstName == firstName
                //             )
                //       select new
                //       {
                //           emp.ID,
                //           emp.FirstName,
                //           emp.LastName,
                //           pos.PositionName,
                //           emp.Password,
                //           emp.EMail
                //       }).ToList();
                //return query;
            }
        }

        public object EmployeePositionGetAll(int projectID)
        {
            return _context.Set<Employee>().Join(_context.Set<ProjectEmployee>(), e => e.ID, pe => pe.EmployeeID, (e, pe) => new { e, pe })
                .Join(_context.Set<Project>(), epe => epe.pe.ProjectID, p => p.ID, (epe, p) => new { epe, p })
                .Where(x => x.epe.e.PositionID != 1 && x.epe.e.PositionID != 2 && x.p.ID == projectID)
                .Select(x => new { FullName = x.epe.e.FirstName + " "+x.epe.e.LastName, ID = x.epe.e.ID }).ToList();
        }



        public object ComboBoxFilter(string firstName, int position)
        {

            if (string.IsNullOrWhiteSpace(firstName))
           {
               return _context.Set<Employee>().Join(_context.Set<Position>(), e => e.PositionID, p => p.ID, (e, p) => new { e, p }).Where(x => x.p.ID == position).Select(x => new { x.e.ID, x.e.FirstName, x.e.LastName, x.p.PositionName, x.e.Password, x.e.EMail }).ToList();


                //var query = (
                //       from emp in _context.Set<Employee>()
                //       join pos in _context.Set<Position>() on emp.PositionID equals pos.ID
                //       where (
                //                pos.ID == position
                //             )
                //       select new
                //       {
                //           emp.ID,
                //           emp.FirstName,
                //           emp.LastName,
                //           pos.PositionName,
                //           emp.Password,
                //           emp.EMail
                //       }).ToList();
                //return query;
            }
            else
            {
                return _context.Set<Employee>().Join(_context.Set<Position>(), e => e.PositionID, p => p.ID, (e, p) => new { e, p }).Where(x => x.p.ID == position && x.e.FirstName == firstName).Select(x => new { x.e.ID, x.e.FirstName, x.e.LastName, x.p.PositionName, x.e.Password, x.e.EMail }).ToList();


                //var query = (
                //       from emp in _context.Set<Employee>()
                //       join pos in _context.Set<Position>() on emp.PositionID equals pos.ID
                //       where (
                //                pos.ID == position && emp.FirstName == firstName
                //             )
                //       select new
                //       {
                //           emp.ID,
                //           emp.FirstName,
                //           emp.LastName,
                //           pos.PositionName,
                //           emp.Password,
                //           emp.EMail
                //       }).ToList();
                //return query;
            }

        }


    }
}
