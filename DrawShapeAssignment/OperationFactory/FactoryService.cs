using System;
using Operation;
using Microsoft.Practices.Unity;


namespace OperationFactory
{
    public class FactoryService
    {
        public static PolygonOperation GetPolygon()
        {
            UnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterType<IPolygonOperation, PolygonOperation>();
            PolygonOperation polygonOperation = unityContainer.Resolve<PolygonOperation>();
            return polygonOperation;
            //throw new NotImplementedException();
        }

        public static TriangleOperation GetTriangleOperationObject()
        {
            UnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterType<ITriangleOperation, TriangleOperation>();
            TriangleOperation triangleOperation = unityContainer.Resolve<TriangleOperation>();
            return triangleOperation;
            //throw new NotImplementedException();
        }
    }
}