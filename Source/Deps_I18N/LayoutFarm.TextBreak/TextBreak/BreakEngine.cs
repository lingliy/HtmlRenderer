﻿//MIT, 2016-2017, WinterDev
//some code from ICU project with BSD license

namespace LayoutFarm.TextBreak
{
    public enum TextBreakKind
    {
        Word,
        Sentence,
    }

    public delegate void OnBreak(BreakBounds breakBounds);

    public class BreakBounds
    {
        public int startIndex;
        public int length;
        public bool stopNext;
        public WorkKind kind;
    }
    public enum WorkKind
    {
        Whitespace,
        NewLine,
        Text,
        Number,
        Punc
    }
    public abstract class TextBreaker
    {
        public abstract void DoBreak(char[] input, int start, int len, OnBreak onbreak);
        public TextBreakKind BreakKind
        {
            get;
            set;
        }
        public void DoBreak(char[] charBuff, OnBreak onbreak)
        {
            IsCanceled = false;//reset 
            //to end
            DoBreak(charBuff, 0, charBuff.Length, onbreak);
        }
       
        protected bool IsCanceled { get; set; }
        /// <summary>
        /// cancel current breaking task
        /// </summary>
        public void Cancel() { IsCanceled = true; }
    }
    public struct SplitBound
    {
        public readonly int startIndex;
        public readonly int length;
        public SplitBound(int startIndex, int length)
        {
            this.startIndex = startIndex;
            this.length = length;
        }
#if DEBUG
        public override string ToString()
        {
            return startIndex + ":" + length;
        }
#endif
    }

}