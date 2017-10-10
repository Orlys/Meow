using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using Meow.Schwarz;
using System.Dynamic;

using System.ComponentModel;
using Meow.Schwarz.Entity;
using System.Linq;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Reflection;
using System.Linq.Expressions;

namespace Meow.Schwarz
{


    public class program
    {

        public static String getguid()
        {
            return Guid.NewGuid().ToString();
        }
        static void Main(string[] args)
        {

            Console.BufferHeight = short.MaxValue - 1;
            Console.OutputEncoding = Encoding.Unicode;

            var html = File.ReadAllText("data2.html");
            var meow = Meow.Load(html);

            foreach (var ra in meow.Query<RuntimeTag>())
            {
                Console.WriteLine(ra.Content);
            }
            

            Console.ReadKey();
            return;

        }
    }
    

}

