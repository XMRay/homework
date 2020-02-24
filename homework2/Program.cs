using System;

namespace PrimeNumber
{
    class Program
    {
        //最值函数
        static void M(int aLong,int[] a)
        {
            int max = a[0];
            int min = a[0];
            for (int i = 0; i < aLong; i++)
            {
                if (a[i] > max)
                    max = a[i];                
            }
            for (int i = 0; i < aLong; i++)
            {
                if (a[i] < min)
                    min = a[i];
            }
            Console.WriteLine("最大值：{0}\n最小值：{1}", max, min);
        }             
        //质数因子函数
        static void priN(int a)
        {
            int i = 2;
            int b = a;
            for (; i <= b; i++)
            {
                if (b == i)
                {
                    Console.WriteLine(i);
                    break;
                }
                while (b % i == 0)
                {                               
                    Console.WriteLine(i);
                    b /= i;                   
                }               
            }
        }
        //求和、平均数、最值函数
        static void Values()
        {   Console.WriteLine("输入数据个数上限");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n + 1];
            int aLong = 0;
            Console.WriteLine("输入n个数据或输入0停止输入");
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                if (a[i] == 0)
                {
                    break;
                }
                aLong++;
            }
                int sum = 0;
                int aver = 0;
            
            for (int i = 0; i < aLong; i++)
            {
                sum += a[i];
                aver = sum / aLong;
            }
            Console.WriteLine("总和：{0}\n平均值：{1}", sum,aver);
            M(aLong, a);

        }
        //埃氏筛选
        static void Sel()
        {
            int[] pn = new int[99];
            int n = 0;
            bool[] p = new bool[99];
            for (int i = 2; i < 101; i++)
            {
                if (p[i-2] == false)
                {
                    pn[n] = i;
                    Console.WriteLine(pn[n]);
                    n++;
                    for (int j = 2*i; j < 101; j += i)
                    {
                        p[j-2] = true;
                    }
                }
            }

            Console.WriteLine("输入数据个数上限");
        }

        static void Main(string[] args)
        {
            //质数因子
            //int a = Convert.ToInt32(Console.ReadLine());
            //priN(a);
           
            //求相关值
            //Values();

            //筛选
            //Sel();
        }
    }
    
}
