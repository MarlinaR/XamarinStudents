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
        public MainPage()
        {
            InitializeComponent();
            sl.ValueChanged += (sender, args) =>
            {
                Color cl = Color.FromRgba((int)sl.Value, 0, 0, 255);
                Grad.StartColor = cl;
              
            };

        }

    }
}
