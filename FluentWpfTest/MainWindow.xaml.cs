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
using System.Windows.Navigation;
using System.Windows.Shapes;
using SourceChord.FluentWPF;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            AcrylicWindow.SetEnabled(this, true);
            AcrylicWindow.SetTintColor(this, (Color)ColorConverter.ConvertFromString("#FFF7F7F7"));
            AcrylicWindow.SetFallbackColor(this, (Color)ColorConverter.ConvertFromString("#FFF7F7F7"));
            AcrylicWindow.SetTintOpacity(this, 1);
            AcrylicWindow.SetNoiseOpacity(this, 0.001);

            InitializeComponent();
        }
    }
}
