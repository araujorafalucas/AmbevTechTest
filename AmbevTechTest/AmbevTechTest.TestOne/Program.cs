using System;
using System.Collections.Generic;
using System.Linq;

namespace AmbevTechTest.TestOne
{
    class Program
    {

        static void Main(string[] args)
        {

            var z = Test("rwxr-x-w-");

            z = Test("---------");
        }


        private static int Test(string perm)
        {
            var keys = new List<KeyValue>(4);
            keys.Add(new KeyValue() { Key = 'r', Value = 4 });
            keys.Add(new KeyValue() { Key = 'w', Value = 2 });
            keys.Add(new KeyValue() { Key = 'x', Value = 1 });
            keys.Add(new KeyValue() { Key = '-', Value = 0 });

            
            var items = new List<string>();
            int index = 0;
            int subTotal = 0;

            foreach (var c in perm)
            {
                var keyValue = keys.FirstOrDefault(x => x.Key == c);

                if (keyValue != null)
                {

                    subTotal += keyValue.Value;

                    if (index == 2)
                    {
                        items.Add(subTotal.ToString());
                        index = 0;
                        subTotal = 0;

                    }
                    else
                    {
                        index++;
                    }


                }

            }

            var result = string.Join("", items);

            return Convert.ToInt32(result);
            
        }

    }


    public class KeyValue
    {
        public char Key { get; set; }
        public int Value { get; set; }
    }

}
