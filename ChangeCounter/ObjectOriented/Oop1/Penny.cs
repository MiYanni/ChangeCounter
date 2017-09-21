namespace ChangeCounter.ObjectOriented.Oop1
{
    internal class Penny : Currency
    {
        static Penny()
        {
            Worth = 1;
            Name = nameof(Penny);
        }
    }
}
