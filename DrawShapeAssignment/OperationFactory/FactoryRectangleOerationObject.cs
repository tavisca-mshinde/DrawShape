using System;
using Operation;
using Microsoft.Practices.Unity;

namespace OperationFactory
{
    public class FactoryRectangleOerationObject
    {
        public static RectangleOperation GetRectagleOperation()
        {
            UnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterType<IRectangleOperation, RectangleOperation>();
            RectangleOperation rectangleOperation = unityContainer.Resolve<RectangleOperation>();
            return rectangleOperation;
            //throw new NotImplementedException();
        }
    }
}