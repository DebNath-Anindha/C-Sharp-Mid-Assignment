using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {


        class Student
        {
            public int Roll_no;
            public string name;

            public void Smethod()
            {
                Console.Write("Enter Roll No  : ");
                Roll_no = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Name  : ");
                name = Convert.ToString(Console.ReadLine());


            }


        }

        class Test : Student
        {


            public int marks1;
            public int marks2;
           


           
            public void Tmethod()
            {
                Console.Write("Enter marks1 :  ");
                marks1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter marks2 :  ");
                marks2 = Convert.ToInt32(Console.ReadLine());



            }

            
            
        }


        class Result : Test
        {
            public int total;
            
            public void Rmethod()
            {
                total = marks1 + marks2;
               
            }
        }

    


        public static void Main(string[] args)
         {
        
        Result r = new Result();
            
           




        Console.WriteLine("OUTPUT");
            r.Smethod();
            r.Tmethod();
            r.Rmethod();
            Console.WriteLine("Roll No :  " + r.Roll_no);
        Console.WriteLine("Name :  " + r.name);
        Console.WriteLine("Marks1 :  " + r.marks1);
        Console.WriteLine("Marks2 :  " + r.marks2);
        Console.WriteLine("Tottal :  " + r.total);

         }


    }


}



        





    

