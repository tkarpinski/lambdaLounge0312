<Query Kind="Statements" />

var x = new List<string> { "x","y","z"};
var z = x.Where(f => f != "x");
var y = from f in x where f != "x" select f;
var a = x.Where(f => f != "x");

Console.WriteLine(z);
Console.WriteLine(y);
Console.WriteLine(a);
