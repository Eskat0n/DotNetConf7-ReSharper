namespace DotNetConf.Seventh.ReSharper.Examples
{
    using System;
    using System.Linq;

    public class ExtractingFieldInitializer
    {
        private string _foo;

        public void MethodOne(string input)
        {
            _foo = new String(input.Replace('c', 'a')
                .ToLowerInvariant()
                .Reverse()
                .ToArray());
            var foo = _foo;

            Console.WriteLine(foo);
        }

        public string MethodTwo(string input)
        {
            var foo = new String(input.Replace('c', 'a')
                .ToLowerInvariant()
                .Reverse()
                .ToArray());

            return foo.Substring(0, 140);
        }        
    }
}