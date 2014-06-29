﻿//BSD 2014, WinterCore 
using System;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using HtmlRenderer.Entities;
using HtmlRenderer.Parse;
using HtmlRenderer.Utils;

namespace HtmlRenderer.Dom
{
    partial class CssBoxBase
    {

        /// <summary>
        /// Inherits inheritable values from specified box.
        /// </summary>
        /// <param name="s">source </param>
        /// <param name="clone">clone all </param>
        protected void InheritStyles(CssBoxBase s, bool clone)
        {

            if (s != null)
            {

                //---------------------------------------
                this._fontProps = s._fontProps;
                this._listProps = s._listProps;
                //--------------------------------------- 
                this._lineHeight = s._lineHeight;
                this._textIndent = s._textIndent;
                this._actualColor = s._actualColor;
                this._emptyCells = s._emptyCells;
                //--------------------------------------- 
                this._textAlign = s._textAlign;
                this._verticalAlign = s._verticalAlign;
                this._visibility = s._visibility;
                this._whitespace = s._whitespace;
                this._wordBreak = s._wordBreak;
                this._cssDirection = s._cssDirection;
                //--------------------------------------- 

                if (clone)
                {
                    //for clone only (eg. split a box into two parts)
                    //---------------------------------------
                    this._backgroundProps = s._backgroundProps;
<<<<<<< HEAD
                    if (this.dbugId == 44)
=======
                    if (this.dbugId == 36)
>>>>>>> FETCH_HEAD
                    {
                    }
                    this._borderProps = s._borderProps;
                    this._cornerProps = s._cornerProps;
                    //---------------------------------------

                    this._left = s._left;
                    this._top = s._top;
                    this._bottom = s._bottom;
                    this._right = s._right;

                    this._width = s._width;
                    this._height = s._height;
                    this._maxWidth = s._maxWidth;
                    this._position = s._position;


                    this._wordSpacing = s._wordSpacing;
                    this._lineHeight = s._lineHeight;
                    this._float = s._float;

<<<<<<< HEAD
                    this.CssDisplay = s._cssDisplay;
=======
                    if (this.dbugId == 36)
                    {
                    }
                    this._cssDisplay = s._cssDisplay;
>>>>>>> FETCH_HEAD
                    this._overflow = s._overflow;
                    this._textDecoration = s._textDecoration;
                    //--------------------------------------- 


                }
            }
        }


        /// <summary>
        /// clone all style from another box
        /// </summary>
        /// <param name="s"></param>
        internal void CloneAllStyles(CssBoxBase s)
        {


            //1.
            //=====================================
            if (s._fontProps.Owner == s)
            {
                this._fontProps = s._fontProps;
            }

            this._listProps = s._listProps;
            //--------------------------------------- 
            this._lineHeight = s._lineHeight;
            this._textIndent = s._textIndent;
            this._actualColor = s._actualColor;
            this._emptyCells = s._emptyCells;
            //--------------------------------------- 
            this._textAlign = s._textAlign;
            this._verticalAlign = s._verticalAlign;
            this._visibility = s._visibility;
            this._whitespace = s._whitespace;
            this._wordBreak = s._wordBreak;
            this._cssDirection = s._cssDirection;
            //---------------------------------------
            //2.
            //for clone only (eg. split a box into two parts)
            //=======================================
            this._backgroundProps = s._backgroundProps;
<<<<<<< HEAD
            //if (this.dbugId == 44)
            //{
            //}
            var s_dbugId = s.dbugId;

=======
            
            //if (this.dbugId == 36)
            //{
            //}
            var s_dbugId = s.dbugId;
            if (s._borderProps.Owner == s)
            {
                this._borderProps = s._borderProps;
            }
>>>>>>> FETCH_HEAD
            this._borderProps = s._borderProps;


            this._cornerProps = s._cornerProps;
            //---------------------------------------

            this._left = s._left;
            this._top = s._top;
            this._bottom = s._bottom;
            this._right = s._right;

            this._width = s._width;
            this._height = s._height;
            this._maxWidth = s._maxWidth;
            this._position = s._position;

            this._wordSpacing = s._wordSpacing;
            this._lineHeight = s._lineHeight;
            this._float = s._float;

<<<<<<< HEAD
            this.CssDisplay = s._cssDisplay;
=======
            //if (this.dbugId == 36)
            //{
            //}
            this._cssDisplay = s._cssDisplay;
>>>>>>> FETCH_HEAD
            this._overflow = s._overflow;
            this._textDecoration = s._textDecoration;

            //3.
            //=====================================
            //if (this.dbugBB > 0)
            //{

            //}
            this._marginProps = s._marginProps;
            //--------------------------------------

            this._cssDirection = s._cssDirection;


            //-----------------------------------
            if (this._paddingProps.Owner != this)
            {
                this._paddingProps = s._paddingProps;
            }
            else
            {
                //this._prop_wait_eval |= (CssBoxBaseAssignments.PADDING_LEFT |
                //                         CssBoxBaseAssignments.PADDING_TOP |
                //                         CssBoxBaseAssignments.PADDING_RIGHT |
                //                         CssBoxBaseAssignments.PADDING_BOTTOM);
            }
            //-----------------------------------
        }


    }
}