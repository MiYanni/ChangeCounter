namespace ChangeCounter.ObjectOriented.Oop1
{
    internal class Dime : Currency
    {
        static Dime()
        {
            Worth = 10;
            Name = nameof(Dime);
        }
    }
}
