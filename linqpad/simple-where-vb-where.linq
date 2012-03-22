<Query Kind="VBStatements" />

	Dim lString As List(Of String) = New List(Of String) From {"x", "y", "z"}
	Dim result = lString.Where(Function(name) name <> "x")
	Console.WriteLine(result)