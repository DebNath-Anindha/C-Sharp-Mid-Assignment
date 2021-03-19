namespace JobDemo
{
    public class Job
    {
        private int jobNumber;
        private int jobHour;
        private int jobPrice;
        private string jobDiscription;
        public int JobNumber
        {
            set => jobNumber = value;
            get => jobNumber;



        }
        public int JobHour
        {
            set => jobHour = value;
            get => jobHour;



        }
        public int JobPrice
        {
            set => jobPrice = value * 45;
            get => jobPrice;



        }
        public string JobDiscription
        {
            set => jobDiscription = value;
            get => jobDiscription;



        }
        public Job(int x, int y, string z)
        {
            JobNumber = x + this.GetHashCode();
            JobHour = y;
            JobPrice = y;
            jobDiscription = z;
        }
        public override string ToString()
        {
            return "Job Number:" + JobNumber + "\n"
                + "Job Hour:" + JobHour + "\n"
                + "Job Price:" + JobPrice + "\n"
                + "Job Description:" + JobDiscription;
        }
    }
    public class JobDemo
    {
        public static void Main(string[] args)
        {
            Job j1 = new Job(5, 3, "Job 1");
            Job j2 = new Job(6, 6, "Job 1");
            System.Console.WriteLine(j1.ToString());
            System.Console.WriteLine("----------------------");
            System.Console.WriteLine(j1.ToString());
        }
    }



}
