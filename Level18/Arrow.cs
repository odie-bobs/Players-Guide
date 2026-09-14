namespace Level18;

public class Arrow
{
  public Head _head;
  public float _length;
  public Fletching _fletching;

  public Arrow(Head head, float length, Fletching fletching)
  {
    _head = head;
    _length = length;
    _fletching = fletching;
  }

  public float GetCost()
  {
    float lengthCost = _length * 0.05f;

    var headCost = _head switch
    {
      Head.Wood => 3,
      Head.Obsidian => 5,
      Head.Steel => 10,
      _ => 0,
    };

    var fletchingCost = _fletching switch
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
