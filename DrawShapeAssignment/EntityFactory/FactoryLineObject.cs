using System;
using Entities;
using Microsoft.Practices.Unity;

namespace EntityFactory
{
    public class FactoryLineObject
    {
        public static Line GetLine()
        {
            UnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterType<Line>();
            Line line = unityContainer.Resolve<Line>();
            return line;
            //throw new NotImplementedException();
        }
    }
}