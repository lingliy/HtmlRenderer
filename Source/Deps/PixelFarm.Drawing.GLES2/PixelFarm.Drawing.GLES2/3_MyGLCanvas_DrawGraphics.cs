﻿//BSD, 2014-2017, WinterDev
//ArthurHub  , Jose Manuel Menendez Poo

// "Therefore those skilled at the unorthodox
// are infinite as heaven and earth,
// inexhaustible as the great rivers.
// When they come to an end,
// they begin again,
// like the days and months;
// they die and are reborn,
// like the four seasons."
// 
// - Sun Tsu,
// "The Art of War"

using System;
namespace PixelFarm.Drawing.GLES2
{

    partial class MyGLCanvas
    {
        class MyGLCanvasException : Exception { }

        float strokeWidth = 1f;
        Color fillSolidColor = Color.Transparent;
        Color strokeColor = Color.Black;
        //==========================================================
        public override Color StrokeColor
        {
            get
            {
                return this.strokeColor;
            }
            set
            {
                painter1.StrokeColor = this.strokeColor = value;
            }
        }
        public override float StrokeWidth
        {
            get
            {
                return this.strokeWidth;
            }
            set
            {
                painter1.StrokeWidth = this.strokeWidth = value;
            }
        }

        public override void RenderTo(IntPtr destHdc, int sourceX, int sourceY, Rectangle destArea)
        {
            throw new MyGLCanvasException();
            //IntPtr gxdc = gx.GetHdc();
            //MyWin32.SetViewportOrgEx(gxdc, CanvasOrgX, CanvasOrgY, IntPtr.Zero);
            //MyWin32.BitBlt(destHdc, destArea.X, destArea.Y,
            //destArea.Width, destArea.Height, gxdc, sourceX, sourceY, MyWin32.SRCCOPY);
            //MyWin32.SetViewportOrgEx(gxdc, -CanvasOrgX, -CanvasOrgY, IntPtr.Zero);
            //gx.ReleaseHdc();
        }
        public override void ClearSurface(PixelFarm.Drawing.Color c)
        {
            painter1.Clear(c);
        }
        public override void DrawPath(GraphicsPath gfxPath)
        {
            throw new MyGLCanvasException();
            //gx.DrawPath(internalPen, gfxPath.InnerPath as System.Drawing.Drawing2D.GraphicsPath);
        }
        public override void FillRectangle(Brush brush, float left, float top, float width, float height)
        {

            switch (brush.BrushKind)
            {
                case BrushKind.Solid:
                    {
                        //use default solid brush
                        SolidBrush solidBrush = (SolidBrush)brush;
                        var prevColor = painter1.FillColor;
                        painter1.FillColor = solidBrush.Color;
                        painter1.FillRectangle(left, this.Height - (top + height), left + width, this.Height - top);
                        painter1.FillColor = prevColor;
                        //internalSolidBrush.Color = prevColor;
                    }
                    break;
                case BrushKind.LinearGradient:
                    {
                        throw new MyGLCanvasException();
                    }
                    break;
                case BrushKind.GeometryGradient:
                    {
                    }
                    break;
                case BrushKind.CircularGraident:
                    {
                    }
                    break;
                case BrushKind.Texture:
                    {
                    }
                    break;
            }
        }
        public override void FillRectangle(Color color, float left, float top, float width, float height)
        {

            painter1.FillColor = color;
            painter1.FillRectangle(left, this.Height - (top + height), left + width, this.Height - top);
        }
        public override void DrawRectangle(Color color, float left, float top, float width, float height)
        {
            painter1.StrokeColor = color;
            painter1.Rectangle(left, this.Height - (top + height), left + width, this.Height - top);
        }

        public override void DrawLine(float x1, float y1, float x2, float y2)
        {
            painter1.Line(x1, this.Height - y1, x2, this.Height - y2);
        }


