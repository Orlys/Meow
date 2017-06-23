using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Viyrex.Meow.Html.Elements
{
    public abstract class CollectionBase : IEnumerable<(string Key,string Value)>
    {
        private readonly Dictionary<string, string> dict;

        protected CollectionBase()
            => this.dict = new Dictionary<string, string>();
        
        public string this[string attribute]
        {
            get
                => this.dict[preprocessKey(attribute)];
            set
                => this.dict[preprocessKey(attribute)] = value;
        }

        private string preprocessKey(string attribute)
            => attribute.ToLower().TrimStart('-', '_').Replace("data-", null);

        public IEnumerator<(string Key, string Value)> GetEnumerator()
            => this.dict.Select(x => (x.Key, x.Value)).GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => this.GetEnumerator();
    }
}