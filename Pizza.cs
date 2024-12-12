using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class pizza
    {
        public string Base;
        public string topings;
        public int slice;
        public string menu;
        public pizza(string bw, string t, int s, string m)
        {
            Base = bw;
            topings = t; 
            slice = s;
            menu = m;
        }
        public pizza(pizza p) {
            Base = p.Base;
            topings = p.topings; 
            slice = p.slice;
            menu = p.menu;

        }
        public void show()
        {
            Console.WriteLine("Base: " + Base);
            Console.WriteLine("toping " + topings);
            Console.WriteLine("Slice: " + slice);
            Console.WriteLine("Menu: " + menu);
        }
    }
}
