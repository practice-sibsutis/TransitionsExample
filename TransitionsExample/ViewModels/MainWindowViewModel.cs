
using Avalonia;
using Avalonia.Media;
using ReactiveUI;
using System.Collections.ObjectModel;
using System.Reactive;
using TransitionsExample.Models;

namespace TransitionsExample.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<CanvasRectangle> canvasRectangles = new ObservableCollection<CanvasRectangle>();
        public MainWindowViewModel()
        {
            AddRectangleCommand = ReactiveCommand.Create(
                () => { 
                    CanvasRectangles
                    .Add(new CanvasRectangle { X = 10, Y = 10, Color = Colors.BlueViolet });
                }
                );

            MoveToRectangle = ReactiveCommand.Create<Point>(
                point =>
                {

                });
        }

        public ObservableCollection<CanvasRectangle> CanvasRectangles
        {
            get
            {
                return canvasRectangles;
            }
            set
            {
                this.RaiseAndSetIfChanged( ref canvasRectangles, value );
            }
        }
        public ReactiveCommand<Unit, Unit> AddRectangleCommand { get; }
        public ReactiveCommand<Point,Unit> MoveToRectangle { get; }
    }
}