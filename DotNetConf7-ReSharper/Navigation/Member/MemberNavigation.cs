namespace DotNetConf.Seventh.ReSharper.Examples.Navigation.Member
{
    using System;

    public class MemberNavigation
    {
        public void Method()
        {
            Console.WriteLine("Date is: " + VingardumLeviosa);
        }

        private DateTime VingardumLeviosa
        {
            get { return DateTime.Now.AddYears(-5); }
        }
    }
}