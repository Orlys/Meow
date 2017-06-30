namespace Meow.Test
{
    using Meow.Html.Elements;
    using Meow.Parsers;
    using System;

    public class Program
    {
        private static void Main(string[] args)
        {
            var data = @"<a data-test=""data-test-value"" class=""test-class"" href=""http://www.test.com/"">test</a>";
            var meow = MeowParser.Load(data);
            foreach (var a in meow.Resolve<A>())
            {
                Console.WriteLine(a.Class);
            }

            Console.ReadKey();
        }
    }
}