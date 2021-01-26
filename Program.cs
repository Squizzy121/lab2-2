using System;

namespace Lab2_2
{
    class TSquare
    {
        public int a;
        public int GetSide
        {
            set
            {
                a = value;
            }
            get
            {
                return a;
            }
        }
        public int FindSquare(int side)
        {
            int Square = side * side;
            return Square;
        }
        public int FindPer(int side)
        {
            int per = side + side;
            return  per;
        }
        public void newSquare(int b)
        {
            Console.WriteLine("{0}  {1}  {2}", a, FindPer(a), FindSquare(a));
            Console.WriteLine("{0}  {1}  {2}", b, FindPer(b), FindSquare(b));
        }
        public void CopySquare(TSquare previoussquare)
        {
            a = previoussquare.a;
        }
        public override string ToString()
        {
            string str= "квадрат зі стороною " + a + " периметр дорівнює " + FindPer(a) + " і з площею " + FindSquare(a);
            return str;

        }
        public static TSquare operator +(TSquare a1, int a2)
        {
            return new TSquare { a = a1.GetSide + a2 };
        }
        public static TSquare operator -(TSquare a1, int a2)
        {
            return new TSquare { a = a1.GetSide - a2 };
        }
        public static TSquare operator *(TSquare a1, int a2)
        {
            return new TSquare { a = a1.GetSide * a2 };
        }
    }
    class TCube:TSquare
    {
        public int FindV()
        {
            return a * a * a;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TSquare sq = new TSquare();
            int side= int.Parse(Console.ReadLine()); 
            sq.GetSide = side;
            Console.WriteLine(sq.GetSide);
            
            sq.newSquare(6);
            Console.WriteLine(sq.ToString());

            TSquare sq1 = new TSquare();
            sq1.GetSide = 6;
            TSquare sq3 = sq1 * 3;
            Console.WriteLine(sq3.GetSide);

            TCube sq2 = new TCube();
            sq2.GetSide = 4;
            Console.WriteLine(sq2.FindV());
        }
    }
}
