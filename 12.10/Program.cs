using System;

namespace onikinoktaon
{
    internal class Program
    {
        internal static void Main(string[] args)
        {}
    }

    internal abstract class Shape
    {
        internal abstract double[] Dimensions {get; set;}

        internal Shape()
        {}
        internal Shape(params double[] dimensions)
        {
            Dimensions = dimensions;
        }
    }

    internal abstract class TwoDimensionalShape : Shape
    {
        internal override double[] Dimensions {get; set;}

        internal TwoDimensionalShape()
        {}
        internal TwoDimensionalShape(params double[] dimensions) : base(dimensions)
        {}

        internal abstract double Area {get;}
    }

    internal abstract class ThreeDimensionalShape : Shape
    {
        internal override double[] Dimensions {get; set;}

        internal ThreeDimensionalShape()
        {}
        internal ThreeDimensionalShape(params double[] dimensions) : base(dimensions)
        {}

        internal abstract double Area {get;}
        internal abstract double Volume {get;}
    }
}