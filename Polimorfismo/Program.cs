using Polimorfismo.Exercicios.Ex1Saudacao;
using Polimorfismo.Exercicios.Ex2Calculadora;
using Polimorfismo.Exercicios.Ex3Instrumento;

Console.WriteLine("=== Exemplos\n");
PolimorfismoExemplo poli = new PolimorfismoExemplo();

poli.Somar(2.5, 3.7);

poli.Somar(2, 3, 5);


Animal a = new Animal();
a.FazerSom();

Cachorro c = new Cachorro();
c.FazerSom();

Gato g = new Gato();
g.FazerSom();


Console.WriteLine("\n=== Ex.1 Saudação");
Saudacao s = new Saudacao();

s.Cumprimentar();
s.Cumprimentar("Ana");
s.Cumprimentar("Bruno", 25);


Console.WriteLine("\n=== Ex.2 Calculadora de Área");
CalculadoraDeArea calc = new CalculadoraDeArea();

Console.WriteLine($"Quadrado: {calc.CalcularArea(4)}");
Console.WriteLine($"Retângulo: {calc.CalcularArea(3, 5)}");


Console.WriteLine("\n=== Ex.3 Instrumento e Violão (sobrescrita)");
Instrumento instrumento = new Instrumento();
Violao violao = new Violao();

instrumento.Tocar();
violao.Tocar();