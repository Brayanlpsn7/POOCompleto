using Heranca;
using Heranca.ex1Animal;
using Heranca.ex2Func;

Console.WriteLine("Exemplo");
Aluno aluno = new Aluno();

aluno.Idade = 20;
aluno.Nome = "Vinicio";

aluno.Apresentar();

Console.WriteLine("\n=== Ex.1 Animal e cachorro");

Cachorro cachorro = new Cachorro();
cachorro.Nome = "Rex";

cachorro.Comer();
cachorro.Latir();

//
Console.WriteLine("\n=== Ex.2 Funcionário e Gerente");

Funcionario ana = new Funcionario("Ana", 3000);
Gerente carlos = new Gerente("Carlos", 5000, 1500);

Console.WriteLine($"{ana.Nome}: R$ {ana.Salario:F2}");
Console.WriteLine($"{carlos.Nome}: R$ {carlos.Salario:F2} + bônus = R$ {carlos.SalarioComBonus():F2}");