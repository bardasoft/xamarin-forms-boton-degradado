using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GradientButtonDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new
            {
                TextTest = "Login",
                RadiusTest = 45.0f,
                GradientStyle = "linear-gradient(135deg, rgba(29, 29, 29, 0.05) 0%, rgba(29, 29, 29, 0.05) 17%,rgba(27, 27, 27, 0.05) 17%, rgba(27, 27, 27, 0.05) 34%,rgba(31, 31, 31, 0.05) 34%, rgba(31, 31, 31, 0.05) 93%,rgba(242, 242, 242, 0.05) 93%, rgba(242, 242, 242, 0.05) 100%),linear-gradient(135deg, rgba(129, 129, 129, 0.05) 0%, rgba(129, 129, 129, 0.05) 66%,rgba(117, 117, 117, 0.05) 66%, rgba(117, 117, 117, 0.05) 91%,rgba(199, 199, 199, 0.05) 91%, rgba(199, 199, 199, 0.05) 100%),linear-gradient(135deg, rgba(31, 31, 31, 0.07) 0%, rgba(31, 31, 31, 0.07) 15%,rgba(139, 139, 139, 0.07) 15%, rgba(139, 139, 139, 0.07) 23%,rgba(200, 200, 200, 0.07) 23%, rgba(200, 200, 200, 0.07) 29%,rgba(102, 102, 102, 0.07) 29%, rgba(102, 102, 102, 0.07) 100%),linear-gradient(90deg, rgb(19, 196, 228),rgb(126, 8, 222))",
                Command = new Command(() =>
                {
                    DisplayAlert("Test", "Testing command", "Ok");
                })
            };
        }
    }
}
