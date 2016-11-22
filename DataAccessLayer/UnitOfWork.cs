using DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Entities;

namespace DataAccessLayer
{
    public class UnitOfWork
    {
        TaskManagerContext _context;
        public UnitOfWork()
        {
            _context = new TaskManagerContext();
        }
        CustomerRepository _customerRepository;
        public CustomerRepository CustomerRepository
        {
            get
            {
                if (_customerRepository == null)
                {
                    _customerRepository = new CustomerRepository(_context);
                }
                return _customerRepository;
            }
        }

        EmployeeRepository _employeeRepository;
        public EmployeeRepository EmployeeRepository
        {
            get
            {
                if (_employeeRepository == null)
                {
                    _employeeRepository = new EmployeeRepository(_context);
                }
                return _employeeRepository;
            }
        }

        PositionRepository _positionRepository;
        public PositionRepository PositionRepository
        {
            get
            {
                if (_positionRepository == null)
                {
                    _positionRepository = new PositionRepository(_context);
                }
                return _positionRepository;
            }
        }

        ProjectEmployeeRepository _projectEmployeeRepository;

        ProjectRepository _projectRepository;

        public ProjectRepository ProjectRepository
        {
            get
            {
                if (_projectRepository == null)
                {
                    _projectRepository = new ProjectRepository(_context);
                }
                return _projectRepository;
            }


        }

        RequestRepository _requestRepository;

        public RequestRepository RequestRepository
        {
            get
            {
                if (_requestRepository == null)
                {
                    _requestRepository = new RequestRepository(_context);
                }
                return _requestRepository;
            }


        }
        RequestTypeRepository _requestTypeRepository;

        public RequestTypeRepository RequestTypeRepository
        {
            get
            {
                if (_requestTypeRepository == null)
                {
                    _requestTypeRepository = new RequestTypeRepository(_context);
                }
                return _requestTypeRepository;
            }
        }

        WorkRepository _workRepository;

        public List<Employee> ProjectEmployeeGet(int ID)
        {
            return _context.Set<Employee>()
                .Join(_context.Set<ProjectEmployee>(), e => e.ID, pe => pe.EmployeeID, (e, pe) => new { e, pe })
                .Where(x=>x.pe.ProjectID==ID)
                .Select(x=>x.e)
                .ToList();
        }

        public WorkRepository WorkRepository
        {
            get
            {
                if (_workRepository == null)
                {
                    _workRepository = new WorkRepository(_context);
                }
                return _workRepository;
            }

        }

        WorkStatusRepository _workStatusRepository;

        public WorkStatusRepository WorkStatusRepository
        {
            get
            {
                if (_workStatusRepository == null)
                {
                    _workStatusRepository = new WorkStatusRepository(_context);
                }
                return _workStatusRepository;
            }
        }

        public ProjectEmployeeRepository ProjectEmployeeRepository
        {
            get
            {
                if (_projectEmployeeRepository==null)
                {
                    _projectEmployeeRepository = new ProjectEmployeeRepository(_context);
                }
                return _projectEmployeeRepository;
            }
            
        }

        DbContextTransaction _tran;
        public bool ApplyChanges()
        {
            bool isSuccess = false;


            _tran = _context.Database.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

            try
            {
                _context.SaveChanges();
                _tran.Commit();
                isSuccess = true;
            }
            catch (Exception)
            {
                _tran.Rollback();
                isSuccess = false;
                throw;
            }
            finally
            {
                _tran.Dispose();
            }
            return isSuccess;


        }






    }
}
