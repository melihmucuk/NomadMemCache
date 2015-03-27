using System;
using System.Collections.Generic;

namespace NomadMemCache.SampleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>{0, 1, 2, 3};

            var cacher = Cacher.Instance.Add("sampleKey", list, DateTimeOffset.Now.AddMinutes(5));
            if (cacher)
            {
                var listFromCache = Cacher.Instance.GetValue<List<int>>("sampleKey");
                foreach (var item in listFromCache)
                {
                    Console.WriteLine(item);
                }
                Cacher.Instance.Delete("sampleKey");
            }            

            Console.ReadLine();

        }
    }
}
