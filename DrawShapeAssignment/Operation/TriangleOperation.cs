using System;
using Entities;
using System.Windows.Forms;
using DrawShape;

namespace Operation
{
    public class TriangleOperation:ITriangleOperation
    {
        public void DrawingTriangle(Triangle triangle)
        {
            Application.Run(new FormForTriangle(triangle));
            //throw new NotImplementedException();
        }
    }
}