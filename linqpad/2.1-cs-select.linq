<Query Kind="Statements" />

var x = new List<char> { 'x','y','z'};
var z = x.Select(n => n.ToString().ToUpper());
var b = x.Select(n => new { Char = n, ASCII = Convert.ToInt32(n)});
Console.WriteLine(x);
Console.WriteLine(z);
Console.WriteLine(b);
