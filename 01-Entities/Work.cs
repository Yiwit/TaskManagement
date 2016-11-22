using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Entities
{
    public class Work
    {
        public int ID { get; set; }
        public string WorkDetail { get; set; }
        public int ProjectID { get; set; }
        public  Project Project { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int ManagerID { get; set; }
        public  Employee Manager { get; set; }
        public int? EmployeeID { get; set; }
        public  Employee Employee { get; set; }
        public int WorkStatusID { get; set; }
        public  WorkStatus WorkStatus { get; set; }
    }
}
