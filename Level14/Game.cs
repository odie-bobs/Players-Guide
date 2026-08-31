namespace Level14;

public class Game
{
  private int _cityHealth = 15;
  private int _manticoreHealth = 10;
  private int _manticoreLocation;
  private int round;

  public void GetPlayer1Input()
  {
    Console.Write("Player 1, how far away from the city do you want to station the Manticore?: ");
    int.TryParse(Console.ReadLine(), out _manticoreLocation);
  }

  public void GetPlayer2Input()
  {
    Console.Write("Enter desired cannon range: ");
  }
}



