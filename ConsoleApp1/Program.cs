using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TYpeCasting
{
    public class Program
    {
        ////here we decalre or create instance variables

        //public int id;
        //public double weight;
        //public string name;
        //public bool Result;

        ////here we declare or create default constructor


        //public Program(int i, double w, string n, bool r)
        //{
        //    id = i;
        //    weight = w;
        //    name = n;
        //    Result = r;
        //}
        //public void show()
        //{
        //    Console.WriteLine(id);
        //    Console.WriteLine(weight);
        //    Console.WriteLine(name);
        //    Console.WriteLine(Result);  

        //}

        public int id;
        public string name;
        public int age;

        public readonly int PhotoCopy = 90;
        public Program(int i, string n, int a)
        {
            id = i;
            name = n;
            age = a;
        }    
        public void valid()
        {
            if (age > 18)
            {
                Console.WriteLine("Valid for vote");
            }
            else
            {
                Console.WriteLine("Not valid");
            }
        }
        public void show()
        {
            Console.WriteLine(id);
            Console.WriteLine(name);
            Console.WriteLine(age);

        }
        public Program()
        {
          Console.WriteLine("sgsdsd");
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the values ");
            int i = int.Parse(Console.ReadLine());
            string n= Console.ReadLine();
            int a = int.Parse(Console.ReadLine());

           Program p= new Program(i,n,a);
            p.valid();
            p.show();
            Program p1 = new Program();

            
        }
    }
}
