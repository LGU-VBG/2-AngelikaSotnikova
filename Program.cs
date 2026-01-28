namespace Baker
{
    class Program
    {
        delegate void Lambda();
        static void Main(string[] args)
        {
            Bake.WetMessage += BakeIsReady;
            Bake.WetStart += WetLevel;

            Bake.Baking(); 
        }

        static void WetLevel() 
        {
            int wet = 60; 
            Random num = new Random();

            for (int mins = 0; mins < 12; mins++) 
            {
                if (wet > 20)
                {
                    int wt = num.Next(5, 10);
                    wet -= wt;

                    Console.WriteLine($"Идет процесс выпечки, текущая влажность {wet}%. ");
                }
                else
                {
                    Console.WriteLine("Низкая влажность, подача пара...");
                    wet = 50;
                }
            }
        }
        static void BakeIsReady() 
        {
            Lambda stroka = () => Console.WriteLine("Температура достигнута, печь готова к работе, влажность 60%.");
            stroka();
        }
    }
}
