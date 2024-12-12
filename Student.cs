using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Student
    {
        private int id;
        private string name;
        private int age;

        public string Name 
        { 
            get 
            { 
                return name; 
            } 
            set 
            {  
                name = value; 
            } 
        }
        public int Id 
        { 
            get 
            { 
                return id; 
            } 
            set 
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Age must be positive");
                }
            } 
        }
    }
   
}
