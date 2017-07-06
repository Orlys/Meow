namespace Meow.Html.Parser
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MeowParser
    {
        private MeowParser(string code)
        {
            this.SourceCode = code;
        }

        public string SourceCode { get; private set; }

        public static MeowParser Load(string code)
            => new MeowParser(code ?? throw new ArgumentNullException(nameof(code)));

        /// <summary>
        /// Resolve <typeparamref name="TElement"/> from source code
        /// </summary>
        /// <typeparam name="TElement">The element type was derived from <see cref="ElementBase"/></typeparam>
        /// <returns></returns>
        public IEnumerable<TElement> Resolve<TElement>() where TElement : ElementBase, new()
            => new TElement().Evaluate(this.SourceCode)
                .Select(element => element.attributes
                .Aggregate(new TElement { ElementContent = element.content }, (body, attr) =>
                {
                    body[attr.key] = attr.value;
                    return body;
                }));
    }
}