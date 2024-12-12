using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        private int id;
        private int age;
        private string name;
        const int adhar_no = 23563;  //Const
        readonly string bank = "HDFC";  //ReadOnly

        private string address;

        public Program(string a) 
        {
           this.address = a;
        }
        public void display()
        {
            Console.WriteLine("Address: "+address);

        }
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Name
        {
            get { return name; }
            set { name=value;  }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        static void Method()   //Method
        {
            string father = "Hemant";
            Console.WriteLine(father);
    
        }

        class Sample
        {
            static void Main(string[] args)
            {
                Program p = new Program("Nagpur");
                p.display();
                p.Age = 23;
                p.Id = 101;
                p.name = "test";
                Console.WriteLine(adhar_no);
                Console.WriteLine(p.Name);
                Console.WriteLine(p.Age);
                Console.WriteLine(p.Id);
                Method();

            }

        }
    }
}
