// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D

namespace Meow.Debugger
{
    using Meow.Schwarz;
    using Meow.Schwarz.Dynamic;
    using System;
    using System.Linq;
    using System.Reactive.Linq;

    public class Program
    {
        #region Private Methods

        private static void Introduction1()
        {
            var html =
   @"
<!Doctype html>
<html>
    <head>
        <title>I am Viyrex.</title>
    </head>
    <body>
        <p class=""introduction"">I'm Viyrex, A student from Taiwan.<br>My motto is 'No pain, no gain'.<br>If you want to contact me , <a href=""https://github.com/0x0001F36D"">Here</a> is my Github page. Have fun coding!
        </p>
    </body>
<html>
";

            var meow = Meow.Load(html);

            // 'I am Viyrex.'
            var title = meow.Resolve<Title>().Single().Content;

            // 'https://github.com/0x0001F36D'
            var github = meow.Resolve<A>().Single().Href;

            Console.WriteLine(title);
            Console.WriteLine(github);
        }

        private static void Introduction2()
        {
            var html = @"<hello description=""i'm runtime-attribute"" yuyu=""fatty liver"">Runtime-Tag</hello>";
            var tag = Meow.Load(html)
                        .Resolve<RuntimeTag>()
                        .Single();

            // hello
            var tagName = tag.TagName;

            // 'Runtime-Tag'
            var content = tag.Content;

            // 'i'm runtime-attribute'
            var description = tag.DynamicAttributes.Description;

            //Just for access attributes.
            dynamic attributes = tag;

            //'fatty liver'
            var yuyu = attributes.yuyu;

            Console.WriteLine(tagName);
            Console.WriteLine(content);
            Console.WriteLine(description);
            Console.WriteLine(yuyu);
        }

        private static void Main(string[] args)
        {
            Introduction1();
            Spilt();
            Introduction2();
            Spilt();
        }

        private static void Spilt()
                                    => Console.WriteLine("======================================================");

        #endregion Private Methods
    }
}