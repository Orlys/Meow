internal class ImageBag
{
    public enum Status
    {
        Skipped,
        Processed
    }

    public int Id { get; set; }
    public Status ImageStatus { get; set; }
    public string Source { get; set; }

    public override string ToString()
        => $"[{this.Id.ToString().PadLeft(3, '0')}] '{this.Source}' is {this.ImageStatus.ToString().ToLower()}";
}