using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Input;
using Avalonia.Media;
using Avalonia.VisualTree;
using System.Linq;

namespace TransitionsExample.Views
{
    public partial class MainWindow : Window
    {
        private bool isRectanglePointerPressed = false;
        private Canvas canvas;
        private Point pointCanvas;
        private Point pointRectangle;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RectanglePointerPressed(object sender, PointerPressedEventArgs args)
        {
            if(args.Source is Rectangle rectangle)
            {
                isRectanglePointerPressed = true;
                pointRectangle = args.GetPosition(rectangle);
                if (canvas == null)
                {
                    canvas = this.GetVisualDescendants().OfType<Canvas>().FirstOrDefault();
                    pointCanvas = args.GetPosition(this.canvas);
                    
                }
            }
        }

        private void RectanglePointerReleased(object sender, PointerReleasedEventArgs args)
        {
            isRectanglePointerPressed = false;
        }

        private void RectanglePointerMoved(object sender, PointerEventArgs args)
        {
            if (args.Source is Rectangle rectangle
                && isRectanglePointerPressed == true)
            {
                Point newPoint = args.GetPosition(this.canvas);

                Point sub = newPoint;

                /*if(rectangle.RenderTransform is TranslateTransform transform)
                {
                    transform.X = newPoint.X - pointRectangle.X;
                    transform.Y = newPoint.Y - pointRectangle.Y;
                }*/

                if(rectangle.RenderTransform is TransformGroup transformGroup)
                {
                    foreach(var transform in transformGroup.Children)
                    {
                        if (transform is TranslateTransform translateTransform)
                        {
                            translateTransform.X = newPoint.X - pointRectangle.X;
                            translateTransform.Y = newPoint.Y - pointRectangle.Y;
                        }
                        else if(transform is RotateTransform rotateTransform)
                        {
                            
                        }
                    }
                }
            }
        }

    }
}