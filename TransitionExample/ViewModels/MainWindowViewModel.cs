
using Avalonia.Controls.Shapes;
using ReactiveUI;

namespace TransitionExample.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private double x;
        private double y;

        public MainWindowViewModel() {
            X = 10;
            Y = 200;
        }

        public double X
        {
            get
            {
                return x;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref x, value);
            }
        }

        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref y, value);
            }
        }
    }
}