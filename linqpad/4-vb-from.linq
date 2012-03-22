<Query Kind="VBStatements" />

Dim lString As List(Of String) = New List(Of String) From {"x", "y", "z"}
Dim result = From f In lString Select f Where f <> "x"
Console.WriteLine(result)