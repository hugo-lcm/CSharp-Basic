using _20AtributosEPropriedadesDaClasse;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

Console.WriteLine("-=-=-= atributos e propriedades da classe =-=-=-\n");

/*Através dos atributos de uma classe, nós podemos alterar e recuperar valores de variáveis relacionados à ela.
  Eles são divididos em dois tipos:

  Campos: Campos são simplesmente variáveis, visíveis a partir das instâncias da classe. São variáveis públicas;
  Propriedades: Propriedades são mais sofisticadas, podendo ter um bloco get (utilizado para ler um valor) e um 
  bloco set (utilizado para atribuir um valor). Estes blocos são utilizados para atribuir valores para uma variável 
  privada, mantendo o princípio de encapsulamento.*/

/*Atributos do tipo campo são variáveis públicas. Os atributos são inicializados durante a criação do seu objeto

class Cliente
{
    public int codigo;
    public string nome;
    public bool ativo;
}

Os atributos também podem receber um valor padrão, definido na sua declaração:

class Cliente
{
    public int codigo = 1;
    public string nome = "Fulano da Silva";
    public bool ativo = true;
}
*/

Cliente c1 = new Cliente();
c1.Codigo = 1;
c1.NomeCLiente = "Hugo";
c1.Ativo = true;
Console.WriteLine($"código: {c1.Codigo}\nnome: {c1.NomeCLiente}\nativo: {c1.Ativo.ToString().ToLower()}");

c1.Familiares = new List<string>();
c1.Familiares.Add("Fulano");
c1.Familiares.Add("Beltrano");
c1.Familiares.Add("Ciclano");
foreach (var nome in c1.Familiares)
{
    Console.WriteLine(nome);
}
