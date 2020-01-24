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
        ObservableCollection<ClassListColor> Colors { get; set; }

        public MainPage()
        {
            InitializeComponent();
            Colors = new ObservableCollection<ClassListColor>();
            foreach (System.Drawing.Color color in ClassListColor.GetColors())
            {
                Colors.Add(new ClassListColor { name = color.Name, color = color }); 

            }
            listView.ItemsSource = Colors;

        }
    }
}
