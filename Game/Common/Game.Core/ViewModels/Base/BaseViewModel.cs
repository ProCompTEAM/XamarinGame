using Game.Common.DI;
using Game.Core.Services;
using Game.Core.Services.Interfaces;

using System.ComponentModel;

namespace Game.Core.ViewModels.Base
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public INavigationService NavigationService => CommonModule.Container.Resolve<NavigationService>();

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void ChangeProperty(string propertyName)
        {
            var handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
