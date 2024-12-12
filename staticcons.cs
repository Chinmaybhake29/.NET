using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class staticcons
    {
        public static string tweeter;
        public static string facebooklite;

        public string id;
        public string password;

        static staticcons()
        {
            tweeter = "account linked";
            facebooklite = "account created";

        }
        public staticcons(string tweet, string face)
        {
            this.id = tweet;
            this.password = face;
        }
        public void display()
        {
            Console.WriteLine(id + " " + password);
        }

    }

}
