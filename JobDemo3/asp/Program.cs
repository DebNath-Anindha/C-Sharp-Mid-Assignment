using System;

namespace JobDemo3
{
    public class Job
    {
        private int jobNumber;
        private int jobHour;
        protected int jobPrice;
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
            set => jobPrice = value;
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
    public class RushJob : Job
    {
        public RushJob(int x, int y, string z) : base(x, y, z) { }
        public int Price()
        {
            return jobPrice = jobPrice * 150;
        }



    }
    public class JobDemo3
    {
        public static void Main(string[] args)
        {
            RushJob[] jrr = new RushJob[5];
            jrr[0] = new RushJob(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Console.ReadLine());
            jrr[1] = new RushJob(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Console.ReadLine());
            jrr[2] = new RushJob(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Console.ReadLine());
            jrr[3] = new RushJob(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Console.ReadLine());
            jrr[4] = new RushJob(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Console.ReadLine());



            foreach (RushJob J in jrr)
            {
                J.Price();
                Console.WriteLine(J.ToString());
            }
        }
    }
}