using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class pizza1
    {
        public static string OvenStatus;
        
        private pizza1()
        {
            OvenStatus = "Ready to Bake";
        }
        public void Bakepizza(string pizzaname)
        {
            Console.WriteLine(pizzaname+"is ready");
        }
        static void Main(string[] args)
        {
            pizza1 p = new pizza1();
            p.Bakepizza("Onion");
        }
    }
}
