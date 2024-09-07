namespace MainProgam
{
    public class GenericClass<T>
    {
        public T Message;

        public void GenericMethod(T name,T Location)
        {
            Console.WriteLine($"Message: {Message}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Location: {Location}");
        }
    }
}