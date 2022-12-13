// úteis quando não sabemos a quantidade de elementos que o usuario vai inserir, já que no array temos que definir
// um tamanho fixo

Console.WriteLine("-=-=-= coleções =-=-=-\n");

/*var numbersList = new List<int>();  // List se compora como um array de alocação dinâmica
bool keepReading = true;
while (keepReading)
{
    Console.WriteLine("digite um número ou sair:");
    string userInput = Console.ReadLine();
    if (userInput.Trim().ToLower().Equals("sair"))
    {
        keepReading = false;
    }
    else
    {
        numbersList.Add(int.Parse(userInput));
    }
}

foreach (var item in numbersList)
{
    Console.WriteLine(item);
}

// alguns metodos comuns entre as collections
numbersList.Remove(5);
numbersList.Clear(); // esvazia a collection
Console.WriteLine(numbersList.IndexOf(2)); // retorn o indice do item, caso ele esteja na collection
numbersList.RemoveAt(2); // remove o elemento no indice especificado*/


Console.WriteLine("\n-=-=-= dictionary =-=-=-\n");

Dictionary<string, string> myDictionary = new Dictionary<string, string>();
myDictionary.Add("palavra1", "significado da palavra1");
myDictionary.Add("palavra2", "significado da palavra2");
foreach (var key in myDictionary.Keys)
{
    Console.WriteLine($"{key}: {myDictionary[key]}");
}

Dictionary<int, string> myDictionry2 = new Dictionary<int, string>();
myDictionry2.Add(1, "numero 1");
myDictionry2.Add(2, "numero 2");
myDictionry2.Add(3, "numero 3");
foreach (var key in myDictionry2.Keys)
{
    Console.WriteLine($"{key}: {myDictionry2[key]}");
}