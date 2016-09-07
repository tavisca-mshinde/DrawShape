using System;
using Entities;
using DrawShape;

namespace Operation
{
    public class RectangleOperation : IRectangleOperation
    {
        public void DrawingRectangle(Rectangle rectangle,Canvas canvas)
        {
            //System.Windows.Forms.Application.Run(new FormForRectangle(rectangle));
            //throw new NotImplementedException();
            int height = (int)(rectangle.PointTwoY - rectangle.PointOneY);
            int width = (int)(rectangle.PointTwoX - rectangle.PointOneX);
            for (int i=(int)rectangle.PointOneY;i<= rectangle.PointTwoY; i++)
            {
                for(int j=(int)rectangle.PointOneX; j <= rectangle.PointTwoX; j++)
                {
                    if (i == rectangle.PointOneY || i == rectangle.PointTwoX)
                        Console.Write("*");
                    else if (j == rectangle.PointOneX || j == rectangle.PointTwoY)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                    //if(i==rectangle.PointOneY )
                    //Console.Write("*");
                    //if (j == rectangle.PointOneY || j == rectangle.PointTwoY)
                    //    Console.Write("*");
                    //if(j==rectangle.PointOneX || j==rectangle.PointTwoY)
                    //    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}