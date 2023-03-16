using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTransformExample.Models
{
    public interface ITransformShape
    {
        double AngleRotateTransformDeg { get; set; }
        double RotateTransformCenterX { get; set; }
        double RotateTransformCenterY { get; set; }
        double TranslateTransformX { get; set; }
        double TranslateTransformY { get; set; }
        double ScaleTransformX { get; set; }
        double ScaleTransformY { get; set; }
        double AngleSkewTransformX { get; set; }
        double AngleSkewTransformY { get; set; }
        double AngleSkewTransformCenterX { get; set; }
        double AngleSkewTransformCenterY { get; set; }
    }
}
