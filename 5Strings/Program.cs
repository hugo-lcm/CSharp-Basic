using System.Text;

string str = "test"; // strings são imutáveis
string str2 = str.Substring(0,2); // pega a partir da posição 0, 2 caracteres
Console.WriteLine(str2);
Console.WriteLine("ab\ncd"); // quebra de linha
Console.WriteLine("ab\tcd"); // tabulação
Console.WriteLine("ab\\cd"); // printar /
Console.WriteLine(@"ab\ncd"); // com @, o \n é ignorado
Console.WriteLine($"str: {str}, str2: {str2}"); // string interpolation

// stringbuilder
var firstName = "Hugo";
var lastName = "Leonardo";
StringBuilder sb = new StringBuilder();
sb.Append(firstName);
sb.Append(" ");
sb.Append(lastName);
Console.WriteLine(sb.ToString());