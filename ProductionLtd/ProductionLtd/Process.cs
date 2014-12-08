using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProductionLtd
{
    class Process
    {
        public string maskine { get; set; }
        public int tid { get; set; }

        public Process(string maskine, int tid)
        {
            this.maskine = maskine;
            this.tid = tid;
        }
    }
}
