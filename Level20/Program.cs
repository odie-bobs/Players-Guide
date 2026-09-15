using Level18;

var arrow1 = new Arrow(Head.Obsidian, .6f, Fletching.Plastic);
Console.WriteLine(arrow1.GetCost());


var arrow2 = new Arrow(Head.Steel, 1f, Fletching.Plastic);
Console.WriteLine(arrow2.GetCost());
