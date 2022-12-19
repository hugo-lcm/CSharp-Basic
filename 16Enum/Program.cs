/*Tipos enumerados são listas de valores constantes cuja representação interna se dá através de números 
    inteiros. Cada constante definida num tipo enumerado mapeia um número inteiro específico, que começa 
    pelo valor inteiro zero (0). Entretanto, esse valor inicial pode ser sobrescrito quando assim 
    especificado na declaração do tipo enumerado*/

/*public enum dia
{
    Domingo,
    Segunda,
    Terca,
    Quarta,
    Quinta,
    Sexta,
    Sabado
};*/

// ou pode-se definir valores específicos

public enum dia : short
{
    Domingo = 7,
    Segunda = 15,
    Terça = 12,
    Quarta = 20,
    Quinta,
    Sexta,
    Sábado
};

/*os elementos a que não foram atribuídos valores são incrementados com o valor do último elemento 
    atribuído. No exemplo, os elementos têm os valores: Domingo = 7, Segunda = 15, Terça = 12, 
    Quarta = 20, e Quinta = 21*/


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("-=-=-= enum =-=-=-\n");

        int x = (int)dia.Quinta;
        Console.WriteLine(x);
    }
}