        /// <summary>
        /// Gets or sets the rendering quality for this <see cref="T:System.Drawing.Graphics"/>.
        /// </summary>
        /// <returns>
        /// One of the <see cref="T:System.Drawing.Drawing2D.SmoothingMode"/> values.
        /// </returns>
        /// <PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence"/></PermissionSet>
        public override SmoothingMode SmoothingMode
        {
            get
            {
                return painter1.SmoothingMode;
            }
            set
            {
                painter1.SmoothingMode = value;
            }
        }
        /// <summary>
        /// Draws the specified portion of the specified <see cref="T:System.Drawing.Image"/> at the specified location and with the specified size.
        /// </summary>
        /// <param name="image"><see cref="T:System.Drawing.Image"/> to draw. </param>
        /// <param name="destRect"><see cref="T:System.Drawing.RectangleF"/> structure that specifies the location and size of the drawn image. The image is scaled to fit the rectangle. </param>
        /// <param name="srcRect"><see cref="T:System.Drawing.RectangleF"/> structure that specifies the portion of the <paramref name="image"/> object to draw. </param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="image"/> is null.</exception>
        public override void DrawImage(Image image, RectangleF destRect, RectangleF srcRect)
        {
            //TODO: review here 
            //painter1.DrawImage(image, destRect.X, destRect.Y);
            throw new MyGLCanvasException();
            //gx.DrawImage(image.InnerImage as System.Drawing.Image,
            //    destRect.ToRectF(),
            //    srcRect.ToRectF(),
            //    System.Drawing.GraphicsUnit.Pixel);
        }
        public override void DrawImages(Image image, RectangleF[] destAndSrcPairs)
        {
            throw new MyGLCanvasException();
            //int j = destAndSrcPairs.Length;
            //if (j > 1)
            //{
            //    if ((j % 2) != 0)
            //    {
            //        //make it even number
            //        j -= 1;
            //    }
            //    //loop draw
            //    var inner = image.InnerImage as System.Drawing.Image;
            //    for (int i = 0; i < j;)
            //    {
            //        gx.DrawImage(inner,
            //            destAndSrcPairs[i].ToRectF(),
            //            destAndSrcPairs[i + 1].ToRectF(),
            //            System.Drawing.GraphicsUnit.Pixel);
            //        i += 2;
            //    }
            //}
        }
        /// <summary>
        /// Draws the specified <see cref="T:System.Drawing.Image"/> at the specified location and with the specified size.
        /// </summary>
        /// <param name="image"><see cref="T:System.Drawing.Image"/> to draw. </param><param name="destRect"><see cref="T:System.Drawing.Rectangle"/> structure that specifies the location and size of the drawn image. </param><exception cref="T:System.ArgumentNullException"><paramref name="image"/> is null.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence"/></PermissionSet>
        public override void DrawImage(Image image, RectangleF destRect)
        {
            throw new MyGLCanvasException();
            //if (image.IsReferenceImage)
            //{
            //    gx.DrawImage(image.InnerImage as System.Drawing.Image,
            //        destRect.ToRectF(),
            //         new System.Drawing.RectangleF(
            //             image.ReferenceX, image.ReferenceY,
            //             image.Width, image.Height),
            //        System.Drawing.GraphicsUnit.Pixel);
            //}
            //else
            //{
            //    gx.DrawImage(image.InnerImage as System.Drawing.Image, destRect.ToRectF());
            //}
        }
        public override void FillPath(Color color, GraphicsPath gfxPath)
        {
            throw new MyGLCanvasException();
            //solid color
            //var prevColor = internalSolidBrush.Color;
            //internalSolidBrush.Color = ConvColor(color);
            //gx.FillPath(internalSolidBrush,
            //    gfxPath.InnerPath as System.Drawing.Drawing2D.GraphicsPath);
            //internalSolidBrush.Color = prevColor;
        }
        /// <summary>
        /// Fills the interior of a <see cref="T:System.Drawing.Drawing2D.GraphicsPath"/>.
        /// </summary>
        /// <param name="brush"><see cref="T:System.Drawing.Brush"/> that determines the characteristics of the fill. </param><param name="path"><see cref="T:System.Drawing.Drawing2D.GraphicsPath"/> that represents the path to fill. </param><exception cref="T:System.ArgumentNullException"><paramref name="brush"/> is null.-or-<paramref name="path"/> is null.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence"/></PermissionSet>
        public override void FillPath(Brush brush, GraphicsPath path)
        {
            throw new MyGLCanvasException();
            //switch (brush.BrushKind)
            //{
            //    case BrushKind.Solid:
            //        {
            //            SolidBrush solidBrush = (SolidBrush)brush;
            //            var prevColor = internalSolidBrush.Color;
            //            internalSolidBrush.Color = ConvColor(solidBrush.Color);
            //            gx.FillPath(internalSolidBrush,
            //                path.InnerPath as System.Drawing.Drawing2D.GraphicsPath);
            //            internalSolidBrush.Color = prevColor;
            //        }
            //        break;
            //    case BrushKind.LinearGradient:
            //        {
            //            LinearGradientBrush solidBrush = (LinearGradientBrush)brush;
            //            var prevColor = internalSolidBrush.Color;
            //            internalSolidBrush.Color = ConvColor(solidBrush.Color);
            //            gx.FillPath(internalSolidBrush,
            //                path.InnerPath as System.Drawing.Drawing2D.GraphicsPath);
            //            internalSolidBrush.Color = prevColor;
            //        }
            //        break;
            //    default:
            //        {
            //        }
            //        break;
            //}
        }

