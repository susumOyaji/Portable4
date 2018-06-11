//using Microsoft.Practices.Prism.Mvvm;

using System.Collections.Generic;
using Xamarin.Forms;

namespace Portable4.ViewModels
{
    public abstract class ContentPageViewModel : BindableBase
    {

        private string _Title;

        public string Title
        {
            get
            {
                return this._Title;
            }
            protected set
            {
                this.SetProperty(ref this._Title, value);
            }
        }

    }

    public sealed class ContentPage1ViewModel : ContentPageViewModel
    {

        public ContentPage1ViewModel()
        {
            List<string> list = new List<string>() { "Item1", "Item2", "Item3", "Item4" };

            var LlistItems = new ListView
            {
                ItemsSource = list,
            };



            this.Title = "Stock";

           

        }

       
    }

    public sealed class ContentPage2ViewModel : ContentPageViewModel
    {
        public ContentPage2ViewModel()
        {
            this.Title = "Ranking Serchi";
        }

    }

}
