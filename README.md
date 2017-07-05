# Meow

## Let you use the easiest way to parse the markup language (e.g. HTML, XML)

```csharp
using Meow.Parses;
using Meow.Html.Elememts;


var source = default(string);
var parser = MeowParser.Load(null);

var hrefs = parser.Resolve<A>().Select(a => a.Href);

var srcs = parser.Resolve<Img>().Select(img => img.Src);
```