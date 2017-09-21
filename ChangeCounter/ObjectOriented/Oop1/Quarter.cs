namespace ChangeCounter.ObjectOriented.Oop1
{
    internal class Quarter : Currency
    {
        static Quarter()
        {
            Worth = 25;
            Name = nameof(Quarter);
        }
    }
}
