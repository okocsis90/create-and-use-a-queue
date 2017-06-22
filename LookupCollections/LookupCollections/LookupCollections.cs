using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; 
using System.Collections.Specialized;
using System.Globalization;

namespace LookupCollections
{
    class LookupCollections
    {
        static void Main(string[] args)
        {
            ListDictionary list = new ListDictionary(new CaseInsensitiveComparer(CultureInfo.InvariantCulture));

            list.Add("Estados Unidos", "United States");
            list.Add("España", "Spain");
            list["Canadá"] = "Canada";

            Console.WriteLine(list["ESTADOS UnIdOs"]);
            Console.WriteLine(list["canadÁ"]);
            Console.WriteLine(list["EsPAña"]);

            Console.ReadKey();
        }
    }
}
