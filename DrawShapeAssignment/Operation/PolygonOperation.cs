using System;
using Entities;
using System.Windows.Forms;
using DrawShape;

namespace Operation
{
    public class PolygonOperation:IPolygonOperation
    {
        //public void DrawingPolygon(Polygon polygon)
        //{
        //    Application.Run(new FormForPolygon(polygon));
        //    //throw new NotImplementedException();
        //}
        public void DrawingPolygon(Circle circle)
        {
            Application.Run(new FormForPolygon(circle));
            //throw new NotImplementedException();
        }
    }
}