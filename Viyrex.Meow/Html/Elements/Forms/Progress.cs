namespace Meow.Html.Elements
{
    using Meow.Html.Infrastructure;

    /// <summary>
    /// Progress Element
    /// </summary>
    public sealed class Progress : NormalElementBase
    {
        public string Max { get; set; }

        public string Value { get; set; }
    }
}