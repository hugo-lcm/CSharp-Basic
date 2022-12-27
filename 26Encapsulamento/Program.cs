using _26Encapsulamento;
using System.Security.Cryptography;

Console.WriteLine("-=-=-= encapsulamento =-=-=-\n");

/* um membro protected é visível dentro da classe em que foi criada, nas classes derivadas, 
mas não é visível nas instâncias da classe.*/

PessoaJuridica pj = new PessoaJuridica("fulano", 1, 10001);
Console.WriteLine(pj.Status);
pj.Incluir();
Console.WriteLine(pj.Status);