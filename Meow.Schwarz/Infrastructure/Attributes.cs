// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz.Infrastructure
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    public sealed class Attributes : IEquatable<Attributes>, IEnumerable<Attribute>
    {
        #region Internal Constructors

        internal Attributes() : this(default)
        {
        }

        internal Attributes(IDictionary<string, string> attributes)
        {
            if (attributes is IDictionary<string, string> attrs)
            {
                this._attributes = new Dictionary<string, string>();
                this.Data = new Data();
                foreach (var a in attrs)
                {
                    if (Data.IsDataAttribute(a.Key))
                        this.Data.Add(a.Key, a.Value);
                    else
                        this._attributes.Add(a);
                }
            }
            else
            {
                this._attributes = new Dictionary<string, string>();
                this.Data = new Data();
            }
        }

        #endregion Internal Constructors

        #region Private Fields

        private readonly IDictionary<string, string> _attributes;

        #endregion Private Fields

        #region Public Properties

        public Data Data { get; }

        #endregion Public Properties

        #region Public Indexers

        public string this[string name]
        {
            get
            {
                if (Data.IsDataAttribute(name))
                    return this.Data[name];
                else
                    return this._attributes.FirstOrDefault(x => string.Equals(x.Key, name.Replace('_', '-'), StringComparison.CurrentCultureIgnoreCase)).Value;
            }

            set
            {
                if (Data.IsDataAttribute(name))
                    this.Data.Add(name, value);
                else
                    this.Add(name, value);
            }
        }

        #endregion Public Indexers

        #region Public Methods

        public void Add(string name, string value)
            => this._attributes[name.Replace('_', '-')] = value;

        public void Delete(string name)
            => this._attributes.Remove(name.Replace('_', '-'));

        public bool Equals(Attributes other)
            => other._attributes.Except(this._attributes).Count() == 0;

        public string Format()
        {
            var x = this.Concat(this.Data).OrderBy(v => v.Name).ToArray();
            if (x.Length == 0)
                return "";
            else
                return " " + Attribute.Concat(x);
        }

        public IEnumerator<Attribute> GetEnumerator()
        {
            return _().OrderBy(x => x.Name).GetEnumerator();
            IEnumerable<Attribute> _()
            {
                foreach (var item in this.Data)
                    yield return item;
                foreach (var item in this._attributes)
                    yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
            => this.GetEnumerator();

        public IDictionary<string, string> ToDictionary()
        {
            return _().OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            IEnumerable<KeyValuePair<string, string>> _()
            {
                foreach (var item in this.Data)
                    yield return new KeyValuePair<string, string>(item.Name, item.Value);

                foreach (var item in this._attributes)
                    yield return item;
            }
        }

        #endregion Public Methods

        #region Internal Methods

        internal static Attributes Resolve(string s)
        {
            try
            {
                var attrs = new Dictionary<string, string>();
                s = s.Trim();
                int i = 0;
                while (s.Length > 0)
                {
                    if (s[i] == '=')
                    {
                        var key = s.Substring(0, i++);

                        var token = s[i];
                        if (token == '\'' || token == '"')
                        {
                            var end = s.IndexOf(token, ++i);
                            var value = s.Substring(i, end - i);
                            attrs.Add(key, value);
                            s = s.Remove(0, key.Length + value.Length + 3);
                        }
                        i = 0;
                    }
                    else if (s[i] == ' ')
                    {
                        var key = s.Substring(0, i++);
                        s = s.Remove(0, key.Length).Trim();
                        if (!string.IsNullOrWhiteSpace(key))
                            attrs.Add(key, string.Empty);
                        i = 0;
                    }
                    else
                        i++;
                }
                return new Attributes(attrs);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                Debug.WriteLine(s);
                return new Attributes();
            }
        }

        #endregion Internal Methods
    }

    public sealed class Data : IEnumerable<Attribute>
    {
        #region Internal Constructors

        internal Data() : this(null)
        {
        }

        internal Data(IDictionary<string, string> data)
        {
            this._data = data ?? new Dictionary<string, string>();
            foreach (var item in _data)
                this.Add(item.Key, item.Value);
        }

        #endregion Internal Constructors

        #region Internal Fields

        internal const string TOKEN = "data-";

        #endregion Internal Fields

        #region Private Fields

        private readonly IDictionary<string, string> _data;

        #endregion Private Fields

        #region Public Indexers

        public string this[string name]
        {
            get => this._data.FirstOrDefault(x => string.Equals(this.PreprocessName(x.Key), this.PreprocessName(name), StringComparison.CurrentCultureIgnoreCase)).Value;
            set => this.Add(name, value);
        }

        #endregion Public Indexers

        #region Public Methods

        public void Add(string name, string value)
            => this._data[this.PreprocessName(name)] = value;

        public IEnumerator<Attribute> GetEnumerator()
            => this._data.Select(x => (Attribute)x).GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

        #endregion Public Methods

        public void Remove(string name)
            => this._data.Remove(this.PreprocessName(name));

        internal static bool IsDataAttribute(string name)
            => name.ToLower().StartsWith(TOKEN);

        private string PreprocessName(string name)
        {
            var n = name.ToLower().Replace('_', '-');
            if (n.StartsWith(TOKEN))
                return name;
            else
                return TOKEN + name.TrimStart('-');
        }
    }
}