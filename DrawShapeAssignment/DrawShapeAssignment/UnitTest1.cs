using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using EntityFactory;
using Entities;
using Operation;
using OperationFactory;


namespace DrawShapeAssignment
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Line line = FactoryLineObject.GetLine();
            line.PointOneX = 100;
            line.PointOneY = 100;
            line.PointTwoX = 100;
            line.PointTwoY = 100;
            ILineOperation lineOperation = FactoryLineOperationObject.GetLineOperation();
            lineOperation.DrawingLine(line);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Entities.Rectangle rectangle = FactoryRectangleObject.GetRectagle();
            rectangle.PointOneX = 100.00;
            rectangle.PointOneY = 100.00;
            rectangle.PointTwoX = 100.00;
            rectangle.PointTwoY = 100.00;
            IRectangleOperation rectangleOperation = FactoryRectangleOerationObject.GetRectagleOperation();
            rectangleOperation.DrawingRectangle(rectangle);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Circle circle = FactoryCircleObject.GetCircle();
            circle.CentreX = 100.0;
            circle.CentreY = 100.0;
            circle.Radius = 100.0;
            ICircleOperation circleOperation = FactoryCircleOperationObject.GetCircleOperationObject();
            circleOperation.DrawingCircle(circle);

        }
        //[TestMethod]
        //public void TestMethod4()
        //{
        //    Polygon polygon = FactoryEntity.GetPolygon();
        //    polygon.PointOne = new Point(10, 10);
        //    polygon.PointTwo = new Point(20, 10);
        //    polygon.PointThree = new Point(30, 20);
        //    polygon.PointFour = new Point(20, 30);
        //    polygon.PointFive = new Point(10, 30);
        //    polygon.PointSix = new Point(5, 20);
        //    IPolygonOperation polygonOperation = FactoryService.GetPolygon();
        //    polygonOperation.DrawingPolygon(polygon);
        //}
        [TestMethod]
        public void TestMethod5()
        {
            Circle circle = FactoryCircleObject.GetCircle();
            circle.CentreX = 100.0;
            circle.CentreY = 100.0;
            circle.Radius = 100.0;
            IPolygonOperation polygonOperation = FactoryService.GetPolygon();
            polygonOperation.DrawingPolygon(circle);
        }
        [TestMethod]
        public void TestMethod6()
        {
            Triangle triangle = FactoryEntity.GetTriangle();
            triangle.PointOne = new Point(60, 60);
            triangle.PointTwo = new Point(100, 300);
            triangle.PointThree = new Point(30, 200);
            ITriangleOperation triangleOperation = FactoryService.GetTriangleOperationObject();
            triangleOperation.DrawingTriangle(triangle);
        }
        [TestMethod]
        public void TestMethod7()
        {
            Canvas canvas = new Canvas();
            canvas.XOne = 10;
            canvas.YOne = 20;
            canvas.XTwo = 10;
            canvas.YTwo = 10;
            ICanvasService canvasService = FactoryCanvas.GetCanvas();
            string[,] str = canvasService.DrawingCanvas(canvas);
        }
    }

}
