namespace Lab3
{
     public class Proccess
    {
        public string name;
       public int user;
        public byte proccessor_number;
        public short memoryForProccess;
        public string desc;
        public int priority;

        public Proccess(string name, int user, byte proccessor_number, short memoryForProccess, string desc, int priority)
        {
            this.name = name;
            this.user = user;
            this.proccessor_number = proccessor_number;
            this.memoryForProccess = memoryForProccess;
            this.desc = desc;
            this.priority = priority;
        }
    }
}