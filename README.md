# Meow.Schwarz

## Introduction

```csharp
using Meow.Schwarz;
using Meow.Schwarz.Entity;


var sourceCode = "html source code";
var meow = Meow.Load(sourceCode);

var hrefs = meow.Query<A>().Select(a => a.Href);

var srcs = meow.Query<Img>().Select(img => img.Src);
```