using System;
using System.Collections.Generic;
using System.Linq;

namespace AmbevTechTest.TestTwo
{
    class Program
    {
        static void Main(string[] args)
        {

            var result = AllPrefixes(3, new string[] { "flow", "flowers", "flew", "flag", "fm" });


            Console.ReadKey();


        }

        public static IEnumerable<string> AllPrefixes(int prefixLength, IEnumerable<string> words)
        {
            List<string> result = new List<string>();

            foreach (var item in words)
            {
                if (item.Length < prefixLength)
                {
                    continue;
                }
                var subs = item.Substring(0, prefixLength);

                if(!result.Contains(subs))
                {
                    yield return subs;
                }


               result.Add(subs);

            }

            //return result.Distinct();

        }
    }
}
