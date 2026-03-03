namespace Hleb
{
    public static class Pech
    {
        public static int temp { get; set; } = 10;
        public static int vlazh { get; set; } = 60;

        public static void Gotovka()
        {
            Random rnd = new Random();
            while (temp < 220)
            {
                int randVlazh = rnd.Next(5, 10);
                int randTemp = rnd.Next(10, 25);
                Console.WriteLine($"Прошло 10 минут. Температура повышается на {randTemp} градусов.");
                temp += randTemp;
                Console.WriteLine($"Всего {temp} градусов.");
                vlazh -= randVlazh;
                Console.WriteLine($"Уровень влажности {vlazh}.");
                if (vlazh <= 20)
                {
                    Pekar.DobPar(); 
                }
            }
            if (temp >= 220)
            {
                Pekar.HlebInPech(); 
            }
        }
    }
}
