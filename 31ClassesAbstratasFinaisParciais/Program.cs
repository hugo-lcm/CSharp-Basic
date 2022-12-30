using _31ClassesAbstratasFinaisParciais;

Console.WriteLine("-=-=-= classes abstratas, finais e parciais =-=-=-\n");

/* uma classe abstrata é uma classe que não pode ser instanciada, servindo apenas de base para 
outras classes a extenderem. Ela não pode ser instanciada e se tornar um objeto. Pense no 
exemplo anterior com as classes Cliente e Fisica. Você não poderia simplesmente ter um objeto 
Cliente dentro de sua aplicação: ele precisaria ser do tipo Fisica ou Juridica, pois Cliente 
sozinho não existe. Então, o correto seria marcar a classe Cliente como abstrata. Para 
transformar a classe Clientes em abstrata, basta utilizar a palavra-chave abstract antes 
do nome da classe.Se tentarmos instanciar esta classe ocorrerá um erro de sintaxe indicando 
que classes abstratas não podem ser instanciadas.

public abstract class Cliente
{
      // demais códigos da classe Cliente
}
*/

PessoaFisica pf = new PessoaFisica(12345);
pf.Incluir();
pf.Excluir();
PessoaJuridica pj = new PessoaJuridica(67890);
pj.Incluir();
pj.Excluir();

/* uma classe final não pode ser herdada, ou seja, não pode conter classes derivadas. Basta 
utilizar a palavra-chave sealed. Por exemplo:

public sealed class Pai
{
      public string status;

      public virtual void Imprimir()
      {
            status = "Imprimir da classe Pai";
      }
}
 
agora nenhuma classe poderá estendendo a classe Pai

uma classe parcial é uma classe em que ao invés de se utilizar um único arquivo físico, se 
utiliza 2 ou mais arquivos. Para criar a classe parcial basta utilizar a palavra-chave 
partial. Exemplo:

// Arquivo Parcial1.cs public partial class Parcial
{
      public void funcao1() { }
}
// Arquivo Parcial2.cs public partial class Parcial
{
      public void funcao2() { }
}

cada fragmento da classe Parcial poderia estar em um arquivo de código-fonte diferente. Agora, 
quando instanciar a classe, os dois métodos estarão disponíveis mesmo estando em arquivos 
diferentes.

este recurso não é tão utilizado, mas, pode servir para auxiliar na separação e organização 
de códigos-fontes. Por exemplo: quando criarmos um projeto no Visual Studio do tipo Windows 
Forms, o Visual Studio utiliza classes parciais para organizar o código referente a um Windows 
form: um arquivo que é o <nome do form>.designer.cs, onde existe o código para criar os 
componentes visuais e para exibi-los; e o <nome do form>.cs, onde ficam os códigos com os 
eventos dos componentes visuais que temos em nosso form.
 
 */