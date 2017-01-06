namespace Extension_Methods_Delegates_Lambda_LINQ.Problem_7._Timer
{
    using System.Diagnostics;

    public class Timer
    {
        private Stopwatch sw;
        public delegate void TimerDelegate();

        public Timer()
        {
            this.sw = new Stopwatch();
            sw.Start();
        }

        public void DoStuffEveryTSeconds(int t, TimerDelegate stuffToDo)
        {
            if (sw.Elapsed.Seconds > t)
            {
                stuffToDo();
                sw.Restart();
            }
        }
    }
}
