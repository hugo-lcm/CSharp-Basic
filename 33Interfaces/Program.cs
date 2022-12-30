Console.WriteLine("-=-=-= interfaces =-=-=-\n");

/* uma interface é uma estrutura que fornece apenas as especificações dos métodos e propriedades. 
Eles são como os métodos abstratos apresentados no tópico de classes abstratas. Ou seja, são 
membros que não fornecem uma implementação padrão. O comportamento desses membros deve ser 
implementado pela classe (ou estrutura – struct) que vier a utilizá-la. A classe que estiver 
utilizando a interface deve implementar o comportamento de todos os membros presentes na interface,
se apenas um membro foi esquecido, o compilador acusará erro.

exemplo de interface com 3 métodos:

interface Cadastros
{
      void Incluir();
      void Alterar();
      void Excluir();
}

os métodos não possuem corpo e nem modificador de acesso. Por padrão, todos os métodos são públicos
(public). Caso outro modificar de acesso seja definido, um erro de compilação será exibido. Mas a 
classe que for implementar esta interface pode definir, além da definição dos métodos, outros 
modificadores de acesso para seus membros.

a implementação desta interface é feita da mesma maneira que uma herança: utiliza-se os dois pontos a
frente do nome da classe para indicar que uma interface está sendo implementada.

class CadastroCliente: Cadastros
{
      public void Incluir()
      {
            //código para incluir Clientes
      }

      public void Alterar()
      {
            //código para alterar Clientes
      }

      public void Excluir()
      {
            //código para excluir Clientes
      }

}

uma interface também pode definir propriedades. Neste caso, não é definido um atributo da propriedade, 
apenas se ela será get e/ou set. Por exemplo:

interface Cadastros
{
      string Status
      {
            get;
      }

      void Incluir();
      void Alterar();
      void Excluir();
}

a interface está definindo uma propriedade somente leitura (possui apenas o get). Assim, quando ela for
implementada pela classe, esta propriedade deverá ser implementada e continuar como somente leitura:

class CadastroCliente: Cadastros
{
      private string status;

      public string Status
      {
            get {  return status; }
      }
      public void Incluir()
      {
            //código para incluir Clientes
      }

      public void Alterar()
      {
            //código para alterar Clientes
      }

      public void Excluir()
      {
            //código para excluir Clientes
      }

}

se nela fosse definido o set, o compilador acusaria erro, pois a interface não permite este tipo de 
implentação
*/