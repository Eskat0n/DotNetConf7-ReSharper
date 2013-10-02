namespace DotNetConf.Seventh.ReSharper.Examples
{
    using System;

    public class Inlining
    {
        public void MethodOne(string input, int count)
        {
            var partOne = int.Parse(input) * (count/10.0m);
            var foo = string.Format("We have {0} and next is {1}", partOne, input.Substring(5, 10));

            Console.WriteLine(foo);
        }

        public void MethodTwo()
        {
            Console.WriteLine(FormatOne, 5, 10, 20);
            Console.WriteLine(FormatOne, 10, 40, 80);
        }

        private string FormatOne
        {
            get { return "{0}{1}{2}"; }
        }
    }
}