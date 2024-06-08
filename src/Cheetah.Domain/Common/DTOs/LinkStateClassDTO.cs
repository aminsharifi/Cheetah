namespace Cheetah.Domain.Common.DTOs;

public class LinkStateClassDTO
{
    public string LinkType { get; set; }
    public string FirstType { get; set; }
    public string SecondType { get; set; }
    public string Sd_Status { get; set; }
    public long? FixedId { get; set; }
    public Dictionary<Tuple<long?, string>, bool> FloatState { get; set; }
}