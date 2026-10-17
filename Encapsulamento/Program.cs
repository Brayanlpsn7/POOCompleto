using Encapsulamento;
Console.WriteLine("=== Ex.1 Contador de Visitas");
ContadorDeVisitas contador = new ContadorDeVisitas();

contador.RegistrarVisita();
contador.RegistrarVisita();
contador.RegistrarVisita();

Console.WriteLine($"Total de visitas: {contador.ObterTotal()}");

//===
Console.WriteLine("\n=== Ex.2 Boletim");

Boletim boletim1 = new Boletim();
boletim1.Aluno = "Ana";

boletim1.DefinirNota(8.5);
boletim1.DefinirNota(15);

Console.WriteLine($"{boletim1.Aluno}: nota {boletim1.ObterNota()}");

