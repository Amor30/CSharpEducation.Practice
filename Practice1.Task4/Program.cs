namespace Task4A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первую фразу: ");
            var firstPhrase = Console.ReadLine();

            Console.Write("Введите первую фразу: ");
            var secondPhrase = Console.ReadLine();

            Console.WriteLine(firstPhrase + " " + secondPhrase);
        }
    }
}
