using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinPoc.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderDetailsPage 
    {
        public OrderDetailsPage()
        {
            InitializeComponent();
        }

        private async void Submit_OnClicked(object sender, EventArgs e)
        {
          //  var orderStatus = await Delivery.OrderAsync(CurrentOrder);

           // await Application.Current.MainPage.Navigation.PushAsync(new OrderStatusPage(orderStatus), true);
        }
    }
}