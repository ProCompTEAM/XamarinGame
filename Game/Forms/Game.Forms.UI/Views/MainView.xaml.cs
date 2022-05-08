using Game.Core.ViewModels;
using Game.Forms.Base.Views;

using Xamarin.Forms.Xaml;

namespace Game.Forms.UI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainView : CustomContentPage<MainViewModel>
    {
        public MainView()
        {
            InitializeComponent();
        }
    }
}