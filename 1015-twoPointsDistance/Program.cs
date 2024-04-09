/* 1015
-------------
Read the four values corresponding to the x and y axes of two points in the plane, p1 (x1, y1) and p2 (x2, y2) and calculate the distance between them, showing four decimal places after the comma, according to the formula:

Distance = root(x2-x1)^2 + (y2-y1)^2

Input
The input file contains two lines of data. The first one contains two double values: x1 y1 and the second one also contains two double values with one digit after the decimal point: x2 y2.

Output
Calculate and print the distance value using the provided formula, with 4 digits after the decimal point.
*/
var xAxis = Console.ReadLine().Split(' ');

var x1 = Double.Parse(xAxis[0]);
var y1 = Double.Parse(xAxis[1]);

var yAxis = Console.ReadLine().Split(' ');

var x2 = Double.Parse(yAxis[0]);
var y2 = Double.Parse(yAxis[1]);

var distance = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2));
var distanceFormated = distance.ToString("0.0000");

//Console.WriteLine(x1); Console.WriteLine(x2); Console.WriteLine(y1); Console.WriteLine(y2);
Console.WriteLine(distanceFormated);
