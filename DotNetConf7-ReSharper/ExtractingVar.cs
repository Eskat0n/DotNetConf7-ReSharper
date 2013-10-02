namespace DotNetConf.Seventh.ReSharper.Examples
{
    using System;

    public class ExtractingVar
    {
        public void MethodOne()
        {
            var bar = new string('-', 40);
            var foo = bar +
                      DateTime.Now.ToLongTimeString();

            Console.WriteLine(foo);
        }
        
        public void MethodTwo()
        {
            var baz = new string('-', 40);
            var foo = baz + DateTime.Now.ToLongTimeString();
            var bar = baz + DateTime.Now.ToLongDateString();

            Console.WriteLine(foo);
            Console.WriteLine(bar);
        }
    }
}
