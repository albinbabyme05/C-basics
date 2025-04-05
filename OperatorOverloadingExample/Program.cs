using System;
using System.Collections.Generic;

class Program
{
    class Rectangle
    {
        public int Width = 0;
        public int Height = 0;
        //constructor
        public Rectangle(int width, int height){
            Width = width;
            Height = height;
        }

        /*Changing h efunction of operator when a 'Rectangle' class pass two rectangle type objects,
        and assign its reult to new object */
        public static Rectangle operator +(Rectangle rect1, Rectangle rect2){
            Rectangle rectResult = new Rectangle(rect1.Width + rect2.Width, rect1.Height + rect2.Height);
            return rectResult;
        }
    }
    static void Main()
    {

        Rectangle rect1 = new Rectangle(20, 10);
        Rectangle rect2 = new Rectangle(15, 5);
        Rectangle rectResult = rect1 + rect2;

        System.Console.WriteLine($"'rect1(20, 10)' + 'rect2(15, 5)' = 'rectResult({rectResult.Width},{rectResult.Height})'");
    }
}
