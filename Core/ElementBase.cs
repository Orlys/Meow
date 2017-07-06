namespace Meow
{
    using Meow.Auxiliary;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text.RegularExpressions;

    public abstract class ElementBase
    {
        protected const string AttributeKeyToken = "key";

        protected const string AttributeToken = "attribute";

        protected const string AttributeValueToken = "value";

        protected const RegexOptions RegexOption = RegexOptions.ExplicitCapture | RegexOptions.IgnoreCase;

        protected ElementBase()
        {
            this.ElementName = this.GetType().Name;
        }

        /// <summary>
        /// Element's content
        /// </summary>
        [NotAttribute]
        public virtual string ElementContent { get; set; }

        /// <summary>
        /// Element's name
        /// </summary>
        [NotAttribute]
        public virtual string ElementName { get; private set; }

        [NotAttribute]
        protected virtual string AttributeRegex => @"(?<" + AttributeKeyToken + @">[\w\-]+)(\s*\=\s*(?<_>['""]?)(?<" + AttributeValueToken + @">.*?)\k<_>)?";

        /// <summary>
        /// Element's attribute indexer
        /// </summary>
        /// <param name="attributeName"></param>
        /// <returns></returns>
        [NotAttribute]
        public virtual string this[string attributeName]
        {
            get => this.GetType()
                .GetRuntimeProperties()
                .FirstOrDefault(x => x.GetCustomAttribute<NotAttributeAttribute>() == null
                    & x.Name.ToLower().Equals(attributeName.ToLower().Replace("-", "_")))?
                .GetValue(this) as string;

            set => this.GetType()
                .GetRuntimeProperties()
                .FirstOrDefault(x => x.GetCustomAttribute<NotAttributeAttribute>() == null
                    & x.Name.ToLower().Equals(attributeName.ToLower().Replace("-", "_")))?
                .SetValue(this, value);
        }

        public virtual IEnumerable<(string Key, string Value)> GetAttributes()
                    => this.GetType()
                            .GetRuntimeProperties()
                            .Where(x => x.GetCustomAttribute<NotAttributeAttribute>() == null)
                            .Select(x => (x.Name, x.GetValue(this).ToString()));

        /// <summary>
        /// Element evaluator
        /// </summary>
        /// <param name="source">html source code</param>
        /// <returns></returns>
        internal abstract IEnumerable<(IList<(string key, string value)> attributes, string content)> Evaluate(string source);

        protected IList<(string key, string value)> ResolveAttributes(string target)
            => Regex.Matches(target, AttributeRegex, RegexOption)
                    .Cast<Match>()
                    .Select(k => (k.Groups[AttributeKeyToken].Value, k.Groups[AttributeValueToken].Value))
                    .ToList();
    }
}