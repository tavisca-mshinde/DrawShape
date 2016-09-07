using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entities;
using DrawShape;

namespace Operation
{
  public class LineOperation: ILineOperation
    {
       public void DrawingLine(Line line,Canvas canvas)
        {
            //if(line.PointOneX==line.PointTwoX)
            //{
            //    for (int i = line.PointOneY; i <= line.PointTwoY; i++)
            //        Console.Write("*");
            //}
            //else if (line.PointTwoY == line.PointOneY)
            //{
            //    for(int )
            //}
            //int height = line.PointTwoX - line.PointOneX+1; //(int)(rectangle.PointOneX + rectangle.PointTwoY);
            //int width = line.PointTwoY - line.PointOneY+1;//(int)(rectangle.PointOneY + rectangle.PointTwoX);
            

            for (int i = 0; i <= line.PointTwoX; i++)
            {
                for (int j = 0; j <= line.PointTwoY; j++)
                {
                    if (j < line.PointOneY)
                        Console.Write(" ");
                    else if (i < line.PointOneX)
                        Console.Write(" ");
                    else
                    {
                        if (i == j)
                        {
                            Console.Write("*");
                        }
                        else
                            Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            //double dY = endRow - startRow;
            //double dX = endColumn - startColumn;
            //double slope = dX / dY;
            //slope = Math.abs(slope);

            //if (slope >= 1)
            //{
            //    double progress = -(dY / dX);
            //    for (int i = startColumn; i <= endColumn; i++)
            //    {
            //        double j = startRow - (int)((i - startColumn) * progress);
            //        int yLoc = (int)(Math.round(j * 100.0) / 100.0);

            //        mPixels[i][yLoc] = '*';
            //    }
            //}
            //Application.Run(new FormLine(line));
        }
    }
}
