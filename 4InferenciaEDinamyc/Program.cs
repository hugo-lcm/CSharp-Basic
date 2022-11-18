// inferência
int number1 = 1;
var number2 = 2;
var test = "test";
Console.WriteLine($"{number1}, {number2}, {test}");

// dynamic
dynamic myVar = 2; // ocupa mais espaço na memória
Console.WriteLine(myVar.GetType());
myVar = "test2";
Console.WriteLine(myVar.GetType());