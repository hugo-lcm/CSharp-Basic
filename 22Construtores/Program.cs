Console.WriteLine("-=-=-= construtores =-=-=-\n");

/*um construtor é um método que é responsável por “inicializar” uma classe. Na chamada de um método 
  construtor, a memória necessária para armazenamento da nova instância do objeto é alocada.

construtores têm as seguintes características:
    tem o mesmo nome da classe;
    não tem tipo de dados;
    a sintaxe de um construtor é a seguinte:

<modificador de acesso> <nome da classe>([<parâmetros opcionais>])
{
      // Código opcional aqui
}

exemplo:

public class PessoaFisica
{
      public PessoaFisica()
      {
      }
}

o método construtor é chamado quando nós criamos uma instância de uma determinada classe, ou seja, 
quando nós utilizamos o new

você pode inserir quaisquer códigos dentro do método construtor. Por exemplo, você pode querer setar 
valores padrão das propriedades de sua classe. Veja no exemplo abaixo:

public class PessoaFisica
{
      public string Nome { get; set; }
      public int Idade { get; set; }

      public PessoaFisica()
      {
            Nome = "Nome 1";
            Idade = 18;
      }
}
PessoaFisica pf = new PessoaFisica();

os métodos construtores também podem receber parâmetros e utilizá-los dentro do escopo do construtor. 
Veja o exemplo abaixo:

public class PessoaFisica
{
      public string Nome { get; set; }
      public int Idade { get; set; }

      public PessoaFisica()
      {
            this.Nome = "Nome 1";
            this.Idade = 18;
      }

      public PessoaFisica(int idade)
      {
            this.Idade = idade;
      }
}

PessoaFisica pf = new PessoaFisica();
Console.WriteLine($"{pf.idade}"); // 18

PessoaFisica pf2 = new PessoaFisica(20);
Console.WriteLine($"{pf2.Idade}"); // 20

No exemplo acima, você pode perceber que é possível declarar vários construtores recebendo diferentes 
parâmetros para a mesma classe. Isso é possível, desde que cada construtor possua uma declaração 
diferente entre eles, o que se chama assinatura de método. Ou seja: você pode ter dois construtores 
que recebam um parâmetro, desde que o tipo do parâmetro entre eles não se repita. Isso é chamado 
sobrecarga. Veja o exemplo abaixo:

public class PessoaFisica
{
      public string Nome { get; set; }
      public int Idade { get; set; }

      public PessoaFisica()
      {
            this.Nome = "Nome 1";
            this.Idade = 18;
      }

      public PessoaFisica(int idade)
      {
            this.Idade = idade;
      }

      public PessoaFisica(string nome)
      {
            this.Nome = nome;
      }

      public PessoaFisica(int idade, string nome)
      {
            this.Idade = idade;
            this.Nome = nome;
      }

}

// chamando o construtor padrão (sem parâmetros)
PessoaFisica pf = new PessoaFisica();
Console.WriteLine($"{pf.Idade}"); // 18

// chamando o construtor que recebe um único parâmetro do tipo int
PessoaFisica pf2 = new PessoaFisica(20);
Console.WriteLine($"{pf2.Idade}"); // 20

// chamando o construtor que recebe um único parâmetro string
PessoaFisica pf3 = new PessoaFisica("João");
Console.WriteLine($"{pf3.Nome}"); // João

// chamando o construtor que recebe um parâmetro int e outro parâmetro string
PessoaFisica pf4 = new PessoaFisica(22, "Maria");
Console.WriteLine("{pf4.Nome}, {pf4.Idade}"); // Maria, 22

no exemplo acima, vemos que é possível termos vários construtores na mesma classe, cada um recebendo 
parâmetros de maneira diferente. Além disso, vimos a keyword this. Essa keyword representa que estamos 
trabalhando com membros da própria classe onde o this está. Repare em um dos construtores:

public PessoaFisica(int idade, string nome)
{
      this.Idade = idade;
      this.Nome = nome;
}

Veja o uso do this neste construtor. Com ele, estamos sinalizando ao compilador que as propriedades 
Idade e Nome para as quais estamos atribuindo valores fazem referência à própria instância do objeto 
PessoaFisica.

*/