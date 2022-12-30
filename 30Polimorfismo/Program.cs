using _30Polimorfismo;

Console.WriteLine("-=-=-= polimorfismo =-=-=-\n");

/* polimorfismo é a capacidade de um objeto se comportar como outro em tempo de execução. Para 
exemplificar o conceito, observe as classes Pai e Filha para poder enxergar o resultado:

class Pai
{
      public string status;

      public virtual void Imprimir()
      {
            this.status = "imprimir da classe pai";
            Console.WriteLine("imprimir da classe pai");
      }
}

class Filha : Pai
{
      public override void Imprimir()
      {
            this.status = "imprimir da classe filha";
            Console.WriteLine("imprimir da classe filha");
      }
}

observe que na classe Filha sobrescrevemos o método Imprimir da classe Pai. Podemos utilizar 
as duas classes criadas da seguinte maneira:

Pai pai = new Pai();
Filha filha = new Filha();
pai.Imprimir(); // irá escrever "imprimir da classe pai"
filha.Imprimir(); // irá escrever "imprimir da classe filha"

não há nada de diferente no código acima. Mas e no código abaixo?

Pai pai = new Pai();
pai.Imprimir(); // irá escrever "imprimir da classe pai"
pai = new Filha();
pai.Imprimir(); // irá escrever "imprimir da classe filha" 

o código acima funciona! Como a classe Filha estende a classe Pai, nós podemos dizer que objetos 
da classe Filha também podem ser objetos da classe Pai. Repare que nós temos uma definição de uma 
classe mais abstrata (no caso, a classe Pai) que também está representando uma classe mais concreta 
(nesse caso, a classe Filha). Essa habilidade de uma referência à uma classe mais abstrata (uma 
classe que esteja mais próxima ou seja uma super classe) representar também instâncias mais concretas
e específicas (objetos da classe filha) é chamada de polimorfismo.

a sobrecarga que vimos na aula sobre construtores, onde nós tínhamos vários construtores definidos com 
parâmetros diferentes também é um tipo de polimorfismos, onde temos métodos com mesmo nome, mas 
assinaturas diferentes que são distintos entre si.

o polimorfismo é um dos pilares da orientação a objetos. Ele torna o código mais claro e de manutenção
muito mais facilitada.

*/

Veiculo carro = new Carro();
Veiculo moto = new Moto();
carro.Ligar();
moto.Ligar();
carro.Desligar();
moto.Desligar();