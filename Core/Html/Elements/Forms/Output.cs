namespace Meow.Html.Elements
{
    using Meow.Html.Infrastructure;

    /// <summary>
    /// Output Element
    /// </summary>
    public sealed class Output : NormalElementBase
    {
        public string For { get; set; }

        public string Form { get; set; }

        public string Name { get; set; }
    }
}