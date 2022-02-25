using System;
namespace DEVELOP_CSHARPINTERFACE
{
    interface AAPNA
    {
        void calculateArea(int a, int b);
    }
    class Rectangle : AAPNA
    {
        public void calculateArea(int a,int b)
        {
            int area = a * b;
            Console.WriteLine("Area of Rectangle is :"+area);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Rectangle gow = new Rectangle();
            gow.calculateArea(10000,1234567890);
        }
    }
}
