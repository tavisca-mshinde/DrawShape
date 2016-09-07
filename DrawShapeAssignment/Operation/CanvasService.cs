 using System;
using Entities;

namespace Operation
{
    public class CanvasService : ICanvasService
    {
        public string[,] DrawingCanvas(Canvas canvas)
        {
            //int canvasRowEnd = canvas.YTwo + canvas.YOne;
            //int canvasColEnd = canvas.XTwo + canvas.YOne;
            string[,] canvasStorage = new string[canvas.YTwo, canvas.XTwo];
            for (int i = 0; i <= canvas.YTwo; i++)
            {
                
               for (int j = 0; j <= canvas.XTwo; j++)
                    {
                    if (i < canvas.XOne)
                    { 
                        canvasStorage[i, j] = " ";Console.Write(" ");
                    }
                    //Console.WriteLine();
                    else if (j < canvas.YOne)
                    {
                        canvasStorage[i, j] = " ";Console.Write(" ");
                    }
                        
                    else
                    {
                        if (i == canvas.XOne || i == canvas.XTwo)
                        {
                            canvasStorage[i, j] = "*"; Console.Write("*");
                        }
                        else if (j == canvas.YOne || j == canvas.YTwo)
                        {
                            canvasStorage[i, j] = "*"; Console.Write("*");
                        }
                        else
                        {
                            canvasStorage[i, j] = " "; Console.Write(" ");
                        }
                    }
                          
                }
                //}
                Console.WriteLine();
            }
            //int height = (canvas.YTwo - canvas.YOne);
            //int width = (canvas.XTwo - canvas.XOne);
            //for (int i = canvas.YOne; i <= canvas.YTwo; i++)
            //{
            //    for (int j = canvas.XOne; j <= canvas.XTwo; j++)
            //    {
            //        if (i == canvas.YOne || i == canvas.XTwo)
            //            Console.Write("*");
            //        else if (j == canvas.XOne || j == canvas.YTwo)
            //            Console.Write("*");
            //        else
            //            Console.Write(" ");

            //    }
            //    Console.WriteLine();
            //}
            //throw new NotImplementedException();
            return canvasStorage;
        }
    }
}