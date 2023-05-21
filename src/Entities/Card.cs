namespace Memoriae.Entities;

public class Card
{
    public long Id { get; set; }
    public long Owner { get; set; } // User.ID
    public DateTime Created { get; set; }
    public CardContent Content { get; set; }
}

public abstract class CardContent {}

public class CardBasic
{
    public string Front { get; set; }
    public string Back { get; set; }
}
