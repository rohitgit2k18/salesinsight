using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SalesInsight.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyRoutePage : ContentPage
    {
        public MyRoutePage()
        {
            InitializeComponent();
            var tabTypes = new List<string>() { "Dados principais", "Cantactos", "Encomendas", "Repositores" };
            segment.Children = tabTypes;
        }

        void Handle_SelectedItemChanged(object sender, SelectedItemChangedEventArgs e)
        {
            //ItemSelectedText.Text = $"{e.SelectedItem}";
            switch (e.SelectedItem)
            {

                case "Dados principais":
                    XFGridData.IsVisible = true;
                    break;

                case "Cantactos":
                    XFGridData.IsVisible = false;
                    DisplayAlert("Info", "Work under Process..", "OK");
                    break;
                case "Encomendas":
                    XFGridData.IsVisible = false;
                    DisplayAlert("Info", "Work under Process..", "OK");
                    break;
                case "Repositores":
                    XFGridData.IsVisible = false;
                    DisplayAlert("Info", "Work under Process..", "OK");
                    break;

                default:
                    XFGridData.IsVisible = true;
                    break;
            }
        }
    }
}