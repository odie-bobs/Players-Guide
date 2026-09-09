namespace Level14;

public class Game
{
  private int _cityHealth = 15;
  private int _manticoreHealth = 10;
  private int _manticoreLocation;
  private int _round;
  private bool _running = true;

  private void GetPlayer1Input()
  {
    Console.Write("Player 1, how far away from the city do you want to station the Manticore?: ");
    int.TryParse(Console.ReadLine(), out _manticoreLocation);
    Console.Clear();
  }

  public int GetPlayer2Input()
  {
    Console.Write("Enter desired cannon range: ");
    int.TryParse(Console.ReadLine(), out int target);
    return target;
  }

  public void Start()
  {
    GetPlayer1Input();
    Console.WriteLine("Player 2, it is your turn.");
    while (_running)
    {
      RunRound();
      DetermineWinner();
    }
  }

  private void DetermineWinner()
  {
    string message;

    if (_cityHealth == 0 && _manticoreHealth == 0)
    {
      message = "The Manticore and city of Consolas have settled their diference!";
    }
    else if (_cityHealth <= 0)
    {
      message = "The city of Consolas has ben destroyed by the Manticore!";
    }
    else if (_manticoreHealth <= 0)
    {
      message = "The Manticore has been destroyed! The city of Consolas has been saved!";
    }
    else
    {
      message = string.Empty;
    }

    if (!string.IsNullOrEmpty(message))
    {
      Console.WriteLine(message);
      _running = false;
    }
  }

  public void RunRound()
  {
    ++_round;
    Console.WriteLine("".PadRight(15, '-'));
    DisplayStatus();
    DisplayHitPotential(CalculateCannonDamage());
    var target = GetPlayer2Input();
    FireCannon(target);
    FireTheManticore();
    DisplayHitResult(target);
  }

  private void FireCannon(int target)
  {
    if (target == _manticoreLocation)
      _manticoreHealth -= CalculateCannonDamage();
  }

  private void DisplayHitPotential(int hit)
  {
    Console.WriteLine($"The cannon is expected to deal {hit} damage this round.");
  }

  private void DisplayHitResult(int target)
  {
    if (target > _manticoreLocation)
    {
      Console.WriteLine("That round OVERSHOT the target.");
    }
    else if (target < _manticoreLocation)
    {
      Console.WriteLine("That round  FELL SHORT of the target.");
    }
    else
    {
      Console.WriteLine("That round was a DIRECT hit!");
    }
  }

  private int CalculateCannonDamage()
  {
    if (_round % 5 <= 0 && _round % 3 <= 0)
    { return 10; }
    else if (_round % 5 == 0 || _round % 3 == 0)
    { return 3; }
    else
    { return 1; }
  }
  private void FireTheManticore()
  {
    _cityHealth--;
  }

  private void DisplayStatus()
  {
    Console.WriteLine($"STATUS: Round: {_round} City: {_cityHealth}/15 Manticore: {_manticoreHealth}/10");
  }
}



