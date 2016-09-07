using System;
//using Entities;
using Operation;
using Microsoft.Practices.Unity;

namespace OperationFactory
{
    public class FactoryLineOperationObject
    {
        public static LineOperation GetLineOperation()
        {
            UnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterType<ILineOperation, LineOperation>();
            LineOperation lineOperation = unityContainer.Resolve<LineOperation>();
            return lineOperation;
            //throw new NotImplementedException();
        }
    }
}