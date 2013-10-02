namespace DotNetConf.Seventh.ReSharper.Examples
{
    using System;
    using System.Linq;

    public class ExtractingMethod
    {
        public void MethodOne(string input)
        {
            var array = Array(input);
            var foo = new String(array);

            Console.WriteLine(foo);
        }

        private static char[] Array(string input)
        {
            var array = input.Replace('c', 'a')
                .ToLowerInvariant()
                .Reverse()
                .ToArray();
            return array;
        }

        public string MethodTwo(string input)
        {
            var array = input.Replace('c', 'a')
                .ToLowerInvariant()
                .Reverse()
                .ToArray();
            var foo = new String(array);

            return foo.Substring(0, 140);
        }
    }
}