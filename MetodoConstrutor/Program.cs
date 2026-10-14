using MetodoConstrutor;

// === ATALHO p gerar construtor: Ctrl + ponto + GerarConstrutor ===

// Exercício 1: Livro
Console.WriteLine("Exercício 1: Livro");

Livro livro01 = new Livro("\nO Pequeno Príncipe", "Antoine de Saint-Exupéry", 96);
Livro livro02 = new Livro("A hora da Estrela", "Clarice Lispector", 88);

livro01.Exibir();
livro02.Exibir();

// Exercício 2: Viagem
Console.WriteLine("\nExercício 2: Viagem");

Viagem v1 = new Viagem("\nBelo Horizonte", 5, 788.55);
Viagem v2 = new Viagem("Portugal", 7, 1250);

v1.Exibir();
v2.Exibir();

// Exercício 3: Contato (dois métodos construtor)
Console.WriteLine("\nExercício 3: Contato (dois métodos construtor)");

Contato c1 = new Contato("\nBrayan", "(11) 97546-4574", "brayanfake@gmail.com");
Contato c2 = new Contato("Brayan", "(11) 97546-4574");

c1.Exibir();
c2.Exibir();