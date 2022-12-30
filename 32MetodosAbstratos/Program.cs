using _32MetodosAbstratos;

Console.WriteLine("-=-=-= métodos abstratos =-=-=-\n");

/* um método abstrato não tem corpo, apenas a declaração do método. Ele é utilizado para 
determinar que as classes que estenderem uma determinada classe pai deverão implementar 
determinado método, porém, a classe pai em si não possui essa implementação. No exemplo 
abaixo foi adicionado 2 métodos abstratos (Alterar e Incluir):

public abstract void Alterar();
public abstract void Incluir();

obs: eles podem ter parâmetros na assinatura

isto significa que as classes derivadas da classe Cliente terão necessariamente que implementar 
estes 2 métodos (Alterar e Incluir), bem como temos que mudar a classe para classe abstrata, 
porque se você tentar compilar o código, ou seja, somente classes abstratas podem conter métodos 
abstratos*/


PessoaFisica pf = new PessoaFisica("fulano", 12345);
Console.WriteLine(pf.Nome);
pf.AlterarNome("ciclano");
Console.WriteLine(pf.Nome);