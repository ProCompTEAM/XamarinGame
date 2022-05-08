using System;
using System.ComponentModel;

using Xamarin.Forms;

namespace Game.Forms.Base.Views
{
    public abstract class CustomContentPage<TViewModel> : ContentPage where TViewModel : class, INotifyPropertyChanged
    {
        protected CustomContentPage()
        {
            BindingContext = (TViewModel)Activator.CreateInstance(typeof(TViewModel), new[] { Navigation });
        }
    }
}