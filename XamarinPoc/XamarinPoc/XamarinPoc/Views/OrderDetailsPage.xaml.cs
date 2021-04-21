using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinPoc.Models;

namespace XamarinPoc.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderDetailsPage 
    {
        private readonly Order Order;
        public OrderDetailsPage(Order order)
        {
            InitializeComponent();
            Order = order;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            int p = 0;
            foreach (var order in Order.Items)
            {
                //column 1 - product name
                OrdersGrid.Children.Add(new Label()
                {
                    Text = order.Name,
                    FontSize = 20,
                    VerticalOptions = LayoutOptions.Center,
                    FontAttributes = FontAttributes.Bold,
                    Margin = new Thickness(6, 0)
                }, 0, p);

                //column 2 - quantity
                OrdersGrid.Children.Add(new Label()
                {
                    Text = "x " + order.Quantity,
                    FontSize = 20,
                    VerticalOptions = LayoutOptions.Center,
                    FontAttributes = FontAttributes.Bold,
                    Margin = new Thickness(6, 0)
                }, 1, p);

                //column 3 - price
                OrdersGrid.Children.Add(new Label()
                {
                    Text = (order.Quantity * order.UnitPrice) + " RON",
                    FontSize = 20,
                    VerticalOptions = LayoutOptions.Center,
                    FontAttributes = FontAttributes.Bold,
                    Margin = new Thickness(6, 0),    
                }, 2, p);

                p++;
            }
            SetTotalPrice();
        }

        private void SetTotalPrice()
        {
            TotalPrice.Text = "Total: " + Order.Price + " RON";
        }

        private async void Submit_OnClicked(object sender, EventArgs e)
        {
            var orderStatus = await MainPage.Delivery.OrderAsync(MainPage.CurrentOrder);
            await Application.Current.MainPage.Navigation.PushAsync(new OrderStatusPage(orderStatus), true);
        }
    }
}