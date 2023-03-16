
using Avalonia.Media;
using ReactiveUI;
using SimpleTransformExample.Models;
using System.Collections.ObjectModel;
using System.Reactive.Linq;

namespace SimpleTransformExample.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<TransformRectangle> transformRectangles;

        public MainWindowViewModel()
        {
            TransformRectangles = new ObservableCollection<TransformRectangle>();
            TransformRectangles.Add(
                /*
                 * TranslateTransform X ; Y
                 */
                new TransformRectangle
                {
                    Height = 50,
                    Width = 50,
                    TranslateTransformX = 10,
                    TranslateTransformY = 10,
                    Color = Colors.DarkMagenta,
                    AngleSkewTransformCenterX = 0,
                    AngleSkewTransformCenterY = 0,
                    RotateTransformCenterX = 0,
                    RotateTransformCenterY = 0,
                    AngleSkewTransformX = 0,
                    AngleSkewTransformY = 0,
                    ScaleTransformX = 1,
                    ScaleTransformY = 1,
                    AngleRotateTransformDeg = 0
                });

            TransformRectangles.Add(
                /*
                 * SkewTransform X = 45
                 */
                new TransformRectangle
                {
                    Height = 50,
                    Width = 50,
                    TranslateTransformX = 100,
                    TranslateTransformY = 10,
                    Color = Colors.DarkMagenta,
                    AngleSkewTransformCenterX = 0,
                    AngleSkewTransformCenterY = 0,
                    AngleSkewTransformX = 45,
                    AngleSkewTransformY = 0,
                    RotateTransformCenterX = 0,
                    RotateTransformCenterY = 0,
                    ScaleTransformX = 1,
                    ScaleTransformY = 1,
                    AngleRotateTransformDeg = 0
                });

            TransformRectangles.Add(
                /*
                 * SkewTransform Y = 45
                 */
                new TransformRectangle
                {
                    Height = 50,
                    Width = 50,
                    TranslateTransformX = 100,
                    TranslateTransformY = 10,
                    Color = Colors.DarkMagenta,
                    AngleSkewTransformCenterX = 0,
                    AngleSkewTransformCenterY = 0,
                    AngleSkewTransformX = 0,
                    AngleSkewTransformY = 45,
                    RotateTransformCenterX = 0,
                    RotateTransformCenterY = 0,
                    ScaleTransformX = 1,
                    ScaleTransformY = 1,
                    AngleRotateTransformDeg = 0
                });

            TransformRectangles.Add(
                /*
                 * RotateTransform 65
                 */
                new TransformRectangle
                {
                    Height = 50,
                    Width = 50,
                    TranslateTransformX = 190,
                    TranslateTransformY = 10,
                    Color = Colors.DarkMagenta,
                    AngleSkewTransformCenterX = 0,
                    AngleSkewTransformCenterY = 0,
                    AngleSkewTransformX = 0,
                    AngleSkewTransformY = 0,
                    RotateTransformCenterX = 0,
                    RotateTransformCenterY = 0,
                    AngleRotateTransformDeg = 65,
                    ScaleTransformX = 1,
                    ScaleTransformY = 1
                });

            TransformRectangles.Add(
                /*
                 * ScaleTransformX 1.5
                 */
                new TransformRectangle
                {
                    Height = 50,
                    Width = 50,
                    TranslateTransformX = 300,
                    TranslateTransformY = 10,
                    Color = Colors.DarkMagenta,
                    AngleSkewTransformCenterX = 0,
                    AngleSkewTransformCenterY = 0,
                    AngleSkewTransformX = 0,
                    AngleSkewTransformY = 0,
                    RotateTransformCenterX = 0,
                    RotateTransformCenterY = 0,
                    AngleRotateTransformDeg = 0,
                    ScaleTransformX = 1.5,
                    ScaleTransformY = 1
                });

            TransformRectangles.Add(
                /*
                 * ScaleTransformX 1.5
                 * ScaleTransformY 3
                 */
                new TransformRectangle
                {
                    Height = 50,
                    Width = 50,
                    TranslateTransformX = 400,
                    TranslateTransformY = 10,
                    Color = Colors.DarkMagenta,
                    AngleSkewTransformCenterX = 0,
                    AngleSkewTransformCenterY = 0,
                    AngleSkewTransformX = 0,
                    AngleSkewTransformY = 0,
                    RotateTransformCenterX = 0,
                    RotateTransformCenterY = 0,
                    AngleRotateTransformDeg = 0,
                    ScaleTransformX = 1.5,
                    ScaleTransformY = 3
                });
        }

        public ObservableCollection<TransformRectangle> TransformRectangles
        {
            get
            {
                return transformRectangles;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref transformRectangles, value);
            }
        }
    }
}