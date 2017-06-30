namespace Meow.Html.Elements
{
    using Meow.Html.Infrastructure;

    /// <summary>
    /// Meter Element
    /// </summary>
    public sealed class Meter : NormalElementBase
    {
        public string Form { get; set; }
        public string High { get; set; }
        public string Low { get; set; }
        public string Max { get; set; }
        public string Min { get; set; }
        public string Optimum { get; set; }
        public string Value { get; set; }
    }
}