<Query Kind="VBProgram" />


Private Function fileMap(ByVal myFile As String) As String
	If myFile.Contains("png") Then
		Return "png"
	ElseIf myFile.Contains("jpg") Then
		Return "jpg"
	ElseIf myFile.Contains("bmp") Then
		Return "jpg"
	End If
End Function
	
Private Function fileReduce(ByVal fileNameStateToThisPoint As String, ByVal nextCondition As String) As String
	If fileNameStateToThisPoint = nextCondition Then
		Return fileNameStateToThisPoint
	Else 
		Return "both"
	End If
End Function
Sub Main
	Dim all As String() = {"image.png", "image.jpg", "img2.jpg", "img.bmp"}
	Dim jpgOnly As String() = {"image.jpg", "image.jpg", "img2.jpg"}
	Dim pngOnly As String() = {"image.png", "image.png", "img2.png"}
	Console.WriteLine(both.Select(AddressOf fileMap).Aggregate(AddressOf fileReduce))
	Console.WriteLine(jpgOnly.Select(AddressOf fileMap).Aggregate(AddressOf fileReduce))
	Console.WriteLine(pngOnly.Select(AddressOf fileMap).Aggregate(AddressOf fileReduce))
End Sub
