Console.WriteLine("-=-=-= arrays =-=-=-\n");

// formas de inicializar um array
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
int[] arrInt = new int[2] { 0, 1 };
int[] arrInt2 = new int[] { 0, 1 };
int[] arrInt3 = { 0, 1 };
int[] arrInt4;
int[] arrInt5 = new int[10];

// inserindo e acessando valores
arrInt5[0] = 1;
arrInt5[9] = 10;
Console.WriteLine($"primeiro valor: {arrInt5[0]} | último valor: {arrInt5[9]}");

foreach (var item in numbers)
{
    Console.WriteLine(item);
}

int[] intArr6 = new int[10];
for (int i = 0; i <= 9; i++)
{
    intArr6[i] = i + 1;
    Console.WriteLine(intArr6[i]);
}

// arrays como objetos
Console.WriteLine();
Console.WriteLine($"tamanho: {numbers.Length}");
Console.WriteLine($"dimensões: {numbers.Rank}");
Array.Reverse(numbers, 1, 2); // inverse so os elementos do indice 1 e 2
foreach (var item in numbers)
{
    Console.Write(item);
}
Array.Reverse(numbers);
Console.WriteLine();
foreach (var item in numbers) // inverte todo o array
{
    Console.WriteLine(item);
}

Console.WriteLine("-=-=-= matrizes multidimensionais =-=-=-\n");

int[,] x = new int[4, 2]; // matriz com 4 linhas e 2 colunas

x[0, 0] = 2;
x[0, 1] = 4;
x[1, 0] = 6;
x[1, 1] = 8;
x[2, 0] = 10;
x[2, 1] = 12;
x[3, 0] = 14;
x[3, 1] = 16;

int[,] x2 = { { 2, 4 }, { 6, 8 }, { 10, 12 }, { 14, 16 } }; // mesma matriz anterior mas com diferente inicialização

Console.WriteLine($"primeira posição da primeira linha: {x2[0, 0]}");
Console.WriteLine($"última posiçõ da última linha: {x2[3, 1]}");

// inserindo valores
int[,] minhaMatriz = new int[2, 4];
int numero = 0;
for (int linha = 0; linha <= 1; linha++)
{
    for (int coluna = 0; coluna <= 3; coluna++)
    {
        minhaMatriz[linha, coluna] = numero;
        numero++;
    }
}

// acessando
for (int linha = 0; linha <= 1; linha++)
{
    for (int coluna = 0; coluna <= 3; coluna++)
    {
        Console.WriteLine($"minhaMtriz[{linha}, {coluna}] = {minhaMatriz[linha, coluna]}");
    }
}

Console.WriteLine($"quantidade de dimensões: {minhaMatriz.Rank}");