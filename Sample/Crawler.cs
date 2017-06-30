using Meow.Html.Elements;
using Meow.Parsers;
using System;
using System.Drawing;
using System.IO;
using System.Linq;

class Crawler
{
    static void Main(string[] args)
    {
        var directory = Path.Combine(AppContext.BaseDirectory, "images");

        var target = "http://imgur.com/";

        var client = new Client(target);

        Directory.CreateDirectory(directory);

        var clients = client.GetResourceAsync(s => MeowParser.Load(s).Resolve<Img>())
            .Result
            .Where(x => Uri.IsWellFormedUriString(x.Src, UriKind.RelativeOrAbsolute))
            .Select(img => new Client("http:" + img.Src));

        foreach (var c in clients)
        {
            try
            {
                var path = Path.Combine(directory,Path.GetFileName(c.Target));
                c.GetResourceAsync(s => Image.FromStream(s)).Result.Save(path);
                Console.WriteLine(c.Target + " was processed.");
            }
            catch
            {
                Console.WriteLine(c.Target + " was skipped.");
            }
        }
        

    }
}
