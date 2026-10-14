using PilaresPOO;
/*Metodo Construtor
 * - Obriga o objeto a ser criado de uma forma que foi definida na Classe
  Evitar estados inválidos */

Carro carro1 = new Carro("Toyota", "Corolla XEi");

Console.WriteLine(carro1.Marca);
Console.WriteLine(carro1.Modelo);


// Encapsulamento
ContaBancaria conta01  = new ContaBancaria();

conta01.Saldo = -500;
conta01.Saldo = 99999999;