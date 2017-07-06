using Meow.Html.Elements;
using Meow.Html.Parser;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

internal class ImageDownloader
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
            .Where(img => Uri.IsWellFormedUriString(img.Src, UriKind.RelativeOrAbsolute))
            .ToArray();

        for (int id = 0; id < images.Length; id++)
            action(await this.ProcessAsync(id, images[id].Src));
    }

    private static void Main()
    {
        var target = "http://imgur.com";
        var crawler = new ImageDownloader(target);
#pragma warning disable 4014
        crawler.RunAsync(msg => Console.WriteLine(msg));
#pragma warning restore
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