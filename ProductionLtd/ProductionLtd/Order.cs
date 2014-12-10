using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace ProductionLtd
{
    class Order
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string DeadLine { get; set; }
        public int Pris { get; set; }
        public string RistType { get; set; }
        public string Antal { get; set; } 


        public Order(int ID, string Name,string DeadLine,int pris, string RistType, string Antal)
        {
            this.ID = ID;
            this.Name = Name;
            this.DeadLine = DeadLine;
            this.Pris = pris;
            this.RistType = RistType;
            this.Antal = Antal;
        }
    }
}
