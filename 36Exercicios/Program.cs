using _36Exercicios;

Console.WriteLine("QUESTÃO 1:\n");
//PrimeiraQuestao.CalcularQuantidadeAzulejos();


Console.WriteLine("QUESTÂO 2:\n");
//SegundaQuestao.CalcularImposto();

Console.WriteLine("QUESTÃO 3:");
Produto arroz = new Produto("arroz", 5.5, 10);
Console.WriteLine(arroz.ToString());
arroz.AdicinarEstoque(5);
Console.WriteLine(arroz.ToString());
arroz.RemoverEstoque(10);
Console.WriteLine(arroz.ToString());
