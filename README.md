# Meow

## Parse your html code to LINQable html element.

```csharp
using Meow.Html.Parses;
using Meow.Html.Elememts;


var sourceCode = "html source code";
var parser = MeowParser.Load(sourceCode);

var hrefs = parser.Resolve<A>().Select(a => a.Href);

var srcs = parser.Resolve<Img>().Select(img => img.Src);
```