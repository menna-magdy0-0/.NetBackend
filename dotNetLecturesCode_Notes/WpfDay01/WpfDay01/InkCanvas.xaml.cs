using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfDay01
{
    /// <summary>
    /// Interaction logic for InkCanvas.xaml
    /// </summary>
    public partial class InkCanvas : Window
    {
        public InkCanvas()
        {
            InitializeComponent();
        }

        private void Color_Checked(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content.ToString())
            {
                case "Red":
                    Ink.DefaultDrawingAttributes.Color = Colors.Red;
                    break;
                case "Green":
                    Ink.DefaultDrawingAttributes.Color = Colors.Green;
                    break;
                case "Blue":
                    Ink.DefaultDrawingAttributes.Color = Colors.Blue;
                    break;
            }

        }

        private void Modes_Checked(object sender, RoutedEventArgs e)
        {
            InkCanvasEditingMode Edite=(InkCanvasEditingMode)Enum.Parse(typeof(InkCanvasEditingMode),((RadioButton)sender).Content.ToString());
            Ink.EditingMode = Edite;
        }
    }
}
