using EntityFactory;
//using Entities;
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
    public partial class FormForRectangle : Form
    {
        Entities.Rectangle rectangle = FactoryRectangleObject.GetRectagle();
        public FormForRectangle()
        {
            InitializeComponent();
        }
        public FormForRectangle(Entities.Rectangle rectangle)
        {
            InitializeComponent();
            this.rectangle = rectangle;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = RectanglePanel.CreateGraphics();
            Brush black = new SolidBrush(Color.Black);
            Pen blackPen = new Pen(black, 1);
            double height = rectangle.PointOneX + rectangle.PointTwoY;
            double width = rectangle.PointOneY + rectangle.PointTwoX;
            graphics.DrawRectangle(blackPen,(float)rectangle.PointOneX, (float)rectangle.PointOneY, (float)width, (float)height);
            //Rectangle
                
            //base.OnPaint(e);
        }
    }
}
