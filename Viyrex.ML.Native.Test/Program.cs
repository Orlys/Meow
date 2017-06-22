#define DEBUG
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using Viyrex.ML.Html.Elements;
using Viyrex.ML.Parsers;

namespace Viyrex.ML.Native.Test
{
    
    class Program
    {

        static void Main(string[] args)
        {
            

            Stopwatch sw = new Stopwatch();
            var m = new[] 
            {
                "<p class=\"a\">"+
                    "aaaaaa"+
                    "<p class=\"b\">"+
                        "<a class=\"anchor\" href=\"http://test.com\">"+
                            "anchor"+
                        "</a>"+
                        "bbbbbb"+
                    "</p>"+
                    "<p class=\"c\">"+
                        "cccccc"+
                    "</p>",

                "<div class=\"a\">aaaa<div class=\"b\"><div class=\"c\">cccc</div>bbbb</div></div>",
                new WebClient{ Encoding = Encoding.UTF8 }.DownloadStringTaskAsync(new[] 
                {
                    "https://msdn.microsoft.com/zh-tw/library/system.text.regularexpressions.regex(v=vs.110).aspx",
                    "https://github.com/"
                }[1]).Result
            }[2];

            sw.Start();
            foreach (var item in LinqIt.Load(m).Resolve<A>())
            {
                Console.WriteLine(item.Href);
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);

            sw.Reset();

            sw.Start();
            foreach (var item in LinqIt.Load(m).Resolve<Div>())
            {
                Console.WriteLine(item.Class);
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);

            Console.ReadKey();
        }
        
    }
}
