using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionLtd
{

    class Employee
    {
        public List<Workplan> _workplan = new List<Workplan>();
        public string employeeType { get; set; } // sælger, service eller produktion 
        public string name { get; set; }
        public int ID { get; set; }
        public string position { get; set; }
        public bool machine1Kvalification { get; set; }
        public bool machine2Kvalification { get; set; }


        public Employee()
        {
           
        }
    }

}
