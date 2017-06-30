using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

class Client : HttpClient
{
    public Client(string target)
    {
        this.Target = Uri.IsWellFormedUriString(target, UriKind.RelativeOrAbsolute) ? target : null;
        this.DefaultRequestHeaders.Add("User-Agent",UserAgent);
    }
    public readonly string Target;
    private const string UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/59.0.3071.115 Safari/537.36";

    public async Task<T> GetResourceAsync<T>(Func<Stream, T> converter)
       => this.Target == null ? default(T) : converter(await this.GetStreamAsync(this.Target));

    public async Task<T> GetResourceAsync<T>(Func<string, T> converter)
               => this.Target == null ? default(T) : converter(await this.GetStringAsync(this.Target));
}



