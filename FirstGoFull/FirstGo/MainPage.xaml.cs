using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FirstGo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


            ToggleSwitch.BindingContext = DataModel;
            btnNumber.BindingContext = DataModel;
            lblHideMe.BindingContext = DataModel;
            lbl1.BindingContext = DataModel;

            ToggleSwitch.SetBinding(Switch.IsToggledProperty, "IsTrue", BindingMode.OneWayToSource);
            btnNumber.SetBinding(Button.IsEnabledProperty, "IsTrue", BindingMode.OneWay);
          
            lbl1.SetBinding(Label.TextProperty, "NumberAsString", BindingMode.OneWay);


        }

        Model DataModel = new Model();

        private void ToggleSwitch_Toggled(object sender, ToggledEventArgs e)
        {
           lblHideMe.IsVisible = ToggleSwitch.IsToggled;
         
        }

        private void btnNumber_Clicked(object sender, EventArgs e)
        {
            DataModel.NextNumber();
        }
    }
}
