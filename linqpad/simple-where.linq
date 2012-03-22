<Query Kind="Statements" />

var x = new List<string> { "x","y","z"};
var z = x.Where(f => f == "x");
var y = x.Where(f => f != "x");

Console.WriteLine(z);
Console.WriteLine(y);