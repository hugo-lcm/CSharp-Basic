Console.WriteLine("-=-=-= keywords this e base =-=-=-\n");

/*
class Pai
{
      public string status = "status da classe Pai";

      public void Imprimir()
      {
            status = "Imprimir da classe Pai";
      }

      public void Imprimir(string status)
      {
            this.status = status;
      }
}

no código acima há 2 métodos com o mesmo nome (Imprimir), mas com parâmetros diferentes 
(sobrecarga de métodos). Observe particularmente a linha no segundo método Imprimir:
this.status = status; Neste caso, estamos obtendo o valor do parâmetro status e atribuindo 
para o status da classe. A palavra-chave this é que está dizendo que status é um atributo 
da classe. Se não fosse utilizado a palavra this estaríamos atribuindo o valor do parâmetro 
para ele mesmo.

a palavra-chave base faz referência a atributos e métodos da classe superior (ou classe pai). 
Por exemplo:

class Filha : Pai
{
      public new string status = "status da classe Filha";

      public new void Imprimir()
      {
            status = "Imprimir da classe filha";
            base.status = status;
      }
}

observe a linha: base.status = status; É nela que estamos atribuindo o status da classe Filha 
para o status da classe Pai. Nós utilizamos a keyword base para acessar membros da classe pai 
à partir das classes filha.
 */
