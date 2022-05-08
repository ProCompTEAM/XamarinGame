using Game.Common.Utilities;
using Game.Core.Services.Interfaces;
using Game.Forms.Base.Views;

using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Game.Core.Services
{
    public class NavigationService : INavigationService
    {
        public Task GoTo<TModelView>(INavigation navigation, bool animated = true) 
            where TModelView : class, INotifyPropertyChanged
        {
            var assembly = AssemblyFinder.FormsUIAssembly;
            var expectedType = typeof(CustomContentPage<TModelView>);
            var targetViewClassType = GetTargetClassType(assembly, expectedType);
            var view = Activator.CreateInstance(targetViewClassType) as Page;
            return navigation.PushAsync(view, animated);
        }

        public Task Back(INavigation navigation)
        {
            return navigation.PopAsync();
        }

        private Type GetTargetClassType(Assembly assembly, Type targetClassType)
        {
            return assembly.GetTypes().Where(t => t.IsSubclassOf(targetClassType)).SingleOrDefault();
        }
    }
}
