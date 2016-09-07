using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entities;
using EntityFactory;

namespace DrawShape
{
    public partial class FormForTriangle : Form
    {
        Triangle triangle = FactoryEntity.GetTriangle();
        public FormForTriangle()
        {
            InitializeComponent();
        }
        public FormForTriangle(Triangle triangle)
        {
            InitializeComponent();
            this.triangle = triangle;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            System.Drawing.Graphics g = TrianglePanel.CreateGraphics();
            Brush black = new SolidBrush(Color.Black);
            Pen bpen = new Pen(black, 1);
            Point[] point = new Point[3];
            point[0] = triangle.PointOne;
            point[1] = triangle.PointTwo;
            point[2] = triangle.PointThree;
            //point[3] = triangle.PointOne;
            //g.DrawLines(bpen, point);
            g.DrawPolygon(bpen,point);
            //base.OnPaint(e);
        }
    }
}
