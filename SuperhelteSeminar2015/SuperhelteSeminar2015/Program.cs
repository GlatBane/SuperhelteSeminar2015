using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperhelteSeminar2015
{
    class Program
    {
        static Dictionary<char, int> mapping = new Dictionary<char,int>{
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}};

        static void Main(string[] args)
        {

            string input = "MCMXCVIII";
            Console.WriteLine(string.Format("{0} - {1}: {2}", 1998, input, Convert(input)));
            input = "MMXV";
            Console.WriteLine(string.Format("{0} - {1}: {2}", 2015, input, Convert(input)));
            input = "LXXXIX";
            Console.WriteLine(string.Format("{0} - {1}: {2}", 89, input, Convert(input)));
            input = "MDCCLXXIV";
            Console.WriteLine(string.Format("{0} - {1}: {2}", 1774, input, Convert(input)));
            input = "CDXLIV";
            Console.WriteLine(string.Format("{0} - {1}: {2}", 444, input, Convert(input)));
            input = "CCCXCVI";
            Console.WriteLine(string.Format("{0} - {1}: {2}", 396, input, Convert(input)));

            Console.ReadKey();
        }

        public static int Convert(string roman)
        {

            int total = 0;

            for (int i = 0; i < roman.Length; i++)
            {
                int sub = mapping[roman[i]];
                // hvis det er sidste værdi så skal den bare lægges til
                if (i + 1 == roman.Length)
                {
                    total += sub;
                }
                else
                {
                    // hvis det næste tal er større end, så skal vi trække fra
                    if (mapping[roman[i + 1]] > sub)
                    {
                        total += mapping[roman[i + 1]] - sub;
                        // og vi har brugt den næste også
                        i++;
                    }
                    else
                    {
                        total += sub;
                    }
                }
            }

            return total;
        }
    
    }
}
