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
        public int ID { get; set; }
        public string Name { get; set; }
        public string employeeType { get; set; } // sælger, service eller produktionmedarbejder 
        public string LaserCutter { get; set; } // yes or no
        public string CNCFræser { get; set; } // yes or no


        public Employee(int ID, string Name, string employeeType, string LaserCutter, string CNCFræser)
        {
            this.ID = ID;
            this.Name = Name;
            this.employeeType = employeeType;
            this.LaserCutter = LaserCutter;
            this.CNCFræser = CNCFræser;
        }
    }

}
