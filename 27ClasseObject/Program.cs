using _27ClasseObject;

Console.WriteLine("-=-=-= classe object =-=-=-\n");

/* toda a classe no C# descende direta ou indiretamente da classe Object. O C# foi projetado 
desta forma de modo que todas as classes tenham um comportamento padrão. Por isso é que em 
qualquer classe criada no C# aparecem estes métodos, provenientes da classe Object. Também 
podemos presumir que qualquer classe que você crie no C# ou que já seja pré-existente é um 
Object

os métodos que são providos pela classe Object e que, consequentemente, todas as classes em 
C# possuem, são:

Equals: método para verificar se um objeto é igual ao outro. Por exemplo, “string”.Equals(“string”) 
nos retornará true, pois ambas strings apresentam o mesmo conteúdo. Porém, com objetos, o método 
Equals age de maneira um pouco mais complexa;
GetHashCode: retorna o código hash que é gerado para cada instância que você cria de um objeto. Este 
hash é único para cada instância e serve para que esta seja identificada internamente;
GetType: retorna o nome completo (full identifier) tipo do objeto em questão. Por exemplo, 
“teste”.GetType() nos retornará “System.String”, pois “teste” é do tipo string;
ToString: método que serve para fazer cast de um objeto para string.*/


string text = "test";
Console.WriteLine("test".Equals(text)); // True
Test t1 = new Test("fulano", "da silva");
Test t2 = new Test("fulano", "da silva");
/*Console.WriteLine(t1.Equals(t2)); // False, mesmo se eles estivessem atributos com mesmo valor, ainda seria falso
Console.WriteLine(t1.Equals(t1)); // True
Test t3 = t1;
Console.WriteLine(t1.Equals(t3)); // True, estão apontando para o mesmo espaço na memória*/

// agora que o .Equals() foi sobrescrito, comparar objetos diferentes mas com mesmos valores de atrubutos vai retornar true
Console.WriteLine(t1.Equals(t2));



Console.WriteLine(t2.GetHashCode());

// Console.WriteLine(t2.ToString()); // antes de sobrescrever: _27ClasseObject.Test

// após sobrescrever o .ToString():
Console.WriteLine(t1.ToString());