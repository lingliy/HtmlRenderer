﻿//2014, Apache2 WinterDev
//MS-PL,


using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using HtmlRenderer.Css;

namespace HtmlRenderer.SvgDom
{
    public class SvgHitChain
    {

        List<SvgHitInfo> svgList = new List<SvgHitInfo>();
        public SvgHitChain()
        {
        }
        public void AddHit(SvgElement svg, float x, float y)
        {
            svgList.Add(new SvgHitInfo(svg, x, y));
        }
        public int Count
        {
            get
            {
                return this.svgList.Count;
            }
        }
        public SvgHitInfo GetHitInfo(int index)
        {
            return this.svgList[index];
        }
        public SvgHitInfo GetLastHitInfo()
        {
            return this.svgList[svgList.Count - 1];
        }
    }


    public struct SvgHitInfo
    {
        public readonly SvgElement svg;
        public readonly float x;
        public readonly float y;
        public SvgHitInfo(SvgElement svg, float x, float y)
        {
            this.svg = svg;
            this.x = x;
            this.y = y;
        }
    }
}