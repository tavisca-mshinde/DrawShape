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
    public partial class FormLine : Form
    {
        Line line = FactoryLineObject.GetLine();

        public FormLine()
        {
            InitializeComponent();
        }
        public FormLine(Line line)
        {
            InitializeComponent();
        
            this.line = line;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = LinePanel.CreateGraphics();
            Brush black = new SolidBrush(Color.Black);
            Pen blackPen = new Pen(black, 1);
            g.DrawLine(blackPen,line.PointOneX, line.PointOneY, line.PointTwoX, line.PointTwoY);
            //base.OnPaint(e);
        }
    }
}
