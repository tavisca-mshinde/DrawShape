using System;
using Operation;
using Microsoft.Practices.Unity;

namespace OperationFactory
{
    public class FactoryCanvas
    {
        public static CanvasService GetCanvas()
        {
            UnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterType<ICanvasService, CanvasService>();
            CanvasService canvasService = unityContainer.Resolve<CanvasService>();
            return canvasService;
            //throw new NotImplementedException();
        }
    }
}