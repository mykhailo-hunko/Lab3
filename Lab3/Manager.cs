
using System.Collections;
using System.Collections.Generic;


namespace Lab3
{
    public class Manager
    {
        public Hashtable listOfComputers = new Hashtable();
        public Dictionary<string, Proccess> listOfProcess = new Dictionary<string, Proccess>();
        public Dictionary<string, Proccess> listOfProcess2 = new Dictionary<string, Proccess>();
        public List<Proccess> proccess;
        public List<Proccess> proccess2;
        enum user
        {
            allUsers,
            admin
        }
        enum proccessor_percent
        {
            low = 10,
            medium = 30,
            hard = 70,
            ultra = 90
        }
        enum priority
        {
          low,
          medium,
          high
        }
        enum memoryForProccess
        {
            verySmall = 8,
            small = 16,
            moreThanSmall = 32,
            almostMedium = 64,
            medium = 128,
            moreThanMedium = 256,
            big = 512,
            biggest = 1024
        }
        public Manager()
        {   
            listOfProcess.Add("browser", new Proccess("browser", (int)user.admin, (int)proccessor_percent.low, (int)memoryForProccess.medium, "---", (int)priority.high));
            listOfProcess.Add("operation system", new Proccess("operation system", (int)user.admin, (int)proccessor_percent.low, (int)memoryForProccess.moreThanSmall, "---", (int)priority.medium)); 
            listOfProcess.Add("visual studio", new Proccess("visual studio", (int)user.admin, (int)proccessor_percent.low, (int)memoryForProccess.small, "---", (int)priority.medium));
            listOfProcess2.Add("browser", new Proccess("browser", (int)user.admin, (int)proccessor_percent.low, (int)memoryForProccess.medium, "---", (int)priority.high));
            listOfProcess2.Add("operation system", new Proccess("operation system", (int)user.admin, (int)proccessor_percent.low, (int)memoryForProccess.moreThanSmall, "---", (int)priority.medium));
            listOfProcess2.Add("visual studio", new Proccess("visual studio", (int)user.admin, (int)proccessor_percent.low, (int)memoryForProccess.small, "---", (int)priority.medium));
            proccess = new List<Proccess>(listOfProcess.Values);

            listOfComputers.Add(1, new Сomputer(4096, proccess, 3300, 8)); 
            listOfProcess.Add("test_1", new Proccess("test_1", (int)user.admin, (int)proccessor_percent.low, (int)memoryForProccess.small, "---", (int)priority.medium));
            proccess = new List<Proccess>(listOfProcess.Values);
            listOfComputers.Add(2, new Сomputer(8192, proccess, 2300, 2));
            listOfProcess.Add("test_2", new Proccess("test_2", (int)user.admin, (int)proccessor_percent.low, (int)memoryForProccess.small, "---", (int)priority.medium));
            proccess2 = new List<Proccess>(listOfProcess2.Values);
            listOfComputers.Add(3, new Сomputer(2048, proccess2, 1900, 4));

        }
    }
}
