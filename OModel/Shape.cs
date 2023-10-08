public abstract class Shape
{
    public abstract double CalculateArea();
    public abstract void Draw();

    // interface vs abstract class
    public void Print()
    {
        Console.WriteLine("Printing...");
    }

    //! Dont think future of the code, think about the current situation
    //? KISS - Keep it simple stupid
}
