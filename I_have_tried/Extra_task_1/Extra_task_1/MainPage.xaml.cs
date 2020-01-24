using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Extra_task_1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]

    public partial class MainPage : ContentPage
    {

        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            if (sender == rs)
            {
                rl.Text = String.Format("Red = {0}", (int)args.NewValue);
            }
            else if (sender == gs)
            {
                gl.Text = String.Format("Green = {0}", (int)args.NewValue);
            }
            else if (sender == bs)
            {
                bl.Text = String.Format("Blue = {0}", (int)args.NewValue);
            }

            boxView.Color = Color.FromRgb((int)rs.Value, (int)gs.Value, (int)bs.Value);
            Graad.StartColor = Color.FromRgb((int)rs.Value, (int)gs.Value, (int)bs.Value);
        }
        public MainPage()
        {
            InitializeComponent();

        }

    }
}
