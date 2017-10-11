# Meow.Schwarz

## Introduction
- ##### 加入命名空間
```csharp
using Meow.Schwarz;
using Meow.Schwarz;
```

- ##### 直接針對想解析的 HTML 元素做處理
```csharp
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
```

- ##### 非 HTML 元素的自定義元素也可輕鬆取得
> *RuntimeTag* 類別(以下稱為 *RT* )是所有非 HTML 元素的轉接類別
> 
> 直接將 *RT* 轉為 *dynamic* 類型就能直接存取標籤的屬性
> 
> 轉換為 *dynamic* 類型的 *RT* 物件無法存取原先 *RT* 物件的成員 *(e.g: TagName, Content)*
```csharp
var html = @"<hello description=""i'm runtime-attribute"" yuyu=""fatty liver"">Runtime-Tag</hello>";
var tag = Meow.Load(html)
            .Resolve<RuntimeTag>()
            .Single();
// 'hello'
var tagName = tag.TagName;
// 'Runtime-Tag'
var content = tag.Content;
// 'i'm runtime-attribute'
var description = tag.DynamicAttributes.Description; 
//Just for access attributes.
dynamic attributes = tag; 
//'fatty liver'
var yuyu = attributes.yuyu; 
```
