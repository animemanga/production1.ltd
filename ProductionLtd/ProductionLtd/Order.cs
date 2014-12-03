using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionLtd
{
    class Order
    {
        Process _processlist;
        public DateTime deadLine { get; set; }
        public string name { get; set; }

        public Order(bool comstom)
        {
            if (comstom == false)
            {
                // code der spørger efter type 1, 2 eller 3
            }
            else
            {
                // code der opretter en liste af Process med sepcial valgte input 
            }
        }
    }
}
