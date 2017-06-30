namespace Meow.Html.Elements
{
    using Meow.Html.Infrastructure;

    /// <summary>
    /// FieldSet Element
    /// </summary>
    public sealed class FieldSet : NormalElementBase
    {
        public string Disabled { get; set; }

        public string Form { get; set; }

        public string Name { get; set; }
    }
}