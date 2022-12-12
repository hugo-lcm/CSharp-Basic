double CalcIMC(double kg, double m)
{
    return Math.Round(kg / (m * m), 2);
}

double CalcAreaRetangulo(double c, double l)
{
    return Math.Round(c * l, 2);
}

double CalcPerimetroRetangulo(double c, double l)
{
    return Math.Round(((2 * c) + (2 * l)), 2);
}

int[] OrdenaVetorInteiroCrescente(int[] numbers)
{
    int aux;
    //iterando todo o vetor
    for (int i = 0; i < numbers.Length; i++)
    {
        //para cada elemento é iterado os elementos subsequentes para verificar se existe um menor que ele
        for (int j = i + 1; j < numbers.Length; j++)
        {
            //se o elemento da iteração atual (o elemento i) for maior que um subsequente (o elemento j)
            if (numbers[i] > numbers[j])
            {
                //o elemento de menor valor é obtido
                aux = numbers[j];

                //o elemento de maior valor é atribuido na posição no de menor valor
                numbers[j] = numbers[i];

                //e o menor valor é atribuido na posição de maior valor
                numbers[i] = aux;
            }
        }
    }
    return numbers;
}

Console.WriteLine("1) Calcular IMC:\n");

Console.Write("digite seu peso em kg: ");
double peso = double.Parse(Console.ReadLine());
Console.Write("digite sua altura em metros: ");
double altura = double.Parse(Console.ReadLine());
Console.WriteLine($"seu imc é: {CalcIMC(peso, altura)}");


Console.WriteLine("\n2) Calcular area e perimetro de um retangulo:\n");

Console.Write("digite a area do retangulo: ");
double area = double.Parse(Console.ReadLine());
Console.Write("digite a largura do retangulo: ");
double largura = double.Parse(Console.ReadLine());
Console.WriteLine($"a area do retangulo é {CalcAreaRetangulo(area, largura)} | o perimetro é " +
    $"{CalcPerimetroRetangulo(area, largura)}");


Console.WriteLine("\n3) Ordenar um vetor de inteiros:\n");

Console.Write("quantos numeros inteiros vc quer adicionar? ");
int qtd = int.Parse(Console.ReadLine());
if (qtd > 0)
{
    int[] intVetor = new int[qtd];
    for (int i = 0; i < qtd; i++)
    {
        Console.Write($"digite o inteiro da posição {i}: ");
        int num = int.Parse(Console.ReadLine());
        intVetor[i] = num;
    }

    Console.WriteLine("vetor não ordenado:");
    foreach (var item in intVetor)
    {
        Console.WriteLine(item);
    }

    int[] vetorOrdenado = new int[qtd];
    vetorOrdenado = OrdenaVetorInteiroCrescente(intVetor);
    Console.WriteLine("vetor ordenado:");
    foreach (var item in vetorOrdenado)
    {
        Console.WriteLine(item);
    }
}