using Avalonia.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTransformExample.Models
{
    public class TransformRectangle : ITransformShape
    {
        public double AngleRotateTransformDeg { get; set; }
        public double RotateTransformCenterX { get; set; }
        public double RotateTransformCenterY { get; set; }
        public required double TranslateTransformX { get; set; }
        public required double TranslateTransformY { get; set; }
        public double ScaleTransformX { get; set; }
        public double ScaleTransformY { get; set; }
        public double AngleSkewTransformX { get; set; }
        public double AngleSkewTransformY { get; set; }
        public double AngleSkewTransformCenterX { get; set; }
        public double AngleSkewTransformCenterY { get; set; }
        public required int Height { get; set; }
        public required int Width { get; set; }
        public Color Color { get; set; }
    }
}