        public override void FillPolygon(Brush brush, PointF[] points)
        {
            throw new MyGLCanvasException();
            //var pps = ConvPointFArray(points);
            ////use internal solid color            
            //gx.FillPolygon(brush.InnerBrush as System.Drawing.Brush, pps);
        }
        public override void FillPolygon(Color color, PointF[] points)
        {
            throw new MyGLCanvasException();
            //var pps = ConvPointFArray(points);
            //internalSolidBrush.Color = ConvColor(color);
            //gx.FillPolygon(this.internalSolidBrush, pps);
        }

        ////==========================================================
        //public override void CopyFrom(Canvas sourceCanvas, int logicalSrcX, int logicalSrcY, Rectangle destArea)
        //{
        //    MyCanvas s1 = (MyCanvas)sourceCanvas;

        //    if (s1.gx != null)
        //    {
        //        int phySrcX = logicalSrcX - s1.left;
        //        int phySrcY = logicalSrcY - s1.top;

        //        System.Drawing.Rectangle postIntersect =
        //            System.Drawing.Rectangle.Intersect(currentClipRect, destArea.ToRect());
        //        phySrcX += postIntersect.X - destArea.X;
        //        phySrcY += postIntersect.Y - destArea.Y;
        //        destArea = postIntersect.ToRect();

        //        IntPtr gxdc = gx.GetHdc();

        //        MyWin32.SetViewportOrgEx(gxdc, CanvasOrgX, CanvasOrgY, IntPtr.Zero);
        //        IntPtr source_gxdc = s1.gx.GetHdc();
        //        MyWin32.SetViewportOrgEx(source_gxdc, s1.CanvasOrgX, s1.CanvasOrgY, IntPtr.Zero);


        //        MyWin32.BitBlt(gxdc, destArea.X, destArea.Y, destArea.Width, destArea.Height, source_gxdc, phySrcX, phySrcY, MyWin32.SRCCOPY);


        //        MyWin32.SetViewportOrgEx(source_gxdc, -s1.CanvasOrgX, -s1.CanvasOrgY, IntPtr.Zero);

        //        s1.gx.ReleaseHdc();

        //        MyWin32.SetViewportOrgEx(gxdc, -CanvasOrgX, -CanvasOrgY, IntPtr.Zero);
        //        gx.ReleaseHdc();



        //    }
        //}
    }
}