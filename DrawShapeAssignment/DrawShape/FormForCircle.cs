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
    public partial class FormForCircle : Form
    {
        Entities.Circle circle = EntityFactory.FactoryCircleObject.GetCircle();
        public FormForCircle()
        {
            InitializeComponent();
        }
        public FormForCircle(Entities.Circle circle)
        {
            InitializeComponent();
            this.circle = circle;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = CirclePanel.CreateGraphics();
            Brush black = new SolidBrush(Color.Black);
            Pen blackPen = new Pen(black, 1);
            double x = circle.CentreX - circle.Radius;
            double y = circle.CentreY - circle.Radius;
            double width = (circle.CentreX + circle.Radius) - x;
            double height = (circle.CentreY + circle.Radius) - y;
            graphics.DrawEllipse(blackPen, (float)x, (float)y, (float)width, (float)height);
            //base.OnPaint(e);
        }
    }
}
