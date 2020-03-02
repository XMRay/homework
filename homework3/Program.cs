using System;

namespace ConsoleApp1
{
    public interface Shape
    {
        string showArea();
        void setValue();
        void isShape();
        double Area { get; set; }
        bool isS { get; set; }

        //double value { get; set; }
    }
    public class Rec : Shape
    {
        private double length;
        private double weigth;
        private double area=0;
        private bool iss=false;

        public bool isS
        {
            get => iss;
            set => iss = value;
        }
        public double Area 
        {
            get => area;
            set => area = value;
        }
        public double Length
        {
            get => length;
            set => length = value;
        }
        public double Weigth
        {
            get => weigth;
            set => weigth = value;
        }

        public void setValue()
        {           
            this.isS = false;
            while (!isS)
            {
                Console.WriteLine("输入长和宽");
                this.Length = Convert.ToInt32(Console.ReadLine());
                this.Weigth = Convert.ToInt32(Console.ReadLine());
                this.isShape();
            }
        }
        public void isShape()
        {
            if (length > 0 && weigth > 0)
            {
                this.isS = true;
            }
            else
            {                
                Console.WriteLine("输入的数字无法组成矩形");
                this.isS = false;
            }
        }
        public string showArea()
        {           
             this.Area = length * weigth;
             return "面积为"+ this.Area + "\n";            
        }
    }
    public class Square : Shape
    {
        private double side;
        private double area=0;
        private bool iss = false;

        public bool isS
        {
            get => iss;
            set => iss = value;
        }

        public double Area
        {
            get => area;
            set => area = value;
        }
        public double Side
        {
            get => side;
            set => side = value;
        }
        public void setValue()
        {
            this.isS = false;
            while (!isS)
            {
                Console.WriteLine("输入边长");
                this.Side = Convert.ToInt32(Console.ReadLine());
                this.isShape();
            }
        }
        public void isShape()
        {
            if (side>0)
            {
                this.isS = true;
            }
            else
            {
                Console.WriteLine("输入的数字无法组成正方形");
                this.isS = false;
            }

        }
        public string showArea()
        {
            this.Area = side *side;
            return "面积为" + this.Area + "\n";
        }
    }
    public class Trg : Shape
    {
        private double a;
        private double b;
        private double c;
        private double area = 0;
        private bool iss = false;

        public bool isS
        {
            get => iss;
            set => iss = value;
        }

        public double Area
        {
            get => area;
            set => area = value;
        }
        public double A
        {
            get => a;
            set => a = value;
        }
        public double B
        {
            get => b;
            set => b = value;
        }
        public double C
        {
            get => c;
            set => c = value;
        }

        public void setValue()
        {
            this.isS = false;
            while (!isS)
            {
                Console.WriteLine("输入三边长");
                this.A = Convert.ToInt32(Console.ReadLine());
                this.B = Convert.ToInt32(Console.ReadLine());
                this.C = Convert.ToInt32(Console.ReadLine());
                this.isShape();
            }

        }
        public void isShape()
        {            
            if (a <= 0 || b <= 0|| c<=0 || (!(a + b > c && a - b < c && a + c > b)))
            {
                Console.WriteLine("输入的数字无法组成三角形");
                this.isS = false;
            }
            else
            {
                this.isS = true;
            }            
        }
        public string showArea()
        {

            if (a > 0 && b > 0)
            {
                double p = (a +b +c)/ 2;
                this.Area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));                
                return "面积为" + this.Area + "\n";
            }
            else
            {
                return "输入错误";
            }
        }
    }
    public class Circle : Shape
    {
        const double PI = 3.14159;
        private double radius;
        private double area=0;
        private bool iss = false;

        public bool isS
        {
            get => iss;
            set => iss = value;
        }
        public double Radius
        {
            get => radius;
            set => radius = value;
        }
        public double Area
        {
            get => area;
            set => area = value;
        }
        public void setValue()
        {
            this.isS = false;
            while (!isS)
            {
                Console.WriteLine("输入半径");
                this.Radius = Convert.ToInt32(Console.ReadLine());
                this.isShape();
            }
        }
        public void isShape()
        {
            if (radius > 0)
            {
                this.isS = true;
            }
            else
            {
                Console.WriteLine("输入的数字无法组成圆形");
                this.isS = false;
            }

        }
        public string showArea()
        {
            this.Area = radius * radius * PI;
            return "面积为" + this.Area+"\n";
        }
    }

    public static class IFactory
    {
        //根据需求生产
        public static Shape CreateShape(int sp)
        {
            Shape s = null;
            switch (sp)
            {
                case 1:
                    s = new Rec();
                    break;
                case 2:
                    s = new Square();
                    break;
                case 3:
                    s = new Trg();
                    break;
                case 4:
                    s = new Circle();
                    break;
                default:
                    break;
            }
            return s;
        }
    }
    class Program
    {          
        static void Main(string[] args)
        {
            double area=0;
            int sp;

            Shape[] shapes=new  Shape[10];
            for(int i=0;i<=10; i++)
            {
                Console.WriteLine("选择形状：1矩形 2正方形 3三角形 4圆形 0退出");
                sp = Convert.ToInt32(Console.ReadLine());
                if (sp == 0)
                {
                    break;
                }
                shapes[i] = IFactory.CreateShape(sp);
                shapes[i].setValue();
                Console.WriteLine(shapes[i].showArea());
                area += shapes[i].Area;
            }
            Console.WriteLine("总面积为"+area);
        }
    }   
}
