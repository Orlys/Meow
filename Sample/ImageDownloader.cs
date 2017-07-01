using Meow.Html.Elements;
using Meow.Parsers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

class ImageDownloader 
{
    public string Location { get; private set; }
    private readonly Client client;
    public ImageDownloader(string target)
    {
        this.client = new Client(target);
        Directory.CreateDirectory(this.Location = Path.Combine(AppContext.BaseDirectory, "images"));
    }
    public async Task RunAsync(Action<ImageBag> action)
    {
        var images = (await this.client.GetResourceAsync(s => MeowParser.Load(s).Resolve<Img>()))
            .Where(img => Uri.IsWellFormedUriString(img.Src, UriKind.RelativeOrAbsolute) & !string.IsNullOrWhiteSpace(img.Src))
            .ToArray();
        
        for (int id = 0; id < images.Length; id++)
            action(await this.ProcessAsync(id, images[id].Src));
    }

    static void Main(string[] args)
    {
        var target = "http://localhost";
        var crawler = new ImageDownloader(target);
        crawler.RunAsync(msg => Console.WriteLine(msg)).Wait();
        Console.ReadKey();
    }

    private async Task<ImageBag> ProcessAsync(int id, string source)
    {
        try
        {
            var c = new Client("http:" + source);
            var name = Path.GetFileName(c.Target);
            var path = Path.Combine(this.Location, name);
            await c.GetResourceAsync(s => Image.FromStream(s))
                .ContinueWith(t => t.Result.Save(path));

            return new ImageBag
            {
                Id = id,
                Source = name,
                ImageStatus = ImageBag.Status.Processed
            };
        }
        catch
        {
            return new ImageBag
            {
                Id = id,
                Source = source,
                ImageStatus = ImageBag.Status.Skipped
            };
        }
    }
}
class ImageBag
{
    public enum Status
    {
        Skipped,
        Processed
    }
    public Status ImageStatus { get; set; }
    public int Id { get; set; }
    public string Source { get; set; }
    public override string ToString() => $"[{Id.ToString().PadLeft(3,'0')}] '{Source}' is {ImageStatus}";
}
