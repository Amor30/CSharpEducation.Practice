namespace Task6A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstLeg = 3.0;
            var secLeg = 4.0;
            var hypotenuse = Math.Sqrt(firstLeg * firstLeg + secLeg * secLeg);

            Console.WriteLine("Известны два катета, 3 и 4, найти гипотинузу. Ответ: {0}", hypotenuse);

            secLeg = Math.Sqrt(hypotenuse * hypotenuse - firstLeg * firstLeg);

            Console.WriteLine("Известен катет 3 и гипотинуза 5, найти второй катет. Ответ {0}", secLeg);

        }
    }
}
