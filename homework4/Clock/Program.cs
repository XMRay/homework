using System;
using System.Threading;

namespace clock
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock myclock=new Clock();
            myclock.c1.go(10,36,0);                      //定时
        }
    }
    public delegate void ClockTick(object sender);
    public delegate void ClockAlarm(object sender);

    public class Clock
    {
        public ClockTime c1 = new ClockTime();
        public Clock()
        {
            c1.clockeventA += alarm;
            c1.clockeventT += tick;
        }
        void tick(object sender)
        {
            Console.WriteLine($"{c1.hour}:{c1.minute}:{c1.second}");
        }
        void alarm(object sender)
        {
            Console.WriteLine("时间到了");
        }
    }
    public class ClockTime
    {
        public int hour { get; set; }
        public int minute { get; set; }
        public int second { get; set; }
        public event ClockTick clockeventT;
        public event ClockAlarm clockeventA;
        
        public void go(int a,int b,int c)
        {
            while (true)
            {
                Thread.Sleep(1000);
                this.second = DateTime.Now.Second;
                this.minute = DateTime.Now.Minute;
                this.hour = DateTime.Now.Hour;
                clockeventT(this);
                doalarm(a,b,c);
            }
        }
        public void doalarm(int a, int b, int c)
        {
            if (a == this.hour&& b == this.minute&& c == this.second)
            {
                clockeventA(this);
            }
        }
    }
}
