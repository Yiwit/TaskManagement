using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Entities
{
    public class ProjectEmployee
    {
        public int ProjectID { get; set; }
        public  Project Project { get; set; }
        public int EmployeeID { get; set; }
        public  Employee Employee { get; set; }
    }
}
