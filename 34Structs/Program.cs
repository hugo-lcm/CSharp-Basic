using _34Structs;

Console.WriteLine("-=-=-= structs =-=-=-\n");

/* estruturas são tipos abstratos de dados muito semelhantes a classes. Mas diferente destas,
as estruturas não fazem parte da Orientação a Objetos. Elas são um tipo de dado definido pelo 
C#. A diferença mais sensível entre classes e estruturas é que esta última não é alocada na 
memória heap, e os seus valores são diretamente contidos na estrutura; o que equivale a dizer 
que estruturas são value-types e não reference-types. As características mais importantes de 
uma estrutura são:

    não suportam mecanismo de herança.
    são usadas para modelar estruturas de dados pequenas. Os tipos int, double e bool são 
    implementados usando estruturas;
    estruturas implementam Interfaces;
    são tipos valor, portanto são alocadas na pilha e não na memória heap;
    cada variável do tipo estrutura (struct) contém uma cópia dos seus valores e, portanto, 
    ao atribuir uma variável A do tipo struct a outra, B, do mesmo tipo, o que se está 
    fazendo é uma cópia dos valores de A em B; portanto, qualquer modificação em B não 
    alterará os valores de A.

sintaxe da declaração de uma estrutura:

[modificador de acesso] struct <nome da estrutura> : [interface]
{
      //membros da estrutura
}

a sintaxe da declaração da estrutura acima, ela é semelhantemente a uma classe. Assim como estas,
as estruturas podem implementar interfaces, possui construtores, propriedades e método; porém não
possui destrutores, métodos virtuais e os construtores têm de ser customizados. Até a declaração 
de uma variável é parecida com a instanciação da classe, como é possível notar na sintaxe abaixo:

<tipo_struct> identificador = new <tipo_struct>[parâmetros do construtor]

uma vez que a declaração da estrutura é feita, os valores padrão dos seus atributos são configurados
e copiados diretamente na estrutura. Ao contrário das classes, que armazenam referências para áreas 
da memória, a estrutura contém os seus valores.
 
*/
Carro c = new Carro();

Dono donoFulano = new Dono();
donoFulano.Nome = "fulano";
donoFulano.Idade = 24;
Dono donoCiclana = new Dono();
donoCiclana.Nome = "ciclana";
donoCiclana.Idade = 37;

c.AdicionarAntigoDono(donoFulano);
c.AdicionarAntigoDono(donoCiclana);
foreach (Dono i in c.GetAntigosDonos())
{
    Console.WriteLine($"nome: {i.Nome}, idade {i.Idade}");
}