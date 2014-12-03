using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionLtd
{
    class Controller
    {
        List<Employee> _employeeliste;

        public Controller()
        {
            _employeeliste = new List<Employee>();

            // code that add employee from database to the employee class
        }

        public void addEmployee()
        {
            // add employee to the database with all necesary information to make a add the employee to the employee class next startop
        }
        public void removeEmployee()
        {
            // remove the emplyee from the database so it would not come into the employee class again
        }


        public void addOrder()
        {
            // code en sølger og admin kan bruge, den tilføjer en order 
        }

        public void finishOrder()
        {
            // code der fjerner en order fra systemmet
        }
        public void changeOrder()
        {
            //code der går in og redigere i en orders processer
        }
        public void buildWorkplan()
        {

            /*
             * vælg en mængde ansatte med alle som standard
             * se liste af ordre igennem 
             * vælg den med nærmest deadline
             * se på orderens process
             * set dene process øverst på en kvalificeret ansats workplan
             * gennegå førnævnte trin med næste odres nærmeste deadline
             * 
            */
        }
        public void printWorkplan()
        {
            /*
             * for alle produktion medarbejdere
             * employeeliste -> workplan
             * print navn
             * print maskine, arbejdstid, order
            */
            for (int i = 0; i < _employeeliste.Count; i++)
            {
                /* systemTingDerPrintNytVindue*/
                string antifejlting1 = _employeeliste[i].name;
                string antifejlting2 = _employeeliste[i]._workplan[i].order;
                string antifejlting3 = _employeeliste[i]._workplan[i].maskine;
                int antifejlting4 = _employeeliste[i]._workplan[i].tid;

            }
        }

    }
}
