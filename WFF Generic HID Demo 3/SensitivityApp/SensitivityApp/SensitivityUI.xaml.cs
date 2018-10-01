using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SensitivityApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        Window opener;

        public double SliderValue;
        public MainWindow(Window parentForm)
        {
            InitializeComponent();
            opener = parentForm;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {

            opener.Close();
            this.Close();
            //send data from slider value back to a usable location
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            SliderValue = valueSlider.Value;
            textbox.Text = SliderValue.ToString();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //SelectedText = TextBox.Text;
        }
    }
}
