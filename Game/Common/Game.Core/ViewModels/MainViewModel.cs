using Game.Core.ViewModels.Base;

using Xamarin.Forms;

namespace Game.Core.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public INavigation Navigation { get; set; }

        public MainViewModel(INavigation navigation)
        {
            Navigation = navigation;
        }
    }
}
