namespace Memoriae.Entities;

public class Deck
{
    public long Id { get; set; }
    public long Owner { get; set; }
    public IEnumerable<long> Cards { get; set; }
    public string Name { get; set; }
}
