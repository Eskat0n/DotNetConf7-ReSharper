namespace DotNetConf.Seventh.ReSharper.Examples
{
    using System;

    public class ExtractingFieldConst
    {
        private const int _i = 5;

        public void MethodOne(string input)
        {
            var foo = _i + "cm";

            Console.WriteLine(foo);
        }

        public void MethodTwo(string input)
        {
            var result = int.Parse(input) + _i;

            Console.WriteLine("{0}cm", result);
        }
    }
}