using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Entities
{
    public class Request
    {
        public int ID { get; set; }
        public string RequestDetail { get; set; }
        public int ProjectID { get; set; }
        public  Project Project { get; set; }
        public int EmployeeID { get; set; }
        public  Employee Employee { get; set; }
        public int RequestTypeID { get; set; }
        public  RequestType RequestType { get; set; }
        public bool State { get; set; }
    }
}
