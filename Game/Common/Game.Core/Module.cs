using Game.Common.DI;
using Game.Core.Services;
using Game.Core.Services.Interfaces;

namespace Game.Core
{
    public static class Module
    {
        static Module()
        {
            RegisterServices();
        }

        private static void RegisterServices()
        {
            CommonModule.Container.RegisterInstanceAs<INavigationService>(new NavigationService());
        }
    }
}
