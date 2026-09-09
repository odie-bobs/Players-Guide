
Chest chestState = Chest.Locked;

while (true)
{
  Console.Write($"The chest is {chestState}. What do you want to do? ");
  var userAction = Console.ReadLine()?.Trim().ToLower();

  switch (chestState)
  {
    case Chest.Locked:
      if (userAction == "unlock")
        chestState = Chest.Unlocked;
      break;
    case Chest.Unlocked:
      if (userAction == "open")
        chestState = Chest.Open;
      else if (userAction == "lock")
        chestState = Chest.Locked;
      break;
    case Chest.Open:
      if (userAction == "close")
        chestState = Chest.Closed;
      break;
    case Chest.Closed:
      if (userAction == "open")
        chestState = Chest.Open;
      else if (userAction == "lock")
        chestState = Chest.Locked;
      break;
  }
}
enum Chest
{
  Locked,
  Unlocked,
  Open,
  Closed
}
