internal class Animal
{
    public virtual void FazerSom()
    {
        Console.WriteLine("O animal faz um som");
    }
}

internal class Cachorro : Animal
{
    public override void FazerSom()
    {
        Console.WriteLine("Au au!");
    }
}


internal class Gato : Animal
{
    public override void FazerSom()
    {
        Console.WriteLine("Miau!");
    }
}

