using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using log4net;
using log4net.Config;

using Entities;
using EntityFactory;
using Operation;
using OperationFactory;
using Validation;

namespace ConsoleDrawShape
{
    class DrawShape
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(DrawShape));
        static void Main(string[] args)
        {
            XmlConfigurator.Configure();
            do
            {
                try
                {
                    Entities.Canvas canvas = new Entities.Canvas();//FactoryRectangleObject.GetRectagle();
                    Console.WriteLine("Enter values for co-ordinates");
                    Console.WriteLine("Enter X co-ordinate for point one");
                    canvas.XOne = Validate.ValidateNumber(Console.ReadLine());
                    Console.WriteLine("Enter Y co-ordinate for point one");
                    canvas.YOne = Validate.ValidateNumber(Console.ReadLine());
                    Console.WriteLine("Enter X co-ordinate for point two");
                    canvas.XTwo = Validate.ValidateNumber(Console.ReadLine());
                    Console.WriteLine("Enter Y co-ordinate for point two");
                    canvas.YTwo = Validate.ValidateNumber(Console.ReadLine());
                    ICanvasService canvasService = FactoryCanvas.GetCanvas();
                    string[,] canvasStorage= canvasService.DrawingCanvas(canvas);

                    

                    Console.WriteLine("enter your choice");
                    Console.WriteLine("1 . line");
                    Console.WriteLine("2 . rectangle");
                    Console.WriteLine("3 . circle");
                    Console.WriteLine("4 . Triangle");
                    Console.WriteLine("5 . Polygon");
                    string choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            Line line = new Line();//FactoryLineObject.GetLine();
                            Console.WriteLine("Enter values for co-ordinates");
                            Console.WriteLine("Enter X co-ordinate for point one");
                            line.PointOneX = Validate.ValidateNumber(Console.ReadLine());
                            Console.WriteLine("Enter Y co-ordinate for point one");
                            line.PointOneY = Validate.ValidateNumber(Console.ReadLine());
                            Console.WriteLine("Enter X co-ordinate for point two");
                            line.PointTwoX = Validate.ValidateNumber(Console.ReadLine());
                            Console.WriteLine("Enter Y co-ordinate for point two");
                            line.PointTwoY = Validate.ValidateNumber(Console.ReadLine());
                            ILineOperation lineOperation = FactoryLineOperationObject.GetLineOperation();
                            lineOperation.DrawingLine(line,canvas);
                            logger.Info("Line with co-ordinate x1 => " + line.PointOneX + " y1 => " + line.PointOneY +
                                " x2 => " + line.PointTwoX + " y2 => " + line.PointTwoY);

                            break;
                        case "2":
                            Entities.Rectangle rectangle = new Entities.Rectangle();//FactoryRectangleObject.GetRectagle();
                            Console.WriteLine("Enter values for co-ordinates");
                            Console.WriteLine("Enter X co-ordinate for point one");
                            rectangle.PointOneX = Validate.ValidateNumber(Console.ReadLine());
                            Console.WriteLine("Enter Y co-ordinate for point one");
                            rectangle.PointOneY = Validate.ValidateNumber(Console.ReadLine());
                            Console.WriteLine("Enter X co-ordinate for point two");
                            rectangle.PointTwoX = Validate.ValidateNumber(Console.ReadLine());
                            Console.WriteLine("Enter Y co-ordinate for point two");
                            rectangle.PointTwoY = Validate.ValidateNumber(Console.ReadLine());
                            IRectangleOperation rectangleOperation = FactoryRectangleOerationObject.GetRectagleOperation();
                            rectangleOperation.DrawingRectangle(rectangle,canvas);

                            logger.Info("Rectangle with co-ordinate x1 => " + rectangle.PointOneX + " y1 => " + rectangle.PointOneY +
                                " x2 => " + rectangle.PointTwoX + " y2 => " + rectangle.PointTwoY);
                            break;
                        case "3":
                            Circle circle = new Circle();//FactoryCircleObject.GetCircle();
                            Console.WriteLine("Enter values for co-ordinates");
                            Console.WriteLine("Enter X co-ordinate for centre");
                            circle.CentreX = Validate.ValidateNumber(Console.ReadLine());
                            Console.WriteLine("Enter Y co-ordinate for centre");
                            circle.CentreY = Validate.ValidateNumber(Console.ReadLine());
                            Console.WriteLine("Enter radius for circle");
                            circle.Radius = Validate.ValidateNumber(Console.ReadLine());
                            ICircleOperation circleOperation = FactoryCircleOperationObject.GetCircleOperationObject();
                            circleOperation.DrawingCircle(circle);
                            logger.Info("Circle with co-ordinate x1 => " + circle.CentreX + " y1 => " + circle.CentreY +
                                " radius => " + circle.Radius);
                            break;
                        case "4":

                            Triangle triangle = new Triangle();//FactoryEntity.GetTriangle();
                            Point point = new Point();
                            Console.WriteLine("Enter values for point one");
                            Console.WriteLine("Enter X co-ordinate for centre");
                            point.X = (int)Validate.ValidateNumber(Console.ReadLine());
                            Console.WriteLine("Enter Y co-ordinate point one");
                            point.Y = (int)Validate.ValidateNumber(Console.ReadLine());
                            triangle.PointOne = point;

                            Console.WriteLine("Enter X co-ordinate point two");
                            point.X = (int)Validate.ValidateNumber(Console.ReadLine());
                            Console.WriteLine("Enter Y co-ordinate point two");
                            point.Y = (int)Validate.ValidateNumber(Console.ReadLine());
                            triangle.PointTwo = point;


                            Console.WriteLine("Enter X co-ordinate point Three");
                            point.X = (int)Validate.ValidateNumber(Console.ReadLine());
                            Console.WriteLine("Enter Y co-ordinate point Three");
                            point.Y = (int)Validate.ValidateNumber(Console.ReadLine());
                            triangle.PointThree = point;


                            ITriangleOperation triangleOperation = FactoryService.GetTriangleOperationObject();
                            triangleOperation.DrawingTriangle(triangle);
                            //Polygon polygon = FactoryEntity.GetPolygon();
                            //polygon.PointOne = new Point(10, 10);
                            //polygon.PointTwo = new Point(20, 10);
                            //polygon.PointThree = new Point(30, 20);
                            //polygon.PointFour = new Point(20, 30);
                            //polygon.PointFive = new Point(10, 30);
                            //polygon.PointSix = new Point(5, 20);
                            //IPolygonOperation polygonOperation = FactoryService.GetPolygon();
                            //polygonOperation.DrawingPolygon(polygon);
                            logger.Info("trangle with co-ordinate x1 => " + triangle.PointOne.X + " y1 => " + triangle.PointOne.Y +
                                " X2 => " + triangle.PointTwo.X + " Y2 => " + triangle.PointTwo.Y +
                                " x3=>  " + triangle.PointThree.X + " Y3 => " + triangle.PointThree.Y);
                            break;
                        case "5":

                            Circle circlep = new Circle();//FactoryCircleObject.GetCircle();
                            Console.WriteLine("Enter values for co-ordinates");
                            Console.WriteLine("Enter X co-ordinate for centre");
                            circlep.CentreX = Validate.ValidateNumber(Console.ReadLine());
                            Console.WriteLine("Enter Y co-ordinate for centre");
                            circlep.CentreY = Validate.ValidateNumber(Console.ReadLine());
                            Console.WriteLine("Enter radius for circle");
                            circlep.Radius = Validate.ValidateNumber(Console.ReadLine());
                            IPolygonOperation polygonOperation = FactoryService.GetPolygon();
                            polygonOperation.DrawingPolygon(circlep);
                            logger.Info("polygon with co-ordinate x1 => " + circlep.CentreX + " y1 => " + circlep.CentreY +
                                " radius => " + circlep.Radius);
                            //Circle circle1 = FactoryCircleObject.GetCircle();
                            //circle1.CentreX = 100.0;
                            //circle1.CentreY = 100.0;
                            //circle1.Radius = 100.0;
                            //IPolygonOperation polygonOperation = FactoryService.GetPolygon();
                            //polygonOperation.DrawingPolygon(circle1);
                            break;
                        //case "6":
                        //    Entities.Canvas canvas = new Entities.Canvas();//FactoryRectangleObject.GetRectagle();
                        //    Console.WriteLine("Enter values for co-ordinates");
                        //    Console.WriteLine("Enter X co-ordinate for point one");
                        //    canvas.XOne = Validate.ValidateNumber(Console.ReadLine());
                        //    Console.WriteLine("Enter Y co-ordinate for point one");
                        //    canvas.YOne = Validate.ValidateNumber(Console.ReadLine());
                        //    Console.WriteLine("Enter X co-ordinate for point two");
                        //    canvas.XTwo = Validate.ValidateNumber(Console.ReadLine());
                        //    Console.WriteLine("Enter Y co-ordinate for point two");
                        //    canvas.YTwo = Validate.ValidateNumber(Console.ReadLine());
                        //    ICanvasService canvasService = FactoryCanvas.GetCanvas();
                        //    canvasService.DrawingCanvas(canvas);

                        //    logger.Info("Rectangle with co-ordinate x1 => " + canvas.XOne + " y1 => " + canvas.YOne +
                        //        " x2 => " + canvas.XTwo + " y2 => " + canvas.YTwo);
                        //    break;
                        default:
                            Console.WriteLine("please check your Input");
                            logger.Error("wrong input Enter by user");
                            break;
                    }
                }
                catch (Exception e)
                {
                    logger.Error(e.Message);
                }
            } while (true);
        }
    }
}
