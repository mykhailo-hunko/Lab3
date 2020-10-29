using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Сomputer
    {
       public string name;
        public int ram;
        public  List<Proccess> proccess = new List<Proccess>();
        public int proccessor;
        public int numberOfProccessors;

        public Сomputer(int ram, List<Proccess> proccess, int proccessor, int numberOfProccessors)
        { 
            this.ram = ram;
            this.proccess = proccess;
            this.proccessor = proccessor;
            this.numberOfProccessors = numberOfProccessors;
            createName();
        }

        public void createName()
        {
            name = "ЦП " + (double) proccessor/1000 + " ГГц; ОЗУ " + ram/1024 + " Гб"; 
       
        }
    }
}
