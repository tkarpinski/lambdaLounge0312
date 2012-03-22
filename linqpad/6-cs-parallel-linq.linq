<Query Kind="Statements" />

var source = Enumerable.Range(100, 20000);

// Result sequence might be out of order.
var parallelQuery = from num in source.AsParallel()
					where num % 10 == 0
					select num;

// Process result sequence in parallel
parallelQuery.ForAll((e) => Console.WriteLine(e));

// Or use foreach to merge results first.
foreach (var n in parallelQuery)
{
	Console.WriteLine(n);
}

// You can also use ToArray, ToList, etc
// as with LINQ to Objects.
var parallelQuery2 = (from num in source.AsParallel()
					  where num % 10 == 0
					  select num).ToArray();

// Method syntax is also supported
var parallelQuery3 = source.AsParallel().Where(n => n % 10 == 0).Select(n => n);