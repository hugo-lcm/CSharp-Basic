/*tipos de erros: erros de sintaxe, erro de runtime e erros lógicos
 erros de sintaxe: quando digita errado alguma palavra reservada, o programa não é executado.
 erros de runtime: acontecem quando o programa para de executar, de repente, durante a execução.
                   Chama-se a essa parada de exceção. Erros de runtime acontecem quando alguma coisa
                   interfere na correta execução do código. Ex: conexão a um servidor de banco de dados,
                   pois a aplicação fatalmente não poderá ser executada e o programa, se o erro não for
                   corretamente tratado, irá ser encerrado abruptamente.
 erros lógicos: é o tipo de erro mais difícil de ser tratado, pois é um erro humano. O código funciona
                perfeitamente, mas o resultado está errado. Por exemplo: uma função deve retornar um valor,
                mas o valor retornado está errado; o erro nesse caso se encontra na lógica da função que
                está processando o cálculo.*/

Console.WriteLine("-=-=-= bloco try-catch =-=-=-");

/*try
{
    // código que você faria normalmente
}
catch [(Exception [ex])]
{
    // código que será executado em situação de erro
}*/

try
{
    StreamReader stream = new StreamReader(@"C:\teste.txt");
    string linha;
    while ((linha = stream.ReadLine()) != null)
    {
        // Tratamento da linha lida do arquivo texto
    }
}
catch (IOException)
{
    Console.WriteLine("O arquivo não existe na unidade C");
}
catch (OutOfMemoryException)
{
    Console.WriteLine("Sem memória para criação do buffer");
}
catch (Exception) // qualquer tipo de exceção, so será executado caso nao tenha as exceções dos blocos acima
{
    Console.WriteLine("Erro desconhecido");
}
//catch (Exception ex)
//{
//    Console.WriteLine($"Erro desconhecido: {ex.Message}");
//}

Console.WriteLine("-=-=-= programação defensiva =-=-=-");


/*é a iniciativa do programador de escrever seu código protegendo-o de erros de runtime.
Veja o código do exemplo anterior com um trecho de programação defensiva:*/

try
{
    if (File.Exists(@"C:\teste.txt"))
    {
        StreamReader stream = new StreamReader(@"C:\teste.txt");
        string linha;
        while ((linha = stream.ReadLine()) != null)
        {
            // Tratamento da linha lida do arquivo texto
        }
    }
    else
    {
        Console.WriteLine("O arquivo não existe na unidade C");
    }
}
catch (IOException)
{
    Console.WriteLine("O arquivo não está acessível.");
}
catch (OutOfMemoryException)
{
    Console.WriteLine("Sem memória para criação do buffer");
}
catch (Exception ex)
{
    Console.WriteLine($"Erro desconhecido: {ex.Message}");
}

/*O código acima usa o método File.Exists para verificar se o arquivo existe antes de 
tentar abri-lo, evitando que ocorra uma exceção de IOException caso o arquivo não exista.
O if não é uma estrutura de tratamento de erros porque não previne os erros de runtime, 
no entanto, ele permite técnicas de validação. O ideal, porém, é o uso das duas: tanto 
da programação defensiva como dos blocos Try...Catch.*/