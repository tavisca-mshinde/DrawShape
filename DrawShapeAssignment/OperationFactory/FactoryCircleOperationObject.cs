using System;
using Operation;
using Microsoft.Practices.Unity;

namespace OperationFactory
{
    public class FactoryCircleOperationObject
    {
        public static ICircleOperation GetCircleOperationObject()
        {
            UnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterType<ICircleOperation, CircleOperation>();
            CircleOperation circleOperation = unityContainer.Resolve<CircleOperation>();
            return circleOperation;
            //throw new NotImplementedException();
        }
    }
}