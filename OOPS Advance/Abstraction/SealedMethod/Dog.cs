namespace SealedMethod;

public class Dog : Animal
{
    public new void makeSound()
    {
        System.Console.WriteLine("Bow Bow");
    }
}