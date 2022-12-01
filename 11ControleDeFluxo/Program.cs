Console.WriteLine("-=-=-= if, else e else if -=-=-=");
bool CompareStrings(string str1, string str2)
{
    if (str1.Length == str2.Length)
    {
        return true;
    }
    else
    {
        return false;
    }
}

string s1 = "phone";
string s2 = "cream";

if (CompareStrings(s1, s2))
{
    Console.WriteLine($"{s1} e {s2} sao do mesmo tamanho");
}
else
{
    Console.WriteLine($"{s1} e {s2} sao de tamanhos diferentes");
}

int n1 = 5;
int n2 = 5;

if (n1 > n2)
{
    Console.WriteLine($"{n1} é maior que {n2}");
}
else if (n1 < n2)
{
    Console.WriteLine($"{n2} é maior que {n1}");
}
else
{
    Console.WriteLine($"{n1} e {n2} sao iguais");
}


var salary = 1250.99;
if (salary < 500)
{
    salary += 50;
}
else if ((salary >= 500) && (salary < 600))
{
    salary += 100;
}
else if ((salary >= 600) && (salary < 700))
{
    salary += 110;
}
else
{
    salary += 250;
}

Console.WriteLine(salary);
Console.WriteLine(salary);


Console.WriteLine("\n-=-=-= switch -=-=-=");

Console.Write("digite um número inteiro positivo: ");
int number = Convert.ToInt32(Console.ReadLine());

switch (number)
{
    case 1:
    case 2:
    case 3: // poderia ser usado <= também
        Console.WriteLine("baixo"); // os 3 case executarão esse código caso number seja 1, 2 ou 3
        break;
    case 4:
    case 5:
    case 6:
        Console.WriteLine("medio");
        break;
    default: // default nao é obrigatório, mas pelo menos 1 case tem que ter
        Console.WriteLine("alto");
        break;
}

Console.WriteLine("\n-=-=-= for -=-=-=");

/*for (inicialização; condição; incremento ou decremento)
{
    // código que será repetido
}*/

for (int i = 0; i <= 5; i++)
{
    Console.WriteLine(i);
}

for (int i = 0; i <= 5; i++)
{
    Console.WriteLine($"iteração número: {i}");
    if (i == 3)
        break; // parar o laço antes que a condição seja falsa
}

for (int i = 0; i <= 5; i++)
{
    Console.WriteLine($"iteração número {i}");
    if (i == 3)
        continue;
    /* A declaração a seguir não será executada quando i==3, porém, o for será "chamado" 
       novamente, incrementando o valor de i */
    Console.WriteLine($"iteração número {i + 2}");
}

Console.WriteLine("\n-=-=-= while -=-=-=");

/* while (condição)
{
      declaração;
} */

int numeroDigitado = 0;
while (numeroDigitado >= 0)
{
    Console.Write("Digite um número: ");
    numeroDigitado = int.Parse(Console.ReadLine());
}

/*do{
      declaração;
} while (condição) */

int numDigitado = -1;
do
{
    Console.Write("Digite um número: ");
    numDigitado = int.Parse(Console.ReadLine());
} while (numDigitado >= 0);