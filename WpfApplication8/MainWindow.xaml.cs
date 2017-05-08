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

namespace WpfApplication8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, RoutedEventArgs e)
        {
            //Rectangle rect = new Rectangle();
            //rect.Stroke = new SolidColorBrush(Colors.Black);
            //rect.Width = 100;
            //rect.Height = 70;
            //rect.Margin = new Thickness(10, 10, 10, 0);
            //canvas.Children.Add(rect);
            Circle circle = new Circle(40, 40);
            Square squarel = new Square(180, 180);
            List<Shape> group = new List<Shape>();

            group.Add(circle);
            group.Add(squarel);

            foreach (Shape shape in group)
            {
                shape.DisplayOn(canvas);
            }
        }
    }
}
