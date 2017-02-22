using Microsoft.Practices.Unity;
using Novsiy.Business.Contracts;
using Novsiy.Business.Realization;
using System.Web.Mvc;
using Unity.Mvc4;

namespace Novsiy.Web.App_Start
{
    public class UnityConfig
    {
        public static UnityContainer Container { get; set; }

        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            container.RegisterType<IQuestionnaireService, FakeQuestionnaireService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            Container = container;
        }
    }
}