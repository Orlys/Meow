namespace Meow.Parsers
{
    using Meow.Html.Infrastructure;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MeowParser
    {
        private MeowParser(string htmlCode)
        {
            this.HtmlCode = htmlCode;
        }

        public string HtmlCode { get; private set; }

        public static MeowParser Load(string htmlCode)
            => new MeowParser(htmlCode ?? throw new ArgumentNullException(nameof(htmlCode)));

        public IEnumerable<T> Resolve<T>() where T : ElementBase, new()
            => new T().Evaluate(this.HtmlCode).Select(x => x.To<T>());
    }
}