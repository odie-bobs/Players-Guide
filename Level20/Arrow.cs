namespace Level20;

public class Arrow
{

  public Head Head { get; set; }
  public float Length { get; private set; }
  public Fletching Fletching { get; set; }

  public Arrow(Head head, float length, Fletching fletching)
  {
    Head = head;
    Length = length;
    Fletching = fletching;
  }

  public float GetCost()
  {
    float lengthCost = Length * 0.05f;

    var headCost = Head switch
    {
      Head.Wood => 3,
      Head.Obsidian => 5,
      Head.Steel => 10,
      _ => 0,
    };

    var fletchingCost = Fletching switch
    {
      Fletching.GooseFeathers => 3,
      Fletching.TurkeyFeathers => 5,
      Fletching.Plastic => 10,
      _ => 0,
    };
    return lengthCost + headCost + fletchingCost;

  }
}

public enum Head
{
  Steel,
  Wood,
  Obsidian
}

public enum Fletching
{
  Plastic,
  TurkeyFeathers,
  GooseFeathers,
}

