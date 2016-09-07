using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DrawShape
{
    public partial class FormForPolygon : Form
    {
        Entities.Circle circle = EntityFactory.FactoryCircleObject.GetCircle();
        //Entities.Polygon polygon = EntityFactory.FactoryEntity.GetPolygon();
        public FormForPolygon()
        {
            InitializeComponent();
        }
        //public FormForPolygon(Entities.Polygon polygon)
        //{
        //    this.polygon = polygon;
        //    InitializeComponent();
        //}
        public FormForPolygon(Entities.Circle circle)
        {
            this.circle = circle;
            InitializeComponent();
        }
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    Graphics graphics = PolygonPanel.CreateGraphics();
        //    Brush blackpen = new SolidBrush(Color.Black);
        //    Pen pen = new Pen(blackpen, 1);
        //    Point[] point = new Point[6];
        //    point[0] = polygon.PointOne;
        //    point[1] = polygon.PointTwo;
        //    point[2] = polygon.PointThree;
        //    point[3] = polygon.PointFour;
        //    point[4] = polygon.PointFive;
        //    point[5] = polygon.PointSix;

        //    graphics.DrawPolygon(pen,point);
        //    //base.OnPaint(e);
        //}
        protected override void OnPaint(PaintEventArgs e)
        {
            System.Drawing.Graphics graphics = PolygonPanel.CreateGraphics();
            Brush blackpen = new SolidBrush(Color.Black);
            Pen pen = new Pen(blackpen, 1);
            Point[] point = new Point[6];
            int cx = (int)circle.CentreX, cy = (int)circle.CentreX;
            int R = (int)circle.Radius,N=6;

            for(int i = 0; i < 6; i++)
            {
                point[i].X= (int)(cx + R * Math.Cos(Math.PI / N * (1 + 2 * i)));
                point[i].Y= (int)(cy + R * Math.Sin(Math.PI / N * (1 + 2 * i)));
            }
            graphics.DrawPolygon(pen, point);
            //int cx = 550, cy = 550;
            //int R = 100, N = 6;
            //int[,] points = new int[6, 2];
            //for (int i = 0; i < 6; i++)
            //{

            //    points[i, 0] = (int)(cx + R * Math.Cos(Math.PI / N * (1 + 2 * i)));
            //    points[i, 1] = (int)(cy + R * Math.Sin(Math.PI / N * (1 + 2 * i)));

            //    //po
            //    //graphics.
            //    //base.OnPaint(e);
            //}
        }
        }
}
