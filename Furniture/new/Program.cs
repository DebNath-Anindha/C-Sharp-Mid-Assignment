using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture
{
    class Program
    {


        class Furniture
        {
            public string material;
            public int price;
        
    public void fmethod()  
    {
                 Console.Write("Enter Material  : " );
                material = Convert.ToString(Console.ReadLine());
                Console.Write("Enter Price  : " );
                price = Convert.ToInt32(Console.ReadLine());


    }

           // public string material { set; get; }

        }

     class Table : Furniture 
        {


        public int height;
        public int surface_area;

        public void tmethod()
        {
            Console.Write("Enter Height  : "  );
                height =   Convert.ToInt32(Console.ReadLine());

            Console.Write(" Enter Surface area  : "  );
                surface_area = Convert.ToInt32(Console.ReadLine());
        }

        }
        public static void Main(string[] args)
            {



           Table t = new Table();
            Console.WriteLine("OUTPUT");
            t.fmethod();

            t.tmethod();
            Console.WriteLine( "Material :  "  +t.material);
            Console.WriteLine( "Price :  "   +t.price);
            Console.WriteLine( "Height :  "   +t.height);
            Console.WriteLine( "Surface Area :  "   +t.surface_area);

            }
     




    }
}

