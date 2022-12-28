Console.WriteLine("-=-=-= sobrescrita de métodos =-=-=-\n");

/* pode ocorrer que você necessite criar métodos com o mesmo nome nas classes derivadas, seja 
porque a funcionalidade é diferente ou por ter a necessidade de validações adicionais. No exemplo
anterior, na classe Cliente, o método Excluir é baseado no código. Na classe Fisica, necessitamos 
que o método Excluir seja baseado no CPF do cliente. Isso geraria dois métodos Excluir, um em cada 
classe. Podemos utilizar a keyword new, que explicitamente oculta um membro herdado de uma classe 
base. O código ficaria assim:

class Fisica: Clientes
{
      private int _cpf;

      public int CPF
      {
            get => _cpf;
            set => _cpf = value;
      }

      public new void Excluir()
      {
            status = Cpf + " excluído";
      }
}

agora, o método Excluir da classe Cliente foi ocultado, ou seja, não é mais acessível a partir
da classe Fisica. O único método que é acessível a partir da classe Fisica agora é o método 
Excluir com a implementação que é feita dentro da própria classe. Em nosso caso, agora, você 
só pode excluir pessoas físicas pelo CPF, e não mais pelo código como estava implementado na 
classe Cliente. O método da classe pai foi escondido. Ele existe, mas está escondido.

nós podemos, ao invés de ocultar apenas um método da classe pai, sobrescrever o mesmo na classe 
derivada. Para isso temos de dizer que o método da classe pai é virtual e na classe filha dizer 
que estamos sobrescrevendo um determinado membro. Para isso, utilizamos as palavras chaves virtual 
e override. Por exemplo (códigos parciais):

class Clientes
{
      public virtual void Excluir()
      {
            status = codigo + " excluído.";
      }
}

class Fisica: Clientes
{

      public override void Excluir()
      {
            status = cpf + " excluído";
      }
}

agora, você de fato está sobrescrevendo um método da classe base, ou seja, está o 
substituindo. A principal diferença entre o new e o override é esta: a keyword new 
oculta o membro quando você utiliza sua implementação, mas não o substitui. A keyword 
override de fato substitui a implementação do método da classe pai. É como se você 
estivesse o reescrevendo com uma determinada implementação nas classes filhas e o 
método não existisse mais na classe pai.

Dde preferência utilize override que economiza memória, pois substitui o método da classe 
Pai.

*/