using System;



namespace JobDemo2
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
    public class JobDemo2
    {
        public static void Main(string[] args)
        {
            Job[] jrr = new Job[5];
            jrr[0] = new Job(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Console.ReadLine());
            jrr[1] = new Job(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Console.ReadLine());
            jrr[2] = new Job(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Console.ReadLine());
            jrr[3] = new Job(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Console.ReadLine());
            jrr[4] = new Job(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Console.ReadLine());



            foreach (Job J in jrr)
            {
                Console.WriteLine(J.ToString());
            }
        }
    }
}