namespace Hleb
{
    public static class Pekar
    {
        public static void DobPar()
        {
            Pech.vlazh += 50;
            Console.WriteLine($"Пекарь повысил влажность. Теперь в печи влажность {Pech.vlazh} %");
        }
        public static void HlebInPech()
        {
            Console.WriteLine("Пекарь загружает хлеб");
        }
    }
}
