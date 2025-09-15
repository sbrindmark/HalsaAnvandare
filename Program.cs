namespace HalsaAnvandare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad är ditt namn?");
            string name = Console.ReadLine();
            SayHello(name);
        }
        
        static void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }   

        
    }
}
