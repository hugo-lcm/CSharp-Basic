using _24SobrecargaDeMetodos;

Console.WriteLine("-=-=-= sobrecarga de métodos =-=-=-\n");

/* no C# pode haver, dentro de uma mesma classe, métodos com nomes iguais, mas com parâmetros 
diferentes. É o que chamamos de sobrecarga de métodos. Basta que a assinatura do método seja 
diferente. A assinatura do método significa a combinação do nome do método e seus parâmetros.
É possível utilizar sobrecarga de métodos para métodos comuns e não somente para construtores.
Sendo os parâmetros diferentes, seja quanto ao tipo ou a quantidade as assinaturas serão diferentes.*/

Conexao c1 = new Conexao();
Console.WriteLine(c1.Conectar());
Console.WriteLine(c1.Conectar("nubank"));
Console.WriteLine(c1.Conectar("nubank", "fulano", "1234"));