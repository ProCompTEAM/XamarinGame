using System.ComponentModel;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Game.Core.Services.Interfaces
{
    public interface INavigationService
    {
        Task GoTo<TModelView>(INavigation navigation, bool animated = true)
            where TModelView : class, INotifyPropertyChanged;

        Task Back(INavigation navigation);
    }
}
