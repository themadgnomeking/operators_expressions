//lambda expression
//squares the maximum number
/*
int[] numbers = { 2, 3, 4, 5, 8, 99 };
var maximumSquare = numbers.Max(x => x * x);
Console.WriteLine(maximumSquare);
*/
//interpolates string
/*
var r = 9.6;
var message = $"The area of a circle with a radius {r} is {Math.PI * r * r:F3}.";
Console.WriteLine(message);
*/

// Query 
/*
var scores = new[] { 90, 97, 78, 68, 85 };
IEnumerable<int> highScoresQuery = 
    from score in scores
    where score > 80
    orderby score descending
    select score;
Console.WriteLine(string.Join(" ", highScoresQuery));
*/

//Operator precedence
/*
var a = 2 + 2 * 2; //output 6
var b = (2 + 2) * 2; //output 8
Console.WriteLine(a);
Console.WriteLine(b);
*/


//***********Arithmetic
/*
Unary (++(increment), --(decrement), +(plus), -(minus))
Binary (*(multiplication), /(division), %(remainder), +(addition), -(subtractions))
*/
int a = 13;
int b = 5;
//int c = 3;
//int d = 5;
//int e = 7;
//int f = 9;

//Unary
/*
Console.WriteLine($"This is referencing a:");
Console.WriteLine(a); // output: 2
Console.WriteLine($"This is a++ for increment: {a++}"); // output: 2
Console.WriteLine(a); // output: 3
Console.WriteLine($"This is ++a for increment: {++a}"); // output: 4

Console.WriteLine(" ");
Console.WriteLine($"This is referencing b:");
Console.WriteLine(b); // output: 4
Console.WriteLine($"This is b-- decrement: {b--}"); // output: 4
Console.WriteLine(b); // output: 3
Console.WriteLine($"This is --b decrement: {--b}"); // output: 2

Console.WriteLine(" ");
int plus_c = (c + 5); // output 8
Console.WriteLine($"c({c}) + 5 = {plus_c}");

Console.WriteLine(" ");
int minus_d = (d - 2); // output 3
Console.WriteLine($"d({d}) - 2 = {minus_d}");
*/
//Unary multiplication
/*
Console.WriteLine(5 * 2);           // output: 10
Console.WriteLine(0.5 * 2.5);       // output 1.25
Console.WriteLine(0.1m * 23.4m);    //output 2.34
*/

//Unary integer division
/*
Console.WriteLine(13 / 5);          // output: 2
Console.WriteLine(-13 / 5);         // output: -2
Console.WriteLine(13 / -5);         // output: -2
Console.WriteLine(-13 / -5);        // output: 2
*/
// to obtain the decimal, use double, float, or decimal on at least one of the variables
Console.WriteLine(13 / 5.0);        // output: 2.6

Console.WriteLine((decimal)a/b);     // output: 2.6