using System;
using Entities;
using Microsoft.Practices.Unity;

namespace EntityFactory
{
    public class FactoryEntity
    {
        public static Polygon GetPolygon()
        {
            UnityContainer unityFactory = new UnityContainer();
            unityFactory.RegisterType<Polygon>();
            Polygon polygon = unityFactory.Resolve<Polygon>();
            return polygon;
            //throw new NotImplementedException();
        }

        public static Triangle GetTriangle()
        {
            UnityContainer unityFactory = new UnityContainer();
            unityFactory.RegisterType<Triangle>();
            Triangle tringle = unityFactory.Resolve<Triangle>();
            return tringle;
            //throw new NotImplementedException();
        }
    }
}