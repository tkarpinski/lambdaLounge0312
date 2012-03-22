require('./linq.js');

var fileMap = function(myFile)
{
    if (myFile.indexOf("png") > 0) {
	    return "png";
    }
    else if (myFile.indexOf("jpg") > 0) { 
        return "jpg";
    }
    else if (myFile.indexOf("bmp") > 0) {
        return "bmp";
    }
    else
        return "oops";
};
	
var fileReduce = function( fileNameStateToThisPoint,nextCondition)
{
	if (fileNameStateToThisPoint === nextCondition)
    {
		return fileNameStateToThisPoint;
    }
	else
    {
		return "all";
    }
};

var all  = ["image.png", "image.jpg", "img2.jpg", "img.bmp"];
var jpgOnly = ["image.jpg", "image.jpg", "img2.jpg"];
var pngOnly  = ["image.png", "image.png", "img2.png"];
console.log(Enumerable.From(all).Select(fileMap).Aggregate(fileReduce));
console.log(Enumerable.From(jpgOnly).Select(fileMap).Aggregate(fileReduce));
console.log(Enumerable.From(pngOnly).Select(fileMap).Aggregate(fileReduce));