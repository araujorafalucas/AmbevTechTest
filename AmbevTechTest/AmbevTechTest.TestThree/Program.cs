using System;
using System.Collections.Generic;
using System.Linq;

namespace AmbevTechTest.TestThree
{
    class Program
    {
        static void Main(string[] args)
        {
            var format = System.Globalization.CultureInfo.InvariantCulture.DateTimeFormat;

            UnloadingTime[] unloadingTimes = new UnloadingTime[]
            {
            new UnloadingTime(DateTime.Parse("3/4/2019 19:00", format), DateTime.Parse("3/4/2019 20:30", format)),
            new UnloadingTime(DateTime.Parse("3/4/2019 22:10", format), DateTime.Parse("3/4/2019 22:30", format)),
            new UnloadingTime(DateTime.Parse("3/4/2019 20:30", format), DateTime.Parse("3/4/2019 22:00", format))
            };

            Console.WriteLine(CanUnloadAll(unloadingTimes));


        }

        //test 1
        //public static bool CanUnloadAll(IEnumerable<UnloadingTime> unloadingTimes)
        //{            

        //    List<bool> result = new List<bool>();
        //    foreach(var unload in unloadingTimes)
        //    {
        //        var zz = unloadingTimes.Any(x => unload.Start < x.End || unload.End > x.Start);

        //        result.Add(zz);
        //    }

        //    var final = result.All(x => x);

        //    return final;

        //}

        public static bool CanUnloadAll(IEnumerable<UnloadingTime> unloadingTimes)
        {
            List<bool> result = new List<bool>();
            foreach (var unload in unloadingTimes)
            {
                bool Naopode = unloadingTimes.Any(x => (unload.Start >= x.Start && unload.Start <= x.End)
                                                    && (unload.End >= x.Start && unload.End <= x.End)
                                                    );

                result.Add(Naopode);
            }

            var final = result.All(x => x);

            return final;

        }
    }



    public class UnloadingTime
    {
        public DateTime Start { get; private set; }
        public DateTime End { get; private set; }

        public UnloadingTime(DateTime start, DateTime end)
        {
            this.Start = start;
            this.End = end;
        }
    }
}
