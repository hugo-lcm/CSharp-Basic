using _23MetodosDasClasses;

Console.WriteLine("-=-=-= métodos das classes =-=-=-\n");


/*método é um termo utilizado para referenciar um procedimento ou uma função, que foi criada dentro 
  de uma classe. No C# todos os procedimentos e funções devem ser criados dentro de classes, portanto
  nós os chamamos de métodos, independente do fato de retornarem ou não um valor.

um método nada mais é do que um bloco de instruções agrupadas e que foi atribuído um nome e que pode ou
não retornar um valor. Eles permitem organizar o código em partes pequenas, especificas para uma certa 
funcionalidade.

exemplo:

class Conexao
{
      public string status = "valor inicial";

      public Conexao()
      {
            status = "construtor padrão";
      }

      public void Conectar()
      {
            status = "conectado com sucesso!";
      }

      public void Desconectar()
      {
            status = "desconectado com sucesso!";
      }
}

Sempre que o método não for do tipo void é necessário que o mesmo retorne um valor compatível com o tipo
do método. Para retornar um valor utilizamos a palavra-chave return:

public bool Conectar()
      {
            status = "conectado com sucesso!";
            return true;
      }

Estes métodos equivalem a funções em algumas outras linguagens. Abaixo tem uma lista de algumas das regras 
básicas para se criar um método:
    os nomes dos métodos devem ser significativos, ou seja: ao nomear um método, não deixar dúvidas sobre
    qual é a sua finalidade;
    utilizar sempre o padrão PascalCase, ou seja, o nome do método começa em maiúscula; já para cada 
    palavra concatenada, a mesma deve iniciar em maiúscula;
    o método deve ter uma finalidade bem específica;
    o método pode ou não retornar um tipo de dados;
    caso não retorne nada, utilizamos a palavra void, antes do nome do método;

*/


Carro c1 = new Carro("uno", 2023);
Console.WriteLine($"modelo: {c1.Modelo}, ano de fabricação: {c1.AnoFabricacao}");

c1.AddAntigoDono("fulano");
c1.AddAntigoDono("ciclano");
c1.AddAntigoDono("beltrano");



foreach (var item in c1.GetAntigosDonos())
{
    Console.WriteLine(item);
}

Console.WriteLine($"o carro tem {Carro.GetIdadeCarro(1970)} anos");

// mudar ordem dos parametros quando for instanciar
Carro c2 = new Carro(modelo: "palio", marca: "fiat");

// construtor anônimo, o compilador vai criar um construtor e passar esses valores
Carro c3 = new Carro
{
    Marca = "chevrolet",
    Modelo = "s10",
    AnoFabricacao = 2016,
    QuantidadePortas = 4,
};
Console.WriteLine($"marca: {c3.Marca}, modelo: {c3.Modelo}, ano fabricãção: {c3.AnoFabricacao}, qtd portas: {c3.QuantidadePortas}");