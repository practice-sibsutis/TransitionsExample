using Avalonia;
using Avalonia.Animation;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Media;
using TransitionExample.ViewModels;

namespace TransitionExample.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CanvasTap(object sender, PointerReleasedEventArgs releasedEventArgs)
        {
            if(releasedEventArgs.Source is Panel mainWindow)
            {
                Point point = releasedEventArgs.GetPosition(mainWindow);

                MyRectangle.Fill = new SolidColorBrush(
                    Color.FromRgb((byte)(point.X % 255),
                    (byte)(point.X % 255),
                    (byte)(point.X + point.Y % 255)));
                

                if(this.DataContext is MainWindowViewModel viewModel)
                {
                    viewModel.X = point.X;
                    viewModel.Y = point.Y;
                }
            }
        }
    }
}