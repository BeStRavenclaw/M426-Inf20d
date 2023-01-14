using Geometry.ThirdParty;
using System;

namespace Geometry
{
    public class RectangleAdapter : IRectangular
    {
        private IQuadratic square;

        public RectangleAdapter(IQuadratic square)
        {
            this.square = square;
        }

        public int GetWidth()
        {
            return square.GetSide();
        }

        public int GetHeight()
        {
            return square.GetSide();
        }

        public static double GetWidthHeightRatio(IRectangular rectangular)
        {
            return rectangular.GetHeight() / Convert.ToDouble(rectangular.GetWidth());
        }
    }
}