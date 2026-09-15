namespace Level19;

public class Arrow
{
  private Head _head;
  private float _length;
  private Fletching _fletching;

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

  public Head GetHead() => _head;
  public void GetHead(Head head)
  {
    _head = head;
  }

  public Fletching GetFletching() => _fletching;
  public void GetFletching(Fletching fletching)
  {
    _fletching = fletching;
  }

  public float GetShaftLength() => _length;

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
}
