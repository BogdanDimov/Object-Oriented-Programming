namespace Extension_Methods_Delegates_Lambda_LINQ.Problem_7._Timer
{
    using System;

    public static class TestTimer
    {
        public static void TimerTest()
        {
            var clock = new Timer();
            Timer.TimerDelegate handler = SayKooKoo;

            while (!Console.KeyAvailable)
            {
                clock.DoStuffEveryTSeconds(1, handler);
            }
        }

        public static void SayKooKoo()
        {
            Console.WriteLine("Koo-Koo, Koo--Koo, KOOO fucking KOOOOO!!!");
            Console.WriteLine("Press any key to stop the cuckoo . . .");
            Console.WriteLine();
        }
    }
}
