int SumValues(int num1, int num2)
{
    return num1 + num2;
}

void DisplayResult(int result)
{
    Console.WriteLine(result);
}

var n1 = 10;
var n2 = 10;
DisplayResult(SumValues(n1, n2));

// métodos com número nao fixo de parâmetros
int SumSeveralNumbers(params int[] numbers)
{
    int result = 0;
    foreach (var number in numbers)
    {
        result += number;
    }
    return result;
}

Console.WriteLine(SumSeveralNumbers(10,10,10,10,10));

// exemplo de metodo com params e outro argumento, o params sempre tem que ficar por último
double TestMethod(double n, params int[] numbers)
{
    int result = 0;
    foreach (var i in numbers)
    {
        result += i;
    }
    return result + n;
}

Console.WriteLine(TestMethod(10.5, 10, 10));
Console.WriteLine(TestMethod(10.5)); // se nao passar o params na chamada nao da erro