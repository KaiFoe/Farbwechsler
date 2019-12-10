using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Farbwechsler
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //reagiert auf Änderungen der Slider
        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {  
            if (sender == redSlider)
            {
                redEntry.Text = args.NewValue.ToString();
            }
            else if (sender == greenSlider)
            {
                greenEntry.Text = args.NewValue.ToString();
            }
            else if (sender == blueSlider)
            {
                blueEntry.Text = args.NewValue.ToString();
            }

            //Setzt Farbe der Boxview aus den Werten der Slider
            boxView.Color = Color.FromRgb((int)redSlider.Value,
                                          (int)greenSlider.Value,
                                          (int)blueSlider.Value);
        }

        //Wenn wir auf den Abschluss der Texteingabe reagieren wollen
        //Beispiel normale Tastatur (reagiert nur auf "Enter")
        void Entry_Completed(object sender, EventArgs args)
        {
            if (sender == redEntry)
            {
                redSlider.Value = Int32.Parse(redEntry.Text);
            }
            else if (sender == greenEntry)
            {
                greenSlider.Value = Int32.Parse(greenEntry.Text);
            }
            else if (sender == blueEntry)
            {
                blueSlider.Value = Int32.Parse(blueEntry.Text);
            }
        }

        //Wenn wir auf Textänderungen reagieren wollen
        //Beispiel bei numerischer Tastatur
        void Entry_TextChanged(object sender, EventArgs args)
        {
            if (sender == redEntry)
            {
                redSlider.Value = Int32.Parse(redEntry.Text);
            }
            else if (sender == greenEntry)
            {
                greenSlider.Value = Int32.Parse(greenEntry.Text);
            }
            else if (sender == blueEntry)
            {
                blueSlider.Value = Int32.Parse(blueEntry.Text);
            }
        }
    }
}
