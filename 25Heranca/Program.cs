using _25Heranca;

Console.WriteLine("-=-=-= herança =-=-=-\n");

/* no C# não existe herança múltipla, ou seja, cada classe só pode ter um pai. Entretanto, 
uma classe pode ter uma ou mais classes filhas.*/

PessoaFisica pf = new PessoaFisica("fulano", 123456789, "centro", "35261258", "ativo", 1);
Console.WriteLine(pf.Incluir());
pf.ShowInfo();