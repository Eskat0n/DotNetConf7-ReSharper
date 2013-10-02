namespace DotNetConf.Seventh.ReSharper.Examples
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SSR
    {
        public void MethodOne(IEnumerable<int> enumerable)
        {
            if (enumerable.Any())
            {
                Console.WriteLine("There are elements!");
            }
        }

        public void MethodTwo(object input)
        {
            if (input == null) 
                return;

            var array = input as Array;

            Console.WriteLine(string.Join(", ", array));
        }
    }
}