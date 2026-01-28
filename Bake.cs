namespace Baker
{
    class Bake
    {
        public static int temperature = 25; 
        public static Random num = new Random(); 
        public delegate void BakeDekegate(); 
        public static event BakeDekegate WetStart = null; 
        public static event BakeDekegate WetMessage = null; 

        public static void Baking() 
        {
            Console.WriteLine("Начат процесс нагревания печи."); 

            for (int t = temperature; t < 220; t = temperature) 
            {
                Console.WriteLine($"Температура {t} °C, нагревание...");
                int temper = num.Next(15, 25); 
                temperature += temper; 
            }
            
            WetMessage(); 
            WetStart(); 
        }
    }
}
