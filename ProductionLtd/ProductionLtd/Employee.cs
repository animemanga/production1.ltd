using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProductionLtd
{

    class Employee
    {
        public List<Workplan> _workplan = new List<Workplan>();
        public string employeeType { get; set; } // sælger, service eller produktionmedarbejder 
        public string name { get; set; }
        public int ID { get; set; }
        public string LaserCutter { get; set; } // yes or no
        public string CNCFræser { get; set; } // yes or no


        public Employee()
        {
           
        }
    }

}
