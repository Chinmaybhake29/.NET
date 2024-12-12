// See https://aka.ms/new-console-template for more information


using Constructor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class program
    {
        internal int rollno;
        internal string name;

        public program(int r, string n)
        {
            this.rollno = r;
            this.name = n;
        }

        //Copy Constructor

        public program(program pr)
        {
            rollno = pr.rollno;
            name = pr.name;
        }

        public void Display() 
        {
            Console.WriteLine("This is our method");
            Console.WriteLine("Roll No"+rollno);
            Console.WriteLine("Name" + name);
        }
    }
    class sample
    {
       static void Main(string[] args)
        {
            program p = new program(101, "Chinnmay");

            p.Display();


            pizza p1 = new pizza("Regular", "Extra-chese", 5, "Onion Pizza");
            pizza p2 = new pizza(p1);

            //p1.show();
            //p2.show();

            //staticcons s = new staticcons("Large", "Extra Cheese");
            //s.display();

            //Console.WriteLine("=====================");

            //staticcons s1 = new staticcons(staticcons.DefaultCrust,staticcons.DefaultSize);
            //s.display();

            //staticcons s=new staticcons("chinmay29@gmail.com","chinmaybhake");
            //s.display();

            //Console.WriteLine("-----------------------------");

            //staticcons s1 = new staticcons(staticcons.facebooklite,staticcons.tweeter);
            //s1.display();

            //Student student = new Student();
            //student.Name = "Chinmay";
            //Console.WriteLine(student.Name);





        }

    }
}