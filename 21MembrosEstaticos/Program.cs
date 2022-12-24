Console.WriteLine("-=-=-= membros estáticos =-=-=-\n");

/*é possível construirmos classes, métodos e propriedades que são estáticas. Quando um membro é estático,
isso significa que não há necessidade de se criar uma instância da classe (ou seja, um objeto) para se 
utilizar aquele membro. Isso ocorre porque não há necessidade de se alocar espaços na memória para a 
utilização dos membros estáticos, ao contrário de quando criamos objetos com o new.

para definirmos membros como estáticos, nós precisamos utilizar a keyword static.Ex:

classe estática:

public static class MinhaClasseEstatica
{
    // métodos e campos da minha classe
}

métodos estáticos:

// declaração da minha classe
public static int Somar(int a, int b)
{
    return a + b;
}

campos estáticos:

public class ClasseTeste
{
    public static int numeroTentativas;
}

alguns pontos relavantes sobre membros estáticos:

classes estáticas são carregadas quando a aplicação é iniciada. Por isso, não é necessário criar instâncias
de classes estáticas para utilizá-las;
como uma classe estática não pode ser “construída” (não utiliza a keyword new para utilização de
classes estáticas), não faz sentido ela conter outros membros que não sejam estáticos em seu interior;
você pode ter campos e métodos estáticos dentro de uma classe que não é estática. Por exemplo, a classe
abaixo é válida:

public class ClasseTeste
{
    public int Codigo { get; set; }
    public static int MaiorDeIdade = 18;

    public int MetodoA()
    {
        // Método A
    }

    public static int MetodoB()
    {
        // Método B
    }
}

para utilizar a classe acima, com métodos estáticos e não-estáticos, pode utilizar o código abaixo:

// para acessar os métodos não-estáticos
ClasseTeste classeTeste = new ClasseTeste();
// MetodoA não é estático e precisa de uma instância para ser utilizado
int a = classeTeste.MetodoA();
// MetodoB é estático e pode ser acessado sem a instância da classe
Int b = ClasseTeste.MetodoB();

mesmo que utilize classes não-estáticas com membros estáticos e crie várias instâncias dessa classe,
os membros estáticos são exatamente os mesmos entre todas as instâncias;
não pode criar herança de classes marcadas como estáticas;

exemplos de situações em que campos estáticos são úteis:

declaração de constantes. Por exemplo: a lei brasileira prevê que, quando alguém completa 18 anos,
passa a ser “maior de idade”. Dessa maneira, podemos criar um campo estático em uma classe para 
fixarmos este valor em nossa aplicação como sendo a idade que representa a maioridade. Ela ficaria 
desta maneira:

public class VerificadorIdade
{
    public static int IdadeMaioridade = 18;
}

para classes que não guardam estado e somente têm métodos utilitários. Por exemplo, uma classe que 
verifica se uma determinada pessoa é “maior de idade”. Ela somente faz isso: ela não tem campos nem 
propriedades, nem guarda nenhum tipo de informação. Ela acaba sendo uma classe para ajudar outras,
uma classe utilitária. Essa classe é uma candidata a ser estática. O código dela poderia ficar assim:

public static class VerificadorMaioridade
{
    public static bool EhMaiorIdade(int idade)
    {
        return idade >= 18;
    }
}

para utilizá-la:

bool ehMaiorDeIdade = VerificadorMaiorIdade.EhMaiorIdade(18);*/