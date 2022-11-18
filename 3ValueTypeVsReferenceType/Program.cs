// passagem por valor
int n1 = 3;
int n2 = n1; // n2 recebe uma cópia de n1, logo o valor de n2 não é alterado quando n1 muda
n1 = 5;
Console.WriteLine($"number 1 = {n1}, number 2 = {n2}"); // 5 3

// passagem por referência
Test t1 = new Test();
t1.Year = 2022;
Test t2 = t1;
t1.Year = 2023;
Console.WriteLine($"t1.Year = {t1.Year}, t2.Year = {t2.Year}"); // 2023 2023


class Test
{
    public int Year;
}