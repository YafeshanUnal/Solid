#region Not Open Closed Principle
public class NotFrog : Amphibian
{
    public void Swim()
    {
        Console.WriteLine("The frog is swimming in water");
    }

    public void Walk()
    {
        Console.WriteLine("The frog is walking on land");
    }
}

public class NotDolphin : Amphibian
{
    public void Swim()
    {
        Console.WriteLine("The dolphin is swimming in water");
    }

    public void Walk()
    {
        Console.WriteLine("The dolphin is walking on land");
    }
}
#endregion


#region Open Closed Principle
public class Frog : IFrog
{
    public void Swim()
    {
        Console.WriteLine("The frog is swimming in water");
    }

    public void Walk()
    {
        Console.WriteLine("The frog is walking on land");
    }
}

public class Dolphin : IDolphin
{
    public void Swim()
    {
        Console.WriteLine("The dolphin is swimming in water");
    }
}
#endregion
