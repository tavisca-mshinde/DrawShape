using System;
using Entities;
using Microsoft.Practices.Unity;

namespace EntityFactory
{
    public class FactoryCircleObject
    {
        public static Circle GetCircle()
        {
            UnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterType<Circle>();
            Circle circle = unityContainer.Resolve<Circle>();
            return circle;
            //throw new NotImplementedException();
        }
    }
}