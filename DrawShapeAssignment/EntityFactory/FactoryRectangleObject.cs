using System;
using Entities;
using Microsoft.Practices.Unity;

namespace EntityFactory
{
    public class FactoryRectangleObject
    {
        public static Rectangle GetRectagle()
        {
            UnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterType<Rectangle>();
            Rectangle rectangle= unityContainer.Resolve<Rectangle>();
            return rectangle;
            //throw new NotImplementedException();
        }

        //public static global::Operation.IRectangleOperation GetRectagleOperation()
        //{
        //    throw new NotImplementedException();
        //}
    }
}