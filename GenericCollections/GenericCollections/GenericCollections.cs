using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class GenericCollections
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            myDictionary[36] = "Hungary";
            myDictionary[43] = "Austria";
            myDictionary[44] = "UK";
            myDictionary[377] = "Monaco";
            myDictionary[598] = "Uruguay";

            Console.WriteLine("The country with countrycode 377 is {0}", myDictionary[377]);

            foreach (KeyValuePair<int, string> country in myDictionary)
            {
                Console.WriteLine("Country: {0}, Code: {1}", country.Value, country.Key);
            }

            Console.ReadKey();
        }
    }
}
