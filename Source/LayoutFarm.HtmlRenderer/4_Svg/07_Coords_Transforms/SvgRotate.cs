//from github.com/vvvv/svg 
//license : Microsoft Public License (MS-PL) 

using System;
using System.Collections.Generic;
using System.Text;
using PixelFarm.Drawing;
using System.Globalization;
using LayoutFarm;

namespace LayoutFarm.Svg.Transforms
{
    public sealed class SvgRotate : SvgTransform
    {
        public float Angle
        {
            get;
            set;
        } 
        public float CenterX
        {
            get;
            set;
        } 
        public float CenterY
        {
            get;
            set;
        }

        //public override Matrix Matrix
        //{
        //    get
        //    {
        //        Matrix matrix = CurrentGraphicsPlatform.CreateMatrix();
        //        //rotate around axis
        //        //1. move to its center
        //        //2. rotate
        //        //3. translate back
        //        matrix.Translate(this.CenterX, this.CenterY);
        //        matrix.Rotate(this.Angle);
        //        matrix.Translate(-this.CenterX, -this.CenterY);
        //        return matrix;
        //    }
        //}

        //public override string WriteToString()
        //{
        //    return string.Format(CultureInfo.InvariantCulture, "rotate({0}, {1}, {2})", this.Angle, this.CenterX, this.CenterY);
        //}

        public SvgRotate(float angle)
        {
            this.Angle = angle;
        }

        public SvgRotate(float angle, float centerX, float centerY)
            : this(angle)
        {
            this.CenterX = centerX;
            this.CenterY = centerY;
        }


        //public override object Clone()
        //{
        //    return new SvgRotate(this.Angle, this.CenterX, this.CenterY);
        //}
    }
}