class ImageBag
{
    public enum Status
    {
        Skipped,
        Processed
    }
    public Status ImageStatus { get; set; }
    public int Id { get; set; }
    public string Source { get; set; }
    public override string ToString() => $"[{Id.ToString().PadLeft(3,'0')}] '{Source}' is {ImageStatus}";
}
