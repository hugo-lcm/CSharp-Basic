// conversão explícita
int a;
double b = 10.5;
a = (int)b; // a parte decimal é ignorada
Console.WriteLine(a);

// conversão implícita
long x;
int y = 5;
x = y; // o tipo int cabe dentro de um long
Console.WriteLine(x);

// boxing é pegar uma var que é valueType e armazenar dentro de uma referenceType
int num = 12; // stack
object obj = num; // heap
Console.WriteLine(obj);

// unboxing
int num2 = (int)obj;
Console.WriteLine(num2);