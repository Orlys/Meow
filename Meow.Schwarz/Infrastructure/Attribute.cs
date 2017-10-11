// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public sealed class Attribute : IEquatable<Attribute>
    {
        #region Public Constructors

        public Attribute(string name, string value)
        {
            this.Name = name?.ToLower() ?? throw new ArgumentNullException(nameof(name));
            this.Value = value;
        }

        public Attribute(string name) : this(name, null)
        {
        }

        #endregion Public Constructors

        #region Private Constructors

        private Attribute(KeyValuePair<String, string> pair) : this(pair.Key, pair.Value)
        {
        }

        #endregion Private Constructors

        #region Public Properties

        public bool HasValue => this.Value != null;

        public string Name { get; }

        public string Value { get; set; }

        #endregion Public Properties

        #region Public Methods

        public static string Concat(params Attribute[] propertys)
            => string.Join(" ", propertys ?? new Attribute[0].AsEnumerable());

        public static implicit operator Attribute(KeyValuePair<string, string> pair)
             => new Attribute(pair);

        public static bool operator !=(Attribute left, Attribute right)
            => !left.Equals(right);

        public static bool operator ==(Attribute left, Attribute right)
            => left.Equals(right);

        public bool Equals(Attribute other)
        {
            if (other is Attribute p)
                return p.GetHashCode() == other.GetHashCode();
            return false;
        }

        public override bool Equals(object obj)
        {
            if (obj is Attribute p)
                return p.GetHashCode() == obj.GetHashCode();
            return false;
        }

        public override int GetHashCode() => this.ToString(true).GetHashCode();

        public override string ToString()
                                                                    => this.ToString(false);

        public string ToString(bool simplify)
            => (HasValue) ? (simplify) ? $"{this.Name}" : $"{this.Name}=\"{this.Value}\"" : null;

        #endregion Public Methods
    }
}